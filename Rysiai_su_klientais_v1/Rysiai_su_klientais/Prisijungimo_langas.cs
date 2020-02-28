using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rysiai_su_klientais
{
    public partial class Prisijungimo_langas : Form
    {
        public Prisijungimo_langas()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            this.Hide();
            pradinis_langas p1 = new pradinis_langas();
            p1.ShowDialog();
            this.Close();
        }
    }
}
