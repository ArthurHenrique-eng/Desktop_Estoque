namespace Estoque
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            txtTituloEstoque = new Label();
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            btnControle = new Button();
            btnReabastecimento = new Button();
            btnRelatorio = new Button();
            SuspendLayout();
            // 
            // txtTituloEstoque
            // 
            txtTituloEstoque.AutoSize = true;
            txtTituloEstoque.BackColor = Color.Transparent;
            txtTituloEstoque.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTituloEstoque.Location = new Point(200, 33);
            txtTituloEstoque.Name = "txtTituloEstoque";
            txtTituloEstoque.Size = new Size(427, 47);
            txtTituloEstoque.TabIndex = 99;
            txtTituloEstoque.Text = "GERENCIE SEU ESTOQUE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(83, 287);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(123, 37);
            label1.TabIndex = 99;
            label1.Text = "Controle";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(58, 324);
            label4.Name = "label4";
            label4.Size = new Size(178, 37);
            label4.TabIndex = 99;
            label4.Text = "de inventário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(614, 324);
            label2.Name = "label2";
            label2.Size = new Size(117, 37);
            label2.TabIndex = 99;
            label2.Text = "produto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(608, 287);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(134, 37);
            label3.TabIndex = 99;
            label3.Text = "Cadastrar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(301, 324);
            label5.Name = "label5";
            label5.Size = new Size(227, 37);
            label5.TabIndex = 99;
            label5.Text = "Reabastecimento";
            // 
            // btnControle
            // 
            btnControle.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnControle.BackColor = Color.Transparent;
            btnControle.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnControle.Location = new Point(83, 377);
            btnControle.Name = "btnControle";
            btnControle.Size = new Size(123, 29);
            btnControle.TabIndex = 0;
            btnControle.Text = "VER";
            btnControle.UseVisualStyleBackColor = false;
            btnControle.Click += btnControle_Click;
            // 
            // btnReabastecimento
            // 
            btnReabastecimento.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnReabastecimento.BackColor = Color.Transparent;
            btnReabastecimento.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnReabastecimento.Location = new Point(345, 377);
            btnReabastecimento.Name = "btnReabastecimento";
            btnReabastecimento.Size = new Size(123, 29);
            btnReabastecimento.TabIndex = 1;
            btnReabastecimento.Text = "COMPRAR";
            btnReabastecimento.UseVisualStyleBackColor = false;
            btnReabastecimento.Click += btnReabastecimento_Click;
            // 
            // btnRelatorio
            // 
            btnRelatorio.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRelatorio.BackColor = Color.Transparent;
            btnRelatorio.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnRelatorio.Location = new Point(608, 377);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(123, 29);
            btnRelatorio.TabIndex = 2;
            btnRelatorio.Text = "VER";
            btnRelatorio.UseVisualStyleBackColor = false;
            btnRelatorio.Click += btnRelatorio_Click;
            // 
            // frmInicio
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(819, 533);
            Controls.Add(btnRelatorio);
            Controls.Add(btnReabastecimento);
            Controls.Add(btnControle);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txtTituloEstoque);
            Name = "frmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            FormClosed += frmInicio_FormClosed;
            Load += frmInicio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtTituloEstoque;
        private Label label1;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label5;
        private Button btnControle;
        private Button btnReabastecimento;
        private Button btnRelatorio;
    }
}