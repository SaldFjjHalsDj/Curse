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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();

            SqlDataReader reader = ServerPart.ServerCalls.showDriver();

            listView1.Items.Clear();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string surname = reader.GetString(1);
                string name = reader.GetString(2);
                string lastname = reader.GetString(3);
                long phone = reader.GetInt64(4);
                long number = reader.GetInt64(5);
                long strah = reader.GetInt64(6);
                int id_staj = reader.GetInt32(7);

                ListViewItem item = new ListViewItem(new string[] {
                        Convert.ToString(id),
                        Convert.ToString(surname),
                        Convert.ToString(name),
                        Convert.ToString(lastname),
                        Convert.ToString(phone),
                        Convert.ToString(number),
                        Convert.ToString(strah),
                        Convert.ToString(id_staj)
                     });

                listView1.Items.Add(item);
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            reader = ServerPart.ServerCalls.showAuto();

            listView2.Items.Clear();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string mark = reader.GetString(1);
                string model = reader.GetString(2);
                string number = reader.GetString(3);
                double weight = reader.GetDouble(4);
                double volume = reader.GetDouble(5);
                DateTime date = reader.GetDateTime(6);
                string special = reader.GetString(7);

                ListViewItem item = new ListViewItem(new string[] {
                        Convert.ToString(id),
                        Convert.ToString(mark),
                        Convert.ToString(model),
                        Convert.ToString(number),
                        Convert.ToString(weight),
                        Convert.ToString(volume),
                        Convert.ToString(date),
                        Convert.ToString(special)
                     });

                listView2.Items.Add(item);
            }

            listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            reader = ServerPart.ServerCalls.showShtat();

            listView3.Items.Clear();

            while (reader.Read())
            {
                string id = reader.GetString(0);
                int pair = reader.GetInt32(1);
                long number = reader.GetInt64(2);
                long strah = reader.GetInt64(3);
                int id_auto = reader.GetInt32(4);
                string autonumber = reader.GetString(5);
                string status = reader.GetString(6);

                ListViewItem item = new ListViewItem(new string[] {
                        Convert.ToString(id),
                        Convert.ToString(pair),
                        Convert.ToString(number),
                        Convert.ToString(strah),
                        Convert.ToString(id_auto),
                        Convert.ToString(autonumber),
                        Convert.ToString(status)
                     });

                listView3.Items.Add(item);
            }

            listView3.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView3.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);



            TextBoxWatermarkExtensionMethod.SetWatermark(textBox1, "Введите номер распределения");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox2, "Введите номер автомобиля");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox3, "Введите номер водителя");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox4, "Введите номера автомобиля");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox5, "Введите номер прав");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox6, "Введите статус");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox7, "Введите номер страховки");

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();   
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void добавитьАвтомобильToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Auto_Add auto_Add = new Auto_Add();
            auto_Add.Show();
        }

        private void добавитьВодителяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Driver_Add driver_Add = new Driver_Add();
            driver_Add.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ServerPart.ServerCalls.shtatAdd(textBox1.Text, int.Parse(textBox3.Text), long.Parse(textBox5.Text), long.Parse(textBox7.Text), int.Parse(textBox2.Text), textBox4.Text, textBox6.Text ));
        }

        private void заработокВодителейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Analitics_Drivers analitics = new Analitics_Drivers();
            analitics.Show();
        }

        private void анализГрузовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnaliticsCargo analiticsCargo = new AnaliticsCargo();
            analiticsCargo.Show();
        }
    }
}
