using Empresa.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa.UI.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            WindowsTools.Usuario = "João";
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new ClienteForm();
            f.ShowDialog();
            //f.Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Fabricante("Impacta", "impacta@teste.com.br");
            MessageBox.Show(f.Nome);
            MessageBox.Show(f.Email);

            


        }
    }
}
