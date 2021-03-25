using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace theSchool
{
    public partial class ServiceList : Form
    {
        public int idNextService = 0, minutes;
        public int? ServicesCount;
        public double price, discount, discountedPrice;
        public DataTable Services = new DataTable();
        public string GetConnect = @"Data Source=BRONISLAV-PC\SQLEXPRESS02;Initial Catalog=theSchool;Integrated Security=True";
        public string title, discountText, showID1, showID2, showID3;
        public bool stop = false;
        public bool deleteSuccess;
        public static bool opened = false;

        public void button4_Click(object sender, EventArgs e)
        {
            editService(showID2);
        }

        public void button6_Click(object sender, EventArgs e)
        {
            editService(showID3);
        }

        public void button1_Click(object sender, EventArgs e)
        {
            editService(showID1);
        }

        public void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0000")
            {
                MessageBox.Show("Вы успешно вошли в режим администратора!");
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button10.Enabled = true;
            }
            else
            {
                MessageBox.Show("Вы ввели неверный код!");
            }
        }

        public void signService(string id)
        {
            ClientService cs = new ClientService(id);
            cs.Show();
        }

        public void button8_Click(object sender, EventArgs e)
        {
            if (idNextService >= 6)
            {
                idNextService -= 6;
                outputServices();
                button7.Enabled = true;
            }
            if (idNextService < 6)
                button8.Enabled = false;
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshServices();
        }

        public void editService(string id)
        {
            if (!opened)
            {
                addEditService go = new addEditService(id);
                opened = true;
                go.Show();
            }
            else
            {
                MessageBox.Show("Вы уже редактируете или добавляете услугу!");
            }
        }

        public void addService()
        {
            if (!opened)
            {
                addEditService go = new addEditService();
                opened = true;
                go.Show();
            }
            else
            {
                MessageBox.Show("Вы уже редактируете или добавляете услугу!");
            }
        }

        public void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshServices();
        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
            refreshServices();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            deleteService(showID1);
        }

        public void deleteService(string id)
        {
            deleteSuccess = false;
            if (!opened)
            {
                if (MessageBox.Show("Вы точно хотите удалить услугу?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string query = "DELETE FROM [Service] WHERE [ID] = " + id;
                    using (SqlConnection connection = new SqlConnection(GetConnect))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(query, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        reader.Close();
                    }
                    deleteSuccess = true;
                    int startFrom = idNextService - 3;
                    ServicesCount--;
                    prepareServices();
                    idNextService = startFrom;
                    outputServices();
                }
            }
            else
            {
                MessageBox.Show("Нельзя удалять услугу во время добавления/редактирования услуги!");
            }
        }

        public void button3_Click(object sender, EventArgs e)
        {
            deleteService(showID2);
        }

        public void button5_Click(object sender, EventArgs e)
        {
            deleteService(showID3);
        }

        public void button10_Click(object sender, EventArgs e)
        {
            addService();
        }

        public void button11_Click(object sender, EventArgs e)
        {
            signService(showID1);
        }

        public void button12_Click(object sender, EventArgs e)
        {
            signService(showID2);
        }

        public void button13_Click(object sender, EventArgs e)
        {
            signService(showID3);
        }

        public void button14_Click(object sender, EventArgs e)
        {
            NearSigns ns = new NearSigns();
            ns.Show();
        }

        public ServiceList()
        {
            InitializeComponent();
        }

        public void button7_Click(object sender, EventArgs e)
        {
            outputServices();
            if (idNextService >= 6)
                button8.Enabled = true;
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            refreshServices();
        }

        public void refreshServices()
        {
            button7.Enabled = true;
            button8.Enabled = false;
            prepareServices();
            if (Services.Rows.Count <= 3)
                button7.Enabled = false;
            outputServices();
        }

        public void prepareServices()
        {
            Services = new DataTable();
            idNextService = 0;
            string query = "SELECT * FROM [Service] WHERE [ID]=[ID]";
            if (textBox2.Text.Trim() != "")
            {
                query += " AND ([Title] LIKE '%" + textBox2.Text.Trim() + "%' OR [Description] LIKE '%" + textBox2.Text.Trim() + "%')";
            }
            switch (comboBox2.SelectedIndex)
            {
                case 1:
                    query += " AND [Discount] >= 0 AND [Discount] < 0.05";
                    break;
                case 2:
                    query += " AND [Discount] >= 0.05 AND [Discount] < 0.15";
                    break;
                case 3:
                    query += " AND [Discount] >= 0.15 AND [Discount] < 0.3";
                    break;
                case 4:
                    query += " AND [Discount] >= 0.3 AND [Discount] < 0.7";
                    break;
                case 5:
                    query += " AND [Discount] >= 0.7 AND [Discount] < 1";
                    break;
            }
            if (comboBox1.SelectedIndex == 1)
                query += " ORDER BY [Cost] ASC";
            if (comboBox1.SelectedIndex == 2)
                query += " ORDER BY [Cost] DESC";
            using (SqlConnection connection = new SqlConnection(GetConnect))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                da.Fill(Services);
                if (Services.Rows.Count < 1)
                {
                    stop = true;
                    MessageBox.Show("Услуг нет!");
                }
                else
                {
                    stop = false;
                }
            }
            if (!ServicesCount.HasValue)
                ServicesCount = Services.Rows.Count;
            label4.Text = Services.Rows.Count + " из " + ServicesCount;
        }

        public void outputServices()
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            if (!stop)
            {
                prepareShowData();
                groupBox1.BackColor = discount != 0 ? Color.Honeydew : Color.White;
                showName1.Text = title;
                showPriceDuration1.Text = discount != 0 ? "(" + (price) + ") " + discountedPrice : price + "";
                showPriceDuration1.Text += " рублей за " + minutes + " минут";
                showDiscount1.Text = discountText;
                pictureBox1.ImageLocation = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName +
                                            @"\" + Services.Rows[idNextService]["MainImagePath"];
                showID1 = Services.Rows[idNextService]["ID"].ToString();
            }
            else
            {
                groupBox1.BackColor = Color.White;
                showName1.Text = "";
                showPriceDuration1.Text = "";
                showDiscount1.Text = "";
                pictureBox1.ImageLocation = "";
                button1.Visible = false;
                button2.Visible = false;
                button11.Visible = false;
            }
            idNextService++;
            if (idNextService < Services.Rows.Count && !stop)
            {
                prepareShowData();
                groupBox2.BackColor = discount != 0 ? Color.Honeydew : Color.White;
                showName2.Text = title;
                showPriceDuration2.Text = discount != 0 ? "(" + (price) + ") " + discountedPrice : price + "";
                showPriceDuration2.Text += " рублей за " + minutes + " минут";
                showDiscount2.Text = discountText;
                pictureBox2.ImageLocation = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName +
                                            @"\" + Services.Rows[idNextService]["MainImagePath"];
                showID2 = Services.Rows[idNextService]["ID"].ToString();
            }
            else
            {
                groupBox2.BackColor = Color.White;
                showName2.Text = "";
                showPriceDuration2.Text = "";
                showDiscount2.Text = "";
                pictureBox2.ImageLocation = "";
                button3.Visible = false;
                button4.Visible = false;
                button12.Visible = false;
            }
            idNextService++;
            if (idNextService < Services.Rows.Count && !stop)
            {
                prepareShowData();
                groupBox3.BackColor = discount != 0 ? Color.Honeydew : Color.White;
                showName3.Text = title;
                showPriceDuration3.Text = discount != 0 ? "(" + (price) + ") " + discountedPrice : price + "";
                showPriceDuration3.Text += " рублей за " + minutes + " минут";
                showDiscount3.Text = discountText;
                pictureBox3.ImageLocation = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName +
                                            @"\" + Services.Rows[idNextService]["MainImagePath"];
                showID3 = Services.Rows[idNextService]["ID"].ToString();
            }
            else
            {
                groupBox3.BackColor = Color.White;
                showName3.Text = "";
                showPriceDuration3.Text = "";
                showDiscount3.Text = "";
                pictureBox3.ImageLocation = "";
                button5.Visible = false;
                button6.Visible = false;
                button13.Visible = false;
            }
            idNextService++;
            if (idNextService >= Services.Rows.Count)
                button7.Enabled = false;
        }

        public void prepareShowData()
        {
            title = Services.Rows[idNextService]["Title"].ToString();
            discount = 0;
            discountText = "";
            price = Math.Round(Convert.ToDouble(Services.Rows[idNextService]["Cost"].ToString()));
            if (Services.Rows[idNextService]["Discount"].ToString() != "")
            {
                discount = Convert.ToDouble(Services.Rows[idNextService]["Discount"].ToString());
                discountedPrice = Math.Round((price - (price * discount)), 2);
                discount = Math.Round(discount * 100);
                discountText = "* скидка " + discount + "%";
            }
            minutes = Convert.ToInt32(Services.Rows[idNextService]["DurationInSeconds"].ToString()) / 60;
        }
    }
}
