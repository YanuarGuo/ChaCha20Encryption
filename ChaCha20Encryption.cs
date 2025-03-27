using System.Buffers.Text;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Tls.Crypto;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;
using BcChaCha20Poly1305 = Org.BouncyCastle.Crypto.Modes.ChaCha20Poly1305;

namespace ChaCha20Encryption
{
    public partial class ChaCha20Encryption : Form
    {
        public string? Key { get; set; }
        public string? Nonce { get; set; }
        public string? Algorithm { get; set; }
        public uint? InitCounter { get; set; }

        public ChaCha20Encryption()
        {
            InitializeComponent();
            GbEnc.Enabled = false;
            GbDec.Enabled = false;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            Key = TxtKey.Text;
            Nonce = TxtNonce.Text;
            Algorithm = CbAlgo.Text;
            InitCounter = uint.Parse(TxtInitCount.Text);
            GbEnc.Enabled = true;
            GbDec.Enabled = true;

            if (
                string.IsNullOrEmpty(Key)
                || string.IsNullOrEmpty(Nonce)
                || string.IsNullOrEmpty(Algorithm)
                || !InitCounter.HasValue
            )
            {
                MessageBox.Show("Form cannot be null or empty!");
                return;
            }
            MessageBox.Show("Configurations confirmed!");
        }

        private void BtnClearEnc_Click(object sender, EventArgs e)
        {
            TxtPlain.Text = "";
            CbOutFormat.SelectedIndex = -1;
        }

        private void BtnClearDec_Click(object sender, EventArgs e)
        {
            TxtCipher.Text = "";
            CbInFormat.SelectedIndex = -1;
        }

        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrEmpty(Key)
                || string.IsNullOrEmpty(Nonce)
                || string.IsNullOrEmpty(Algorithm)
                || !InitCounter.HasValue
            )
            {
                MessageBox.Show("Data cannot be null or empty!");
                return;
            }
            if (Key.Length != 32)
                throw new ArgumentException("Key must be exactly 32 bytes.");

