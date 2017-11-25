using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Empresa.BLL;
using Empresa.Model;

namespace Empresa.UI.Windows
{
    public partial class ClienteForm : Form
    {
        ClienteBLL bll = null;

        public ClienteForm()
        {
            InitializeComponent();

            this.Text = "Olá, " + WindowsTools.Usuario;
        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {
            bll = new ClienteBLL();

            fichaPanel.Dock = DockStyle.Fill;
            fichaPanel.Visible = false;

            listagemPanel.Dock = DockStyle.Fill;
            listagemPanel.Visible = true;

            //clienteDataGridView.DataSource = bll.Listar();


            clienteDataGridView.DataSource = bll.Listar().OrderBy(m => m.Nome).ToList();

            //var x=bll.Listar().OrderBy(m => m.Nome).ToList();
            //x.RemoveAt(0);


        }


       

      




        private void novoButton_Click(object sender, EventArgs e)
        {

            //MessageBox.Show("Mensagem");
            // MessageBox.Show("Mensagem", "Titulo");
            // MessageBox.Show("Mensagem", "Titulo", MessageBoxButtons.OK);
            // MessageBox.Show("Mensagem", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //string nome = "Jose";
            //string letra = nome.PrimeiraLetra();
            //int valor = 20.Dobro();
            


            novoButton.Visible = false;
            alterarButton.Visible = false;
            excluirButton.Visible = false;
            sairButton.Visible = false;
            incluirButton.Visible = true;
            voltarButton.Visible = true;

            listagemPanel.Visible = false;
            fichaPanel.Visible = true;
            LimparFicha();

            idTextBox.Text = Guid.NewGuid().ToString();
            idTextBox.Enabled = false;
            
        }

        private void LimparFicha()
        {
            foreach (Control c in fichaPanel.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = string.Empty;
                }
            }
        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            novoButton.Visible = true;
            alterarButton.Visible = true;
            excluirButton.Visible = true;
            sairButton.Visible = true;
            incluirButton.Visible = false;
            voltarButton.Visible = false;
            confirmarAlterarButton.Visible = false;
            confirmarExcluirButton.Visible = false;

            listagemPanel.Visible = true;
            fichaPanel.Visible = false;

            mensagemExcluirLabel.Visible = false;
        }

       
        

       
        private void alterarButton_Click(object sender, EventArgs e)
        {
            //clienteDataGridView.Rows[0].DataBoundItem
            var linha = clienteDataGridView.CurrentRow;
            var clienteGrid = (Cliente)linha.DataBoundItem;

            var cliente = bll.ObterPorId(clienteGrid.Id);

            idTextBox.Text = cliente.Id;
            nomeTextBox.Text = cliente.Nome;
            telefoneTextBox.Text = cliente.Telefone;
            emailTextBox.Text = cliente.Email;
            CpfTextBox.Text = cliente.CPF;

            fichaPanel.Visible = true;
            listagemPanel.Visible = false;

            novoButton.Visible = false;
            alterarButton.Visible = false;
            excluirButton.Visible = false;
            sairButton.Visible = false;
            confirmarAlterarButton.Visible = true;
            voltarButton.Visible = true;
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            //clienteDataGridView.Rows[0].DataBoundItem
            var linha = clienteDataGridView.CurrentRow;
            var clienteGrid = (Cliente)linha.DataBoundItem;

            var cliente = bll.ObterPorId(clienteGrid.Id);

            idTextBox.Text = cliente.Id;
            nomeTextBox.Text = cliente.Nome;
            telefoneTextBox.Text = cliente.Telefone;
            emailTextBox.Text = cliente.Email;
            CpfTextBox.Text = cliente.CPF;

            fichaPanel.Visible = true;
            listagemPanel.Visible = false;

            novoButton.Visible = false;
            alterarButton.Visible = false;
            excluirButton.Visible = false;
            sairButton.Visible = false;
            confirmarExcluirButton.Visible = true;
            voltarButton.Visible = true;

            //fichaPanel.Enabled = false;
            mensagemExcluirLabel.Visible = true;


          
        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void incluirButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (!emailTextBox.Text.EmailValido())
                {
                    MessageBox.Show("Email inválido");
                    return;
                }


                var cliente = new Cliente(idTextBox.Text, nomeTextBox.Text);

                //cliente.Id = idTextBox.Text;
                //cliente.Nome = nomeTextBox.Text;

                cliente.Email = emailTextBox.Text;
                cliente.CPF = CpfTextBox.Text;
                cliente.Telefone = telefoneTextBox.Text;

                if (!cliente.Valido())
                {
                    MessageBox.Show("Cliente inválido");
                }


                bll.Incluir(cliente);
                clienteDataGridView.DataSource = null;
                clienteDataGridView.DataSource = bll.Listar();
                voltarButton.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }

        private void confirmarAlterarButton_Click(object sender, EventArgs e)
        {
            try
            {
                var cliente = new Cliente(idTextBox.Text, nomeTextBox.Text);
                
                cliente.Email = emailTextBox.Text;
                cliente.CPF = CpfTextBox.Text;
                cliente.Telefone = telefoneTextBox.Text;

                bll.Alterar(cliente);
                clienteDataGridView.DataSource = null;
                clienteDataGridView.DataSource = bll.Listar();
                voltarButton.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }

        }

        private void confirmarExcluirButton_Click(object sender, EventArgs e)
        {
            try
            {
                bll.Excluir(idTextBox.Text);
                clienteDataGridView.DataSource = null;
                clienteDataGridView.DataSource = bll.Listar();
                voltarButton.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }

        }
    }
}
