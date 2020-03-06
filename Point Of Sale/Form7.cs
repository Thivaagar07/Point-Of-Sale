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
    public partial class Form7 : Form
    {
        

        private OleDbConnection connection = new OleDbConnection();
        public Form7()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Desktop\Point Of Sale\Database.accdb;
Persist Security Info=False;";
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string query = "select * from Trans ";
            
            
            command.CommandText = query;

            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void Filter_Click(object sender, EventArgs e)
        {
            // string.Format("(0: dd MM yyyy)", label1.Text);

            //label1.Text = dateTimePicker1.Value.Date.ToString("d/MM/yyyy");

            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string query = "select * from Trans where Date= '" + dateTimePicker1.Value.Date.ToString("d/MM/yyyy") + "'";
            command.CommandText = query;

            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            connection.Close();

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CashierLogin f1 = new CashierLogin();
            f1.ShowDialog();
        }

        private void itemManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void profileManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }
    }
}
