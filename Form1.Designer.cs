namespace baif13_canchi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnam = new System.Windows.Forms.TextBox();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btntn = new System.Windows.Forms.Button();
            this.lstnam = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Năm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kết Quả";
            // 
            // txtnam
            // 
            this.txtnam.Location = new System.Drawing.Point(208, 123);
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(100, 20);
            this.txtnam.TabIndex = 1;
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(208, 176);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(100, 20);
            this.txtkq.TabIndex = 1;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(353, 169);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 2;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btntn
            // 
            this.btntn.Location = new System.Drawing.Point(353, 121);
            this.btntn.Name = "btntn";
            this.btntn.Size = new System.Drawing.Size(75, 23);
            this.btntn.TabIndex = 2;
            this.btntn.Text = "Tính ";
            this.btntn.UseVisualStyleBackColor = true;
            this.btntn.Click += new System.EventHandler(this.btntn_Click);
            // 
            // lstnam
            // 
            this.lstnam.FormattingEnabled = true;
            this.lstnam.Location = new System.Drawing.Point(494, 121);
            this.lstnam.Name = "lstnam";
            this.lstnam.Size = new System.Drawing.Size(281, 199);
            this.lstnam.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstnam);
            this.Controls.Add(this.btntn);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.txtnam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnam;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btntn;
        private System.Windows.Forms.ListBox lstnam;
    }
}

