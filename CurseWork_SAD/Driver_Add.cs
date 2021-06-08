using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurseWork_SAD
{
    public partial class Driver_Add : Form
    {
        public Driver_Add()
        {
            InitializeComponent();

            TextBoxWatermarkExtensionMethod.SetWatermark(textBox1, "Введите марку автомобиля");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox2, "Введите модель автомобиля");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox3, "Введите номера автомобиля");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox4, "Введите грузоподъемность");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox5, "Введите объем кузова");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox6, "Введите дату техосмотра");

            string[] mas = { "1. Менее 1 года", "2. От 1 года до 2 лет", "3. От 2 лет до 3 лет", "4. От 3 лет до 5 лет", "5. Более 5 лет" };
            comboBox1.Items.AddRange(mas);
            comboBox1.SelectedItem = "1. Менее 1 года";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ServerPart.ServerCalls.driverAdd(textBox1.Text, textBox2.Text, textBox3.Text, long.Parse(textBox4.Text), long.Parse(textBox5.Text), long.Parse(textBox6.Text), int.Parse(comboBox1.Text[0].ToString())));
        }
    }
}
