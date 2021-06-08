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
    public partial class Cargo_Add : Form
    {
        public Cargo_Add()
        {
            InitializeComponent();

            string[] mas = { "1. Мебель", "2. Продукты питания", "3. Бытовая техника", "4. Медецинские изделия", "5. Электротовары", "6. Музыкальные инструменты", "7. Другие товары" };
            comboBox1.Items.AddRange(mas);
            comboBox1.SelectedItem = "1. Мебель";

            textBox1.Text = comboBox1.Text[0].ToString();

            TextBoxWatermarkExtensionMethod.SetWatermark(textBox2, "Введите примерный вес");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox3, "Введите примерный объем");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox4, "Введите количество");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox5, "Введите краткое описание");

            //TextBoxWatermarkExtensionMethod.SetWatermark(textBox6, "Телефон");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox7, "Введите дату отправления");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox8, "Введите место отправления");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox9, "Введите место прибытия");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox10, "Введите примерное расстояние");
        }

        public string TXT1
        {
            get { return textBox6.Text; }
            set { textBox6.Text = value; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ServerPart.ServerCalls.createDelivery(int.Parse(comboBox1.Text[0].ToString()), float.Parse(textBox2.Text), float.Parse(textBox3.Text), int.Parse(textBox4.Text), textBox5.Text, long.Parse(textBox6.Text), textBox7.Text, textBox8.Text, textBox9.Text, float.Parse(textBox10.Text)));
            //try
            //{
            //    //long.Parse(textBox1.Text), textBox2.Text)
            //    //MessageBox.Show(ServerPart.ServerCalls.createDelivery(int.Parse(comboBox1.Text[0].ToString()), float.Parse(textBox2.Text), float.Parse(textBox3.Text), int.Parse(textBox4.Text), textBox5.Text, long.Parse(textBox6.Text), textBox7.Text, textBox8.Text, textBox9.Text, float.Parse(textBox10.Text)));
            //    //ClientForm clientForm = new ClientForm();
            //    //Hide();
            //    //clientForm.Show();
            //    ClientForm clientForm = new ClientForm();
            //    clientForm.Update();
            //    this.Close();
            //    //clientForm.TextBox1 = this.textBox1.Text;
            //    //clientForm.TextBox2 = this.textBox2.Text;
            //}
            //catch
            //{
            //    MessageBox.Show("Ошибка ввода данных. Проверьте введеные данные.");
            //}
        }
    }
}
