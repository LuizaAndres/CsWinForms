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
        Label lblTitulo;
        Button btnCadastraCliente;
        Button btnListaClientes;
        Button btnDetalhaCliente;
        Button btnCadastraFilme;
        Button btnListaFilmes;
        Button btnDetalhaFilme;
        Button btnCadastaLocacao;
        Button btnListaLocacoes;
        Button btnSair;
        public TelaInicial(){
            this.Text = "BlockBuster";
            this.BackColor = Color.Beige;
            this.Size = new Size(300,400);

            lblTitulo = new Label();
            lblTitulo.Text = "Blockbuster";
            lblTitulo.Width = 100;
            lblTitulo.Left = (this.Width - lblTitulo.Width) / 2;
            this.Controls.Add(lblTitulo);
            
            btnCadastraCliente = new Button();
            btnCadastraCliente.Size = new Size(200, 20);
            btnCadastraCliente.Location = new Point(40, 30);
            btnCadastraCliente.Text = "Cadastrar Cliente";
            this.Controls.Add(btnCadastraCliente);
            btnCadastraCliente.Click += new EventHandler(btnCadastraClienteClick);

            btnListaClientes = new Button();
            btnListaClientes.Size = new Size(200, 20);
            btnListaClientes.Location = new Point(40, 60);
            btnListaClientes.Text = "Listar Clientes";
            this.Controls.Add(btnListaClientes);
            btnListaClientes.Click += new EventHandler(btnListaClientesClick);

            btnDetalhaCliente = new Button();
            btnDetalhaCliente.Size = new Size(200, 20);
            btnDetalhaCliente.Location = new Point(40, 90);
            btnDetalhaCliente.Text = "Detalha clientes";
            this.Controls.Add(btnDetalhaCliente);
            btnDetalhaCliente.Click += new EventHandler(DetalhaClienteClick);

            btnCadastraFilme = new Button();
            btnCadastraFilme.Size = new Size(200, 20);
            btnCadastraFilme.Location = new Point(40, 120);
            btnCadastraFilme.Text = "Cadastra Filme";
            this.Controls.Add(btnCadastraFilme);
            btnCadastraFilme.Click += new EventHandler(CadastraFilmeClick);

            btnListaFilmes = new Button();
            btnListaFilmes.Size = new Size(200, 20);
            btnListaFilmes.Location = new Point(40, 150);
            btnListaFilmes.Text = "Lista de Filmes";
            this.Controls.Add(btnListaFilmes);
            //btnListaFilmes.Click += new EventHandler(btnListaFilmesClick);

            btnDetalhaFilme = new Button();
            btnDetalhaFilme.Size = new Size(200, 20);
            btnDetalhaFilme.Location = new Point(40, 180);
            btnDetalhaFilme.Text = "Detalha Filme";
            this.Controls.Add(btnDetalhaFilme);
            //btnDetalhaFilme.Click += new EventHandler(btnDetalhaFilmeClick);

            btnCadastaLocacao = new Button();
            btnCadastaLocacao.Size = new Size(200, 20);
            btnCadastaLocacao.Location = new Point(40, 210);
            btnCadastaLocacao.Text = "Cadastar Locação";
            this.Controls.Add(btnCadastaLocacao);
            //btnCadastaLocacao.Click += new EventHandler(btnCadastaLocacaoClick);

            btnListaLocacoes = new Button();
            btnListaLocacoes.Size = new Size(200, 20);
            btnListaLocacoes.Location = new Point(40, 240);
            btnListaLocacoes.Text = "Todas as locações";
            this.Controls.Add(btnListaLocacoes);
            //btnListaLocacoes.Click += new EventHandler(btnListaLocacoesClick);

            btnSair = new Button();
            btnSair.Size = new Size(200, 20);
            btnSair.Location = new Point(40, 270);
            btnSair.Text = "Sair";
            this.Controls.Add(btnSair);
            btnSair.Click += new EventHandler(btnSairClick);
            
        }
        private void btnSairClick(object sender, EventArgs e)
        {
            this.Hide();
            Application.Exit();
            
        }
        private void btnCadastraClienteClick(object sender, EventArgs e)
        {
            this.Hide();
            CadastraCliente cadastraCliente = new CadastraCliente();
            cadastraCliente.Show();
            
        }
        private void btnListaClientesClick(object sender, EventArgs e)
        {
            this.Hide();
            ListaClientes listaClientes = new ListaClientes();
            listaClientes.Show();
            
        }
        private void CadastraFilmeClick(object sender, EventArgs e)
        {
            this.Hide();
            CadastraFilme CadastraFilmeClick = new CadastraFilme();
            CadastraFilmeClick.Show();
        }
         private void DetalhaClienteClick(object sender, EventArgs e)
        {
            this.Hide();
            DetalhaCliente DetalhaClienteClick = new DetalhaCliente();
            DetalhaClienteClick.Show();
        }
    }
    
    public class CadastraFilme : Form {
        Label lblNome;
        TextBox txtNome;
        Button btnConfirma;
        Button btnCancela;
        public CadastraFilme(){
            int x = 20;
            this.Text = "Cadastra Filme";
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
            btnConfirma.Location = new Point(20, 270);
            btnConfirma.Text = "Confirma";
            this.Controls.Add(btnConfirma);
            btnConfirma.Click += new EventHandler(btnConfirmaClick);

            btnCancela = new Button();
            btnCancela.Size = new Size(80, 20);
            btnCancela.Location = new Point(120, 270);
            btnCancela.Text = "Cancela";
            this.Controls.Add(btnCancela);
            btnCancela.Click += new EventHandler(btnCancelaClick);
        }
        private void btnConfirmaClick(object sender, EventArgs e)
        {
            MessageBox.Show("Confirmado!!");
            this.Close();
            TelaInicial telaInicial = new TelaInicial();
            telaInicial.Show();
        }
        private void btnCancelaClick(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelado!!");
            this.Close();
            TelaInicial telaInicial = new TelaInicial();
            telaInicial.Show();
        }
    }
