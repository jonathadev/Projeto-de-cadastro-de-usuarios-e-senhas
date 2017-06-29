using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
     
    public partial class FrmCadastroCliente : Form
    {

        string connectionString = @"Server=.\sqlexpress;Database=BDCADASTRO;Trusted_Connection=True;";
        bool novo;


        public FrmCadastroCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            tsbNovo.Enabled = true;
            tsbSalvar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbExcluir.Enabled = false;
            tstId.Enabled = true;
            tsbBuscar.Enabled = true;
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            mskCEP.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtUF.Enabled = false;
            mskTelefone.Enabled = false;
        }

        private void tsbNovo_Click(object sender, EventArgs e)
        {
            tsbNovo.Enabled = false;
            tsbSalvar.Enabled = true;
            tsbCancelar.Enabled = true;
            tsbExcluir.Enabled = false;
            tstId.Enabled = false;
            tsbBuscar.Enabled = false;
            txtNome.Enabled = true;
            txtEndereco.Enabled = true;
            mskCEP.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtUF.Enabled = true;
            mskTelefone.Enabled = true;
            txtNome.Focus();
            novo = true;
        }

        private void tsbSalvar_Click(object sender, EventArgs e)
        {
            if (novo)
              {
                string sql = "INSERT INTO CLIENTE (ID, NOME,ENDERECO,CEP,BAIRRO,CIDADE,UF,TELEFONE) "
                + "VALUES ('" + txtId.Text + "', '" + txtNome.Text + "', '" + txtEndereco.Text + "', '" 
                + mskCEP.Text + "', '" + txtBairro.Text
                + "', '" + txtCidade.Text + "', '" + txtUF.Text + "', '" 
                + mskTelefone.Text + "')";
              
                  SqlConnection con = new SqlConnection(connectionString);
                  SqlCommand cmd = new SqlCommand(sql, con);
                  cmd.CommandType = CommandType.Text;
                  con.Open();
                  try
                  {
                      int i = cmd.ExecuteNonQuery();
                      if (i > 0)
                          MessageBox.Show("Cadastro realizado com sucesso!");
                  }
                  catch (Exception ex)
                  {
                      MessageBox.Show("Erro: " + ex.ToString());
                  }
                  finally
                  {
                      con.Close();
                  }
              }
              else
              {
                string sql = "UPDATE CLIENTE SET NOME='" + txtNome.Text + "', ENDERECO='" + txtEndereco.Text + "', " +
                 "CEP='" + mskCEP.Text + "', BAIRRO='" + txtBairro.Text + "', CIDADE='" + txtCidade.Text + "', " +
                 "UF='" + txtUF.Text + "', TELEFONE='" + mskTelefone.Text + "'";
   
                  SqlConnection con = new SqlConnection(connectionString);
                  SqlCommand cmd = new SqlCommand(sql, con);
                  cmd.CommandType = CommandType.Text;
                  con.Open();
                  try
                  {
                      int i = cmd.ExecuteNonQuery();
                      if (i > 0)
                          MessageBox.Show("Cadastro atualizado com sucesso!");
                  }
                  catch (Exception ex)
                  {
                      MessageBox.Show("Erro: " + ex.ToString());
                  }
                  finally
                  {
                      con.Close();
                  }
              }
   
              tsbNovo.Enabled = true;
              tsbSalvar.Enabled = false;
              tsbCancelar.Enabled = false;
              tsbExcluir.Enabled = false;
              tstId.Enabled = true;
              tsbBuscar.Enabled = true;
              txtNome.Enabled = false;
              txtEndereco.Enabled = false;
              mskCEP.Enabled = false;
              txtBairro.Enabled = false;
              txtCidade.Enabled = false;
              txtUF.Enabled = false;
              mskTelefone.Enabled = false;
              txtId.Text = "";
              txtNome.Text = "";
              txtEndereco.Text = "";
              mskCEP.Text = "";
              txtBairro.Text = "";
              txtCidade.Text = "";
              txtUF.Text = "";
              mskTelefone.Text = "";
   
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
           
              tsbNovo.Enabled = true;
              tsbSalvar.Enabled = false;
              tsbCancelar.Enabled = false;
              tsbExcluir.Enabled = false;
              tstId.Enabled = true;
              tsbBuscar.Enabled = true;
              txtNome.Enabled = false;
              txtEndereco.Enabled = false;
              mskCEP.Enabled = false;
              txtBairro.Enabled = false;
              txtCidade.Enabled = false;
              txtUF.Enabled = false;
              mskTelefone.Enabled = false;
              txtId.Text = "";
              txtNome.Text = "";
              txtEndereco.Text = "";
              mskCEP.Text = "";
              txtBairro.Text = "";
              txtCidade.Text = "";
              txtUF.Text = "";
              mskTelefone.Text = "";
   
          
        }

        private void tsbExcluir_Click(object sender, EventArgs e)
        {
            
   
              string sql = "DELETE FROM CLIENTE WHERE ID=" + txtId.Text;
   
              SqlConnection con = new SqlConnection(connectionString);
              SqlCommand cmd = new SqlCommand(sql, con);
              cmd.CommandType = CommandType.Text;
              con.Open();
   
              try
              {
                  int i = cmd.ExecuteNonQuery();
                  if (i > 0)
                      MessageBox.Show("Registro excluído com sucesso!");
              }
              catch (Exception ex)
              {
                  MessageBox.Show("Erro: " + ex.ToString());
              }
              finally
              {
                  con.Close();
              }
              
              tsbNovo.Enabled = true;
              tsbSalvar.Enabled = false;
              tsbCancelar.Enabled = false;
              tsbExcluir.Enabled = false;
              tstId.Enabled = true;
              tsbBuscar.Enabled = true;
              txtNome.Enabled = false;
              txtEndereco.Enabled = false;
              mskCEP.Enabled = false;
              txtBairro.Enabled = false;
              txtCidade.Enabled = false;
              txtUF.Enabled = false;
              mskTelefone.Enabled = false;
              txtId.Text = "";
              txtNome.Text = "";
              txtEndereco.Text = "";
              mskCEP.Text = "";
              txtBairro.Text = "";
              txtCidade.Text = "";
              txtUF.Text = "";
              mskTelefone.Text = "";
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
             
              string sql = "SELECT * FROM CLIENTE WHERE ID=" + tstId.Text;
   
              SqlConnection con = new SqlConnection(connectionString);
              SqlCommand cmd = new SqlCommand(sql, con);
              cmd.CommandType = CommandType.Text;
              SqlDataReader reader;
              con.Open();
   
              try
              {
                  reader = cmd.ExecuteReader();
                  if (reader.Read())
                  {
                      tsbNovo.Enabled = false;
                      tsbSalvar.Enabled = true;
                      tsbCancelar.Enabled = true;
                      tsbExcluir.Enabled = true;
                      tstId.Enabled = false;
                      tsbBuscar.Enabled = false;
                      txtNome.Enabled = true;
                      txtEndereco.Enabled = true;
                      mskCEP.Enabled = true;
                      txtBairro.Enabled = true;
                      txtCidade.Enabled = true;
                      txtUF.Enabled = true;
                      mskTelefone.Enabled = true;
                      txtNome.Focus();
                      txtId.Text = reader[0].ToString();
                      txtNome.Text = reader[1].ToString();
                      txtEndereco.Text = reader[2].ToString();
                      mskCEP.Text = reader[3].ToString();
                      txtBairro.Text = reader[4].ToString();
                      txtCidade.Text = reader[5].ToString();
                      txtUF.Text = reader[6].ToString();
                      mskTelefone.Text = reader[7].ToString();
                      novo = false;
                  }
                  else
                      MessageBox.Show("Nenhum registro encontrado com o Id informado!");
   
              }
              catch (Exception ex)
              {
                  MessageBox.Show("Erro: " + ex.ToString());
              }
              finally
              {
                  con.Close();
              }
   
              tstId.Text = "";
        }

    }
}
