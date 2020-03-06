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
    public partial class Form4 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form4()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Desktop\Point Of Sale\Database.accdb;
Persist Security Info=False;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text == "")
            {
                MessageBox.Show("PLease Enter a Username");
            }
            else if (txt_Password.Text == "")
            {
                MessageBox.Show("PLease Enter a Password");
            }

            else
            {

                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;


                    // command.CommandText = "insert into Admin (EID,Username,[Password]) values('" + txt_ID.Text+ "','" + txt_Username.Text + "','" + txt_Password.Text + "')";
                    command.CommandText = "insert into Login (Username,[Password]) values('" + txt_Username.Text + "','" + txt_Password.Text + "')";

                    command.ExecuteNonQuery();
                    MessageBox.Show("New User Data INSERTED Successfully");
                    connection.Close();
                }

                
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);

                }
                txt_ID.Text = "";
                txt_Username.Text = "";
                txt_Password.Text = "";
            }
        }

        private void Load_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string query = "select * from Login";
            command.CommandText = query;

            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            connection.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text == "")
            {
                MessageBox.Show("Please Select User's ID From The Data To Be EDITED");
            }
            else
            {
                try
                {


                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    string query = "update Login set Username='" + txt_Username.Text + "',[Password]='" + txt_Password.Text + "' where EID=" + txt_ID.Text + "";
                    MessageBox.Show(query);
                    command.CommandText = query;


                    command.ExecuteNonQuery();
                    MessageBox.Show("User's Data EDITED Successfully");
                    connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
                txt_ID.Text = "";
                txt_Username.Text = "";
                txt_Password.Text = "";
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text == "")
            {
                MessageBox.Show("Please Select User's ID From The Data To Be DELETED");
            }
            else
            {
                try
                {


                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    string query = "delete from Login where EID=" + txt_ID.Text + "";
                    //MessageBox.Show(query);
                    command.CommandText = query;


                    command.ExecuteNonQuery();
                    MessageBox.Show("User's Data DELETED Successfully");
                    connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
                txt_ID.Text = "";
                txt_Username.Text = "";
                txt_Password.Text = "";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CashierLogin f1 = new CashierLogin();
            f1.ShowDialog();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
         

           
        }

        private void itemManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }

       

       

        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {

                txt_ID.Text = row.Cells["EID"].Value.ToString();

                txt_Username.Text = row.Cells["Username"].Value.ToString();
                txt_Password.Text = row.Cells["Password"].Value.ToString();

            }
        }

      
    }
}