public class ListaClientes : Form {
        Button btnConfirma;
        Button btnCancela;
        public ListaClientes(){
            this.Text = "Lista Cliente";
            this.BackColor = Color.Beige;
            this.Size = new Size(300,400);

            btnConfirma = new Button();
            btnConfirma.Size = new Size(80, 20);
            btnConfirma.Location = new Point(20, 270);
            btnConfirma.Text = "Confirma";
            this.Controls.Add(btnConfirma);
            btnConfirma.Click += new EventHandler(btnConfirmaClick);

            btnCancela = new Button();
            btnCancela.Size = new Size(80, 20);
            btnCancela.Location = new Point(120, 270);
            btnCancela.Text = "Cancela";
            this.Controls.Add(btnCancela);
            btnCancela.Click += new EventHandler(btnCancelaClick);
        }
        private void btnConfirmaClick(object sender, EventArgs e)
        {
            MessageBox.Show("Confirmado!!");
            this.Close();
            TelaInicial telaInicial = new TelaInicial();
            telaInicial.Show();
        }
        private void btnCancelaClick(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelado!!");
            this.Close();
            TelaInicial telaInicial = new TelaInicial();
            telaInicial.Show();
        }
    }
    public class DetalhaCliente : Form {
        Button btnConfirma;
        Button btnCancela;
        public DetalhaCliente(){
            this.Text = "Cliente";
            this.BackColor = Color.Beige;
            this.Size = new Size(300,400);

            btnConfirma = new Button();
            btnConfirma.Size = new Size(80, 20);
            btnConfirma.Location = new Point(20, 270);
            btnConfirma.Text = "Confirma";
            this.Controls.Add(btnConfirma);
            btnConfirma.Click += new EventHandler(btnConfirmaClick);

            btnCancela = new Button();
            btnCancela.Size = new Size(80, 20);
            btnCancela.Location = new Point(120, 270);
            btnCancela.Text = "Cancela";
            this.Controls.Add(btnCancela);
            btnCancela.Click += new EventHandler(btnCancelaClick);
        }
        private void btnConfirmaClick(object sender, EventArgs e)
        {
            MessageBox.Show("Confirmado!!");
            this.Close();
            TelaInicial telaInicial = new TelaInicial();
            telaInicial.Show();
        }
        private void btnCancelaClick(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelado!!");
            this.Close();
            TelaInicial telaInicial = new TelaInicial();
            telaInicial.Show();
        }
    }
}

