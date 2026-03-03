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
            ((System.ComponentModel.ISupportInitialize)dgvAlunos).BeginInit();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(454, 51);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 0;
            // 
            // txtRM
            // 
            txtRM.Location = new Point(454, 109);
            txtRM.Name = "txtRM";
            txtRM.Size = new Size(100, 23);
            txtRM.TabIndex = 1;
            // 
            // txtNome
            // 
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
            btnCadastrar.Location = new Point(405, 179);
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
            dgvAlunos.Location = new Point(354, 254);
            dgvAlunos.Name = "dgvAlunos";
            dgvAlunos.Size = new Size(240, 150);
            dgvAlunos.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvAlunos);
            Controls.Add(btnCadastrar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(txtRM);
            Controls.Add(txtCodigo);
            Name = "Form1";
            Text = "Form1";
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
    }
}
