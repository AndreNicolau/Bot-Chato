using System;
using System.Windows.Forms;

namespace Bot_Chato
{
    public partial class Form1 : Form
    {
        int duration = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            duration = 10;
            timer1.Start();
            
        }

        private void count_down(object sender, EventArgs e)
        {
            if (duration == 0)
            {
                timer1.Stop();

                string mensagem = txtMensagem.Text;
                int numeroMensagens = Convert.ToInt32(numEnviar.Value);
                int contador = 0;

                while (contador < numeroMensagens)
                {
                    SendKeys.SendWait(mensagem);
                    SendKeys.Send("{ENTER}");
                    contador++;
                    lblMensagensEnviadas.Text = contador.ToString();
                }
            }
            else if (duration > 0)
            {
                duration--;
                lblContagem.Text = duration.ToString();
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
