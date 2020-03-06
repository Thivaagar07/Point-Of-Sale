using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Point_Of_Sale
{
    public partial class Form6 : Form
    {
      
        private OleDbConnection connection = new OleDbConnection();

        public Form6(string payment, string userName)
        {
            InitializeComponent();
            textBox2.Text = payment;
          
            label4.Text =  userName;
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Desktop\Point Of Sale\Database.accdb;
Persist Security Info=False;";
        }

        private void Form6_Load(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DateTime date = System.DateTime.Today.Date;
            //string.Format("(0: dd MM yyyy)", date);

            var dateTimeNow = DateTime.Now; // Return 00/00/0000 00:00:00
            var dateOnlyString = dateTimeNow.ToShortDateString(); //Return 00/00/0000

            if (Convert.ToDouble(textBox1.Text) < Convert.ToDouble(textBox2.Text))
            {
                MessageBox.Show("Not Enough");
            }
            else {
                textBox3.Text =  (Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text)).ToString();

                
                
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    //command.CommandText = "insert into Test (Name,Place,location, New) values('" + label1.Text + "','" + label7.Text + "','" + "RM " + sum + "','" +00 + "')";
                    //command.CommandText = "insert into Transaction (Name,Time,Date, Payment, Received, Balance) values('" + label4.Text + "','" + DateTime.Now.ToLongTimeString() + "','" + "RM " + textBox2.Text + "','" + date + "')";
                    command.CommandText = "insert into Trans (Name,[Time],[Date], Payment, Received, Balance) values('" + label4.Text + "','" + DateTime.Now.ToLongTimeString() + "','" + dateOnlyString + "','" + "RM " + textBox2.Text + "','" + "RM " + textBox1.Text + "','" + "RM " + textBox3.Text + "')";

                    //command.CommandText = "insert into Trans (Name, [Time]) values('" + label4.Text + "','" + DateTime.Now.ToLongTimeString() + "')";


                    MessageBox.Show(command.CommandText);
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2(label4.Text);
            f2.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
