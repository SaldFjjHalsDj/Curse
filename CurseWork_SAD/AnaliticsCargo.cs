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
    public partial class AnaliticsCargo : Form
    {
        public AnaliticsCargo()
        {
            InitializeComponent();

            SqlDataReader reader = ServerPart.ServerCalls.cargoDel();
            while(reader.Read())
            {
                string type = reader.GetString(0);
                int amount = reader.GetInt32(1);

                chart1.Series[0].Points.AddXY(type, amount);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
