using System;
using System.Drawing;
using System.Windows.Forms;

namespace CsWinForms
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TelaInicial());
        }
    }
    public class TelaInicial : Form {
        Button btnCadastraCliente;
        Button btnListaClientes;
        Button btnDetalhaCliente;
        Button btnCadastraFilme;
        Button btnListaFilmes;
        Button btnDetalhaFilme;
        Button btnCadastaLocacao;
        Button btnListaLocacoes;
        public TelaInicial(){
            btnCadastraCliente = new Button();
            btnCadastraCliente.Size = new Size(200, 20);
            btnCadastraCliente.Location = new Point(40, 30);
            btnCadastraCliente.Text = "Cadastrar Cliente";
            this.Controls.Add(btnCadastraCliente);
            btnCadastraCliente.Click += new EventHandler(btnCadastraClienteClick);
        }
        private void btnCadastraClienteClick(object sender, EventArgs e)
        {
            CadastraCliente cadastraCliente = new CadastraCliente();
            cadastraCliente.ShowDialog();
        }

    }
    public class CadastraCliente : Form {
        Label lblNome;
        Label lblDtNasc;
        Label lblCpf;
        Label lblDiasDev;
        TextBox txtNome;
        TextBox txtDtNasc;
        TextBox txtCpf;
        TextBox txtDiasDev;
        Button btnConfirma;
        Button btnCancela;
         
        public CadastraCliente(){
            int x = 20;
            this.Text = "BlockBuster";
            this.BackColor = Color.Beige;

            lblNome = new Label();
            lblNome.Text = "Nome: ";
            lblNome.Location = new Point(x,20);
            
            txtNome = new TextBox();
            txtNome.Location = new Point(x,45);
            txtNome.Size = new Size(180,20);

            
            lblDtNasc = new Label();
            lblDtNasc.Text = "Dt. Nasc:";
            lblDtNasc.Location = new Point(x,80);

            txtDtNasc = new TextBox();
            txtDtNasc.Location = new Point(x,105);
            txtDtNasc.Size = new Size(180,20);

            
            lblCpf = new Label();
            lblCpf.Text = "CPF: ";
            lblCpf.Location = new Point(x,140);

            txtCpf = new TextBox();
            txtCpf.Location = new Point(x,165);
            txtCpf.Size = new Size(180,20);

            lblDiasDev = new Label();
            lblDiasDev.Text = "Dias Dev.: ";
            lblDiasDev.Location = new Point(x,200);

            txtDiasDev = new TextBox();
            txtDiasDev.Location = new Point(x,225);
            txtDiasDev.Size = new Size(180,20);

            this.Controls.Add(lblNome);
            this.Controls.Add(txtNome);
            this.Controls.Add(lblDtNasc);
            this.Controls.Add(txtDtNasc);
            this.Controls.Add(lblCpf);
            this.Controls.Add(txtCpf);
            this.Controls.Add(lblDiasDev);
            this.Controls.Add(txtDiasDev);
            this.Size = new Size(300,400);

            btnConfirma = new Button();
            btnConfirma.Size = new Size(80, 20);
            btnConfirma.Location = new Point(x, 270);
            btnConfirma.Text = "Confirma";
            this.Controls.Add(btnConfirma);
            btnConfirma.Click += new EventHandler(btnConfirmaClick);

            btnCancela = new Button();
            btnCancela.Size = new Size(80, 20);
            btnCancela.Location = new Point(x+100, 270);
            btnCancela.Text = "Cancela";
            this.Controls.Add(btnCancela);
            btnCancela.Click += new EventHandler(btnCancelaClick);
        }
    
        private void btnConfirmaClick(object sender, EventArgs e)
        {
            MessageBox.Show("Confirmado!!");
        }

        private void btnCancelaClick(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelado!!");
        }
    }
    public class CadastraFilme : Form {
        Label lblNome;
        Label lblDtNasc;
        Label lblCpf;
        Label lblDiasDev;
        TextBox txtNome;
        TextBox txtDtNasc;
        TextBox txtCpf;
        TextBox txtDiasDev;
        Button btnConfirma;
        Button btnCancela;
         
        public CadastraFilme(){
            int x = 20;
            this.Text = "BlockBuster";
            this.BackColor = Color.Beige;

            lblNome = new Label();
            lblNome.Text = "Nome: ";
            lblNome.Location = new Point(x,20);
            
            txtNome = new TextBox();
            txtNome.Location = new Point(x,45);
            txtNome.Size = new Size(180,20);

            this.Controls.Add(lblNome);
            this.Controls.Add(txtNome);
            
            this.Size = new Size(300,400);

            btnConfirma = new Button();
            btnConfirma.Size = new Size(80, 20);
            btnConfirma.Location = new Point(x, 270);
            btnConfirma.Text = "Confirma";
            this.Controls.Add(btnConfirma);
            btnConfirma.Click += new EventHandler(btnConfirmaClick);

        }
    
        private void btnConfirmaClick(object sender, EventArgs e)
        {
            MessageBox.Show("Confirmado!!");
        }

        private void btnCancelaClick(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelado!!");
        }
    }
}

