namespace jp.mn.jp.uk.fileout
{
    partial class Form2
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
            this.btnOK = new System.Windows.Forms.Button();
            this.lbl001 = new System.Windows.Forms.Label();
            this.btnNG = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(52, 58);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lbl001
            // 
            this.lbl001.AutoSize = true;
            this.lbl001.Location = new System.Drawing.Point(29, 20);
            this.lbl001.Name = "lbl001";
            this.lbl001.Size = new System.Drawing.Size(132, 12);
            this.lbl001.TabIndex = 1;
            this.lbl001.Text = "File over write OK or NG";
            // 
            // btnNG
            // 
            this.btnNG.Location = new System.Drawing.Point(147, 58);
            this.btnNG.Name = "btnNG";
            this.btnNG.Size = new System.Drawing.Size(75, 23);
            this.btnNG.TabIndex = 0;
            this.btnNG.Text = "NG";
            this.btnNG.UseVisualStyleBackColor = true;
            this.btnNG.Click += new System.EventHandler(this.btnNG_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 102);
            this.Controls.Add(this.lbl001);
            this.Controls.Add(this.btnNG);
            this.Controls.Add(this.btnOK);
            this.Name = "Form2";
            this.Text = "Conform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lbl001;
        private System.Windows.Forms.Button btnNG;
    }
}