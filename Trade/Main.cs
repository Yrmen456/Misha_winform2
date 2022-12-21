using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trade
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        //Кнопки
        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.authorization.Show();
        }
    }
}
