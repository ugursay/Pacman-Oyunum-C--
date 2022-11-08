using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.OleDb;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      public  int can ;
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(60, 50);
            pictureBox1.ImageLocation = "mavi dur.png";


            timer1.Enabled = true;
            timer4.Enabled = true;
            timer7.Enabled = true;

            timer10.Enabled = true;

            can = 3;
            can -= 1;
            label26.Text = can.ToString();

            timer11.Enabled = true;

            label27.Text = "1";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
            if (label9.Left < label2.Right && label9.Right > label2.Left && label9.Top < label2.Bottom && label9.Bottom > label2.Top)
            {
                timer2.Enabled = true;
                timer3.Enabled = false;
            }

           if (label9.Left < label1.Right && label9.Right > label1.Left && label9.Top < label1.Bottom && label9.Bottom > label1.Top)
            {
                timer2.Enabled = false;
                timer3.Enabled = true;
            }



           
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label8.Top -= 1;
            label9.Top += 1;
            label10.Top -= 1;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label8.Top += 1;
            label9.Top -= 1;
            label10.Top += 1;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {

            if (label12.Left < label11.Right && label12.Right > label11.Left && label12.Top < label11.Bottom && label12.Bottom > label11.Top)
            {
                timer5.Enabled = false;
                timer6.Enabled = true;
            }

            if (label12.Left < label5.Right && label12.Right > label5.Left && label12.Top < label5.Bottom && label12.Bottom > label5.Top)
            {
                timer5.Enabled = true;
                timer6.Enabled = false;
            }

        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            label12.Top -= 1;
            label13.Top -= 1;
            label15.Top -= 1;
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            label12.Top += 1;
            label13.Top += 1;
            label15.Top += 1;
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (label19.Left < label4.Right && label19.Right > label4.Left && label19.Top < label4.Bottom && label19.Bottom > label4.Top)
            {
                timer8.Enabled = true;
                timer9.Enabled = false;
            }

            if (label19.Left < label3.Right && label19.Right > label3.Left && label19.Top < label3.Bottom && label19.Bottom > label3.Top)
            {
                timer8.Enabled = false;
                timer9.Enabled = true;
            }

        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            label19.Left -= 3;
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            label19.Left += 3;
        }

        int x;
        int y;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
             x = pictureBox1.Location.X;
             y = pictureBox1.Location.Y;



            if (e.KeyCode == Keys.A )
            {
                pictureBox1.ImageLocation = "mavi sol.gif";
                pictureBox1.Width = 43;
                pictureBox1.Height = 45;
                x -= 10;
            }

            if (e.KeyCode == Keys.D )
            {
                pictureBox1.ImageLocation = "mavi sag.gif";
                pictureBox1.Width = 43;
                pictureBox1.Height = 45;
                x += 10;
            }

            if (e.KeyCode == Keys.W )
            {
                pictureBox1.ImageLocation = "mavi dur.png";
                pictureBox1.Width = 43;
                pictureBox1.Height = 45;
                y -= 10;
            }

            if (e.KeyCode == Keys.S )
            {
                pictureBox1.ImageLocation = "mavi dur.png";
                pictureBox1.Width = 43;
                pictureBox1.Height = 45;
                y += 10;
            }



            if (e.KeyCode == Keys.P)
            {



                DialogResult sec = MessageBox.Show("ÇIKIŞ", "OYUN KAYDEDİLSİN Mİ ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (sec == DialogResult.OK)
                {

                    baglanti.Open();
                    komut = new OleDbCommand();
                    komut.Connection = baglanti;
                    komut.CommandText = "update kayıt set bölüm='" + label27.Text + "' ,can='" + label26.Text + "' where sıra='" + "1" + "' ";
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    verilerigörüntüle();

                    Form4 frm4 = new Form4();
                    frm4.Show();
                    this.Hide();

                }
                else
                {

                   
                }



            
            }




            if (pictureBox1.Left < label3.Right)
            {
                x += 10;
                pictureBox1.Location = new Point(x, y);
            }

            if (pictureBox1.Top < label2.Bottom)
            {
                y += 10;
                pictureBox1.Location = new Point(x, y);
            }

            if (pictureBox1.Right > label4.Left)
            {
                x -= 10;
                pictureBox1.Location = new Point(x, y);
            }

            if (pictureBox1.Bottom > label7.Top)
            {
                y -= 10;
                pictureBox1.Location = new Point(x, y);
            }




            if (pictureBox1.Left < label1.Right && pictureBox1.Right > label1.Left && pictureBox1.Top < label1.Bottom && pictureBox1.Bottom > label1.Top)
            {
                y -= 10;
            }

            if (pictureBox1.Left < label17.Right && pictureBox1.Right > label17.Left && pictureBox1.Top < label17.Bottom && pictureBox1.Bottom > label17.Top)
            {
                y += 10;
            }

            if (pictureBox1.Left < label18.Right && pictureBox1.Right > label18.Left && pictureBox1.Top < label18.Bottom && pictureBox1.Bottom > label18.Top)
            {
                x += 10;
            }




            if (pictureBox1.Left < label5.Right && pictureBox1.Right > label5.Left && pictureBox1.Top < label5.Bottom && pictureBox1.Bottom > label5.Top)
            {
                y -= 10;
            }

            if (pictureBox1.Left < label20.Right && pictureBox1.Right > label20.Left && pictureBox1.Top < label20.Bottom && pictureBox1.Bottom > label20.Top)
            {
                y += 10;
            }

            if (pictureBox1.Left < label22.Right && pictureBox1.Right > label22.Left && pictureBox1.Top < label22.Bottom && pictureBox1.Bottom > label22.Top)
            {
                x -= 10;
            }



            if (pictureBox1.Left < label6.Right && pictureBox1.Right > label6.Left && pictureBox1.Top < label6.Bottom && pictureBox1.Bottom > label6.Top)
            {
                y -= 10;
            }

            if (pictureBox1.Left < label23.Right && pictureBox1.Right > label23.Left && pictureBox1.Top < label23.Bottom && pictureBox1.Bottom > label23.Top)
            {
                y += 10;
            }

            if (pictureBox1.Left < label24.Right && pictureBox1.Right > label24.Left && pictureBox1.Top < label24.Bottom && pictureBox1.Bottom > label24.Top)
            {
                x += 10;
            }




            if (pictureBox1.Left < pictureBox2.Right && pictureBox1.Right > pictureBox2.Left && pictureBox1.Top < pictureBox2.Bottom && pictureBox1.Bottom > pictureBox2.Top)
            {
                MessageBox.Show("KAZANDIN");

                Form2 frm2 = new Form2();

                
                frm2.label32.Text = label26.Text;
                frm2.label36.Text = label26.Text;
                

                frm2.Show();
                this.Hide();



            }




            pictureBox1.Location = new Point(x, y);
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Left < label8.Right && pictureBox1.Right > label8.Left && pictureBox1.Top < label8.Bottom && pictureBox1.Bottom > label8.Top)
            {
                timer10.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(183,62);
                timer10.Enabled = true;
                can-=1;
                label26.Text=can.ToString();
            }

            if (pictureBox1.Left < label9.Right && pictureBox1.Right > label9.Left && pictureBox1.Top < label9.Bottom && pictureBox1.Bottom > label9.Top)
            {
                timer10.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(183, 62);
                timer10.Enabled = true;
                can -= 1;
                label26.Text = can.ToString();
            }

            if (pictureBox1.Left < label10.Right && pictureBox1.Right > label10.Left && pictureBox1.Top < label10.Bottom && pictureBox1.Bottom > label10.Top)
            {
                timer10.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(183, 62);
                timer10.Enabled = true;
                can -= 1;
                label26.Text = can.ToString();
            }          

            if (pictureBox1.Left < label11.Right && pictureBox1.Right > label11.Left && pictureBox1.Top < label11.Bottom && pictureBox1.Bottom > label11.Top)
            {
                timer10.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(183, 62);
                timer10.Enabled = true;
                can -= 1;
                label26.Text = can.ToString();
            }

            if (pictureBox1.Left < label12.Right && pictureBox1.Right > label12.Left && pictureBox1.Top < label12.Bottom && pictureBox1.Bottom > label12.Top)
            {
                timer10.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(183, 62);
                timer10.Enabled = true;
                can -= 1;
                label26.Text = can.ToString();
            }

            if (pictureBox1.Left < label13.Right && pictureBox1.Right > label13.Left && pictureBox1.Top < label13.Bottom && pictureBox1.Bottom > label13.Top)
            {
                timer10.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(183, 62);
                timer10.Enabled = true;
                can -= 1;
                label26.Text = can.ToString();
            }

            if (pictureBox1.Left < label14.Right && pictureBox1.Right > label14.Left && pictureBox1.Top < label14.Bottom && pictureBox1.Bottom > label14.Top)
            {
                timer10.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(183, 62);
                timer10.Enabled = true;
                can -= 1;
                label26.Text = can.ToString();
            }

            if (pictureBox1.Left < label15.Right && pictureBox1.Right > label15.Left && pictureBox1.Top < label15.Bottom && pictureBox1.Bottom > label15.Top)
            {
                timer10.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(183, 62);
                timer10.Enabled = true;
                can -= 1;
                label26.Text = can.ToString();
            }

            if (pictureBox1.Left < label16.Right && pictureBox1.Right > label16.Left && pictureBox1.Top < label16.Bottom && pictureBox1.Bottom > label16.Top)
            {
                timer10.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(183, 62);
                timer10.Enabled = true;
                can -= 1;
                label26.Text = can.ToString();
            }

            if (pictureBox1.Left < label19.Right && pictureBox1.Right > label19.Left && pictureBox1.Top < label19.Bottom && pictureBox1.Bottom > label19.Top)
            {
                timer10.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(183, 62);
                timer10.Enabled = true;
                can -= 1;
                label26.Text = can.ToString();
            }

           
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            if (can == 0)
            {
                timer11.Enabled = false;
                MessageBox.Show("OYUNU KAYBETTİNİZ");
                
               

                Form4 frm4 = new Form4();
                frm4.Show();
                this.Hide();
            }
        }

      
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=kayıtverileri.mdw");
        OleDbCommand komut = new OleDbCommand();
        private void verilerigörüntüle()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("Select *From kayıt");
            OleDbDataReader oku = komut.ExecuteReader();

           

            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
        }
    }
}
