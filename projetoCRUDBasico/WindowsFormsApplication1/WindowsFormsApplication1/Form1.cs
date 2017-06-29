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
           
        }

        private void tsbNovo_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtNome.Text = "";

            txtId.Focus();
            novo = true;
        }

        private void tsbSalvar_Click(object sender, EventArgs e)
        {
            if (novo)
              {
                string sql = "INSERT INTO CLIENTE (ID, NOME) "
                + "VALUES ('" + txtId.Text + "', '" + txtNome.Text + "')";
              
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
                string sql = "UPDATE CLIENTE SET NOME='" + txtNome.Text +  "'";
   
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

              txtId.Text = "";
              txtNome.Text = "";

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
                     

                      txtNome.Focus();
                      txtId.Text = reader[0].ToString();
                      txtNome.Text = reader[1].ToString();
                  
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
