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
    public partial class SelectType : Form
    {
        public SelectType()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Autorisation aut = new Autorisation();
            aut.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            RegNewUserLaw reg = new RegNewUserLaw();
            reg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            RegNewUserPhys reg = new RegNewUserPhys();
            reg.Show();
        }
    }
}
