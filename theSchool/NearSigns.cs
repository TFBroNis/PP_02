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

namespace theSchool
{
    public partial class NearSigns : Form
    {
        public string GetConnect = @"Data Source=BRONISLAV-PC\SQLEXPRESS02;Initial Catalog=theSchool;Integrated Security=True";
        public NearSigns()
        {
            InitializeComponent();
        }

        public void NearSigns_Load(object sender, EventArgs e)
        {
            refreshSigns();
        }

        public void refreshSigns()
        {
            string query = "SELECT DISTINCT [Service],concat([Client], ' ', [FirstName], ' ', [MiddleName]) AS [Client],[Email],[Phone],[StartTime],CONCAT(DATEDIFF(HOUR, GETDATE(), [StartTime]), ' ч. ', DateDiff(minute, DateAdd(hour, DateDiff(hour, GETDATE(),[StartTime]),GETDATE()), [StartTime]), ' мин.') AS TimeRemaining FROM [ClientService],[Client] WHERE [Client] = [LastName] AND (CAST([StartTime] as DATE) = CAST(GETDATE() as DATE) OR CAST([StartTime] as DATE) = CAST(dateadd(day,-1,GETDATE()) as DATE)) ORDER BY [StartTime] ASC";
            using (SqlConnection connection = new SqlConnection(GetConnect))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells["TimeRemaining"].Value?.ToString()[0] == '0')
                    dataGridView1.Rows[i].Cells["TimeRemaining"].Style.BackColor = Color.LightCoral;
            }
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            refreshSigns();
        }
    }
}
