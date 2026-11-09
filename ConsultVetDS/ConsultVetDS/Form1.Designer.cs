namespace ConsultVetDS
{
    partial class FormHome
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
            panel1 = new Panel();
            label2 = new Label();
            btnTratamentos = new Button();
            btnVet = new Button();
            btnAnimais = new Button();
            btnClientes = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            tcClientes = new TabControl();
            tabPage1 = new TabPage();
            btnExcluir = new Button();
            btnEditar = new Button();
            btnNovo = new Button();
            dgvClientes = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            tcClientes.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnTratamentos);
            panel1.Controls.Add(btnVet);
            panel1.Controls.Add(btnAnimais);
            panel1.Controls.Add(btnClientes);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 453);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 61);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 5;
            label2.Text = "cadastros";
            // 
            // btnTratamentos
            // 
            btnTratamentos.Location = new Point(3, 200);
            btnTratamentos.Name = "btnTratamentos";
            btnTratamentos.Size = new Size(207, 40);
            btnTratamentos.TabIndex = 4;
            btnTratamentos.Text = "Tratamentos";
            btnTratamentos.UseVisualStyleBackColor = true;
            btnTratamentos.Click += btnTratamentos_Click;
            // 
            // btnVet
            // 
            btnVet.Location = new Point(3, 162);
            btnVet.Name = "btnVet";
            btnVet.Size = new Size(207, 40);
            btnVet.TabIndex = 3;
            btnVet.Text = "Veterinários";
            btnVet.UseVisualStyleBackColor = true;
            btnVet.Click += button3_Click;
            // 
            // btnAnimais
            // 
            btnAnimais.Location = new Point(3, 124);
            btnAnimais.Name = "btnAnimais";
            btnAnimais.Size = new Size(207, 40);
            btnAnimais.TabIndex = 2;
            btnAnimais.Text = "Animais";
            btnAnimais.UseVisualStyleBackColor = true;
            btnAnimais.Click += btnAnimais_Click;
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(3, 86);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(207, 40);
            btnClientes.TabIndex = 1;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 20);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Clínica Vet";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(234, 39);
            label3.Name = "label3";
            label3.Size = new Size(261, 37);
            label3.TabIndex = 1;
            label3.Text = "Cadastro de Clientes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(238, 77);
            label4.Name = "label4";
            label4.Size = new Size(218, 15);
            label4.TabIndex = 2;
            label4.Text = "Cadastre e gerencie os tutores da clínica";
            // 
            // tcClientes
            // 
            tcClientes.Controls.Add(tabPage1);
            tcClientes.Location = new Point(234, 108);
            tcClientes.Name = "tcClientes";
            tcClientes.SelectedIndex = 0;
            tcClientes.Size = new Size(554, 322);
            tcClientes.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnExcluir);
            tabPage1.Controls.Add(btnEditar);
            tabPage1.Controls.Add(btnNovo);
            tabPage1.Controls.Add(dgvClientes);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(546, 294);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(465, 27);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(385, 27);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(304, 27);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 23);
            btnNovo.TabIndex = 1;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvClientes.Location = new Point(0, 56);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(546, 150);
            dgvClientes.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Nome";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Telefone";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "E-mail";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Endereço";
            Column5.Name = "Column5";
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tcClientes);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "FormHome";
            Text = "Clientes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tcClientes.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnClientes;
        private Label label1;
        private Button btnTratamentos;
        private Button btnVet;
        private Button btnAnimais;
        private Label label2;
        private Label label3;
        private Label label4;
        private TabControl tcClientes;
        private TabPage tabPage1;
        private Button btnEditar;
        private Button btnNovo;
        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button btnExcluir;
    }
}
