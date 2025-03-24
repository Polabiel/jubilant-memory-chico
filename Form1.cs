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

namespace apListaLigada_1_a_4
{
    public partial class FrmListaLigada : Form
    {
        ListaSimples<Aluno> lista1, lista2;
        public FrmListaLigada()
        {
            InitializeComponent();
        }

        // tratador do evento Load
        // esse evento ocorre quanto o formulário está criado
        // na memória e logo será exibido (antes de ser exibido)
        private void FrmListaLigada_Load(object sender, EventArgs e)
        {
            lista1 = new ListaSimples<Aluno>();
        }

        // esse método será chamado automaticamente quando o usuário
        // clicar no btnIncluir
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtRA.Text != "" && txtNome.Text != "")
            {
                var novoAluno = new Aluno(txtRA.Text, txtNome.Text,
                                            (double)udNota.Value);
                lista1.InserirAposFim(novoAluno);
                lista1.Listar(lsbUm);
            }
        }

        private void FazerLeitura(ref ListaSimples<Aluno> qualLista,
                                  ListBox lsb)
        {
            if (dlgAbrir.ShowDialog() == DialogResult.OK)
            {
                qualLista = new ListaSimples<Aluno>();
                var arquivo = new StreamReader(dlgAbrir.FileName);
                while (!arquivo.EndOfStream)
                {
                    var linhaLida = arquivo.ReadLine();
                    var novoAluno = new Aluno(linhaLida);
                    qualLista.InserirAposFim(novoAluno);
                }
                arquivo.Close();
                qualLista.Listar(lsb);
            }
        }
        private void btnLerArquivo1_Click(object sender, EventArgs e)
        {
            FazerLeitura(ref lista1, lsbUm);
        }

        private void btnLerArquivo2_Click(object sender, EventArgs e)
        {
            FazerLeitura(ref lista2, lsbDois);
        }

        private void btnExercicio3_Click(object sender, EventArgs e)
        {
            var lista3 = lista1.Juntar(lista2);
            lista3.Listar(lsbTres);
        }

        private void btnExercicio1_Click(object sender, EventArgs e)
        {
            if (lista1 != null)
            {
                lbQuantosNos.Text = "Quantos nós: " + lista1.ContarNos();
            }
        }

 
    }
}
