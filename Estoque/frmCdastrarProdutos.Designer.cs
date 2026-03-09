namespace Estoque
{
    partial class frmCdastrarProdutos
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
            dataGridView1 = new DataGridView();
            txtCodigo = new TextBox();
            txtSecao = new TextBox();
            txtSenha = new TextBox();
            lobCodigoItem = new Label();
            lblSecao = new Label();
            lblSenha = new Label();
            boxItens = new GroupBox();
            btnAprovar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            boxID = new GroupBox();
            checkAlterarDB = new CheckBox();
            checkSalvar = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            boxItens.SuspendLayout();
            boxID.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(435, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(340, 414);
            dataGridView1.TabIndex = 98;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(6, 46);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(335, 23);
            txtCodigo.TabIndex = 0;
            // 
            // txtSecao
            // 
            txtSecao.Location = new Point(6, 132);
            txtSecao.Name = "txtSecao";
            txtSecao.Size = new Size(335, 23);
            txtSecao.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(6, 219);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(335, 23);
            txtSenha.TabIndex = 2;
            // 
            // lobCodigoItem
            // 
            lobCodigoItem.AutoSize = true;
            lobCodigoItem.Location = new Point(6, 28);
            lobCodigoItem.Name = "lobCodigoItem";
            lobCodigoItem.Size = new Size(90, 15);
            lobCodigoItem.TabIndex = 99;
            lobCodigoItem.Text = "Código do item";
            // 
            // lblSecao
            // 
            lblSecao.AutoSize = true;
            lblSecao.Location = new Point(6, 114);
            lblSecao.Name = "lblSecao";
            lblSecao.Size = new Size(82, 15);
            lblSecao.TabIndex = 97;
            lblSecao.Text = "Seção do item";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(6, 201);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(83, 15);
            lblSenha.TabIndex = 96;
            lblSenha.Text = "Senha do item";
            // 
            // boxItens
            // 
            boxItens.Controls.Add(lobCodigoItem);
            boxItens.Controls.Add(lblSenha);
            boxItens.Controls.Add(txtCodigo);
            boxItens.Controls.Add(lblSecao);
            boxItens.Controls.Add(txtSecao);
            boxItens.Controls.Add(txtSenha);
            boxItens.Location = new Point(12, 24);
            boxItens.Name = "boxItens";
            boxItens.Size = new Size(347, 256);
            boxItens.TabIndex = 8;
            boxItens.TabStop = false;
            boxItens.Text = "Itens";
            // 
            // btnAprovar
            // 
            btnAprovar.BackColor = Color.Transparent;
            btnAprovar.BackgroundImage = Properties.Resources.btnSalvar;
            btnAprovar.BackgroundImageLayout = ImageLayout.Stretch;
            btnAprovar.Location = new Point(12, 295);
            btnAprovar.Name = "btnAprovar";
            btnAprovar.Size = new Size(111, 88);
            btnAprovar.TabIndex = 3;
            btnAprovar.UseVisualStyleBackColor = false;
            btnAprovar.Click += btnAprovar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Transparent;
            btnEditar.BackgroundImage = Properties.Resources.btnExcluir;
            btnEditar.BackgroundImageLayout = ImageLayout.Zoom;
            btnEditar.Location = new Point(129, 295);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(112, 88);
            btnEditar.TabIndex = 4;
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Transparent;
            btnExcluir.BackgroundImage = Properties.Resources.btnEditar;
            btnExcluir.BackgroundImageLayout = ImageLayout.Zoom;
            btnExcluir.Location = new Point(247, 295);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(112, 88);
            btnExcluir.TabIndex = 5;
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // boxID
            // 
            boxID.Controls.Add(checkAlterarDB);
            boxID.Controls.Add(checkSalvar);
            boxID.Location = new Point(12, 389);
            boxID.Name = "boxID";
            boxID.Size = new Size(341, 79);
            boxID.TabIndex = 12;
            boxID.TabStop = false;
            boxID.Text = "ID";
            // 
            // checkAlterarDB
            // 
            checkAlterarDB.AutoSize = true;
            checkAlterarDB.Location = new Point(213, 30);
            checkAlterarDB.Name = "checkAlterarDB";
            checkAlterarDB.Size = new Size(96, 19);
            checkAlterarDB.TabIndex = 1;
            checkAlterarDB.Text = "Alterar no DB";
            checkAlterarDB.UseVisualStyleBackColor = true;
            // 
            // checkSalvar
            // 
            checkSalvar.AutoSize = true;
            checkSalvar.Location = new Point(6, 30);
            checkSalvar.Name = "checkSalvar";
            checkSalvar.Size = new Size(57, 19);
            checkSalvar.TabIndex = 0;
            checkSalvar.Text = "Salvar";
            checkSalvar.UseVisualStyleBackColor = true;
            // 
            // frmCdastrarProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 480);
            Controls.Add(boxID);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnAprovar);
            Controls.Add(boxItens);
            Controls.Add(dataGridView1);
            Name = "frmCdastrarProdutos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCdastrarProdutos";
            Load += frmCdastrarProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            boxItens.ResumeLayout(false);
            boxItens.PerformLayout();
            boxID.ResumeLayout(false);
            boxID.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtCodigo;
        private TextBox txtSecao;
        private TextBox txtSenha;
        private Label lobCodigoItem;
        private Label lblSecao;
        private Label lblSenha;
        private GroupBox boxItens;
        private Button btnAprovar;
        private Button btnEditar;
        private Button btnExcluir;
        private GroupBox boxID;
        private CheckBox checkSalvar;
        private CheckBox checkAlterarDB;
    }
}