namespace SecurityMethod
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Encrypte = new System.Windows.Forms.Button();
            this.radioBtn_MD5 = new System.Windows.Forms.RadioButton();
            this.btn_Decode = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_EncrypteOutput = new System.Windows.Forms.TextBox();
            this.txt_DecodeOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioBtn_SHA512Hash = new System.Windows.Forms.RadioButton();
            this.radioBtn_SHA512HashPlusSalt = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txt_Input
            // 
            this.txt_Input.Location = new System.Drawing.Point(137, 23);
            this.txt_Input.Name = "txt_Input";
            this.txt_Input.Size = new System.Drawing.Size(186, 21);
            this.txt_Input.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input";
            // 
            // btn_Encrypte
            // 
            this.btn_Encrypte.Location = new System.Drawing.Point(185, 98);
            this.btn_Encrypte.Name = "btn_Encrypte";
            this.btn_Encrypte.Size = new System.Drawing.Size(75, 23);
            this.btn_Encrypte.TabIndex = 2;
            this.btn_Encrypte.Text = "Encrypte";
            this.btn_Encrypte.UseVisualStyleBackColor = true;
            this.btn_Encrypte.Click += new System.EventHandler(this.btn_Encrypte_Click);
            // 
            // radioBtn_MD5
            // 
            this.radioBtn_MD5.AutoSize = true;
            this.radioBtn_MD5.Location = new System.Drawing.Point(113, 73);
            this.radioBtn_MD5.Name = "radioBtn_MD5";
            this.radioBtn_MD5.Size = new System.Drawing.Size(41, 16);
            this.radioBtn_MD5.TabIndex = 3;
            this.radioBtn_MD5.TabStop = true;
            this.radioBtn_MD5.Text = "MD5";
            this.radioBtn_MD5.UseVisualStyleBackColor = true;
            // 
            // btn_Decode
            // 
            this.btn_Decode.Location = new System.Drawing.Point(185, 174);
            this.btn_Decode.Name = "btn_Decode";
            this.btn_Decode.Size = new System.Drawing.Size(75, 23);
            this.btn_Decode.TabIndex = 4;
            this.btn_Decode.Text = "Decode";
            this.btn_Decode.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output";
            // 
            // txt_EncrypteOutput
            // 
            this.txt_EncrypteOutput.Location = new System.Drawing.Point(137, 136);
            this.txt_EncrypteOutput.Multiline = true;
            this.txt_EncrypteOutput.Name = "txt_EncrypteOutput";
            this.txt_EncrypteOutput.ReadOnly = true;
            this.txt_EncrypteOutput.Size = new System.Drawing.Size(508, 21);
            this.txt_EncrypteOutput.TabIndex = 6;
            // 
            // txt_DecodeOutput
            // 
            this.txt_DecodeOutput.Location = new System.Drawing.Point(137, 215);
            this.txt_DecodeOutput.Name = "txt_DecodeOutput";
            this.txt_DecodeOutput.Size = new System.Drawing.Size(186, 21);
            this.txt_DecodeOutput.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "Output";
            // 
            // radioBtn_SHA512Hash
            // 
            this.radioBtn_SHA512Hash.AutoSize = true;
            this.radioBtn_SHA512Hash.Location = new System.Drawing.Point(185, 73);
            this.radioBtn_SHA512Hash.Name = "radioBtn_SHA512Hash";
            this.radioBtn_SHA512Hash.Size = new System.Drawing.Size(83, 16);
            this.radioBtn_SHA512Hash.TabIndex = 9;
            this.radioBtn_SHA512Hash.TabStop = true;
            this.radioBtn_SHA512Hash.Text = "SHA512Hash";
            this.radioBtn_SHA512Hash.UseVisualStyleBackColor = true;
            // 
            // radioBtn_SHA512HashPlusSalt
            // 
            this.radioBtn_SHA512HashPlusSalt.AutoSize = true;
            this.radioBtn_SHA512HashPlusSalt.Location = new System.Drawing.Point(295, 73);
            this.radioBtn_SHA512HashPlusSalt.Name = "radioBtn_SHA512HashPlusSalt";
            this.radioBtn_SHA512HashPlusSalt.Size = new System.Drawing.Size(131, 16);
            this.radioBtn_SHA512HashPlusSalt.TabIndex = 10;
            this.radioBtn_SHA512HashPlusSalt.TabStop = true;
            this.radioBtn_SHA512HashPlusSalt.Text = "SHA512HashPlusSalt";
            this.radioBtn_SHA512HashPlusSalt.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(443, 73);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(41, 16);
            this.radioButton4.TabIndex = 11;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "MD5";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 274);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioBtn_SHA512HashPlusSalt);
            this.Controls.Add(this.radioBtn_SHA512Hash);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_DecodeOutput);
            this.Controls.Add(this.txt_EncrypteOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Decode);
            this.Controls.Add(this.radioBtn_MD5);
            this.Controls.Add(this.btn_Encrypte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Encrypte;
        private System.Windows.Forms.RadioButton radioBtn_MD5;
        private System.Windows.Forms.Button btn_Decode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_EncrypteOutput;
        private System.Windows.Forms.TextBox txt_DecodeOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioBtn_SHA512Hash;
        private System.Windows.Forms.RadioButton radioBtn_SHA512HashPlusSalt;
        private System.Windows.Forms.RadioButton radioButton4;
    }
}

