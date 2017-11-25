namespace Empresa.UI.Windows
{
    partial class ClienteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.novoButton = new System.Windows.Forms.Button();
            this.alterarButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.sairButton = new System.Windows.Forms.Button();
            this.incluirButton = new System.Windows.Forms.Button();
            this.confirmarAlterarButton = new System.Windows.Forms.Button();
            this.confirmarExcluirButton = new System.Windows.Forms.Button();
            this.voltarButton = new System.Windows.Forms.Button();
            this.listagemPanel = new System.Windows.Forms.Panel();
            this.clienteDataGridView = new System.Windows.Forms.DataGridView();
            this.fichaPanel = new System.Windows.Forms.Panel();
            this.CpfTextBox = new System.Windows.Forms.TextBox();
            this.cpfLabel = new System.Windows.Forms.Label();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.telefoneLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idlabel = new System.Windows.Forms.Label();
            this.mensagemExcluirLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.listagemPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).BeginInit();
            this.fichaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.novoButton);
            this.flowLayoutPanel1.Controls.Add(this.alterarButton);
            this.flowLayoutPanel1.Controls.Add(this.excluirButton);
            this.flowLayoutPanel1.Controls.Add(this.sairButton);
            this.flowLayoutPanel1.Controls.Add(this.incluirButton);
            this.flowLayoutPanel1.Controls.Add(this.confirmarAlterarButton);
            this.flowLayoutPanel1.Controls.Add(this.confirmarExcluirButton);
            this.flowLayoutPanel1.Controls.Add(this.voltarButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 285);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(759, 46);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // novoButton
            // 
            this.novoButton.Location = new System.Drawing.Point(8, 8);
            this.novoButton.Name = "novoButton";
            this.novoButton.Size = new System.Drawing.Size(75, 23);
            this.novoButton.TabIndex = 0;
            this.novoButton.Text = "Novo";
            this.novoButton.UseVisualStyleBackColor = true;
            this.novoButton.Click += new System.EventHandler(this.novoButton_Click);
            // 
            // alterarButton
            // 
            this.alterarButton.Location = new System.Drawing.Point(89, 8);
            this.alterarButton.Name = "alterarButton";
            this.alterarButton.Size = new System.Drawing.Size(75, 23);
            this.alterarButton.TabIndex = 1;
            this.alterarButton.Text = "Alterar";
            this.alterarButton.UseVisualStyleBackColor = true;
            this.alterarButton.Click += new System.EventHandler(this.alterarButton_Click);
            // 
            // excluirButton
            // 
            this.excluirButton.Location = new System.Drawing.Point(170, 8);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(75, 23);
            this.excluirButton.TabIndex = 2;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Click += new System.EventHandler(this.excluirButton_Click);
            // 
            // sairButton
            // 
            this.sairButton.Location = new System.Drawing.Point(251, 8);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(75, 23);
            this.sairButton.TabIndex = 3;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // incluirButton
            // 
            this.incluirButton.Location = new System.Drawing.Point(332, 8);
            this.incluirButton.Name = "incluirButton";
            this.incluirButton.Size = new System.Drawing.Size(75, 23);
            this.incluirButton.TabIndex = 4;
            this.incluirButton.Text = "Incluir";
            this.incluirButton.UseVisualStyleBackColor = true;
            this.incluirButton.Visible = false;
            this.incluirButton.Click += new System.EventHandler(this.incluirButton_Click);
            // 
            // confirmarAlterarButton
            // 
            this.confirmarAlterarButton.Location = new System.Drawing.Point(413, 8);
            this.confirmarAlterarButton.Name = "confirmarAlterarButton";
            this.confirmarAlterarButton.Size = new System.Drawing.Size(75, 23);
            this.confirmarAlterarButton.TabIndex = 5;
            this.confirmarAlterarButton.Text = "Alterar";
            this.confirmarAlterarButton.UseVisualStyleBackColor = true;
            this.confirmarAlterarButton.Visible = false;
            this.confirmarAlterarButton.Click += new System.EventHandler(this.confirmarAlterarButton_Click);
            // 
            // confirmarExcluirButton
            // 
            this.confirmarExcluirButton.Location = new System.Drawing.Point(494, 8);
            this.confirmarExcluirButton.Name = "confirmarExcluirButton";
            this.confirmarExcluirButton.Size = new System.Drawing.Size(75, 23);
            this.confirmarExcluirButton.TabIndex = 6;
            this.confirmarExcluirButton.Text = "Excluir";
            this.confirmarExcluirButton.UseVisualStyleBackColor = true;
            this.confirmarExcluirButton.Visible = false;
            this.confirmarExcluirButton.Click += new System.EventHandler(this.confirmarExcluirButton_Click);
            // 
            // voltarButton
            // 
            this.voltarButton.Location = new System.Drawing.Point(575, 8);
            this.voltarButton.Name = "voltarButton";
            this.voltarButton.Size = new System.Drawing.Size(75, 23);
            this.voltarButton.TabIndex = 7;
            this.voltarButton.Text = "Voltar";
            this.voltarButton.UseVisualStyleBackColor = true;
            this.voltarButton.Visible = false;
            this.voltarButton.Click += new System.EventHandler(this.voltarButton_Click);
            // 
            // listagemPanel
            // 
            this.listagemPanel.Controls.Add(this.clienteDataGridView);
            this.listagemPanel.Location = new System.Drawing.Point(12, 23);
            this.listagemPanel.Name = "listagemPanel";
            this.listagemPanel.Padding = new System.Windows.Forms.Padding(10);
            this.listagemPanel.Size = new System.Drawing.Size(273, 256);
            this.listagemPanel.TabIndex = 1;
            // 
            // clienteDataGridView
            // 
            this.clienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clienteDataGridView.Location = new System.Drawing.Point(10, 10);
            this.clienteDataGridView.Name = "clienteDataGridView";
            this.clienteDataGridView.Size = new System.Drawing.Size(253, 236);
            this.clienteDataGridView.TabIndex = 0;
            // 
            // fichaPanel
            // 
            this.fichaPanel.Controls.Add(this.mensagemExcluirLabel);
            this.fichaPanel.Controls.Add(this.CpfTextBox);
            this.fichaPanel.Controls.Add(this.cpfLabel);
            this.fichaPanel.Controls.Add(this.telefoneTextBox);
            this.fichaPanel.Controls.Add(this.telefoneLabel);
            this.fichaPanel.Controls.Add(this.emailTextBox);
            this.fichaPanel.Controls.Add(this.emailLabel);
            this.fichaPanel.Controls.Add(this.nomeTextBox);
            this.fichaPanel.Controls.Add(this.nomeLabel);
            this.fichaPanel.Controls.Add(this.idTextBox);
            this.fichaPanel.Controls.Add(this.idlabel);
            this.fichaPanel.Location = new System.Drawing.Point(347, 12);
            this.fichaPanel.Name = "fichaPanel";
            this.fichaPanel.Size = new System.Drawing.Size(375, 257);
            this.fichaPanel.TabIndex = 2;
            this.fichaPanel.Visible = false;
            // 
            // CpfTextBox
            // 
            this.CpfTextBox.Location = new System.Drawing.Point(78, 174);
            this.CpfTextBox.Name = "CpfTextBox";
            this.CpfTextBox.Size = new System.Drawing.Size(118, 20);
            this.CpfTextBox.TabIndex = 9;
            // 
            // cpfLabel
            // 
            this.cpfLabel.AutoSize = true;
            this.cpfLabel.Location = new System.Drawing.Point(20, 177);
            this.cpfLabel.Name = "cpfLabel";
            this.cpfLabel.Size = new System.Drawing.Size(30, 13);
            this.cpfLabel.TabIndex = 8;
            this.cpfLabel.Text = "CPF:";
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.Location = new System.Drawing.Point(78, 139);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(118, 20);
            this.telefoneTextBox.TabIndex = 7;
            // 
            // telefoneLabel
            // 
            this.telefoneLabel.AutoSize = true;
            this.telefoneLabel.Location = new System.Drawing.Point(20, 142);
            this.telefoneLabel.Name = "telefoneLabel";
            this.telefoneLabel.Size = new System.Drawing.Size(52, 13);
            this.telefoneLabel.TabIndex = 6;
            this.telefoneLabel.Text = "Telefone:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(78, 103);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(194, 20);
            this.emailTextBox.TabIndex = 5;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(20, 106);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "Email:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(78, 68);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(194, 20);
            this.nomeTextBox.TabIndex = 3;
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(20, 71);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(38, 13);
            this.nomeLabel.TabIndex = 2;
            this.nomeLabel.Text = "Nome:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(78, 35);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(222, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Location = new System.Drawing.Point(20, 35);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(18, 13);
            this.idlabel.TabIndex = 0;
            this.idlabel.Text = "ID";
            // 
            // mensagemExcluirLabel
            // 
            this.mensagemExcluirLabel.AutoSize = true;
            this.mensagemExcluirLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensagemExcluirLabel.ForeColor = System.Drawing.Color.Red;
            this.mensagemExcluirLabel.Location = new System.Drawing.Point(20, 226);
            this.mensagemExcluirLabel.Name = "mensagemExcluirLabel";
            this.mensagemExcluirLabel.Size = new System.Drawing.Size(209, 13);
            this.mensagemExcluirLabel.TabIndex = 10;
            this.mensagemExcluirLabel.Text = "Confirma a exclusão deste registro?";
            this.mensagemExcluirLabel.Visible = false;
            // 
            // ClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 331);
            this.Controls.Add(this.fichaPanel);
            this.Controls.Add(this.listagemPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(340, 358);
            this.Name = "ClienteForm";
            this.Text = "ClienteForm";
            this.Load += new System.EventHandler(this.ClienteForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.listagemPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).EndInit();
            this.fichaPanel.ResumeLayout(false);
            this.fichaPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button novoButton;
        private System.Windows.Forms.Button alterarButton;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button sairButton;
        private System.Windows.Forms.Button incluirButton;
        private System.Windows.Forms.Button confirmarAlterarButton;
        private System.Windows.Forms.Button confirmarExcluirButton;
        private System.Windows.Forms.Button voltarButton;
        private System.Windows.Forms.Panel listagemPanel;
        private System.Windows.Forms.DataGridView clienteDataGridView;
        private System.Windows.Forms.Panel fichaPanel;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.Label telefoneLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.TextBox CpfTextBox;
        private System.Windows.Forms.Label cpfLabel;
        private System.Windows.Forms.Label mensagemExcluirLabel;
    }
}