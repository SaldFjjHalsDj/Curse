using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurseWork_SAD
{


    public partial class RegNewUserLaw : Form
    {
        public RegNewUserLaw()
        {
            InitializeComponent();

            TextBoxWatermarkExtensionMethod.SetWatermark(textBox1, "Фамилия");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox2, "Имя");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox3, "Отчество");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox4, "Адрес");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox5, "Телефон");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox6, "ИНН");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox7, "Название огранизации");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox8, "Пароль");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            SelectType sel = new SelectType();
            sel.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(ServerPart.ServerCalls.newLawUser(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, long.Parse(textBox5.Text), long.Parse(textBox6.Text), textBox7.Text, textBox8.Text));
            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных.");
            }

            this.Close();
            Autorisation aut = new Autorisation();
            aut.Show();

        }

    }
}
