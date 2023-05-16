namespace Testing_python
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSource = new System.Windows.Forms.TextBox();
            this.cmdTalk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.cboLang = new System.Windows.Forms.ComboBox();
            this.txtLang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(5, 102);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(793, 134);
            this.txtSource.TabIndex = 0;
            // 
            // cmdTalk
            // 
            this.cmdTalk.Location = new System.Drawing.Point(607, 242);
            this.cmdTalk.Name = "cmdTalk";
            this.cmdTalk.Size = new System.Drawing.Size(181, 59);
            this.cmdTalk.TabIndex = 1;
            this.cmdTalk.Text = "Gen Mp3 to Play";
            this.cmdTalk.UseVisualStyleBackColor = true;
            this.cmdTalk.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập Văn Bản";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(12, 263);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(50, 16);
            this.labelStatus.TabIndex = 3;
            this.labelStatus.Text = "Status::";
            // 
            // cboLang
            // 
            this.cboLang.FormattingEnabled = true;
            this.cboLang.Location = new System.Drawing.Point(503, 12);
            this.cboLang.Name = "cboLang";
            this.cboLang.Size = new System.Drawing.Size(165, 24);
            this.cboLang.TabIndex = 4;
            // 
            // txtLang
            // 
            this.txtLang.Location = new System.Drawing.Point(674, 12);
            this.txtLang.Multiline = true;
            this.txtLang.Name = "txtLang";
            this.txtLang.Size = new System.Drawing.Size(59, 24);
            this.txtLang.TabIndex = 5;
            this.txtLang.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngôn Ngữ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 308);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLang);
            this.Controls.Add(this.cboLang);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdTalk);
            this.Controls.Add(this.txtSource);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button cmdTalk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox cboLang;
        private System.Windows.Forms.TextBox txtLang;
        private System.Windows.Forms.Label label3;
    }
}

