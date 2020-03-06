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
    public partial class Form2 : Form
    {
        
        private OleDbConnection connection = new OleDbConnection();
        public Form2(string userName)
        {

            InitializeComponent();
            label1.Text = userName;
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Desktop\Point Of Sale\Database.accdb;
Persist Security Info=False;";

            
            dataGridView2.ColumnCount = 4;
            dataGridView2.Columns[0].Name = "ID";
            dataGridView2.Columns[1].Name = "Product Name";
            dataGridView2.Columns[2].Name = "Price";
            dataGridView2.Columns[3].Name = "Quantity";

        }

        private void tabPage2_Click(object sender, EventArgs e)
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
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        DataTable table = new DataTable();
        private object userName;

        private void Form2_Load(object sender, EventArgs e)
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

            timer1.Start();
            label7.Text = DateTime.Now.ToLongTimeString();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Cell_Click(object sender, DataGridViewCellEventArgs e)
        {


            //Cart_Box.Items.Add("ID    " + "Product      " + "Price");

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {

                textBox2.Text = row.Cells["ID"].Value.ToString();

                textBox3.Text = row.Cells["Product_Name"].Value.ToString();
                textBox5.Text = row.Cells["Price"].Value.ToString();
              
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Please choose the product");
            }

           


            else if (textBox6.Text == "")
            {
                MessageBox.Show("Please enter the quantity");
            }
            else
            {
                addData(textBox2.Text, textBox3.Text, textBox5.Text, textBox6.Text);


                textBox2.Text = "";
                textBox3.Text = "";
                textBox6.Text = "";
                textBox5.Text = "";
            }

        }

        private void addData(string id, string name, string price, string quantity)
        {
            String[] row = { id, name, price, quantity };
            dataGridView2.Rows.Add(row);
        }

        private void Cell_Content_Click(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = 0;

            for(int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                sum += (Convert.ToInt32(dataGridView2.Rows[i].Cells[3].Value) * Convert.ToInt32(dataGridView2.Rows[i].Cells[2].Value));
            }

            //MessageBox.Show("You have to pay RM " + sum.ToString());

           


            this.Hide();
            Form6 f6 = new Form6(sum.ToString(), label1.Text);
            f6.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4(object sender, KeyPressEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label8.Text = DateTime.Now.ToLongDateString();
            label7.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (searchbox.Text == "Search by Name")
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
                search.Text = "";
            }
            
            else if (searchbox.Text == "Search by ID")
            {

                if (search.Text == "")
                {
                    MessageBox.Show("Please Enter The Keyword");
                }
                else
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
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if(!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Load_Click(object sender, EventArgs e)
        {
            label8.Text = DateTime.Now.ToLongDateString();

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

        private void search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (searchbox.Text == "Search by ID" || searchbox.Text == "")
            {
                char ch = e.KeyChar;

                if (!Char.IsDigit(ch) && ch != 8)
                {
                    e.Handled = true;
                }
            }


        }

        private void searchbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            search.Text = "";
        }
    }
}