            string encrypted = ChaCha20Encrypt(
                TxtPlain.Text,
                Key,
                Nonce,
                Algorithm,
                InitCounter.Value,
                CbOutFormat.Text
            );
            TxtCipher.Text = encrypted;
        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrEmpty(Key)
                || string.IsNullOrEmpty(Nonce)
                || string.IsNullOrEmpty(Algorithm)
                || !InitCounter.HasValue
            )
            {
                MessageBox.Show("Data cannot be null or empty!");
                return;
            }
            if (Key.Length != 32)
                throw new ArgumentException("Key must be exactly 32 bytes.");

            string plain = ChaCha20Decrypt(
                TxtCipher.Text,
                Key,
                Nonce,
                Algorithm,
                InitCounter.Value,
                CbInFormat.Text
            );
            TxtPlain.Text = plain;
        }

        private void CheckNonce_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckNonce.Checked)
            {
                byte[] nonce = new byte[12];
                using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
                {
                    rng.GetBytes(nonce);
                }

                TxtNonce.Text = Convert.ToBase64String(nonce).Substring(0, 12);
            }
            else
            {
                TxtNonce.Text = "";
            }
        }

        private void CbAlgo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbAlgo.Text == "ChaChaEngine20")
            {
                TxtNonce.MaxLength = 8;
                TxtInitCount.Enabled = true;
            }
            else if (CbAlgo.Text == "ChaCha7539Engine")
            {
                TxtNonce.MaxLength = 12;
                TxtInitCount.Text = "0";
                TxtInitCount.Enabled = false;
            }
            else if (CbAlgo.Text == "ChaCha20-Poly1305")
            {
                TxtNonce.MaxLength = 12;
                TxtInitCount.Text = "1";
                TxtInitCount.Enabled = false;
            }
        }

        private string ChaCha20Encrypt(
            string plain,
            string key,
            string nonce,
            string algo,
            uint initCount,
            string outputFormat
        )
        {
            bool useHash = CheckHash.Checked;
            byte[] keyBytes = GenerateKey(Encoding.ASCII.GetBytes(key), useHash);
            byte[] nonceBytes = NoncePad(Encoding.ASCII.GetBytes(nonce), algo);

            try
            {
                byte[] rawBytes = Encoding.ASCII.GetBytes(nonce);
                string testBase64 = Convert.ToBase64String(new byte[12]);
            }
            catch
            {
                throw new ArgumentException("Nonce must be a valid Base64-encoded string.");
            }

            byte[] plainBytes = Encoding.UTF8.GetBytes(plain);
            byte[] encryptedBytes;

            if (algo == "ChaChaEngine20")
            {
                encryptedBytes = EncryptProcessChaChaEngine20(
                    plainBytes,
                    keyBytes,
                    nonceBytes,
                    initCount
                );

                byte[] finalOutput = encryptedBytes.Take(encryptedBytes.Length).ToArray();
                return outputFormat.Equals("HEX", StringComparison.OrdinalIgnoreCase)
                    ? BitConverter.ToString(finalOutput).Replace("-", "")
                    : Convert.ToBase64String(finalOutput);
            }
            else if (algo == "ChaCha7539Engine")
            {
                encryptedBytes = EncryptProcessChaCha7539Engine(plainBytes, keyBytes, nonceBytes);
                byte[] finalOutput = encryptedBytes.Take(encryptedBytes.Length).ToArray();
                return outputFormat.Equals("HEX", StringComparison.OrdinalIgnoreCase)
                    ? BitConverter.ToString(finalOutput).Replace("-", "")
                    : Convert.ToBase64String(finalOutput);
            }
            else if (algo == "ChaCha20-Poly1305")
            {
                encryptedBytes = EncryptProcessChaCha20Poly1305(plainBytes, keyBytes, nonceBytes);
                byte[] finalOutput = encryptedBytes.Take(encryptedBytes.Length).ToArray();
                return outputFormat.Equals("HEX", StringComparison.OrdinalIgnoreCase)
                    ? BitConverter.ToString(finalOutput).Replace("-", "")
                    : Convert.ToBase64String(finalOutput);
            }
            else
            {
                throw new ArgumentException("Unsupported algorithm: " + algo);
            }
        }

        private string ChaCha20Decrypt(
            string cipher,
            string key,
            string nonce,
            string algo,
            uint initCount,
            string inputFormat
        )
        {
            bool useHash = CheckHash.Checked;
            byte[] keyBytes = GenerateKey(Encoding.ASCII.GetBytes(key), useHash);
            byte[] nonceBytes = NoncePad(Encoding.ASCII.GetBytes(nonce), algo);
            byte[] cipherBytes;

            if (inputFormat.Equals("HEX", StringComparison.OrdinalIgnoreCase))
            {
                cipherBytes = Enumerable
                    .Range(0, cipher.Length / 2)
                    .Select(x => Convert.ToByte(cipher.Substring(x * 2, 2), 16))
                    .ToArray();
            }
            else
            {
                cipherBytes = Convert.FromBase64String(cipher);
            }

            byte[] decryptedBytes;

            if (algo == "ChaChaEngine20")
            {
                decryptedBytes = DecryptProcessChaChaEngine20(
                    cipherBytes,
                    keyBytes,
                    nonceBytes,
                    initCount
                );
            }
            else if (algo == "ChaCha7539Engine")
            {
                decryptedBytes = DecryptProcessChaCha7539Engine(cipherBytes, keyBytes, nonceBytes);
            }
            else if (algo == "ChaCha20-Poly1305")
            {
                decryptedBytes = DecryptProcessChaCha20Poly1305(cipherBytes, keyBytes, nonceBytes);
            }
            else
            {
                throw new ArgumentException("Unsupported algorithm: " + algo);
            }

            return Encoding.UTF8.GetString(decryptedBytes);
        }

        private byte[] EncryptProcessChaChaEngine20(
            byte[] data,
            byte[] key,
            byte[] nonce,
            uint counter
        )
        {
            if (nonce.Length != 8)
                throw new ArgumentException("Nonce must be exactly 8 bytes for ChaCha20.");

            ChaChaEngine engine = new(20);
            KeyParameter keyParam = new(key);

            engine.Init(true, new ParametersWithIV(keyParam, nonce));

            engine.Reset();
            engine.ProcessBytes(
                new byte[64 * (int)counter],
                0,
                64 * (int)counter,
                new byte[64 * (int)counter],
                0
            );

            byte[] output = new byte[data.Length];
            engine.ProcessBytes(data, 0, data.Length, output, 0);

            return output;
        }

        private byte[] EncryptProcessChaCha7539Engine(byte[] data, byte[] key, byte[] nonce)
        {
            if (nonce.Length != 12)
                throw new ArgumentException("Nonce must be exactly 12 bytes for ChaCha7539.");

            ChaCha7539Engine engine = new();
            KeyParameter keyParam = new(key);
            ParametersWithIV parameters = new(keyParam, nonce);

            engine.Init(true, parameters);

            byte[] output = new byte[data.Length];
            engine.ProcessBytes(data, 0, data.Length, output, 0);

            return output;
        }

        private byte[] EncryptProcessChaCha20Poly1305(byte[] data, byte[] key, byte[] nonce)
        {
            if (nonce.Length != 12)
                throw new ArgumentException(
                    "Nonce must be exactly 12 bytes for ChaCha20-Poly1305."
                );

            BcChaCha20Poly1305 cipher = new();
            KeyParameter keyParam = new(key);
            AeadParameters parameters = new(keyParam, 128, nonce, []);

            cipher.Init(true, parameters);

            byte[] ciphertext = new byte[data.Length + 16];
            int len = cipher.ProcessBytes(data, 0, data.Length, ciphertext, 0);
            cipher.DoFinal(ciphertext, len);

            return ciphertext;
        }

        private byte[] DecryptProcessChaChaEngine20(
            byte[] data,
            byte[] key,
            byte[] nonce,
            uint counter
        )
        {
            if (nonce.Length != 8)
                throw new ArgumentException("Nonce must be exactly 8 bytes for ChaCha20.");
            ChaChaEngine engine = new(20);
            KeyParameter keyParam = new(key);
            engine.Init(false, new ParametersWithIV(keyParam, nonce));
            engine.Reset();
            engine.ProcessBytes(
                new byte[64 * (int)counter],
                0,
                64 * (int)counter,
                new byte[64 * (int)counter],
                0
            );
            byte[] output = new byte[data.Length];
            engine.ProcessBytes(data, 0, data.Length, output, 0);
            return output;
        }

        private byte[] DecryptProcessChaCha7539Engine(byte[] cipherData, byte[] key, byte[] nonce)
        {
            if (nonce.Length != 12)
                throw new ArgumentException("ChaCha7539Engine requires exactly 12 bytes of nonce.");

            ChaCha7539Engine engine = new();
            KeyParameter keyParam = new(key);
            ParametersWithIV parameters = new(keyParam, nonce);

            engine.Init(false, parameters);

            byte[] output = new byte[cipherData.Length];
            engine.ProcessBytes(cipherData, 0, cipherData.Length, output, 0);

            return output;
        }

        private byte[] DecryptProcessChaCha20Poly1305(byte[] ciphertext, byte[] key, byte[] nonce)
        {
            if (nonce.Length != 12)
                throw new ArgumentException(
                    "Nonce must be exactly 12 bytes for ChaCha20-Poly1305."
                );

            if (ciphertext.Length < 16)
                throw new ArgumentException(
                    "Ciphertext must be at least 16 bytes long (to include the authentication tag)."
                );

            BcChaCha20Poly1305 cipher = new();
            KeyParameter keyParam = new(key);
            AeadParameters parameters = new(keyParam, 128, nonce, []);

            cipher.Init(false, parameters);

            byte[] output = new byte[ciphertext.Length - 16];
            int len = cipher.ProcessBytes(ciphertext, 0, ciphertext.Length, output, 0);
            cipher.DoFinal(output, len);

            return output;
        }

        private static byte[] GenerateKey(byte[] keyBytes, bool useHash)
        {
            byte[] adjustedKey;
            int keyLength = 32;

            if (keyBytes.Length >= keyLength)
            {
                adjustedKey = keyBytes.Take(keyLength).ToArray();
            }
            else
            {
                int padLength = keyLength - keyBytes.Length;
                adjustedKey = keyBytes.Concat(new byte[padLength]).ToArray();
            }
            if (useHash)
            {
                byte[] hashedKey = SHA256.HashData(adjustedKey);
                byte[] finalKey = hashedKey.Take(keyLength).ToArray();
                return finalKey;
            }

            return adjustedKey;
        }

        private static byte[] NoncePad(byte[] nonceBytes, string algo)
        {
            byte[] adjustedNonce;
            int NonceLength;

            if (algo == "ChaChaEngine20")
            {
                NonceLength = 8;
            }
            else
            {
                NonceLength = 12;
            }

            if (nonceBytes.Length >= NonceLength)
            {
                adjustedNonce = nonceBytes.Take(NonceLength).ToArray();
            }
            else
            {
                int padLength = NonceLength - nonceBytes.Length;
                adjustedNonce = nonceBytes
                    .Concat(Enumerable.Repeat((byte)0x00, padLength))
                    .ToArray();
            }
            return adjustedNonce;
        }
    }
}
