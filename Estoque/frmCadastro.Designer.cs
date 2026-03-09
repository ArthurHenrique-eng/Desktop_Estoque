namespace Estoque
{
    partial class frmCadastro
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
            checkBoxLembrarLogin = new CheckBox();
            btnEntrar = new Button();
            boxUsuario = new TextBox();
            txtEsqueciSenha = new LinkLabel();
            boxSenha = new TextBox();
            imagemConfiguracoes = new PictureBox();
            txtSenha = new Label();
            imagemRelatorio = new PictureBox();
            imagemReabastecimento = new PictureBox();
            txtUsuario = new Label();
            imagemInventario = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)imagemConfiguracoes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imagemRelatorio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imagemReabastecimento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imagemInventario).BeginInit();
            SuspendLayout();
            // 
            // checkBoxLembrarLogin
            // 
            checkBoxLembrarLogin.AutoSize = true;
            checkBoxLembrarLogin.BackColor = Color.Transparent;
            checkBoxLembrarLogin.ForeColor = SystemColors.Control;
            checkBoxLembrarLogin.Location = new Point(87, 316);
            checkBoxLembrarLogin.Name = "checkBoxLembrarLogin";
            checkBoxLembrarLogin.Size = new Size(127, 19);
            checkBoxLembrarLogin.TabIndex = 103;
            checkBoxLembrarLogin.Text = "Lembrar meu login";
            checkBoxLembrarLogin.UseVisualStyleBackColor = false;
            // 
            // btnEntrar
            // 
            btnEntrar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEntrar.AutoSize = true;
            btnEntrar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEntrar.BackColor = Color.Blue;
            btnEntrar.ForeColor = SystemColors.Control;
            btnEntrar.Location = new Point(231, 316);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(48, 25);
            btnEntrar.TabIndex = 104;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // boxUsuario
            // 
            boxUsuario.Location = new Point(87, 207);
            boxUsuario.Name = "boxUsuario";
            boxUsuario.Size = new Size(192, 23);
            boxUsuario.TabIndex = 100;
            // 
            // txtEsqueciSenha
            // 
            txtEsqueciSenha.AutoSize = true;
            txtEsqueciSenha.BackColor = Color.Transparent;
            txtEsqueciSenha.Location = new Point(87, 287);
            txtEsqueciSenha.Name = "txtEsqueciSenha";
            txtEsqueciSenha.Size = new Size(100, 15);
            txtEsqueciSenha.TabIndex = 102;
            txtEsqueciSenha.TabStop = true;
            txtEsqueciSenha.Text = "Tenho uma conta";
            txtEsqueciSenha.LinkClicked += txtEsqueciSenha_LinkClicked;
            // 
            // boxSenha
            // 
            boxSenha.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            boxSenha.Location = new Point(87, 251);
            boxSenha.Name = "boxSenha";
            boxSenha.PasswordChar = '*';
            boxSenha.Size = new Size(192, 23);
            boxSenha.TabIndex = 101;
            // 
            // imagemConfiguracoes
            // 
            imagemConfiguracoes.BackColor = Color.Transparent;
            imagemConfiguracoes.Image = Properties.Resources.imagemConfiguracoes;
            imagemConfiguracoes.Location = new Point(645, 364);
            imagemConfiguracoes.Name = "imagemConfiguracoes";
            imagemConfiguracoes.Size = new Size(100, 50);
            imagemConfiguracoes.SizeMode = PictureBoxSizeMode.Zoom;
            imagemConfiguracoes.TabIndex = 108;
            imagemConfiguracoes.TabStop = false;
            // 
            // txtSenha
            // 
            txtSenha.AutoSize = true;
            txtSenha.BackColor = Color.Transparent;
            txtSenha.ForeColor = SystemColors.Control;
            txtSenha.Location = new Point(87, 233);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(69, 15);
            txtSenha.TabIndex = 109;
            txtSenha.Text = "Nova senha";
            // 
            // imagemRelatorio
            // 
            imagemRelatorio.BackColor = Color.Transparent;
            imagemRelatorio.Image = Properties.Resources.imagemGraficoRelatorio;
            imagemRelatorio.Location = new Point(464, 364);
            imagemRelatorio.Name = "imagemRelatorio";
            imagemRelatorio.Size = new Size(100, 50);
            imagemRelatorio.SizeMode = PictureBoxSizeMode.Zoom;
            imagemRelatorio.TabIndex = 107;
            imagemRelatorio.TabStop = false;
            // 
            // imagemReabastecimento
            // 
            imagemReabastecimento.BackColor = Color.Transparent;
            imagemReabastecimento.Image = Properties.Resources.imagemReabastecimento;
            imagemReabastecimento.Location = new Point(275, 364);
            imagemReabastecimento.Name = "imagemReabastecimento";
            imagemReabastecimento.Size = new Size(100, 50);
            imagemReabastecimento.SizeMode = PictureBoxSizeMode.Zoom;
            imagemReabastecimento.TabIndex = 106;
            imagemReabastecimento.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.AutoSize = true;
            txtUsuario.BackColor = Color.Transparent;
            txtUsuario.ForeColor = SystemColors.Control;
            txtUsuario.Location = new Point(87, 189);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(78, 15);
            txtUsuario.TabIndex = 110;
            txtUsuario.Text = "Novo usuário";
            // 
            // imagemInventario
            // 
            imagemInventario.BackColor = Color.Transparent;
            imagemInventario.Image = Properties.Resources.imagemControleInventario;
            imagemInventario.Location = new Point(87, 364);
            imagemInventario.Name = "imagemInventario";
            imagemInventario.Size = new Size(100, 50);
            imagemInventario.SizeMode = PictureBoxSizeMode.Zoom;
            imagemInventario.TabIndex = 105;
            imagemInventario.TabStop = false;
            // 
            // frmCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.fundo_desktop_app;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBoxLembrarLogin);
            Controls.Add(btnEntrar);
            Controls.Add(boxUsuario);
            Controls.Add(txtEsqueciSenha);
            Controls.Add(boxSenha);
            Controls.Add(imagemConfiguracoes);
            Controls.Add(txtSenha);
            Controls.Add(imagemRelatorio);
            Controls.Add(imagemReabastecimento);
            Controls.Add(txtUsuario);
            Controls.Add(imagemInventario);
            Name = "frmCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            FormClosed += frmCadastro_FormClosed;
            Load += frmCadastro_Load;
            ((System.ComponentModel.ISupportInitialize)imagemConfiguracoes).EndInit();
            ((System.ComponentModel.ISupportInitialize)imagemRelatorio).EndInit();
            ((System.ComponentModel.ISupportInitialize)imagemReabastecimento).EndInit();
            ((System.ComponentModel.ISupportInitialize)imagemInventario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxLembrarLogin;
        private Button btnEntrar;
        private TextBox boxUsuario;
        private LinkLabel txtEsqueciSenha;
        private TextBox boxSenha;
        private PictureBox imagemConfiguracoes;
        private Label txtSenha;
        private PictureBox imagemRelatorio;
        private PictureBox imagemReabastecimento;
        private Label txtUsuario;
        private PictureBox imagemInventario;
    }
}