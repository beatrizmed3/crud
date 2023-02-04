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

namespace Crud
{
	public partial class Professores : Form
	{
		public Professores()
		{
			InitializeComponent();
		}

		SqlConnection sqlCon = null;
		private string strCon = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Crud;Data Source=BM";
		private string strSql = string.Empty;

		private void tsbSalvar_Click(object sender, EventArgs e)
		{
			strSql = "insert into Professores (Id, Nome, Endereco, CEP, Bairro, Cidade, UF, Telefone) values (@Id, @Nome, @Endereco, @CEP, @Bairro, @Cidade, @UF, @Telefone)";
			sqlCon = new SqlConnection(strCon);
			SqlCommand comando = new SqlCommand(strSql, sqlCon);

			comando.Parameters.Add("@Id", SqlDbType.Int).Value = txtId1.Text;
			comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtNome1.Text;
			comando.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = txtEndereco1.Text;
			comando.Parameters.Add("CEP", SqlDbType.VarChar).Value = mskCep1.Text;
			comando.Parameters.Add("Bairro", SqlDbType.VarChar).Value = txtBairro1.Text;
			comando.Parameters.Add("Cidade", SqlDbType.VarChar).Value = txtCidade1.Text;
			comando.Parameters.Add("UF", SqlDbType.VarChar).Value = txtUf1.Text;
			comando.Parameters.Add("Telefone", SqlDbType.VarChar).Value = mskTelefone1.Text;

			try
			{
				sqlCon.Open();
				comando.ExecuteNonQuery();
				MessageBox.Show("Cadastro Feito!");
			}

			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				sqlCon.Close();
			}

			tsbNovo1.Enabled = true;
			tsbSalvar1.Enabled = false;
			tsbAlterar1.Enabled = false;
			tsbCancelar1.Enabled = false;
			tsbExcluir1.Enabled = false;
			tstIdBuscar1.Enabled = true;
			tsbBuscar1.Enabled = true;
			txtId1.Enabled = false;
			txtNome1.Enabled = false;
			txtEndereco1.Enabled = false;
			txtBairro1.Enabled = false;
			mskCep1.Enabled = false;
			txtCidade1.Enabled = false;
			txtUf1.Enabled = false;
			mskTelefone1.Enabled = false;
			txtNome1.Text = "";
			txtEndereco1.Text = "";
			txtBairro1.Text = "";
			txtCidade1.Text = "";
			txtUf1.Text = "";
			mskCep1.Text = "";
			mskTelefone1.Text = "";
		}

		private void tsbNovo_Click(object sender, EventArgs e)
		{

		}

		private void tsbCancelar1_Click(object sender, EventArgs e)
		{

		}

		private void tsbBuscar1_Click(object sender, EventArgs e)
		{
			strSql = "select * from Alunos where Id=@Id";
			sqlCon = new SqlConnection(strCon);
			SqlCommand comando = new SqlCommand(strSql, sqlCon);

			comando.Parameters.Add("@Id", SqlDbType.VarChar).Value = tstBuscar1.Text;

			try
			{
				if (tstBuscar1.Text == string.Empty)
				{
					throw new Exception("Você precisa inserir um Id!");
				}
				sqlCon.Open();

				SqlDataReader dr = comando.ExecuteReader();

				if (dr.HasRows == false)
				{
					throw new Exception("Cadastrado não encontrado.");
				}

				txtId1.Text = Convert.ToString(dr["Id"]);
				txtNome1.Text = Convert.ToString(dr["Nome"]);
				txtEndereco1.Text = Convert.ToString(dr["Endereco"]);
				mskCep1.Text = Convert.ToString(dr["CEP"]);
				txtBairro1.Text = Convert.ToString(dr["Bairro"]);
				txtCidade1.Text = Convert.ToString(dr["Cidade"]);
				txtUf1.Text = Convert.ToString(dr["UF"]);
				mskTelefone1.Text = Convert.ToString(dr["Telefone"]);

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				sqlCon.Close();
			}

			tsbNovo1.Enabled = false;
			tsbSalvar1.Enabled = false;
			tsbAlterar1.Enabled = true;
			tsbCancelar1.Enabled = true;
			tsbExcluir1.Enabled = true;
			tstIdBuscar1.Enabled = true;
			tsbBuscar1.Enabled = true;
			txtNome1.Enabled = true;
			txtEndereco1.Enabled = true;
			txtBairro1.Enabled = true;
			mskCep1.Enabled = true;
			txtCidade1.Enabled = true;
			txtUf1.Enabled = true;
			mskTelefone1.Enabled = true;
			tsbBuscar1.Text = "";
			txtNome1.Focus();
		}

