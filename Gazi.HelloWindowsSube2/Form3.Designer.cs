namespace Gazi.HelloWindowsSube2
{
    partial class Form3
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
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.btnBaslik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(325, 195);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(100, 20);
            this.txtBaslik.TabIndex = 0;
            // 
            // btnBaslik
            // 
            this.btnBaslik.Location = new System.Drawing.Point(303, 234);
            this.btnBaslik.Name = "btnBaslik";
            this.btnBaslik.Size = new System.Drawing.Size(136, 58);
            this.btnBaslik.TabIndex = 1;
            this.btnBaslik.Text = "Form2 Başlık Değiştir";
            this.btnBaslik.UseVisualStyleBackColor = true;
            this.btnBaslik.Click += new System.EventHandler(this.btnBaslik_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBaslik);
            this.Controls.Add(this.txtBaslik);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBaslik;
        private System.Windows.Forms.Button btnBaslik;
    }
}