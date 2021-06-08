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
    public partial class Auto_Add : Form
    {
        public Auto_Add()
        {
            InitializeComponent();

            TextBoxWatermarkExtensionMethod.SetWatermark(textBox1, "Введите марку автомобиля");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox2, "Введите модель автомобиля");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox3, "Введите номера автомобиля");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox4, "Введите грузоподъемность");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox5, "Введите объем кузова");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox6, "Введите дату техосмотра");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox7, "Введите наличие спец. оборудования");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ServerPart.ServerCalls.autoAdd(textBox1.Text, textBox2.Text, textBox3.Text, float.Parse(textBox4.Text), float.Parse(textBox5.Text), textBox6.Text, textBox7.Text));
        }
    }
}
