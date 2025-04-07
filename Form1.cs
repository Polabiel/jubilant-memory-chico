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
                lista1.InserirEmOrdem(novoAluno);
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
                    string[] palavrasLidas = linhaLida.Split(' ');
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

        private void btnExercicio4_Click(object sender, EventArgs e)
        {
            lista1.Listar(lsbUm);
            lista1.Inverter();
            lista1.Listar(lsbDois);
        }

        private void btnExercicio2_Click(object sender, EventArgs e)
        {
            lista1.Listar(lsbUm);
            ListaSimples<Aluno> pares = null, impares = null;
            lista1.Separar(ref pares, ref impares);
            pares.Listar(lsbDois);
            impares.Listar(lsbTres);
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            if (txtRA.Text != "")
            {
                var alunoAProcurar = new Aluno(txtRA.Text, "-", 0);
                if (lista1.Existe(alunoAProcurar)) // ajusta o ponteiro atual da lista
                {
                    var alunoEncontrado = lista1.Atual.Info;
                    txtNome.Text = alunoEncontrado.Nome;
                    udNota.Value = Convert.ToDecimal(alunoEncontrado.Nota);
                }
                else
                    MessageBox.Show("RA não encontrado!");
            }
        }

    private void btnExcluir_Click(object sender, EventArgs e)
    {
      if (txtRA.Text != "" && lista1 != null)
      {
        var alunoAProcurar = new Aluno(txtRA.Text, "-", 0);
        if (lista1.Remover(alunoAProcurar))
          MessageBox.Show("Aluno removido!");
        else
          MessageBox.Show("RA não encontrado!");
      }
    }

    // executa quando o usuário finaliza o programa
    private void FrmListaLigada_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (dlgSalvar.ShowDialog() == DialogResult.OK)
      {
        lista1.GravarDados(dlgSalvar.FileName);
      }
    }

    private void btnOrdenar_Click(object sender, EventArgs e)
    {
      lista1.Ordenar();
      lista1.Listar(lsbUm);
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
