using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroFuncs
{
    internal class LocalizarCPF
    {

        public static void Localizar()
        {
            if (!string.IsNullOrWhiteSpace(Variaveis.CEP))
            {
                using (var ws = new WSCorreios.AtendeClienteClient())
                {
                    try
                    {
                        var endereco = ws.consultaCEP(Variaveis.CEP.Trim());

                        Variaveis.ESTADO = endereco.uf;
                        Variaveis.CIDADE = endereco.cidade;
                        Variaveis.BAIRRO = endereco.bairro;
                        Variaveis.ENDERECO = endereco.end;
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Informe um CEP válido...", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
