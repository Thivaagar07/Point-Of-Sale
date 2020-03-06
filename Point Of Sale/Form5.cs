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
    public partial class Form5 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form5()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Desktop\Point Of Sale\Database.accdb;
Persist Security Info=False;";
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

        private void txt_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Product_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into Shop (ID,Product_Name,[Price]) values('" + txt_ID.Text + "','" + txt_Product_Name.Text + "','" + txt_Price.Text + "')";

                command.ExecuteNonQuery();
                MessageBox.Show("Data Saved");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);

            }
        }

        private void Load_Product_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Shop";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
           
        }

        private void Edit_Product_Click(object sender, EventArgs e)
        {
            try
            {             
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update Shop set Product_Name='" + txt_Product_Name.Text + "',[Price]='" + txt_Price.Text + "',[Quantity]='" + txt_Quantity.Text + "' where ID=" + txt_ID.Text + "";
                MessageBox.Show(query);
                command.CommandText = query;

                command.ExecuteNonQuery();
                MessageBox.Show("Data Edit Successful");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void Del_Product_Click(object sender, EventArgs e)
        {
            try
            {


                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "delete from Shop where ID=" + txt_ID.Text + "";
                //MessageBox.Show(query);
                command.CommandText = query;


                command.ExecuteNonQuery();
                MessageBox.Show("Data Delete Successful");
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Search(object sender, EventArgs e)
        {
            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(searchbox.Text == "Search by Name")
            {
                try
                {

                    connection.Open();
                    OleDbCommand command = new OleDbCommand();

                    command.Connection = connection;
                    string query = "select * from Shop where Product_Name='" + search.Text + "'";
                    command.CommandText = query;

                    OleDbDataAdapter da = new OleDbDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
            }

            else if(searchbox.Text == "Search by ID")
            {
                try
                {

                    connection.Open();
                    OleDbCommand command = new OleDbCommand();

                    command.Connection = connection;
                    string query = "select * from Shop where [ID]=" + search.Text + "";
                    command.CommandText = query;

                    OleDbDataAdapter da = new OleDbDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
            }
        
        }

        private void profileManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void searchbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }
    }
}