		private void tsbAlterar1_Click(object sender, EventArgs e)
		{
			strSql = "update Alunos set Id=@Id, Nome=@Nome, Endereco=@Endereco, CEP=@CEP, Bairro=@Bairro, Cidade=@Cidade, UF=@UF, Telefone=@Telefone where Id=@IdBuscar";
			sqlCon = new SqlConnection(strCon);
			SqlCommand comando = new SqlCommand(strSql, sqlCon);

			comando.Parameters.Add("@IdBuscar", SqlDbType.Int).Value = tstBuscar1.Text;

			comando.Parameters.Add("@Id", SqlDbType.Int).Value = txtId1.Text;
			comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtNome1.Text;
			comando.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = txtEndereco1.Text;
			comando.Parameters.Add("CEP", SqlDbType.VarChar).Value = mskCep1.Text;
			comando.Parameters.Add("Bairro", SqlDbType.VarChar).Value = txtBairro1.Text;
			comando.Parameters.Add("Cidade", SqlDbType.VarChar).Value = txtCidade1.Text;
			comando.Parameters.Add("UF", SqlDbType.VarChar).Value = txtUf1.Text;
			comando.Parameters.Add("Telefone", SqlDbType.VarChar).Value = mskTelefone1.Text;

			try
			{
				sqlCon.Open();
				comando.ExecuteNonQuery();
				MessageBox.Show("Cadastro Atualizado!");

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				sqlCon.Close();
			}

			tsbNovo1.Enabled = true;
			tsbSalvar1.Enabled = false;
			tsbAlterar1.Enabled = false;
			tsbCancelar1.Enabled = false;
			tsbExcluir1.Enabled = false;
			tstIdBuscar1.Enabled = true;
			tsbBuscar1.Enabled = true;
			txtId1.Enabled = false;
			txtNome1.Enabled = false;
			txtEndereco1.Enabled = false;
			txtBairro1.Enabled = false;
			mskCep1.Enabled = false;
			txtCidade1.Enabled = false;
			txtUf1.Enabled = false;
			mskTelefone1.Enabled = false;
			txtNome1.Text = "";
			txtEndereco1.Text = "";
			txtBairro1.Text = "";
			txtCidade1.Text = "";
			txtUf1.Text = "";
			mskCep1.Text = "";
			mskTelefone1.Text = "";
		}

		private void tsbExcluir1_Click(object sender, EventArgs e)
		{

			if (MessageBox.Show("Deseja excluir este cadastro?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
			{
				MessageBox.Show("Cancelado!");
			}

			else
			{
				strSql = "delete from Alunos where Id=@Id";
				sqlCon = new SqlConnection(strSql);
				SqlCommand comando = new SqlCommand(strSql, sqlCon);

				comando.Parameters.Add("@Id", SqlDbType.Int).Value = tstBuscar1.Text;
			}

			try
			{
				sqlCon.Open();
				//comando.ExecuteNonQuery();
				MessageBox.Show("Cadastro excluido!");

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				sqlCon.Close();
			}

			tsbNovo1.Enabled = true;
			tsbSalvar1.Enabled = false;
			tsbAlterar1.Enabled = false;
			tsbCancelar1.Enabled = false;
			tsbExcluir1.Enabled = false;
			tstIdBuscar1.Enabled = true;
			tsbBuscar1.Enabled = true;
			txtNome1.Enabled = false;
			txtEndereco1.Enabled = false;
			txtBairro1.Enabled = false;
			mskCep1.Enabled = false;
			txtCidade1.Enabled = false;
			txtUf1.Enabled = false;
			mskTelefone1.Enabled = false;
			txtNome1.Text = "";
			txtEndereco1.Text = "";
			txtBairro1.Text = "";
			txtCidade1.Text = "";
			txtUf1.Text = "";
			mskCep1.Text = "";
			mskTelefone1.Text = "";
		}

		private void tsbNovo1_Click(object sender, EventArgs e)
		{
			tsbNovo1.Enabled = false;
			tsbSalvar1.Enabled = true;
			tsbAlterar1.Enabled = false;
			tsbCancelar1.Enabled = true;
			tsbExcluir1.Enabled = false;
			tstIdBuscar1.Enabled = false;
			tsbBuscar1.Enabled = false;
			txtId1.Enabled = true;
			txtNome1.Enabled = true;
			txtEndereco1.Enabled = true;
			txtBairro1.Enabled = true;
			mskCep1.Enabled = true;
			txtCidade1.Enabled = true;
			txtUf1.Enabled = true;
			mskTelefone1.Enabled = true;



		}

		private void tsbCancelar_Click(object sender, EventArgs e)
		{
			tsbNovo1.Enabled = true;
			tsbSalvar1.Enabled = false;
			tsbAlterar1.Enabled = false;
			tsbCancelar1.Enabled = false;
			tsbExcluir1.Enabled = false;
			tstIdBuscar1.Enabled = true;
			tsbBuscar1.Enabled = true;
			txtNome1.Enabled = false;
			txtEndereco1.Enabled = false;
			txtBairro1.Enabled = false;
			mskCep1.Enabled = false;
			txtCidade1.Enabled = false;
			txtUf1.Enabled = false;
			mskTelefone1.Enabled = false;
			txtId1.Enabled = false;
			txtNome1.Text = "";
			txtEndereco1.Text = "";
			txtBairro1.Text = "";
			txtCidade1.Text = "";
			txtUf1.Text = "";
			mskCep1.Text = "";
			mskTelefone1.Text = "";
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			tsbNovo1.Enabled = true;
			tsbSalvar1.Enabled = false;
			tsbAlterar1.Enabled = false;
			tsbCancelar1.Enabled = false;
			tsbExcluir1.Enabled = false;
			tstIdBuscar1.Enabled = true;
			tsbBuscar1.Enabled = true;
			txtId1.Enabled = false;
			txtNome1.Enabled = false;
			txtEndereco1.Enabled = false;
			txtBairro1.Enabled = false;
			mskCep1.Enabled = false;
			txtCidade1.Enabled = false;
			txtUf1.Enabled = false;
			mskTelefone1.Enabled = false;

		}
	}
}
