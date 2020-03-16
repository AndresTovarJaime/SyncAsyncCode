namespace SyncAsyncCode
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
            this.btnGetSync = new System.Windows.Forms.Button();
            this.txtElapsed = new System.Windows.Forms.TextBox();
            this.txtResultBox = new System.Windows.Forms.RichTextBox();
            this.btnGetAsync = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetSync
            // 
            this.btnGetSync.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetSync.Location = new System.Drawing.Point(12, 12);
            this.btnGetSync.Name = "btnGetSync";
            this.btnGetSync.Size = new System.Drawing.Size(291, 54);
            this.btnGetSync.TabIndex = 0;
            this.btnGetSync.Text = "Get SYNC";
            this.btnGetSync.UseVisualStyleBackColor = true;
            this.btnGetSync.Click += new System.EventHandler(this.btnGetSync_Click);
            // 
            // txtElapsed
            // 
            this.txtElapsed.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtElapsed.Location = new System.Drawing.Point(13, 485);
            this.txtElapsed.Name = "txtElapsed";
            this.txtElapsed.Size = new System.Drawing.Size(601, 32);
            this.txtElapsed.TabIndex = 1;
            // 
            // txtResultBox
            // 
            this.txtResultBox.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultBox.Location = new System.Drawing.Point(12, 72);
            this.txtResultBox.Name = "txtResultBox";
            this.txtResultBox.Size = new System.Drawing.Size(602, 407);
            this.txtResultBox.TabIndex = 2;
            this.txtResultBox.Text = "";
            // 
            // btnGetAsync
            // 
            this.btnGetAsync.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetAsync.Location = new System.Drawing.Point(309, 12);
            this.btnGetAsync.Name = "btnGetAsync";
            this.btnGetAsync.Size = new System.Drawing.Size(291, 54);
            this.btnGetAsync.TabIndex = 3;
            this.btnGetAsync.Text = "Get ASYNC";
            this.btnGetAsync.UseVisualStyleBackColor = true;
            this.btnGetAsync.Click += new System.EventHandler(this.btnGetAsync_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 517);
            this.Controls.Add(this.btnGetAsync);
            this.Controls.Add(this.txtResultBox);
            this.Controls.Add(this.txtElapsed);
            this.Controls.Add(this.btnGetSync);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetSync;
        private System.Windows.Forms.TextBox txtElapsed;
        private System.Windows.Forms.RichTextBox txtResultBox;
        private System.Windows.Forms.Button btnGetAsync;
    }
}

