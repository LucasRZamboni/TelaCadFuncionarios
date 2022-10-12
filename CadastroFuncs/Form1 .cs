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
            Variaveis.CEP = Convert.ToString(mTB_CEP.Text);
            LocalizarCPF.Localizar();
            tb_cidade.Text = Variaveis.CIDADE;
            tb_bairro.Text = Variaveis.BAIRRO;
            tb_endereço.Text = Variaveis.ENDERECO;
            tb_uf.Text = Variaveis.ESTADO;
            
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
        private bool mover;
        private int cX, cY;
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                mover = false;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                this.Left += e.X - (cX - panel4.Left);
                this.Top += e.Y - (cY - panel4.Top);
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                cX = e.X;
                cY = e.Y;
                mover = true;
            }
        }

    }
}
