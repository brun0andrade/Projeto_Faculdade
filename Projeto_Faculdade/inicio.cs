using System.Collections;
using System.Net.Mail;
using System.Threading;

namespace Projeto_Faculdade
{
    public partial class inicio : Form
    {
        Thread nt;
        

        public inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "12345")
            {
                this.Close();
                nt = new Thread(novoForm);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            else if (textBox1.Text == "user1" && textBox2.Text == "1234")
            {
                this.Close();
                nt = new Thread(novoForm);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            else
            {
                label4.Visible = true;
            }
        }

        private void novoForm(object? obj)
        {
            Application.Run(new tela_admin());
        }
    }
}
