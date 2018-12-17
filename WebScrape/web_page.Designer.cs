namespace WebScrape
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
            this.txt_url = new System.Windows.Forms.TextBox();
            this.btn_url = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(12, 13);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(675, 20);
            this.txt_url.TabIndex = 0;
            // 
            // btn_url
            // 
            this.btn_url.Location = new System.Drawing.Point(693, 13);
            this.btn_url.Name = "btn_url";
            this.btn_url.Size = new System.Drawing.Size(105, 23);
            this.btn_url.TabIndex = 1;
            this.btn_url.Text = "Go To Url";
            this.btn_url.UseVisualStyleBackColor = true;
            this.btn_url.Click += new System.EventHandler(this.btn_url_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 45);
            this.Controls.Add(this.btn_url);
            this.Controls.Add(this.txt_url);
            this.Name = "Form1";
            this.Text = "Url";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Button btn_url;
    }
}

