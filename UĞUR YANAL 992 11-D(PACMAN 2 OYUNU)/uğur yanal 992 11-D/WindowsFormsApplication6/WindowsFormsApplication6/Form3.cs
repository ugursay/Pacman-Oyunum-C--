using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication6
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
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






      public  int can;
        private void Form3_Load(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(35, 35);

           timer1.Enabled = true;

           can = 3;
           can -= 1;
           label40.Text = can.ToString();

           label40.Text = label52.Text;
           can = int.Parse(label52.Text);


           label50.Text = "3";

           timer6.Enabled = true;

           timer7.Enabled = true;
        }

        int x;
        int y;
        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            x = pictureBox1.Location.X;
            y = pictureBox1.Location.Y;



            if (e.KeyCode == Keys.A)
            {
                pictureBox1.ImageLocation = "mavi sol.gif";
                pictureBox1.Width = 43;
                pictureBox1.Height = 45;
                x -= 10;
            }

            if (e.KeyCode == Keys.D)
            {
                pictureBox1.ImageLocation = "mavi sag.gif";
                pictureBox1.Width = 43;
                pictureBox1.Height = 45;
                x += 10;
            }

            if (e.KeyCode == Keys.W)
            {
                pictureBox1.ImageLocation = "mavi dur.png";
                pictureBox1.Width = 43;
                pictureBox1.Height = 45;
                y -= 10;
            }

            if (e.KeyCode == Keys.S)
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
                    komut.CommandText = "update kayıt set bölüm='" + label50.Text + "' ,can='" + label40.Text + "' where sıra='" + "1" + "' ";
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




            if (pictureBox1.Left < pictureBox2.Right && pictureBox1.Right > pictureBox2.Left && pictureBox1.Top < pictureBox2.Bottom && pictureBox1.Bottom > pictureBox2.Top)
            {
                MessageBox.Show("KAZANDIN");

                Form5 frm5 = new Form5();
                frm5.Show();
                this.Hide();

            }





            if (pictureBox1.Left < label1.Right && pictureBox1.Right > label1.Left && pictureBox1.Top < label1.Bottom && pictureBox1.Bottom > label1.Top)
            {
                y += 10;
            }

            if (pictureBox1.Left < label2.Right && pictureBox1.Right > label2.Left && pictureBox1.Top < label2.Bottom && pictureBox1.Bottom > label2.Top)
            {
                y -= 10;
            }

            if (pictureBox1.Left < label3.Right && pictureBox1.Right > label3.Left && pictureBox1.Top < label3.Bottom && pictureBox1.Bottom > label3.Top)
            {
                x += 10;
            }

            if (pictureBox1.Left < label4.Right && pictureBox1.Right > label4.Left && pictureBox1.Top < label4.Bottom && pictureBox1.Bottom > label4.Top)
            {
                x -= 10;
            }



            if (pictureBox1.Left < label7.Right && pictureBox1.Right > label7.Left && pictureBox1.Top < label7.Bottom && pictureBox1.Bottom > label7.Top)
            {
                x -= 10;
            }

            if (pictureBox1.Left < label42.Right && pictureBox1.Right > label42.Left && pictureBox1.Top < label42.Bottom && pictureBox1.Bottom > label42.Top)
            {
                x += 10;
            }

            if (pictureBox1.Left < label8.Right && pictureBox1.Right > label8.Left && pictureBox1.Top < label8.Bottom && pictureBox1.Bottom > label8.Top)
            {
                x -= 10;
            }

            if (pictureBox1.Left < label43.Right && pictureBox1.Right > label43.Left && pictureBox1.Top < label43.Bottom && pictureBox1.Bottom > label43.Top)
            {
                x += 10;
            }

            if (pictureBox1.Left < label14.Right && pictureBox1.Right > label14.Left && pictureBox1.Top < label14.Bottom && pictureBox1.Bottom > label14.Top)
            {
                x -= 10;
            }

            if (pictureBox1.Left < label44.Right && pictureBox1.Right > label44.Left && pictureBox1.Top < label44.Bottom && pictureBox1.Bottom > label44.Top)
            {
                x += 10;
            }

            if (pictureBox1.Left < label15.Right && pictureBox1.Right > label15.Left && pictureBox1.Top < label15.Bottom && pictureBox1.Bottom > label15.Top)
            {
                x -= 10;
            }

            if (pictureBox1.Left < label45.Right && pictureBox1.Right > label45.Left && pictureBox1.Top < label45.Bottom && pictureBox1.Bottom > label45.Top)
            {
                x += 10;
            }

            if (pictureBox1.Left < label47.Right && pictureBox1.Right > label47.Left && pictureBox1.Top < label47.Bottom && pictureBox1.Bottom > label47.Top)
            {
                y += 10;
            }

            if (pictureBox1.Left < label46.Right && pictureBox1.Right > label46.Left && pictureBox1.Top < label46.Bottom && pictureBox1.Bottom > label46.Top)
            {
                y += 10;
            }

            if (pictureBox1.Left < label49.Right && pictureBox1.Right > label49.Left && pictureBox1.Top < label49.Bottom && pictureBox1.Bottom > label49.Top)
            {
                y -= 10;
            }

            if (pictureBox1.Left < label48.Right && pictureBox1.Right > label48.Left && pictureBox1.Top < label48.Bottom && pictureBox1.Bottom > label48.Top)
            {
                y -= 10;
            }


            pictureBox1.Location = new Point(x, y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label9.Left < label18.Right && label9.Right > label18.Left && label9.Top < label18.Bottom && label9.Bottom > label18.Top)
            {
                timer2.Enabled = true;
                timer3.Enabled = false;
            }

            if (label9.Left < label3.Right && label9.Right > label3.Left && label9.Top < label3.Bottom && label9.Bottom > label3.Top)
            {
                timer2.Enabled = false;
                timer3.Enabled = true;
            }



            if (label29.Left < label1.Right && label29.Right > label1.Left && label29.Top < label1.Bottom && label29.Bottom > label1.Top)
            {
                timer4.Enabled = true;
                timer5.Enabled = false;
            }

            if (label29.Left < label28.Right && label29.Right > label28.Left && label29.Top < label28.Bottom && label29.Bottom > label28.Top)
            {
                timer4.Enabled = false;
                timer5.Enabled = true;
            }




            if (label39.Left < label4.Right && label39.Right > label4.Left && label39.Top < label4.Bottom && label39.Bottom > label4.Top)
            {
                timer8.Enabled = true;
                timer9.Enabled = false;
            }

            if (label39.Left < label3.Right && label39.Right > label3.Left && label39.Top < label3.Bottom && label39.Bottom > label3.Top)
            {
                timer8.Enabled = false;
                timer9.Enabled = true;
            }


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label9.Left -= 1;
            label20.Left -= 1;
            label19.Left += 1;

            label36.Left += 1;
            label37.Left -= 1;

            label16.Top -= 3;
            label34.Top += 3;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label9.Left += 1;
            label20.Left += 1;
            label19.Left -= 1;

            label36.Left -= 1;
            label37.Left += 1;

            label16.Top += 3;
            label34.Top -= 3;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            label29.Top += 1;
            label28.Top -= 1;

            label5.Top += 3;

            label6.Top += 1;
            label13.Top -= 1;

            label31.Top += 2;

            label17.Left += 2;

            label32.Top -= 1;
            label33.Top += 1;

            label21.Left -= 3;


           

            label26.Top += 3;
            label27.Top -= 3;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            label29.Top -= 1;
            label28.Top += 1;

            label5.Top -= 3;

            label6.Top -= 1;
            label13.Top += 1;

            label31.Top -= 2;

            label17.Left -= 2;

            label32.Top += 1;
            label33.Top -= 1;

            label21.Left += 3;

           

            label26.Top -= 3;
            label27.Top += 3;
        }
  
        private void timer6_Tick(object sender, EventArgs e)
        {
            //label40.Text = can.ToString();
            if (pictureBox1.Left < label9.Right && pictureBox1.Right > label9.Left && pictureBox1.Top < label9.Bottom && pictureBox1.Bottom > label9.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(31, 60);
                timer6.Enabled = true;
                can -= 1;
                label40.Text = can.ToString();
            }

            if (pictureBox1.Left < label19.Right && pictureBox1.Right > label19.Left && pictureBox1.Top < label19.Bottom && pictureBox1.Bottom > label19.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(31, 60);
                timer6.Enabled = true;
                can -= 1;
                label40.Text = can.ToString();
            }

            if (pictureBox1.Left < label20.Right && pictureBox1.Right > label20.Left && pictureBox1.Top < label20.Bottom && pictureBox1.Bottom > label20.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(31, 60);
                timer6.Enabled = true;
                can -= 1;
                label40.Text = can.ToString();
            }

            if (pictureBox1.Left < label28.Right && pictureBox1.Right > label28.Left && pictureBox1.Top < label28.Bottom && pictureBox1.Bottom > label28.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(31, 60);
                timer6.Enabled = true;
                can -= 1;
                label40.Text = can.ToString();
            }

            if (pictureBox1.Left < label29.Right && pictureBox1.Right > label29.Left && pictureBox1.Top < label29.Bottom && pictureBox1.Bottom > label29.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(31, 60);
                timer6.Enabled = true;
                can -= 1;
                label40.Text = can.ToString();
            }

            if (pictureBox1.Left < label18.Right && pictureBox1.Right > label18.Left && pictureBox1.Top < label18.Bottom && pictureBox1.Bottom > label18.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(31, 60);
                timer6.Enabled = true;
                can -= 1;
                label40.Text = can.ToString();
            }

            if (pictureBox1.Left < label17.Right && pictureBox1.Right > label17.Left && pictureBox1.Top < label17.Bottom && pictureBox1.Bottom > label17.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(31, 60);
                timer6.Enabled = true;
                can -= 1;
                label40.Text = can.ToString();
            }

            if (pictureBox1.Left < label5.Right && pictureBox1.Right > label5.Left && pictureBox1.Top < label5.Bottom && pictureBox1.Bottom > label5.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(31, 60);
                timer6.Enabled = true;
                can -= 1;
                label40.Text = can.ToString();
            }

            if (pictureBox1.Left < label6.Right && pictureBox1.Right > label6.Left && pictureBox1.Top < label6.Bottom && pictureBox1.Bottom > label6.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(31, 60);
                timer6.Enabled = true;
                can -= 1;
                label40.Text = can.ToString();
            }

            if (pictureBox1.Left < label13.Right && pictureBox1.Right > label13.Left && pictureBox1.Top < label13.Bottom && pictureBox1.Bottom > label13.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(31, 60);
                timer6.Enabled = true;
                can -= 1;
                label40.Text = can.ToString();
            }

            if (pictureBox1.Left < label33.Right && pictureBox1.Right > label33.Left && pictureBox1.Top < label33.Bottom && pictureBox1.Bottom > label33.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(31, 60);
                timer6.Enabled = true;
                can -= 1;
                label40.Text = can.ToString();
            }

            if (pictureBox1.Left < label32.Right && pictureBox1.Right > label32.Left && pictureBox1.Top < label32.Bottom && pictureBox1.Bottom > label32.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(31, 60);
                timer6.Enabled = true;
                can -= 1;
                label40.Text = can.ToString();
            }

            if (pictureBox1.Left < label31.Right && pictureBox1.Right > label31.Left && pictureBox1.Top < label31.Bottom && pictureBox1.Bottom > label31.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(31, 60);
                timer6.Enabled = true;
                can -= 1;
                label40.Text = can.ToString();
            }

            if (pictureBox1.Left < label30.Right && pictureBox1.Right > label30.Left && pictureBox1.Top < label30.Bottom && pictureBox1.Bottom > label30.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(31, 60);
                timer6.Enabled = true;
                can -= 1;
                label40.Text = can.ToString();
            }

            if (pictureBox1.Left < label10.Right && pictureBox1.Right > label10.Left && pictureBox1.Top < label10.Bottom && pictureBox1.Bottom > label10.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(31, 60);
                timer6.Enabled = true;
                can -= 1;
                label40.Text = can.ToString();
            }

            if (pictureBox1.Left < label12.Right && pictureBox1.Right > label12.Left && pictureBox1.Top < label12.Bottom && pictureBox1.Bottom > label12.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(31, 60);
                timer6.Enabled = true;
                can -= 1;
                label40.Text = can.ToString();
            }

            if (pictureBox1.Left < label34.Right && pictureBox1.Right > label34.Left && pictureBox1.Top < label34.Bottom && pictureBox1.Bottom > label34.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(31, 60);
                timer6.Enabled = true;
                can -= 1;
                label40.Text = can.ToString();
            }

            if (pictureBox1.Left < label35.Right && pictureBox1.Right > label35.Left && pictureBox1.Top < label35.Bottom && pictureBox1.Bottom > label35.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(31, 60);
                timer6.Enabled = true;
                can -= 1;
                label40.Text = can.ToString();
            }

            if (pictureBox1.Left < label35.Right && pictureBox1.Right > label35.Left && pictureBox1.Top < label35.Bottom && pictureBox1.Bottom > label35.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(31, 60);
                timer6.Enabled = true;
                can -= 1;
                label40.Text = can.ToString();
            }

            if (pictureBox1.Left < label16.Right && pictureBox1.Right > label16.Left && pictureBox1.Top < label16.Bottom && pictureBox1.Bottom > label16.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(31, 60);
                timer6.Enabled = true;
                can -= 1;
                label40.Text = can.ToString();
            }

            if (pictureBox1.Left < label37.Right && pictureBox1.Right > label37.Left && pictureBox1.Top < label37.Bottom && pictureBox1.Bottom > label37.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(31, 60);
                timer6.Enabled = true;
                can -= 1;
                label40.Text = can.ToString();
            }

            if (pictureBox1.Left < label36.Right && pictureBox1.Right > label36.Left && pictureBox1.Top < label36.Bottom && pictureBox1.Bottom > label36.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(31, 60);
                timer6.Enabled = true;
                can -= 1;
                label40.Text = can.ToString();
            }

            if (pictureBox1.Left < label21.Right && pictureBox1.Right > label21.Left && pictureBox1.Top < label21.Bottom && pictureBox1.Bottom > label21.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(31, 60);
                timer6.Enabled = true;
                can -= 1;
                label40.Text = can.ToString();
            }

            if (pictureBox1.Left < label22.Right && pictureBox1.Right > label22.Left && pictureBox1.Top < label22.Bottom && pictureBox1.Bottom > label22.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(31, 60);
                timer6.Enabled = true;
                can -= 1;
                label40.Text = can.ToString();
            }

            if (pictureBox1.Left < label23.Right && pictureBox1.Right > label23.Left && pictureBox1.Top < label23.Bottom && pictureBox1.Bottom > label23.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(31, 60);
                timer6.Enabled = true;
                can -= 1;
                label40.Text = can.ToString();
            }

            if (pictureBox1.Left < label24.Right && pictureBox1.Right > label24.Left && pictureBox1.Top < label24.Bottom && pictureBox1.Bottom > label24.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(31, 60);
                timer6.Enabled = true;
                can -= 1;
                label40.Text = can.ToString();
            }

            if (pictureBox1.Left < label25.Right && pictureBox1.Right > label25.Left && pictureBox1.Top < label25.Bottom && pictureBox1.Bottom > label25.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(31, 60);
                timer6.Enabled = true;
                can -= 1;
                label40.Text = can.ToString();
            }

            if (pictureBox1.Left < label26.Right && pictureBox1.Right > label26.Left && pictureBox1.Top < label26.Bottom && pictureBox1.Bottom > label26.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(31, 60);
                timer6.Enabled = true;
                can -= 1;
                label40.Text = can.ToString();
            }

            if (pictureBox1.Left < label27.Right && pictureBox1.Right > label27.Left && pictureBox1.Top < label27.Bottom && pictureBox1.Bottom > label27.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(31, 60);
                timer6.Enabled = true;
                can -= 1;
                label40.Text = can.ToString();
            }

            if (pictureBox1.Left < label38.Right && pictureBox1.Right > label38.Left && pictureBox1.Top < label38.Bottom && pictureBox1.Bottom > label38.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(31, 60);
                timer6.Enabled = true;
                can -= 1;
                label40.Text = can.ToString();
            }

            if (pictureBox1.Left < label39.Right && pictureBox1.Right > label39.Left && pictureBox1.Top < label39.Bottom && pictureBox1.Bottom > label39.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(31, 60);
                timer6.Enabled = true;
                can -= 1;
                label40.Text = can.ToString();
            }

            if (pictureBox1.Left < label11.Right && pictureBox1.Right > label11.Left && pictureBox1.Top < label11.Bottom && pictureBox1.Bottom > label11.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(31, 60);
                timer6.Enabled = true;
                can -= 1;
                label40.Text = can.ToString();
            }

        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (can == 0)
            {
                timer6.Enabled = false;
                timer7.Enabled = false;
          
                MessageBox.Show("OYUNU KAYBETTİNİZ");


               
                Form4 frm4 = new Form4();
                frm4.Show();
                this.Hide();
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            label22.Left -= 3;
            label23.Left -= 3;
            label24.Left -= 3;
            label25.Left -= 3;
            label38.Left -= 3;
            label39.Left -= 3;
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            label22.Left += 3;
            label23.Left += 3;
            label24.Left += 3;
            label25.Left += 3;
            label38.Left += 3;
            label39.Left += 3;
        }
    }
}

