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

namespace DataGridView
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public int daysData;
        public int monthsData;
        public Form1()
        {
            InitializeComponent();
        }
        //Criando a conexão
        SqlConnection con = new SqlConnection(@"Data Source=DELL-E5440\SQLEXPRESS;Initial Catalog=RegistradorGridView;Integrated Security=True");

        private void gpbInfos_Enter(object sender, EventArgs e)
        {
            
        }
        #region Salvar Clicado e testes:
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Testando se está tudo certo com os textos e conectando à database e registrando dos textos nela:
            string dayDataString = txbData.Text.Length <= 2 ? txbData.Text : txbData.Text.Substring(0, 2);
            daysData = Int16.Parse(dayDataString);
            string monthDataString = txbData.Text.Length <= 2 ? txbData.Text : txbData.Text.Substring(0, 2);
            monthsData = Int16.Parse(monthDataString);
            if (txbData.TextLength > 10 || txbData.TextLength < 10 || !txbData.Text.Contains("/") || txbData.Text.Contains("q"))
            {
                MessageBox.Show("Digite uma data válida!!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!txbEmail.Text.Contains("@") || !txbEmail.Text.Contains(".com"))
            {
                MessageBox.Show("Digite um email válido!!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbAge.TextLength >= 3)
            {
                MessageBox.Show("Digite uma idade válida!!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(daysData > 31)
            {
                MessageBox.Show("Digite uma data válida!!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);//Continuar
            }
            else if (monthsData > 12 || monthsData <= 0)
            {
                MessageBox.Show("Digite uma data válida!!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                String query = "INSERT INTO tbl_Insertion (Nome, Idade, Endereço, Email, Telefone, CPF, Data) VALUES('" + txbName.Text + "', '" + txbAge.Text + "', '" + txbAdress.Text + "', '" + txbEmail.Text + "', '" + txbFone.Text + "', '" + txbCPF.Text + "', '" + txbData.Text + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Salvo!!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Zerando as caixas de txts
                txbAdress.Text = "";
                txbFone.Text = "";
                txbEmail.Text = "";
                txbData.Text = "";
                txbCPF.Text = "";
                txbAge.Text = "";
                txbName.Text = "";
            }
            
            
        }
        #endregion
        private void btnView_Click(object sender, EventArgs e)
        {
            //Abrindo os dados do banco de dados e mostrando os na dataGridView
            con.Open();
            String query = "SELECT * FROM tbl_Insertion";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            //Permitindo apenas números
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permitindo apenas letras, barras de espaços e backspaces
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txbName_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        private void txbData_TextChanged(object sender, EventArgs e)
        {
            
            //Adicionando automaticamente as barras da data
            if (txbData.TextLength == 2 || txbData.TextLength == 5)
            {
                txbData.AppendText("/");
            }
        }
        public bool isBackSpace = false;
        private void txbEmail_TextChanged(object sender, EventArgs e)
        {
            //Preenchendo automaticamente o .com dos emails e testando se já foi preenchido ou se está deleteando - os
            var isFilled = false;
            if (txbEmail.Text.Contains("@gmail") || txbEmail.Text.Contains("@hotmail") || txbEmail.Text.Contains("@outlook") || txbEmail.Text.Contains("@yahoo"))
            {
                if (!isBackSpace)
                {
                    if (txbEmail.Text.Contains(".com"))
                    {
                        isFilled = true;
                    }
                    if (!isFilled)
                    {
                        txbEmail.AppendText(".com");
                        
                    }
                }
                
                
            }
            
        }

        private void txbEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            isBackSpace = false;
            if (e.KeyChar == (char)Keys.Back)
            {

                isBackSpace = true;
            }
        }

        private void txbCPF_TextChanged(object sender, EventArgs e)
        {
            
            if(txbCPF.TextLength == 3 || txbCPF.TextLength == 7)
            {
                txbCPF.AppendText(".");
            }
            if(txbCPF.TextLength == 11)
            {
                txbCPF.AppendText("-");
            }
        }

        private void KeyPresssCPF(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
            if(e.KeyChar == (char)Keys.Back)
            {
                txbCPF.Text = "";
            }
        }
    }
}
