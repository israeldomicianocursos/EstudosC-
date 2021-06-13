using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp2.Banco;

namespace WindowsFormsApp2
{
    public partial class frmTelaPrincipal : Form
    {
        SqlConnection sqlCon = null;
        public string strCon = (@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CRUD;Data Source=desktop-vhtio37\sqlexpress");
        public string strSql = string.Empty;
        public frmTelaPrincipal()
        {
            InitializeComponent();

           // AtualizarTabela();
        }
        
        //public void AtualizarTabela()
        //{
          //  dgvTelaPrincipal.DataSource = Banco.funcionarioDataAccess.PegarFuncionarios();

       //}

       // DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
        

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTelaPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cRUDDataSet.Funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.cRUDDataSet.Funcionarios);

            DataGridViewButtonColumn Btn = new DataGridViewButtonColumn();
            Btn.HeaderText = "Selecionar";
            Btn.Name = "Name";
            Btn.Text = "Selecionar";           
            dgvTelaPrincipal.Columns.Add(Btn);
            Btn.UseColumnTextForButtonValue = true;

            //Criação do btn

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            strSql = "INSERT INTO Funcionarios (Nome, CPF, Telefone, Email, DataNascimento, Departamento)values (@Nome, @CPF, @Telefone, @Email, @DataNascimento, @Departamento)";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            //comando.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = txbId.Text;
            comando.Parameters.AddWithValue("@Nome", SqlDbType.VarChar).Value = txbNome.Text;
            comando.Parameters.AddWithValue("@Telefone", SqlDbType.VarChar).Value = txbTelefone.Text;
            comando.Parameters.AddWithValue("@CPF", SqlDbType.VarChar).Value = txbCPF.Text;
            comando.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = txbEmail.Text;
            comando.Parameters.AddWithValue("@DataNascimento", SqlDbType.Date).Value = txbDataNascimento.Text;
            comando.Parameters.AddWithValue("@Departamento", SqlDbType.VarChar).Value = txbDepartamento.Text;
            
            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado!");

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlCon.Close();

                //Inserir funcionarios no banco
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            strSql =  "select * from Funcionarios where CPF=@CPF";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.AddWithValue("@CPF", SqlDbType.VarChar).Value = txbPesquisar.Text;

            try
            {
                if (txbPesquisar.Text == string.Empty)
                {
                    throw new Exception("Você precisa digitar um CPF!"); 
                }
                sqlCon.Open();

                SqlDataReader dr = comando.ExecuteReader();               

                if (dr.HasRows == false)
                {
                    throw new Exception("CPF não cadastrado!");
                }

                dr.Read();

                
                txbCPF.Text = Convert.ToString(dr["CPF"]);
                txbNome.Text = Convert.ToString(dr["Nome"]);
                txbTelefone.Text = Convert.ToString(dr["Telefone"]);
                txbEmail.Text = Convert.ToString(dr["Email"]);
                txbDataNascimento.Text = Convert.ToString(dr["DataNascimento"]);
                txbDepartamento.Text = Convert.ToString(dr["Departamento"]);

            }
                       
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

            finally
            {
                sqlCon.Close();
                //Filtrar por CPF na pesquisa
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {

                strSql = "select * from Funcionarios";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);

                comando.Parameters.AddWithValue("@Id", SqlDbType.Int);
                sqlCon.Open();

                //dr.Read();


                txbCPF.Text = Convert.ToString("CPF");
                txbNome.Text = Convert.ToString("Nome");
                txbTelefone.Text = Convert.ToString("Telefone");
                txbEmail.Text = Convert.ToString("Email");
                txbDataNascimento.Text = Convert.ToString("DataNascimento");
                txbDepartamento.Text = Convert.ToString("Departamento");




                //frmMaisOpcoes frmMaisOpcoes = new frmMaisOpcoes();
                //frmMaisOpcoes.Show();
                // MessageBox.Show("Deu certo");
                //Botão do grid


            }
        }

       
    }
}
