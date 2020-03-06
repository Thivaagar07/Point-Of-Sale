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
    public partial class CashierLogin : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public CashierLogin()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Desktop\Point Of Sale\Database.accdb;
Persist Security Info=False;";
        }


       

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            //command.CommandText = "select * from Admin where Username='" + txt_Username.Text + "' and Password='" + txt_Password.Text + "'";
            command.CommandText = "select * from Admin,Login where Admin.Username='" + Username.Text + "' and Admin.Password='" + Password.Text + "'or Login.Username='"+ Username.Text + "' and Login.Password='" +Password.Text+ "'";
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
                Form2 f2 = new Form2(Username.Text);
                f2.ShowDialog();

            }
            else if (count > 1)
            {
                //MessageBox.Show("Duplicate password");


                MessageBox.Show("Username and password is correct boy");
                connection.Close();
                connection.Dispose();

                this.Hide();
                Form2 f2 = new Form2(Username.Text);
                f2.ShowDialog();

            }
            else
            {
                MessageBox.Show("Username password is incorrect");
            }
            connection.Close();
        }

        private void txt_Username_Enter(object sender, EventArgs e)
        {
            if(Username.Text == "Username")
            {
                Username.Text = "";
                Username.ForeColor = Color.DarkGray;
            }
        }

        private void txt_Username_Leave(object sender, EventArgs e)
        {
            if (Username.Text == "")
            {
                Username.Text = "Username";
                Username.ForeColor = Color.Silver;
            }
        }

        private void txt_Password_Enter(object sender, EventArgs e)
        {
            if (Password.Text == "Password")
            {
                Password.Text = "";
                Password.ForeColor = Color.DarkGray;
            }
        }

        private void txt_Password_Leave(object sender, EventArgs e)
        {
            if (Password.Text == "")
            {
                Password.Text = "Password";
                Password.ForeColor = Color.Silver;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void CheckedChange(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Password.UseSystemPasswordChar = true;
            }
            else
            {
                Password.UseSystemPasswordChar = false;
            }
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
