using System;
using System.Windows.Forms;

namespace VerificaCaratere
{
    public partial class Form1 : Form
    {
        char entrada;
        int valor;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            entrada = Convert.ToChar(txtCaractere.Text);
            valor = Convert.ToInt32(entrada);
            if (!string.IsNullOrEmpty(txtCaractere.Text))
            {
                //Verificando os caracteres através da tabela ASCII.
                if (valor >= 65 && valor <= 90)
                {
                    lblResultado.Text = "String Maiúscula";
                }
                if (valor >= 97 && valor <= 122)
                {
                    lblResultado.Text = "String Minúscula";
                }
                if (valor >= 48 && valor <= 57)
                {
                    lblResultado.Text = "Dígito";
                }
                if (valor == 0 && valor <= 47 || valor >= 58 && valor <= 64 || valor >= 91 && valor <= 96
                    || valor >= 123 && valor <= 127)
                {
                    lblResultado.Text = "Símbolo Especial";
                }
                if (valor >= 127)
                {
                    lblResultado.Text = "Caractere Especial";
                }
            }
            else
            {
                MessageBox.Show("Preenche o campo antes de clicar em verificar.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
