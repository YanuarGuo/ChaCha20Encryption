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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            TxtKey = new TextBox();
            label1 = new Label();
            label2 = new Label();
            TxtNonce = new TextBox();
            CheckHash = new CheckBox();
            CheckNonce = new CheckBox();
            CbAlgo = new ComboBox();
            TxtInitCount = new TextBox();
            label3 = new Label();
            label4 = new Label();
            TxtPlain = new TextBox();
            label5 = new Label();
            CbOutFormat = new ComboBox();
            label6 = new Label();
            BtnClearEnc = new Button();
            BtnEncrypt = new Button();
            BtnConfirm = new Button();
            groupBox3 = new GroupBox();
            BtnDecrypt = new Button();
            BtnClearDec = new Button();
            label7 = new Label();
            CbInFormat = new ComboBox();
            label8 = new Label();
            TxtCipher = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnConfirm);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TxtInitCount);
            groupBox1.Controls.Add(CbAlgo);
            groupBox1.Controls.Add(CheckNonce);
            groupBox1.Controls.Add(CheckHash);
            groupBox1.Controls.Add(TxtNonce);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TxtKey);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(473, 256);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "ChaCha20 Configurations";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnEncrypt);
            groupBox2.Controls.Add(BtnClearEnc);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(CbOutFormat);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(TxtPlain);
            groupBox2.Location = new Point(12, 274);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(234, 307);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Encryption";
            // 
            // TxtKey
            // 
            TxtKey.Location = new Point(82, 26);
            TxtKey.Name = "TxtKey";
            TxtKey.Size = new Size(377, 23);
            TxtKey.TabIndex = 2;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 90);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 4;
            label2.Text = "Nonce";
            // 
            // TxtNonce
            // 
            TxtNonce.Location = new Point(82, 87);
            TxtNonce.Name = "TxtNonce";
            TxtNonce.Size = new Size(377, 23);
            TxtNonce.TabIndex = 5;
            // 
            // CheckHash
            // 
            CheckHash.AutoSize = true;
            CheckHash.Location = new Point(82, 55);
            CheckHash.Name = "CheckHash";
            CheckHash.Size = new Size(114, 19);
            CheckHash.TabIndex = 7;
            CheckHash.Text = "Use Key Hashing";
            CheckHash.UseVisualStyleBackColor = true;
            // 
            // CheckNonce
            // 
            CheckNonce.AutoSize = true;
            CheckNonce.Location = new Point(82, 116);
            CheckNonce.Name = "CheckNonce";
            CheckNonce.Size = new Size(123, 19);
            CheckNonce.TabIndex = 8;
            CheckNonce.Text = "Randomize Nonce";
            CheckNonce.UseVisualStyleBackColor = true;
            // 
            // CbAlgo
            // 
            CbAlgo.DropDownStyle = ComboBoxStyle.DropDownList;
            CbAlgo.FormattingEnabled = true;
            CbAlgo.Items.AddRange(new object[] { "Plain ChaCha20", "ChaCha20-Poly1305" });
            CbAlgo.Location = new Point(257, 169);
            CbAlgo.Name = "CbAlgo";
            CbAlgo.Size = new Size(202, 23);
            CbAlgo.TabIndex = 9;
            // 
            // TxtInitCount
            // 
            TxtInitCount.Location = new Point(15, 169);
            TxtInitCount.Name = "TxtInitCount";
            TxtInitCount.Size = new Size(224, 23);
            TxtInitCount.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 151);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 11;
            label3.Text = "Initial Count";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(257, 151);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 12;
            label4.Text = "Select Algorithm";
            // 
            // TxtPlain
            // 
            TxtPlain.Location = new Point(10, 43);
            TxtPlain.Multiline = true;
            TxtPlain.Name = "TxtPlain";
            TxtPlain.Size = new Size(214, 138);
            TxtPlain.TabIndex = 11;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 199);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 15;
            label6.Text = "Output Format";
            // 
            // BtnClearEnc
            // 
            BtnClearEnc.Location = new Point(9, 269);
            BtnClearEnc.Name = "BtnClearEnc";
            BtnClearEnc.Size = new Size(104, 23);
            BtnClearEnc.TabIndex = 17;
            BtnClearEnc.Text = "Clear";
            BtnClearEnc.UseVisualStyleBackColor = true;
            // 
            // BtnEncrypt
            // 
            BtnEncrypt.Location = new Point(120, 269);
            BtnEncrypt.Name = "BtnEncrypt";
            BtnEncrypt.Size = new Size(104, 23);
            BtnEncrypt.TabIndex = 18;
            BtnEncrypt.Text = "Encrypt";
            BtnEncrypt.UseVisualStyleBackColor = true;
            // 
            // BtnConfirm
            // 
            BtnConfirm.Location = new Point(355, 217);
            BtnConfirm.Name = "BtnConfirm";
            BtnConfirm.Size = new Size(104, 23);
            BtnConfirm.TabIndex = 18;
            BtnConfirm.Text = "Confirm";
            BtnConfirm.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(BtnDecrypt);
            groupBox3.Controls.Add(BtnClearDec);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(CbInFormat);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(TxtCipher);
            groupBox3.Location = new Point(250, 274);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(234, 307);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            groupBox3.Text = "Decryption";
            // 
            // BtnDecrypt
            // 
            BtnDecrypt.Location = new Point(117, 269);
            BtnDecrypt.Name = "BtnDecrypt";
            BtnDecrypt.Size = new Size(104, 23);
            BtnDecrypt.TabIndex = 18;
            BtnDecrypt.Text = "Decrypt";
            BtnDecrypt.UseVisualStyleBackColor = true;
            // 
            // BtnClearDec
            // 
            BtnClearDec.Location = new Point(6, 269);
            BtnClearDec.Name = "BtnClearDec";
            BtnClearDec.Size = new Size(104, 23);
            BtnClearDec.TabIndex = 17;
            BtnClearDec.Text = "Clear";
            BtnClearDec.UseVisualStyleBackColor = true;
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
            ClientSize = new Size(496, 592);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ChaCha20Encryption";
            Text = "ChaCha20Encryption";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox TxtKey;
        private GroupBox groupBox2;
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
        private GroupBox groupBox3;
        private Button BtnDecrypt;
        private Button BtnClearDec;
        private Label label7;
        private ComboBox CbInFormat;
        private Label label8;
        private TextBox TxtCipher;
    }
}
