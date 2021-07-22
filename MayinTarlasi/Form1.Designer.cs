
namespace MayinTarlasi
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
            this.uretbutton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.skor = new System.Windows.Forms.Label();
            this.mayinsayisi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uretbutton
            // 
            this.uretbutton.Location = new System.Drawing.Point(625, 12);
            this.uretbutton.Name = "uretbutton";
            this.uretbutton.Size = new System.Drawing.Size(163, 145);
            this.uretbutton.TabIndex = 0;
            this.uretbutton.Text = "Üret";
            this.uretbutton.UseVisualStyleBackColor = true;
            this.uretbutton.Click += new System.EventHandler(this.uretbutton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(607, 426);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // skor
            // 
            this.skor.AutoSize = true;
            this.skor.Location = new System.Drawing.Point(636, 176);
            this.skor.Name = "skor";
            this.skor.Size = new System.Drawing.Size(41, 17);
            this.skor.TabIndex = 1;
            this.skor.Text = "Skor:";
            // 
            // mayinsayisi
            // 
            this.mayinsayisi.AutoSize = true;
            this.mayinsayisi.Location = new System.Drawing.Point(639, 206);
            this.mayinsayisi.Name = "mayinsayisi";
            this.mayinsayisi.Size = new System.Drawing.Size(49, 17);
            this.mayinsayisi.TabIndex = 2;
            this.mayinsayisi.Text = "Mayın:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mayinsayisi);
            this.Controls.Add(this.skor);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.uretbutton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mayın Tarlası";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uretbutton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label skor;
        private System.Windows.Forms.Label mayinsayisi;
    }
}

