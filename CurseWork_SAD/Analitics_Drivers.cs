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

namespace CurseWork_SAD
{
    public partial class Analitics_Drivers : Form
    {
        public Analitics_Drivers()
        {
            InitializeComponent();

            SqlDataReader reader = ServerPart.ServerCalls.countSum();

            listView1.Items.Clear();

            while (reader.Read())
            {
                string surname = reader.GetString(0);
                string name = reader.GetString(1);
                long phone = reader.GetInt64(2);
                string mark = reader.GetString(3);
                string model = reader.GetString(4);
                double sum = reader.GetDouble(5);

                ListViewItem item = new ListViewItem(new string[] {
                        Convert.ToString(surname),
                        Convert.ToString(name),
                        Convert.ToString(phone),
                        Convert.ToString(mark),
                        Convert.ToString(model),
                        Convert.ToString(sum)
                     });

                listView1.Items.Add(item);
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
