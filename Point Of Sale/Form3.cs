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
    public partial class Form3 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form3()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Desktop\Point Of Sale\Database.accdb;
Persist Security Info=False;";
        }

        private void txt_Username_Enter(object sender, EventArgs e)
        {
            if (txt_Username.Text == "Administrator")
            {
                txt_Username.Text = "";
                txt_Username.ForeColor = Color.DarkGray;
            }
        }

        private void txt_Username_Leave(object sender, EventArgs e)
        {
            if (txt_Username.Text == "")
            {
                txt_Username.Text = "Administrator";
                txt_Username.ForeColor = Color.Silver;
            }
        }

        private void txt_Password_Enter(object sender, EventArgs e)
        {
            if (txt_Password.Text == "Password")
            {
                txt_Password.Text = "";
                txt_Password.ForeColor = Color.DarkGray;
            }
        }

        private void txt_Password_Leave(object sender, EventArgs e)
        {
            if (txt_Password.Text == "")
            {
                txt_Password.Text = "Password";
                txt_Password.ForeColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select * from Admin where Username='" + txt_Username.Text + "' and Password='" + txt_Password.Text + "'";

            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count = count + 1;

            }
            if (count == 1)
            {
                MessageBox.Show("Username and password is correct boy");
                connection.Close();
                connection.Dispose();

                this.Hide();
                Form4 f4 = new Form4();
                f4.ShowDialog();

            }
            else if (count > 1)
            {
                MessageBox.Show("Dupklicate password");
            }
            else
            {
                MessageBox.Show("Username password is incorrect");
            }
            connection.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CashierLogin f1 = new CashierLogin();
            f1.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_Password.UseSystemPasswordChar = true;
            }
            else
            {
                txt_Password.UseSystemPasswordChar = false;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
