using System;
using System.Drawing;
using System.Windows.Forms;

namespace View
{
    public class CadastraFilme : Form
    {
        Label lblNome;
        TextBox txtNome;
        Button btnConfirma;
        Button btnCancela;
        public CadastraFilme()
        {
            int x = 20;
            this.Text = "Cadastra Filme";
            this.BackColor = Color.Beige;

            lblNome = new Label();
            lblNome.Text = "Nome: ";
            lblNome.Location = new Point(x, 20);

            txtNome = new TextBox();
            txtNome.Location = new Point(x, 45);
            txtNome.Size = new Size(180, 20);

            this.Controls.Add(lblNome);
            this.Controls.Add(txtNome);

            this.Size = new Size(300, 400);

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