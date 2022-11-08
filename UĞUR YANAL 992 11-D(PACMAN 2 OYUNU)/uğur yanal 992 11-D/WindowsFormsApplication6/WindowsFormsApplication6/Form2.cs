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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int x;
        int y;


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




        private void Form2_KeyDown(object sender, KeyEventArgs e)
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
                    komut.CommandText = "update kayıt set bölüm='" + label34.Text + "' ,can='" + label32.Text + "' where sıra='" + "1" + "' ";
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
              
                Form3 frm3 = new Form3();

                frm3.label40.Text = label32.Text;
                frm3.label52.Text = label32.Text;
              


                frm3.Show();
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

            if (pictureBox1.Left < label4.Right && pictureBox1.Right > label4.Left && pictureBox1.Top < label4.Bottom && pictureBox1.Bottom > label4.Top)
            {
                x += 10;
            }

            if (pictureBox1.Left < label3.Right && pictureBox1.Right > label3.Left && pictureBox1.Top < label3.Bottom && pictureBox1.Bottom > label3.Top)
            {
                x -= 10;
            }




            if (pictureBox1.Left < label5.Right && pictureBox1.Right > label5.Left && pictureBox1.Top < label5.Bottom && pictureBox1.Bottom > label5.Top)
            {
                x -= 10;
            }

            if (pictureBox1.Left < label14.Right && pictureBox1.Right > label14.Left && pictureBox1.Top < label14.Bottom && pictureBox1.Bottom > label14.Top)
            {
                x += 10;
            }

            if (pictureBox1.Left < label15.Right && pictureBox1.Right > label15.Left && pictureBox1.Top < label15.Bottom && pictureBox1.Bottom > label15.Top)
            {
                y += 10;
            }



            if (pictureBox1.Left < label13.Right && pictureBox1.Right > label13.Left && pictureBox1.Top < label13.Bottom && pictureBox1.Bottom > label13.Top)
            {
                y += 10;
            }

            if (pictureBox1.Left < label23.Right && pictureBox1.Right > label23.Left && pictureBox1.Top < label23.Bottom && pictureBox1.Bottom > label23.Top)
            {
                y -= 10;
            }

            if (pictureBox1.Left < label24.Right && pictureBox1.Right > label24.Left && pictureBox1.Top < label24.Bottom && pictureBox1.Bottom > label24.Top)
            {
                x += 10;
            }


            if (pictureBox1.Left < label22.Right && pictureBox1.Right > label22.Left && pictureBox1.Top < label22.Bottom && pictureBox1.Bottom > label22.Top)
            {
                y += 10;
            }

            if (pictureBox1.Left < label26.Right && pictureBox1.Right > label26.Left && pictureBox1.Top < label26.Bottom && pictureBox1.Bottom > label26.Top)
            {
                y -= 10;
            }

            if (pictureBox1.Left < label29.Right && pictureBox1.Right > label29.Left && pictureBox1.Top < label29.Bottom && pictureBox1.Bottom > label29.Top)
            {
                x -= 10;
            }


            pictureBox1.Location = new Point(x, y);
        }
        public int can;
        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(35,35);

            can = 3;
            can -= 1;
            label32.Text = can.ToString();
            

            label32.Text = label36.Text;
            can = int.Parse(label36.Text);

            timer1.Enabled = true;

           
            timer7.Enabled = true;

            label34.Text = "2";

            timer6.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label6.Left < label4.Right && label6.Right > label4.Left && label6.Top < label4.Bottom && label6.Bottom > label4.Top)
            {
                
                timer2.Enabled = true;
                timer3.Enabled = false;
            }
            if (label6.Left < label7.Right && label6.Right > label7.Left && label6.Top < label7.Bottom && label6.Bottom > label7.Top)
            {
                
                timer2.Enabled = false;
                timer3.Enabled = true;
            }




            if (label11.Left < label10.Right && label11.Right > label10.Left && label11.Top < label10.Bottom && label11.Bottom > label10.Top)
            {

                timer2.Enabled = true;
                timer3.Enabled = false;
            }
            if (label11.Left < label4.Right && label11.Right > label4.Left && label11.Top < label4.Bottom && label11.Bottom > label4.Top)
            {

                timer2.Enabled = false;
                timer3.Enabled = true;
            }





            if (label12.Left < label2.Right && label12.Right > label2.Left && label12.Top < label2.Bottom && label12.Bottom > label2.Top)
            {

                timer4.Enabled = true;
                timer5.Enabled = false;
            }

            if (label12.Left < label1.Right && label12.Right > label1.Left && label12.Top < label1.Bottom && label12.Bottom > label1.Top)
            {

                timer4.Enabled = false;
                timer5.Enabled = true;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label6.Left += 1;
            label7.Left -= 1;

            label11.Left -= 1;
            label10.Left += 1;

            label9.Left += 1;
            label8.Left -= 1;

            label16.Top -= 1;
            label17.Top += 1;

            label18.Top -= 1;
            label19.Top += 1;

            label30.Top += 1;
            label31.Top -= 1;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label6.Left -= 1;
            label7.Left += 1;

            label11.Left += 1;
            label10.Left -= 1;

            label9.Left -= 1;
            label8.Left += 1;

            label16.Top += 1;
            label17.Top -= 1;

            label18.Top += 1;
            label19.Top -= 1;

            label30.Top -= 1;
            label31.Top += 1;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            label12.Top -= 2;

            label20.Left -= 4;
            label21.Left -= 4;

            label25.Left += 3;
            label28.Left += 3;
            label27.Left -= 3;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            label12.Top += 2;

            label20.Left += 4;
            label21.Left += 4;

            label25.Left -= 3;
            label28.Left -= 3;
            label27.Left += 3;
        }

     
        private void timer6_Tick(object sender, EventArgs e)
        {

            if (pictureBox1.Left < label8.Right && pictureBox1.Right > label8.Left && pictureBox1.Top < label8.Bottom && pictureBox1.Bottom > label8.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(34,34);
                timer6.Enabled = true;
                can -= 1;
                label32.Text = can.ToString();
            }

            if (pictureBox1.Left < label9.Right && pictureBox1.Right > label9.Left && pictureBox1.Top < label9.Bottom && pictureBox1.Bottom > label9.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(34, 34);
                timer6.Enabled = true;
                can -= 1;
                label32.Text = can.ToString();
            }

            if (pictureBox1.Left < label10.Right && pictureBox1.Right > label10.Left && pictureBox1.Top < label10.Bottom && pictureBox1.Bottom > label10.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(34, 34);
                timer6.Enabled = true;
                can -= 1;
                label32.Text = can.ToString();
            }

            if (pictureBox1.Left < label11.Right && pictureBox1.Right > label11.Left && pictureBox1.Top < label11.Bottom && pictureBox1.Bottom > label11.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(34, 34);
                timer6.Enabled = true;
                can -= 1;
                label32.Text = can.ToString();
            }

            if (pictureBox1.Left < label6.Right && pictureBox1.Right > label6.Left && pictureBox1.Top < label6.Bottom && pictureBox1.Bottom > label6.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(34, 34);
                timer6.Enabled = true;
                can -= 1;
                label32.Text = can.ToString();
            }

            if (pictureBox1.Left < label7.Right && pictureBox1.Right > label7.Left && pictureBox1.Top < label7.Bottom && pictureBox1.Bottom > label7.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(34, 34);
                timer6.Enabled = true;
                can -= 1;
                label32.Text = can.ToString();
            }

            if (pictureBox1.Left < label12.Right && pictureBox1.Right > label12.Left && pictureBox1.Top < label12.Bottom && pictureBox1.Bottom > label12.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(34, 34);
                timer6.Enabled = true;
                can -= 1;
                label32.Text = can.ToString();
            }

            if (pictureBox1.Left < label16.Right && pictureBox1.Right > label16.Left && pictureBox1.Top < label16.Bottom && pictureBox1.Bottom > label16.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(34, 34);
                timer6.Enabled = true;
                can -= 1;
                label32.Text = can.ToString();
            }

            if (pictureBox1.Left < label17.Right && pictureBox1.Right > label17.Left && pictureBox1.Top < label17.Bottom && pictureBox1.Bottom > label17.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(34, 34);
                timer6.Enabled = true;
                can -= 1;
                label32.Text = can.ToString();
            }

            if (pictureBox1.Left < label18.Right && pictureBox1.Right > label18.Left && pictureBox1.Top < label18.Bottom && pictureBox1.Bottom > label18.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(34, 34);
                timer6.Enabled = true;
                can -= 1;
                label32.Text = can.ToString();
            }

            if (pictureBox1.Left < label19.Right && pictureBox1.Right > label19.Left && pictureBox1.Top < label19.Bottom && pictureBox1.Bottom > label19.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(34, 34);
                timer6.Enabled = true;
                can -= 1;
                label32.Text = can.ToString();
            }

            if (pictureBox1.Left < label20.Right && pictureBox1.Right > label20.Left && pictureBox1.Top < label20.Bottom && pictureBox1.Bottom > label20.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(34, 34);
                timer6.Enabled = true;
                can -= 1;
                label32.Text = can.ToString();
            }

            if (pictureBox1.Left < label21.Right && pictureBox1.Right > label21.Left && pictureBox1.Top < label21.Bottom && pictureBox1.Bottom > label21.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(34, 34);
                timer6.Enabled = true;
                can -= 1;
                label32.Text = can.ToString();
            }

            if (pictureBox1.Left < label25.Right && pictureBox1.Right > label25.Left && pictureBox1.Top < label25.Bottom && pictureBox1.Bottom > label25.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(34, 34);
                timer6.Enabled = true;
                can -= 1;
                label32.Text = can.ToString();
            }

            if (pictureBox1.Left < label27.Right && pictureBox1.Right > label27.Left && pictureBox1.Top < label27.Bottom && pictureBox1.Bottom > label27.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(34, 34);
                timer6.Enabled = true;
                can -= 1;
                label32.Text = can.ToString();
            }

            if (pictureBox1.Left < label28.Right && pictureBox1.Right > label28.Left && pictureBox1.Top < label28.Bottom && pictureBox1.Bottom > label28.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(34, 34);
                timer6.Enabled = true;
                can -= 1;
                label32.Text = can.ToString();
            }

            if (pictureBox1.Left < label30.Right && pictureBox1.Right > label30.Left && pictureBox1.Top < label30.Bottom && pictureBox1.Bottom > label30.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(34, 34);
                timer6.Enabled = true;
                can -= 1;
                label32.Text = can.ToString();
            }

            if (pictureBox1.Left < label31.Right && pictureBox1.Right > label31.Left && pictureBox1.Top < label31.Bottom && pictureBox1.Bottom > label31.Top)
            {
                timer6.Enabled = false;
                MessageBox.Show("YAKALANDIN");
                pictureBox1.Location = new Point(34, 34);
                timer6.Enabled = true;
                can -= 1;
                label32.Text = can.ToString();
            }

        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (can == 0)
            {
                //timer6.Enabled = false;
                timer7.Enabled = false;
                MessageBox.Show("OYUNU KAYBETTİNİZ");
               

                Form4 frm4 = new Form4();
                frm4.Show();
                this.Close();
            }
        }
    }
}
