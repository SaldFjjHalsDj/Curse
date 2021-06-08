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
    public partial class NakladnayNull : Form
    {
        public NakladnayNull()
        {

            InitializeComponent();
            try
            {
                Autorisation autorisation = new Autorisation();

                SqlDataReader reader = ServerPart.ServerCalls.showDeliveryNull(long.Parse(textBox1.Text));

                listView1.Items.Clear();

                while (reader.Read())
                {
                    int id1 = reader.GetInt32(0);
                    int id2 = reader.GetInt32(1);
                    double sum = reader.GetDouble(2);


                    ListViewItem item = new ListViewItem(new string[] {
                        Convert.ToString(id1),
                        Convert.ToString(id2),
                        Convert.ToString(sum)
                     });

                    listView1.Items.Add(item);
                }

                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch
            {
                MessageBox.Show("Ошибка. Нет накладных");
            }



        }

        public string TXTBox1
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
