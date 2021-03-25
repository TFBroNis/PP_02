using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace theSchool
{
    public partial class ClientService : Form
    {
        public string GetConnect = @"Data Source=BRONISLAV-PC\SQLEXPRESS02;Initial Catalog=theSchool;Integrated Security=True";
        public string serviceId;
        public double durH, durM;
        public bool canSign = false;
        public ClientService(string id)
        {
            serviceId = id;
            InitializeComponent();
        }

        public void ClientService_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM [Service] WHERE [ID] = " + serviceId;
            using (SqlConnection connection = new SqlConnection(GetConnect))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    pictureBox1.ImageLocation = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\" + reader["MainImagePath"].ToString();
                    label1.Text = reader["Title"].ToString();
                    durM = Convert.ToInt32(reader["DurationInSeconds"].ToString()) / 60;
                    durH = Math.Floor(durM / 60);
                    label2.Text = durM + " мин.";
                    durM %= 60;
                }
                reader.Close();
                query = "SELECT DISTINCT [FirstName],[MiddleName],[LastName] FROM [Client]";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                string[] mas = new string[dt.Rows.Count + 1];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    mas[i] = dt.Rows[i]["LastName"].ToString() + " " + dt.Rows[i]["FirstName"].ToString() + " " + dt.Rows[i]["MiddleName"].ToString();
                }
                comboBox1.DataSource = mas;
                comboBox1.SelectedIndex = 0;
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (canSign)
            {
                string[] lastName = comboBox1.Text.Split(new char[] { ' ' });
                string query = "INSERT INTO [ClientService] (Client,Service,StartTime) VALUES ('" + lastName[0] + "','" + label1.Text + "','"
                    + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + " " + textBox1.Text.Trim().Replace(" ", "") + "')";
                using (SqlConnection connection = new SqlConnection(GetConnect))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                }
                MessageBox.Show("Клиент успешно записан!");
            }
            else
            {
                MessageBox.Show("Время должно быть введено в формате: 00:00");
            }
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            string[] time = textBox1.Text.Split(new char[] { ':' });
            if (time.Length == 2)
            {
                string hours = time[0].Trim().Replace(" ", "");
                string minutes = time[1].Trim().Replace(" ", "");
                int Num;
                bool isNum = int.TryParse(hours, out Num);
                bool isNum2 = int.TryParse(minutes, out Num);
                if (isNum && isNum2 && hours.Length == 2 && minutes.Length == 2 && Convert.ToInt32(hours) < 24 && Convert.ToInt32(minutes) < 60)
                {
                    double endH = Convert.ToDouble(hours) + durH;
                    if (endH >= 24)
                        endH -= 24;
                    double endM = Convert.ToDouble(minutes) + durM;
                    if (endM >= 60)
                    {
                        endM -= 60;
                        endH++;
                    }
                    if (endH >= 24)
                        endH -= 24;
                    label7.Text = "Время окончания: " + (endH.ToString().Length == 1 ? "0" : "") + endH + ":" + (endM.ToString().Length == 1 ? "0" : "") + endM;
                    canSign = true;
                }
                else
                {
                    canSign = false;
                    label7.Text = "Время окончания: --:--";
                }
            }
            else
            {
                canSign = false;
                label7.Text = "Время окончания: --:--";
            }
        }
    }
}
