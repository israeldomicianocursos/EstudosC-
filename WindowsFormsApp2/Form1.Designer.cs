
namespace WindowsFormsApp2
{
    partial class frmTelaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvTelaPrincipal = new System.Windows.Forms.DataGridView();
            this.funcionariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbCRUDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.txbCPF = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbDataNascimento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbDepartamento = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txbPesquisar = new System.Windows.Forms.TextBox();
            this.tabelaCrudBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.updateOrderOptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionariosTableAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioDataAccessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cRUDDataSet = new WindowsFormsApp2.CRUDDataSet();
            this.funcionariosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.funcionariosTableAdapter = new WindowsFormsApp2.CRUDDataSetTableAdapters.FuncionariosTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelaPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRUDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCrudBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateOrderOptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosTableAdapterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioDataAccessBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTelaPrincipal
            // 
            this.dgvTelaPrincipal.AutoGenerateColumns = false;
            this.dgvTelaPrincipal.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTelaPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelaPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvTelaPrincipal.DataSource = this.funcionariosBindingSource2;
            this.dgvTelaPrincipal.Location = new System.Drawing.Point(2, 38);
            this.dgvTelaPrincipal.Name = "dgvTelaPrincipal";
            this.dgvTelaPrincipal.Size = new System.Drawing.Size(844, 267);
            this.dgvTelaPrincipal.TabIndex = 0;
            this.dgvTelaPrincipal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // funcionariosBindingSource1
            // 
            this.funcionariosBindingSource1.DataMember = "Funcionarios";
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataSource = typeof(WindowsFormsApp2.Modelo.Funcionario);
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataMember = "Funcionarios";
            // 
            // dbCRUDBindingSource
            // 
            this.dbCRUDBindingSource.DataMember = "db_CRUD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(535, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "CPF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(430, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Data de Nascimento:";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(174, 337);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(250, 20);
            this.txbNome.TabIndex = 7;
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(430, 337);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(100, 20);
            this.txbTelefone.TabIndex = 8;
            // 
            // txbCPF
            // 
            this.txbCPF.Location = new System.Drawing.Point(535, 337);
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(100, 20);
            this.txbCPF.TabIndex = 9;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(174, 386);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(250, 20);
            this.txbEmail.TabIndex = 10;
            // 
            // txbDataNascimento
            // 
            this.txbDataNascimento.Location = new System.Drawing.Point(431, 387);
            this.txbDataNascimento.Name = "txbDataNascimento";
            this.txbDataNascimento.Size = new System.Drawing.Size(100, 20);
            this.txbDataNascimento.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(535, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Departamento:";
            // 
            // txbDepartamento
            // 
            this.txbDepartamento.Location = new System.Drawing.Point(536, 386);
            this.txbDepartamento.Name = "txbDepartamento";
            this.txbDepartamento.Size = new System.Drawing.Size(100, 20);
            this.txbDepartamento.TabIndex = 13;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(295, 435);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 41);
            this.btnCadastrar.TabIndex = 14;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(389, 434);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 42);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(761, 435);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 41);
            this.button4.TabIndex = 17;
            this.button4.Text = "Fechar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(182, 10);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 18;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txbPesquisar
            // 
            this.txbPesquisar.Location = new System.Drawing.Point(12, 12);
            this.txbPesquisar.Name = "txbPesquisar";
            this.txbPesquisar.Size = new System.Drawing.Size(164, 20);
            this.txbPesquisar.TabIndex = 19;
            // 
            // tabelaCrudBindingSource
            // 
            this.tabelaCrudBindingSource.DataMember = "TabelaCrud";
            // 
            // funcionarioDataAccessBindingSource
            // 
            this.funcionarioDataAccessBindingSource.DataSource = typeof(WindowsFormsApp2.Banco.funcionarioDataAccess);
            // 
            // cRUDDataSet
            // 
            this.cRUDDataSet.DataSetName = "CRUDDataSet";
            this.cRUDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionariosBindingSource2
            // 
            this.funcionariosBindingSource2.DataMember = "Funcionarios";
            this.funcionariosBindingSource2.DataSource = this.cRUDDataSet;
            // 
            // funcionariosTableAdapter
            // 
            this.funcionariosTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CPF";
            this.dataGridViewTextBoxColumn2.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Telefone";
            this.dataGridViewTextBoxColumn3.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DataNascimento";
            this.dataGridViewTextBoxColumn5.HeaderText = "DataNascimento";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Departamento";
            this.dataGridViewTextBoxColumn6.HeaderText = "Departamento";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(848, 505);
            this.Controls.Add(this.txbPesquisar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txbDepartamento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbDataNascimento);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbCPF);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvTelaPrincipal);
            this.Name = "frmTelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Principal";
            this.Load += new System.EventHandler(this.frmTelaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelaPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRUDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCrudBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateOrderOptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosTableAdapterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioDataAccessBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTelaPrincipal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.TextBox txbCPF;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbDataNascimento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbDepartamento;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txbPesquisar;
        private System.Windows.Forms.BindingSource dbCRUDBindingSource;
        private System.Windows.Forms.BindingSource tabelaCrudBindingSource;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private System.Windows.Forms.BindingSource funcionarioDataAccessBindingSource;
        private System.Windows.Forms.BindingSource updateOrderOptionBindingSource;
        private System.Windows.Forms.BindingSource funcionariosTableAdapterBindingSource;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource funcionariosBindingSource1;
        private CRUDDataSet cRUDDataSet;
        private System.Windows.Forms.BindingSource funcionariosBindingSource2;
        private CRUDDataSetTableAdapters.FuncionariosTableAdapter funcionariosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

