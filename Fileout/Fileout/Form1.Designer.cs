namespace jp.mn.jp.uk.fileout
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
            this.btnSet = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.lbl001 = new System.Windows.Forms.Label();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.lbl002 = new System.Windows.Forms.Label();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(725, 16);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(47, 23);
            this.btnSet.TabIndex = 0;
            this.btnSet.Text = "参照";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(359, 79);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(146, 58);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "実行";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lbl001
            // 
            this.lbl001.AutoSize = true;
            this.lbl001.Location = new System.Drawing.Point(12, 19);
            this.lbl001.Name = "lbl001";
            this.lbl001.Size = new System.Drawing.Size(76, 12);
            this.lbl001.TabIndex = 2;
            this.lbl001.Text = "検索先フォルダ";
            // 
            // txtTarget
            // 
            this.txtTarget.Location = new System.Drawing.Point(94, 16);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(625, 19);
            this.txtTarget.TabIndex = 3;
            // 
            // lbl002
            // 
            this.lbl002.AutoSize = true;
            this.lbl002.Location = new System.Drawing.Point(12, 44);
            this.lbl002.Name = "lbl002";
            this.lbl002.Size = new System.Drawing.Size(41, 12);
            this.lbl002.TabIndex = 2;
            this.lbl002.Text = "保存先";
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(94, 41);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(625, 19);
            this.txtDest.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 168);
            this.Controls.Add(this.txtDest);
            this.Controls.Add(this.lbl002);
            this.Controls.Add(this.txtTarget);
            this.Controls.Add(this.lbl001);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnSet);
            this.Name = "Form1";
            this.Text = "File list output tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lbl001;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.Label lbl002;
        private System.Windows.Forms.TextBox txtDest;
    }
}