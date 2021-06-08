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
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();

            //long.Parse(textBox1.Text), textBox2.Text

            try
            {
                SqlDataReader reader = ServerPart.ServerCalls.userOrders(long.Parse(textBox1.Text), textBox2.Text);

                listViewOrders.Items.Clear();



                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    DateTime date = reader.GetDateTime(1);
                    string place_start = reader.GetString(2);
                    string place_finish = reader.GetString(3);
                    string description = reader.GetString(4);
                    double weight = reader.GetDouble(5);
                    double volume = reader.GetDouble(6);
                    int amount = reader.GetInt32(7);

                    ListViewItem item = new ListViewItem(new string[] {
                        Convert.ToString(id),
                        Convert.ToString(date),
                        Convert.ToString(place_start),
                        Convert.ToString(place_finish),
                        Convert.ToString(description),
                        Convert.ToString(weight),
                        Convert.ToString(volume),
                        Convert.ToString(amount)
                     });

                    listViewOrders.Items.Add(item);
                }

                listViewOrders.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listViewOrders.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch
            {
                MessageBox.Show("Ошибка. Нет заявок и грузов");
            }



            //Cargo_Add cargo_Add = new Cargo_Add();
            //cargo_Add.TXT1 = this.textBox1.Text;
        }

        public string TextBox1
        {
            set { textBox1.Text = value; }
        }

        public string TextBox2
        {
            set { textBox2.Text = value; }
        }

        //public string TextBox2
        //{
        //    get { return textBox2.Text; }
        //}

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void добавитьЗаявкуНаПеревозкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cargo_Add cargo_Add = new Cargo_Add();
            cargo_Add.Show();
            cargo_Add.TXT1 = this.textBox1.Text;
        }

        private void накладныеНаЗаказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nakladnay nakladnay = new Nakladnay();
            nakladnay.Show();
            nakladnay.TXTBox1 = this.textBox1.Text;
        }

        private void неоплаченныеЗаказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NakladnayNull nakladnayNull = new NakladnayNull();
            nakladnayNull.Show();
            nakladnayNull.TXTBox1 = this.textBox1.Text;
        }

        private void информацияПоЗаполнениюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.Show();
        }
    }
}
