using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroFuncs
{
    public partial class Form1 : Form
    {

       
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)//PESQUISA O CPF 
        {
            if (!string.IsNullOrWhiteSpace(mTB_CEP.Text))
            {
                using (var ws = new WSCorreios.AtendeClienteClient())
                {
                    try
                    {
                        var endereco = ws.consultaCEP(mTB_CEP.Text.Trim());

                        tb_uf.Text = endereco.uf;
                        tb_cidade.Text = endereco.cidade;
                        tb_bairro.Text = endereco.bairro;
                        tb_endereço.Text = endereco.end;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Informe um CEP válido...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)// FECHA O PROGRAMA
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)//LIMPA OS DADOS DO FORMULARIO
        {
            tb_uf.Text = string.Empty;
            tb_cidade.Text = string.Empty;
            tb_bairro.Text = string.Empty;
            tb_endereço.Text = string.Empty;
            mTB_CEP.Text = string.Empty;
            tb_numero.Text = string.Empty;

            tb_id.Text = string.Empty;
            tb_nome.Text = string.Empty;
            tb_sobrenome.Text = string.Empty;
            tb_apelido.Text = string.Empty;
            mTB_RG.Text = string.Empty;
            mTB_CPF.Text = string.Empty;
            mTB_Nascimento.Text = string.Empty;
            mTB_Telefone.Text = string.Empty;
            tb_email.Text = string.Empty;
            mTB_Celular.Text = string.Empty;
            mTB_Recado.Text = string.Empty;
            tb_complemento.Text = string.Empty;

            mTB_admissao.Text = string.Empty;
            mTB_demissao.Text = string.Empty;
            tb_cargo.Text = string.Empty;
            cb_setor.Text = string.Empty;
            mTB_pis.Text = string.Empty;
            mTB_ctps.Text = string.Empty;
            mTB_serie.Text = string.Empty;
            
            mTB_tituloeleitor.Text = string.Empty;

            rTB_obs.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (mTB_CPF.Text != "")
            {
                bt_Alterar.Enabled = false;
                bt_Excluir.Enabled = false;
            }
        }

    }
}
