namespace Fiap.Aula02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCodigo = new TextBox();
            txtRM = new TextBox();
            txtNome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCadastrar = new Button();
            dgvAlunos = new DataGridView();
            txtCep = new TextBox();
            label4 = new Label();
            txtBairro = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtRua = new TextBox();
            BtnBuscarCep = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAlunos).BeginInit();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = SystemColors.ButtonShadow;
            txtCodigo.Location = new Point(454, 51);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 0;
            // 
            // txtRM
            // 
            txtRM.BackColor = SystemColors.ButtonShadow;
            txtRM.Location = new Point(454, 109);
            txtRM.Name = "txtRM";
            txtRM.Size = new Size(100, 23);
            txtRM.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.ButtonShadow;
            txtNome.Location = new Point(454, 80);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(337, 59);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 3;
            label1.Text = "Código do Aluno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(337, 88);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(337, 117);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 4;
            label3.Text = "RM";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(468, 236);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // dgvAlunos
            // 
            dgvAlunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlunos.Location = new Point(429, 288);
            dgvAlunos.Name = "dgvAlunos";
            dgvAlunos.Size = new Size(240, 150);
            dgvAlunos.TabIndex = 6;
            dgvAlunos.CellContentClick += dgvAlunos_CellContentClick;
            // 
            // txtCep
            // 
            txtCep.BackColor = SystemColors.ButtonShadow;
            txtCep.Location = new Point(454, 138);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(100, 23);
            txtCep.TabIndex = 7;
            txtCep.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(337, 146);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 8;
            label4.Text = "CEP";
            // 
            // txtBairro
            // 
            txtBairro.BackColor = SystemColors.ButtonShadow;
            txtBairro.Enabled = false;
            txtBairro.Location = new Point(454, 167);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(100, 23);
            txtBairro.TabIndex = 9;
            txtBairro.TextChanged += txtBairro_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(337, 175);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 10;
            label5.Text = "Bairro";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(337, 204);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 12;
            label6.Text = "Rua";
            // 
            // txtRua
            // 
            txtRua.BackColor = SystemColors.ButtonShadow;
            txtRua.Enabled = false;
            txtRua.Location = new Point(454, 196);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(100, 23);
            txtRua.TabIndex = 11;
            txtRua.TextChanged += textBox3_TextChanged;
            // 
            // BtnBuscarCep
            // 
            BtnBuscarCep.Location = new Point(575, 138);
            BtnBuscarCep.Name = "BtnBuscarCep";
            BtnBuscarCep.Size = new Size(75, 23);
            BtnBuscarCep.TabIndex = 13;
            BtnBuscarCep.Text = "Buscar Cep";
            BtnBuscarCep.UseVisualStyleBackColor = true;
            BtnBuscarCep.Click += BtnBuscarCep_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnBuscarCep);
            Controls.Add(label6);
            Controls.Add(txtRua);
            Controls.Add(label5);
            Controls.Add(txtBairro);
            Controls.Add(label4);
            Controls.Add(txtCep);
            Controls.Add(dgvAlunos);
            Controls.Add(btnCadastrar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(txtRM);
            Controls.Add(txtCodigo);
            Name = "Form1";
            Text = "Form1Z";
            ((System.ComponentModel.ISupportInitialize)dgvAlunos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodigo;
        private TextBox txtRM;
        private TextBox txtNome;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCadastrar;
        private DataGridView dgvAlunos;
        private TextBox txtCep;
        private Label label4;
        private TextBox txtBairro;
        private Label label5;
        private Label label6;
        private TextBox txtRua;
        private Button BtnBuscarCep;
    }
}
