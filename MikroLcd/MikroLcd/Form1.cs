using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MikroLcd
{
    public partial class Form1 : Form
    {

        private Button currentButton; // buton renklendirme
        public Form1()
        {
            InitializeComponent();
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            ActivateButtonAlt(button45);//$40
        }
        private void ActivateButton(object btnSender,object labelyan,object labelalt,int deger)
        {
            if (btnSender != null)
            {
                currentButton = (Button)btnSender;
                Label lbl=(Label)labelyan;
                Label lblalt = (Label)labelalt;

                if (currentButton.BackColor== Color.FromArgb(24, 30, 54))//ikinci seçildiğinde
                {
                    currentButton.BackColor = Color.White;
                    currentButton.ForeColor = Color.FromArgb(24, 30, 54);

                    lbl.Text = (Convert.ToInt32(lbl.Text) - deger).ToString();   
                }
                else //ilk seçildiğinde
                {
                    currentButton.BackColor = Color.FromArgb(24, 30, 54);
                    

                    lbl.Text = (Convert.ToInt32(lbl.Text) + deger).ToString();
                }

                lblalt.Text = lbl.Text;
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panel1.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.White;
                    previousBtn.ForeColor = Color.FromArgb(24, 30, 54);
                    // previousBtn.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                }
            }

        }
        private void ActivateButtonAlt(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButtonAlt();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(24, 30, 54);
                    currentButton.ForeColor = Color.White;
                    lbl20.Text = currentButton.Text;
                    //  currentButton.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                }
            }
        }
        private void DisableButtonAlt()
        {
            foreach (Control previousBtn in panel2.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.White;
                    previousBtn.ForeColor = Color.FromArgb(24, 30, 54);
                    // previousBtn.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                }
            }
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender,lbl1,lbl21,16);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, lbl1, lbl21, 8);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, lbl1, lbl21, 4);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, lbl1, lbl21, 2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, lbl1, lbl21, 1);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, lbl2, lbl22, 16);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, lbl2, lbl22, 8);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, lbl2, lbl22, 4);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, lbl2, lbl22, 2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, lbl2, lbl22, 1);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, lbl3, lbl23, 16);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, lbl3, lbl23, 8);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, lbl3, lbl23, 4);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, lbl3, lbl23, 2);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, lbl3, lbl23, 1);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, lbl4, lbl24, 16);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, lbl4, lbl24, 8);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, lbl4,lbl24, 4);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, lbl4, lbl24, 2);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, lbl4, lbl24, 1);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, lbl5, lbl25, 16);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, lbl5, lbl25, 8);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, lbl5, lbl25, 4);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, lbl5, lbl25, 2);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, lbl5, lbl25, 1); 
        }

        private void button30_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, lbl6, lbl26, 16);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, lbl6, lbl26, 8);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, lbl6, lbl26, 4);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, lbl6, lbl26, 2);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, lbl6, lbl26, 1);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, lbl7, lbl27, 16);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, lbl7, lbl27, 8);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, lbl7, lbl27, 4);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, lbl7, lbl27, 2);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, lbl7, lbl27, 1);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, lbl8, lbl28, 16);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, lbl8, lbl28, 8);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, lbl8, lbl28, 4);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, lbl8, lbl28, 2);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, lbl8, lbl28, 1);
        }



        private void button45_Click(object sender, EventArgs e)
        {
            ActivateButtonAlt(sender);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            ActivateButtonAlt(sender);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            ActivateButtonAlt(sender);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            ActivateButtonAlt(sender);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            ActivateButtonAlt(sender);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            ActivateButtonAlt(sender);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            ActivateButtonAlt(sender);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            ActivateButtonAlt(sender);
        }

 
        private void button49_Click(object sender, EventArgs e)
        {
            DisableButton();
            DisableButtonAlt();
            ActivateButtonAlt(button45);

            lbl1.Text = "0";
            lbl2.Text = "0";
            lbl3.Text = "0";
            lbl4.Text = "0";
            lbl5.Text = "0";
            lbl6.Text = "0";
            lbl7.Text = "0";
            lbl8.Text = "0";
            
            lbl21.Text = "0";
            lbl22.Text = "0";
            lbl23.Text = "0";
            lbl24.Text = "0";
            lbl25.Text = "0";
            lbl26.Text = "0";
            lbl27.Text = "0";
        }
        private void button50_Click(object sender, EventArgs e)
        {
            string kopyalama;

            kopyalama = "LCDOUT $fe," + lbl20.Text + "," + lbl21.Text + "," + lbl22.Text + "," + lbl23.Text + "," + lbl24.Text + "," + lbl25.Text + "," + lbl26.Text + "," + lbl27.Text + "," + lbl28.Text ;

            Clipboard.SetText(kopyalama);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/mustafabeyazbulut");
        }
    }
}
