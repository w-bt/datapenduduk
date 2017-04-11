using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Penduduk
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection(@"Data Source=MELKA-PC;Initial Catalog=citizen;Integrated Security=True");
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayData();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into data (name,city,country) values('" + textName.Text + "','" + textCity.Text + "','" + textCountry.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            displayData();
            MessageBox.Show("Record inserted succesfully!");
            textName.Clear();
            textCity.Clear();
            textCountry.Clear();
        }

        public void displayData()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from data";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView.DataSource = dt;
            con.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from data where citizenID='"+textID.Text+"'";
            cmd.ExecuteNonQuery();
            con.Close();
            displayData();
            MessageBox.Show("Record " + textID.Text + " deleted succesfully!");
            textID.Clear();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update data set name='"+textName.Text+"', city='"+textCity.Text+"', country='"+textCountry.Text+"' where citizenID='" + textID.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            displayData();
            MessageBox.Show("Record " + textID.Text + " updated succesfully!");
            textID.Clear();
            textName.Clear();
            textCity.Clear();
            textCountry.Clear();
        }

        private void butttonSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            string tempCommand = "select * from data where ";
            int flag = 0;
            if (textID.Text != "")
            {
                tempCommand = tempCommand + "citizenID LIKE '%" + textID.Text + "%' or ";
                flag = 1;
            }
            if (textName.Text != "")
            {
                tempCommand = tempCommand + "name LIKE '%" + textName.Text + "%' or ";
                flag = 1;
            }
            if (textCity.Text != "")
            {
                tempCommand = tempCommand + "city LIKE '%" + textCity.Text + "%' or ";
                flag = 1;
            }
            if (textCountry.Text != "")
            {
                tempCommand = tempCommand + "country LIKE '%" + textCountry.Text + "%' or ";
                flag = 1;
            }
            if (flag == 0)
            {
                tempCommand = "select * from data";
            }
            else
            {
                string tempCommand2 = "";
                for (int i = 0; i < (tempCommand.Length - 4); i++)
                {
                    tempCommand2 = tempCommand2 + tempCommand[i];
                }
                tempCommand = tempCommand2;
            }
            cmd.CommandText = tempCommand;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView.DataSource = dt;
            con.Close();
            textID.Clear();
            textName.Clear();
            textCity.Clear();
            textCountry.Clear();
        }
    }
}
