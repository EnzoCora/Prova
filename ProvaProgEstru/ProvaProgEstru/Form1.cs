using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaProgEstru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string CaminhoCsv = "C:\\Users\\Enzo Corá\\source\\repos\\Prova2\\ProvaProgEstru\\.csv\\usuario";

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string admin = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (admin == "ADMIN" && senha == "123")
            {
                MessageBox.Show($"Bem-Vindo, {admin}!");
                Principal Princip = new Principal();
                this.Hide();
                Princip.Show();
            }
            else 
            {
                string[] linhas = File.ReadAllLines(CaminhoCsv);
                foreach(string linha in linhas)
                {
                    string[] dados = linha.Split(';');
                    if (dados[0] == admin && dados[1] == senha)
                    {
                        MessageBox.Show($"Bem-Vindo, {dados[0]}!");
                        Principal Princip = new Principal();
                        this.Hide();
                        Princip.Show();
                        return;
                    }
                }
            }
        }
    }
}
