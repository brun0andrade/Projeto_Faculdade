using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Faculdade
{
    public partial class tela_admin : Form
    {
        public tela_admin()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastrar Form3 = new cadastrar();
            Form3.ShowDialog();
        }
        private void balançoGeralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            balanco_geral Form4 = new balanco_geral();
            Form4.ShowDialog();
        }
    }
}
