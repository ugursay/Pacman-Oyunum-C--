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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }


        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=kayıtverileri.mdw");

        private void verilerigörüntüle()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("Select *From kayıt");
            OleDbDataReader oku = komut.ExecuteReader();
            listBox1.Items.Clear();
            while (oku.Read())
            {


                listBox1.Items.Add(oku["bölüm"].ToString());
                listBox1.Items.Add(oku["can"].ToString());


            }

            baglanti.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            if (Convert.ToInt32(listBox1.Items[0].ToString()) == 1)
            {

               
                frm1.Show();
                this.Hide();
                if (Convert.ToInt32(listBox1.Items[1].ToString()) == 1)
                {
                    
                    frm1.label26.Text = "1";
                    frm1.can = 1;
                }

                if (Convert.ToInt32(listBox1.Items[1].ToString()) == 2)
                {

                    frm1.label26.Text = "2";
                    frm1.can = 2;
                }

                if (Convert.ToInt32(listBox1.Items[1].ToString()) == 3)
                {

                    frm1.label26.Text = "3";
                    frm1.can = 3;
                }
                
              
            }
            Form2 frm2 = new Form2();
            if (Convert.ToInt32(listBox1.Items[0].ToString()) == 2)
            {
              
                frm2.Show();
                this.Hide();

                if (Convert.ToInt32(listBox1.Items[1].ToString()) == 1)
                {
                    frm2.label32.Text = "1";
                    frm2.can = 1;
                   
                }

                if (Convert.ToInt32(listBox1.Items[1].ToString()) == 2)
                {
                    frm2.label32.Text = "2";
                    frm2.can = 2;
                  
                }

                if (Convert.ToInt32(listBox1.Items[1].ToString()) == 3)
                {
                    frm2.label32.Text = "3";
                    frm2.can = 3;
                    
                }

            }
            Form3 frm3 = new Form3();
            if (Convert.ToInt32(listBox1.Items[0].ToString()) == 3)
            {
               
                frm3.Show();
                this.Hide();

                if (Convert.ToInt32(listBox1.Items[1].ToString()) == 1)
                {
                   
                   
                    frm3.label40.Text = "1";
                    frm3.can = 1;
                }

                if (Convert.ToInt32(listBox1.Items[1].ToString()) == 2)
                {
                
                    frm3.label40.Text = "2";
                    frm3.can = 2;
                }

                if (Convert.ToInt32(listBox1.Items[1].ToString()) == 3)
                {
                  
                    frm3.label40.Text = "3";
                    frm3.can = 3;
                }

            }

            

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            verilerigörüntüle();
        }
    }
}
