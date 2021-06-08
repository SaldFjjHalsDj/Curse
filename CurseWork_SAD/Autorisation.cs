using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurseWork_SAD
{
    public partial class Autorisation : Form
    {

        public static string myvariable;

        public Autorisation()
        {
            InitializeComponent();

            TextBoxWatermarkExtensionMethod.SetWatermark(textBox1, "Телефон");
            TextBoxWatermarkExtensionMethod.SetWatermark(textBox2, "Пароль");
            //textBox1.Text = "79557689517";
            //textBox2.Text = "LXCu0fpo";

            //textBox1.Text = "00000000000";
            //textBox2.Text = "root";

            //myvariable = textBox1.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            SelectType sel = new SelectType();
            sel.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( textBox1.Text == "00000000000" && textBox2.Text == "root")
            {
                Admin admin = new Admin();
                Hide();
                admin.Show();
            }
            else
            {
                MessageBox.Show(ServerPart.ServerCalls.findUser(long.Parse(textBox1.Text), textBox2.Text));

                ClientForm clientForm = new ClientForm();
                Hide();
                clientForm.Show();
                myvariable = this.textBox1.Text;

                clientForm.TextBox1 = this.textBox1.Text;
                clientForm.TextBox2 = this.textBox2.Text;

                //Nakladnay nakladnay = new Nakladnay();
                //nakladnay.TXTBox1 = this.textBox1.Text;
                ////try
                ////{
                ////    long.Parse(textBox1.Text), textBox2.Text)

                ////}
                ////catch
                ////{
                ////    MessageBox.Show("Ошибка входа. Проверьте введеные данные.");
                ////}
            }
        }
    }



    public static class TextBoxWatermarkExtensionMethod
    {
        private const uint ECM_FIRST = 0x1500;
        private const uint EM_SETCUEBANNER = ECM_FIRST + 1;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        public static void SetWatermark(this TextBox textBox, string watermarkText)
        {
            SendMessage(textBox.Handle, EM_SETCUEBANNER, 0, watermarkText);
        }

    }
}
