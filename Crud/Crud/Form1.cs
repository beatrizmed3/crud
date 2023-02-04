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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		SqlConnection sqlCon = null;
		private string strCon = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Crud;Data Source=BM";
		private string strSql = string.Empty;

		private void tsbSalvar_Click(object sender, EventArgs e)
		{
			strSql = "insert into Alunos (Id, Nome, Endereco, CEP, Bairro, Cidade, UF, Telefone) values (@Id, @Nome, @Endereco, @CEP, @Bairro, @Cidade, @UF, @Telefone)";
			sqlCon = new SqlConnection(strCon);
			SqlCommand comando = new SqlCommand(strSql, sqlCon);

			comando.Parameters.Add("@Id", SqlDbType.Int).Value=txtId.Text;
			comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtNome.Text;
			comando.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = txtEndereco.Text;
			comando.Parameters.Add("CEP", SqlDbType.VarChar).Value = mskCep.Text;
			comando.Parameters.Add("Bairro", SqlDbType.VarChar).Value = txtBairro.Text;
			comando.Parameters.Add("Cidade", SqlDbType.VarChar).Value = txtCidade.Text;
			comando.Parameters.Add("UF", SqlDbType.VarChar).Value = txtUf.Text;
			comando.Parameters.Add("Telefone", SqlDbType.VarChar).Value = mskTelefone.Text;

			try
			{
				sqlCon.Open();
				comando.ExecuteNonQuery();
				MessageBox.Show("Cadastro Feito!");
			}

			catch(Exception ex) 
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				sqlCon.Close();
			}

			tsbNovo.Enabled = true;
			tsbSalvar.Enabled = false;
			tsbAlterar.Enabled = false;
			tsbCancelar.Enabled = false;
			tsbExcluir.Enabled = false;
			tstIdBuscar.Enabled = true;
			tsbBuscar.Enabled = true;
			txtId.Enabled = false;
			txtNome.Enabled = false;
			txtEndereco.Enabled = false;
			txtBairro.Enabled = false;
			mskCep.Enabled = false;
			txtCidade.Enabled = false;
			txtUf.Enabled = false;
			mskTelefone.Enabled = false;
			txtNome.Text = "";
			txtEndereco.Text = "";
			txtBairro.Text = "";
			txtCidade.Text = "";
			txtUf.Text = "";
			mskCep.Text = "";
			mskTelefone.Text = "";
		}

		private void txtBairro_TextChanged(object sender, EventArgs e)
		{

		}

		private void tsbBuscar_Click(object sender, EventArgs e)
		{
			strSql = "select * from Alunos where Id=@Id";
			sqlCon= new SqlConnection(strCon);
			SqlCommand comando = new SqlCommand(strSql, sqlCon);

			comando.Parameters.Add("@Id", SqlDbType.VarChar).Value = tstBuscar.Text;
			
			try
			{
				if (tstBuscar.Text == string.Empty)
				{
					throw new Exception("Você precisa inserir um Id!");
				}
				sqlCon.Open();

				SqlDataReader dr = comando.ExecuteReader();

				if (dr.HasRows == false)
				{
					throw new Exception("Cadastrado não encontrado.");
				}

				txtId.Text = Convert.ToString(dr["Id"]);
				txtNome.Text = Convert.ToString(dr["Nome"]);
				txtEndereco.Text = Convert.ToString(dr["Endereco"]);
				mskCep.Text = Convert.ToString(dr["CEP"]);
				txtBairro.Text = Convert.ToString(dr["Bairro"]);
				txtCidade.Text = Convert.ToString(dr["Cidade"]);
				txtUf.Text = Convert.ToString(dr["UF"]);
				mskTelefone.Text = Convert.ToString(dr["Telefone"]);
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				sqlCon.Close();
			}

			tsbNovo.Enabled = false;
			tsbSalvar.Enabled = false;
			tsbAlterar.Enabled = true;
			tsbCancelar.Enabled = true;
			tsbExcluir.Enabled = true;
			tstIdBuscar.Enabled = true;
			tsbBuscar.Enabled = true;
			txtNome.Enabled = true;
			txtEndereco.Enabled = true;
			txtBairro.Enabled = true;
			mskCep.Enabled = true;
			txtCidade.Enabled = true;
			txtUf.Enabled = true;
			mskTelefone.Enabled = true;
			tsbBuscar.Text = "";
			txtNome.Focus();

		}

		private void tsbAlterar_Click(object sender, EventArgs e)
		{
			strSql = "update Alunos set Id=@Id, Nome=@Nome, Endereco=@Endereco, CEP=@CEP, Bairro=@Bairro, Cidade=@Cidade, UF=@UF, Telefone=@Telefone where Id=@IdBuscar";
			sqlCon = new SqlConnection(strCon);
			SqlCommand comando = new SqlCommand(strSql, sqlCon);

			comando.Parameters.Add("@IdBuscar", SqlDbType.Int).Value=tstBuscar.Text;

			comando.Parameters.Add("@Id", SqlDbType.Int).Value = txtId.Text;
			comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtNome.Text;
			comando.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = txtEndereco.Text;
			comando.Parameters.Add("CEP", SqlDbType.VarChar).Value = mskCep.Text;
			comando.Parameters.Add("Bairro", SqlDbType.VarChar).Value = txtBairro.Text;
			comando.Parameters.Add("Cidade", SqlDbType.VarChar).Value = txtCidade.Text;
			comando.Parameters.Add("UF", SqlDbType.VarChar).Value = txtUf.Text;
			comando.Parameters.Add("Telefone", SqlDbType.VarChar).Value = mskTelefone.Text;

			try
			{
				sqlCon.Open();
				comando.ExecuteNonQuery();
				MessageBox.Show("Cadastro Atualizado!");

			}
			catch(Exception ex) 
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{ 
				sqlCon.Close();
			}

			tsbNovo.Enabled = true;
			tsbSalvar.Enabled = false;
			tsbAlterar.Enabled = false;
			tsbCancelar.Enabled = false;
			tsbExcluir.Enabled = false;
			tstIdBuscar.Enabled = true;
			tsbBuscar.Enabled = true;
			txtId.Enabled = false;
			txtNome.Enabled = false;
			txtEndereco.Enabled = false;
			txtBairro.Enabled = false;
			mskCep.Enabled = false;
			txtCidade.Enabled = false;
			txtUf.Enabled = false;
			mskTelefone.Enabled = false;
			txtNome.Text = "";
			txtEndereco.Text = "";
			txtBairro.Text = "";
			txtCidade.Text = "";
			txtUf.Text = "";
			mskCep.Text = "";
			mskTelefone.Text = "";

		}

		private void tsbExcluir_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Deseja excluir este cadastro?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)==DialogResult.No)
			{
				MessageBox.Show("Cancelado!");
			}

			else
			{
				strSql = "delete from Alunos where Id=@Id";
				sqlCon= new SqlConnection(strSql);
				SqlCommand comando = new SqlCommand(strSql, sqlCon);

				comando.Parameters.Add("@Id", SqlDbType.Int).Value = tstBuscar.Text;
			}

			try
			{
				sqlCon.Open();
				//comando.ExecuteNonQuery();
				MessageBox.Show("Cadastro excluido!");

			}
			catch (Exception ex ) 
			{
				MessageBox.Show(ex.Message);
			}
			finally 
			{
				sqlCon.Close();
			}

			tsbNovo.Enabled = true;
			tsbSalvar.Enabled = false;
			tsbAlterar.Enabled = false;
			tsbCancelar.Enabled = false;
			tsbExcluir.Enabled = false;
			tstIdBuscar.Enabled = true;
			tsbBuscar.Enabled = true;
			txtNome.Enabled = false;
			txtEndereco.Enabled = false;
			txtBairro.Enabled = false;
			mskCep.Enabled = false;
			txtCidade.Enabled = false;
			txtUf.Enabled = false;
			mskTelefone.Enabled = false;
			txtNome.Text = "";
			txtEndereco.Text = "";
			txtBairro.Text = "";
			txtCidade.Text = "";
			txtUf.Text = "";
			mskCep.Text = "";
			mskTelefone.Text = "";
		}

		private void tsbNovo_Click(object sender, EventArgs e)
		{
			tsbNovo.Enabled = false;
			tsbSalvar.Enabled = true;
			tsbAlterar.Enabled = false;
			tsbCancelar.Enabled = true;
			tsbExcluir.Enabled = false;
			tstIdBuscar.Enabled = false;
			tsbBuscar.Enabled = false;
			txtId.Enabled = true;
			txtNome.Enabled = true;
			txtEndereco.Enabled = true;
			txtBairro.Enabled = true;
			mskCep.Enabled = true;
			txtCidade.Enabled = true;
			txtUf.Enabled = true;
			mskTelefone.Enabled = true;
			


		}

		private void tsbCancelar_Click(object sender, EventArgs e)
		{
			tsbNovo.Enabled = true;
			tsbSalvar.Enabled = false;
			tsbAlterar.Enabled = false;
			tsbCancelar.Enabled = false;
			tsbExcluir.Enabled = false;
			tstIdBuscar.Enabled = true;
			tsbBuscar.Enabled = true;
			txtNome.Enabled = false;
			txtEndereco.Enabled = false;
			txtBairro.Enabled = false;
			mskCep.Enabled = false;
			txtCidade.Enabled = false;
			txtUf.Enabled = false;
			mskTelefone.Enabled = false;
			txtId.Enabled = false;
			txtNome.Text = "";
			txtEndereco.Text = "";
			txtBairro.Text = "";
			txtCidade.Text = "";
			txtUf.Text = "";
			mskCep.Text = "";
			mskTelefone.Text = "";
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			tsbNovo.Enabled = true;
			tsbSalvar.Enabled = false;
			tsbAlterar.Enabled = false;
			tsbCancelar.Enabled = false;
			tsbExcluir.Enabled = false;
			tstIdBuscar.Enabled = true;
			tsbBuscar.Enabled = true;
			txtId.Enabled = false;
			txtNome.Enabled = false;
			txtEndereco.Enabled = false;
			txtBairro.Enabled = false;
			mskCep.Enabled = false;
			txtCidade.Enabled = false;
			txtUf.Enabled = false;
			mskTelefone.Enabled = false;

		}

		private void txtNome_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
