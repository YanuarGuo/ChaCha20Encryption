namespace ChaCha20Encryption
{
    partial class ChaCha20Encryption
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GbConfig = new GroupBox();
            BtnConfirm = new Button();
            label4 = new Label();
            label3 = new Label();
            TxtNonce = new TextBox();
            label2 = new Label();
            TxtInitCount = new TextBox();
            CheckNonce = new CheckBox();
            CbAlgo = new ComboBox();
            CheckHash = new CheckBox();
            label1 = new Label();
            TxtKey = new TextBox();
            GbEnc = new GroupBox();
            BtnEncrypt = new Button();
            BtnClearEnc = new Button();
            label6 = new Label();
            CbOutFormat = new ComboBox();
            label5 = new Label();
            TxtPlain = new TextBox();
            GbDec = new GroupBox();
            BtnDecrypt = new Button();
            BtnClearDec = new Button();
            label7 = new Label();
            CbInFormat = new ComboBox();
            label8 = new Label();
            TxtCipher = new TextBox();
            GbConfig.SuspendLayout();
            GbEnc.SuspendLayout();
            GbDec.SuspendLayout();
            SuspendLayout();
            // 
            // GbConfig
            // 
            GbConfig.Controls.Add(BtnConfirm);
            GbConfig.Controls.Add(label4);
            GbConfig.Controls.Add(label3);
            GbConfig.Controls.Add(TxtNonce);
            GbConfig.Controls.Add(label2);
            GbConfig.Controls.Add(TxtInitCount);
            GbConfig.Controls.Add(CheckNonce);
            GbConfig.Controls.Add(CbAlgo);
            GbConfig.Controls.Add(CheckHash);
            GbConfig.Controls.Add(label1);
            GbConfig.Controls.Add(TxtKey);
            GbConfig.Location = new Point(12, 12);
            GbConfig.Name = "GbConfig";
            GbConfig.Size = new Size(473, 229);
            GbConfig.TabIndex = 0;
            GbConfig.TabStop = false;
            GbConfig.Text = "ChaCha20 Configurations";
            // 
            // BtnConfirm
            // 
            BtnConfirm.Location = new Point(355, 188);
            BtnConfirm.Name = "BtnConfirm";
            BtnConfirm.Size = new Size(104, 23);
            BtnConfirm.TabIndex = 18;
            BtnConfirm.Text = "Confirm";
            BtnConfirm.UseVisualStyleBackColor = true;
            BtnConfirm.Click += BtnConfirm_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 58);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 12;
            label4.Text = "Select Algorithm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(235, 88);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 11;
            label3.Text = "Initial Count";
            // 
            // TxtNonce
            // 
            TxtNonce.Location = new Point(15, 106);
            TxtNonce.MaxLength = 12;
            TxtNonce.Name = "TxtNonce";
            TxtNonce.Size = new Size(211, 23);
            TxtNonce.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 88);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 4;
            label2.Text = "Nonce";
            // 
            // TxtInitCount
            // 
            TxtInitCount.Location = new Point(235, 106);
            TxtInitCount.Name = "TxtInitCount";
            TxtInitCount.Size = new Size(224, 23);
            TxtInitCount.TabIndex = 10;
            // 
            // CheckNonce
            // 
            CheckNonce.AutoSize = true;
            CheckNonce.Location = new Point(15, 167);
            CheckNonce.Name = "CheckNonce";
            CheckNonce.Size = new Size(123, 19);
            CheckNonce.TabIndex = 8;
            CheckNonce.Text = "Randomize Nonce";
            CheckNonce.UseVisualStyleBackColor = true;
            CheckNonce.CheckedChanged += CheckNonce_CheckedChanged;
            // 
            // CbAlgo
            // 
            CbAlgo.DropDownStyle = ComboBoxStyle.DropDownList;
            CbAlgo.FormattingEnabled = true;
            CbAlgo.Items.AddRange(new object[] { "ChaChaEngine20", "ChaCha7539Engine", "ChaCha20-Poly1305" });
            CbAlgo.Location = new Point(116, 55);
            CbAlgo.Name = "CbAlgo";
            CbAlgo.Size = new Size(343, 23);
            CbAlgo.TabIndex = 9;
            CbAlgo.SelectedIndexChanged += CbAlgo_SelectedIndexChanged;
            // 
            // CheckHash
            // 
            CheckHash.AutoSize = true;
            CheckHash.Location = new Point(15, 192);
            CheckHash.Name = "CheckHash";
            CheckHash.Size = new Size(114, 19);
            CheckHash.TabIndex = 7;
            CheckHash.Text = "Use Key Hashing";
            CheckHash.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 27);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 3;
            label1.Text = "Secret Key";
            // 
            // TxtKey
            // 
            TxtKey.Location = new Point(116, 26);
            TxtKey.MaxLength = 32;
            TxtKey.Name = "TxtKey";
            TxtKey.Size = new Size(343, 23);
            TxtKey.TabIndex = 2;
            // 
            // GbEnc
            // 
            GbEnc.Controls.Add(BtnEncrypt);
            GbEnc.Controls.Add(BtnClearEnc);
            GbEnc.Controls.Add(label6);
            GbEnc.Controls.Add(CbOutFormat);
            GbEnc.Controls.Add(label5);
            GbEnc.Controls.Add(TxtPlain);
            GbEnc.Location = new Point(12, 246);
            GbEnc.Name = "GbEnc";
            GbEnc.Size = new Size(234, 307);
            GbEnc.TabIndex = 1;
            GbEnc.TabStop = false;
            GbEnc.Text = "Encryption";
            // 
            // BtnEncrypt
            // 
            BtnEncrypt.Location = new Point(120, 269);
            BtnEncrypt.Name = "BtnEncrypt";
            BtnEncrypt.Size = new Size(104, 23);
            BtnEncrypt.TabIndex = 18;
            BtnEncrypt.Text = "Encrypt";
            BtnEncrypt.UseVisualStyleBackColor = true;
            BtnEncrypt.Click += BtnEncrypt_Click;
            // 
            // BtnClearEnc
            // 
            BtnClearEnc.Location = new Point(9, 269);
            BtnClearEnc.Name = "BtnClearEnc";
            BtnClearEnc.Size = new Size(104, 23);
            BtnClearEnc.TabIndex = 17;
            BtnClearEnc.Text = "Clear";
            BtnClearEnc.UseVisualStyleBackColor = true;
            BtnClearEnc.Click += BtnClearEnc_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 199);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 15;
            label6.Text = "Output Format";
            // 
            // CbOutFormat
            // 
            CbOutFormat.DropDownStyle = ComboBoxStyle.DropDownList;
            CbOutFormat.FormattingEnabled = true;
            CbOutFormat.Items.AddRange(new object[] { "Base64", "HEX" });
            CbOutFormat.Location = new Point(10, 217);
            CbOutFormat.Name = "CbOutFormat";
            CbOutFormat.Size = new Size(214, 23);
            CbOutFormat.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 25);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 13;
            label5.Text = "Plain Text";
            // 
            // TxtPlain
            // 
            TxtPlain.Location = new Point(10, 43);
            TxtPlain.Multiline = true;
            TxtPlain.Name = "TxtPlain";
            TxtPlain.Size = new Size(214, 138);
            TxtPlain.TabIndex = 11;
            // 
            // GbDec
            // 
            GbDec.Controls.Add(BtnDecrypt);
            GbDec.Controls.Add(BtnClearDec);
            GbDec.Controls.Add(label7);
            GbDec.Controls.Add(CbInFormat);
            GbDec.Controls.Add(label8);
            GbDec.Controls.Add(TxtCipher);
            GbDec.Location = new Point(250, 246);
            GbDec.Name = "GbDec";
            GbDec.Size = new Size(234, 307);
            GbDec.TabIndex = 19;
            GbDec.TabStop = false;
            GbDec.Text = "Decryption";
            // 
            // BtnDecrypt
            // 
            BtnDecrypt.Location = new Point(117, 269);
            BtnDecrypt.Name = "BtnDecrypt";
            BtnDecrypt.Size = new Size(104, 23);
            BtnDecrypt.TabIndex = 18;
            BtnDecrypt.Text = "Decrypt";
            BtnDecrypt.UseVisualStyleBackColor = true;
            BtnDecrypt.Click += BtnDecrypt_Click;
            // 
            // BtnClearDec
            // 
            BtnClearDec.Location = new Point(6, 269);
            BtnClearDec.Name = "BtnClearDec";
            BtnClearDec.Size = new Size(104, 23);
            BtnClearDec.TabIndex = 17;
            BtnClearDec.Text = "Clear";
            BtnClearDec.UseVisualStyleBackColor = true;
            BtnClearDec.Click += BtnClearDec_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 199);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 15;
            label7.Text = "Input Format";
            // 
            // CbInFormat
            // 
            CbInFormat.DropDownStyle = ComboBoxStyle.DropDownList;
            CbInFormat.FormattingEnabled = true;
            CbInFormat.Items.AddRange(new object[] { "Base64", "HEX" });
            CbInFormat.Location = new Point(10, 217);
            CbInFormat.Name = "CbInFormat";
            CbInFormat.Size = new Size(214, 23);
            CbInFormat.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 25);
            label8.Name = "label8";
            label8.Size = new Size(66, 15);
            label8.TabIndex = 13;
            label8.Text = "Cipher Text";
            // 
            // TxtCipher
            // 
            TxtCipher.Location = new Point(10, 43);
            TxtCipher.Multiline = true;
            TxtCipher.Name = "TxtCipher";
            TxtCipher.Size = new Size(214, 138);
            TxtCipher.TabIndex = 11;
            // 
            // ChaCha20Encryption
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 563);
            Controls.Add(GbDec);
            Controls.Add(GbEnc);
            Controls.Add(GbConfig);
            Name = "ChaCha20Encryption";
            Text = "ChaCha20Encryption";
            GbConfig.ResumeLayout(false);
            GbConfig.PerformLayout();
            GbEnc.ResumeLayout(false);
            GbEnc.PerformLayout();
            GbDec.ResumeLayout(false);
            GbDec.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GbConfig;
        private Label label1;
        private TextBox TxtKey;
        private GroupBox GbEnc;
        private TextBox TxtNonce;
        private Label label2;
        private CheckBox CheckNonce;
        private CheckBox CheckHash;
        private Label label3;
        private TextBox TxtInitCount;
        private ComboBox CbAlgo;
        private Label label4;
        private TextBox TxtPlain;
        private Button BtnConfirm;
        private Button BtnEncrypt;
        private Button BtnClearEnc;
        private Label label6;
        private ComboBox CbOutFormat;
        private Label label5;
        private GroupBox GbDec;
        private Button BtnDecrypt;
        private Button BtnClearDec;
        private Label label7;
        private ComboBox CbInFormat;
        private Label label8;
        private TextBox TxtCipher;
    }
}
