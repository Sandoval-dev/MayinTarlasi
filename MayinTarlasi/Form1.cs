using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayinTarlasi
{
    public partial class Form1 : Form
    {
        int puan=0;
        int mayinsayi=5;
        int mayinsayac = 5;

        Button btnOrnek;
        public Form1()
        {
            InitializeComponent();
            skor.Text = "Skor: " + puan;
            mayinsayisi.Text = "Mayın: " + mayinsayi;
        }

        private void uretbutton_Click(object sender, EventArgs e)
        {
          
            int mayin1 = 0;
            int mayin2 = 0;
            int mayin3 = 0;
            int mayin4 = 0;
            int mayin5 = 0;

            Random random = new Random();
            mayin1 = random.Next(1, 20);
            mayin2 = random.Next(21, 40);
            mayin3 = random.Next(41, 60);
            mayin4 = random.Next(61, 80);
            mayin5 = random.Next(81, 100);

            for (int i = 1; i <= 100; i++)
            {
                btnOrnek = new Button();

                btnOrnek.Name = "btn" + i.ToString();
                btnOrnek.Size= new System.Drawing.Size(32, 32);
                btnOrnek.Text = i.ToString();
                if (mayin1==i || mayin2==i || mayin3==i || mayin4==i || mayin5==i )
                {
                    btnOrnek.Tag = true;
                }
                else
                {
                    btnOrnek.Tag = false;
                }
            
                btnOrnek.UseVisualStyleBackColor = true;
                btnOrnek.Click += btnOrnek_Click;
                flowLayoutPanel1.Controls.Add(btnOrnek);


                if (mayinsayac==0)
                {
                    btnOrnek.Enabled = false;
                }


                //this.btnOrnek.Location = new System.Drawing.Point(3, 3);
                //this.btnOrnek.Name = "btnOrnek";
                //this.btnOrnek.Size = new System.Drawing.Size(32, 32);
                //this.btnOrnek.TabIndex = 0;
                //this.btnOrnek.Text = "1";
                //this.btnOrnek.UseVisualStyleBackColor = true;

            }

           
        }

        private void btnOrnek_Click(object sender, EventArgs e)
        {
            
            Button basilanbutton = ((Button)sender);
            bool mayinbulundumu = (bool)basilanbutton.Tag;

            if (mayinbulundumu)
            {
                puan = puan - 10;
                mayinsayi-=1;
                MessageBox.Show("Mayına bastınız.");
                basilanbutton.BackColor = Color.Red;
                skor.Text = "Skor: " + puan;
                mayinsayisi.Text = "Mayın: " + mayinsayi;
                mayinsayac--;
                basilanbutton.Enabled = false;
                if (mayinsayac==0)
                {
                   DialogResult result= MessageBox.Show("Mayınların Hepsine Bastınız!!", "OYUN BİTTİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    uretbutton.Enabled = false;
                     
                     
                    
                }
            }
            else
            {
                puan = puan + 10;               
                basilanbutton.BackColor = Color.Green;
                skor.Text = "Skor: " + puan;
                mayinsayisi.Text = "Mayın: " + mayinsayi;
                basilanbutton.Enabled = false;
            }
         
        }
    }
}
