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
    public partial class pradinis_langas : Form
    {
        public pradinis_langas()
        {
            InitializeComponent();
        }

        /*
        * Prisijungimo mygtukas
        * 
        */
        private void prisijungimas_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Prisijungimo_langas login_langas = new Prisijungimo_langas();
            login_langas.ShowDialog();

        }

        /*
         * Registracijos mygtukas
         * 
        */
        private void registracija_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registracijos_langas registracijos_langas = new Registracijos_langas();
            registracijos_langas.ShowDialog();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(0);
            Application.Exit();
        }
    }
}
