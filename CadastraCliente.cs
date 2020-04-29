using System;
using System.Drawing;
using System.Windows.Forms;

namespace CsWinForms
{
    public class CadastraCliente : Form
    {
        Label lblNome;
        Label lblDtNasc;
        Label lblCpf;
        Label lblDiasDev;
        TextBox txtNome;
        TextBox txtDtNasc;
        TextBox txtCpf;
        ComboBox cbDiasDev;
        CheckBox chbAtivo;
        GroupBox gbGenero;
        RadioButton rbSexoMasc;
        RadioButton rbSexoFem;
        Button btnConfirma;
        Button btnCancela;
        public CadastraCliente()
        {
            int x = 20;
            this.Text = "Cadastra Cliente";
            this.BackColor = Color.Beige;

            lblNome = new Label();
            lblNome.Text = "Nome: ";
            lblNome.Location = new Point(x, 20);

            txtNome = new TextBox();
            txtNome.Location = new Point(130, 20);
            txtNome.Size = new Size(110, 20);

            lblDtNasc = new Label();
            lblDtNasc.Text = "Dt. Nasc:";
            lblDtNasc.Location = new Point(x, 50);

            txtDtNasc = new TextBox();
            txtDtNasc.Location = new Point(130, 50);
            txtDtNasc.Size = new Size(110, 20);

            lblCpf = new Label();
            lblCpf.Text = "CPF: ";
            lblCpf.Location = new Point(x, 80);

            txtCpf = new TextBox();
            txtCpf.Location = new Point(130, 80);
            txtCpf.Size = new Size(110, 20);

            lblDiasDev = new Label();
            lblDiasDev.Text = "Dias Dev.: ";
            lblDiasDev.Location = new Point(x, 110);

            cbDiasDev = new ComboBox();
            cbDiasDev.Items.Add("05");
            cbDiasDev.Items.Add("10");
            cbDiasDev.Items.Add("15");
            cbDiasDev.Items.Add("20");
            cbDiasDev.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbDiasDev.Location = new Point(130, 110);
            cbDiasDev.Size = new Size(110, 20);
            cbDiasDev.Sorted = true;

            chbAtivo = new CheckBox();
            chbAtivo.Location = new Point (130,140);
            chbAtivo.Size = new Size (110,20);
            chbAtivo.Text = "Ativo?";

            gbGenero = new GroupBox();
            gbGenero.Location = new Point (130,170);
            gbGenero.Size = new Size (110,80);
            gbGenero.Text = "Genero";

            rbSexoMasc = new RadioButton();
            rbSexoMasc.Location = new Point(5,20);
            rbSexoMasc.Size = new Size (110,20);
            rbSexoMasc.Text = "Masculino";

            rbSexoFem = new RadioButton();
            rbSexoFem.Location = new Point(5,50);
            rbSexoFem.Size = new Size (110,20);
            rbSexoFem.Text = "Feminino";

            gbGenero.Controls.Add(rbSexoMasc);
            gbGenero.Controls.Add(rbSexoFem);

            this.Controls.Add(lblNome);
            this.Controls.Add(txtNome);
            this.Controls.Add(lblDtNasc);
            this.Controls.Add(txtDtNasc);
            this.Controls.Add(lblCpf);
            this.Controls.Add(txtCpf);
            this.Controls.Add(lblDiasDev);
            this.Controls.Add(cbDiasDev);
            this.Controls.Add(chbAtivo);
            this.Controls.Add(gbGenero);
            this.Size = new Size(300, 400);

            btnConfirma = new Button();
            btnConfirma.Size = new Size(80, 20);
            btnConfirma.Location = new Point(x, 270);
            btnConfirma.Text = "Confirma";
            this.Controls.Add(btnConfirma);
            btnConfirma.Click += new EventHandler(btnConfirmaClick);

            btnCancela = new Button();
            btnCancela.Size = new Size(80, 20);
            btnCancela.Location = new Point(x + 100, 270);
            btnCancela.Text = "Cancela";
            this.Controls.Add(btnCancela);
            btnCancela.Click += new EventHandler(btnCancelaClick);
        }
        private void btnConfirmaClick(object sender, EventArgs e)
        {
            MessageBox.Show(
                $"Nome: {this.txtNome.Text}\n" +
                $"Data Nasc: {this.txtDtNasc.Text}\n" +
                $"CPF: {this.txtDtNasc.Text}\n" +
                $"DiasDev: {this.cbDiasDev.Text}",
                "Cliente",
                MessageBoxButtons.OK
            );
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