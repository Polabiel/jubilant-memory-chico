using System;
using System.Windows.Forms;

public class ListaSimples<Dado> where Dado : IComparable<Dado>
{
    NoLista<Dado> primeiro, ultimo, atual, anterior;

    int quantosNos;

    public ListaSimples()
    {
        primeiro = ultimo = null;
        quantosNos = 0;
    }

    public bool EstaVazia
    {
        get => primeiro == null;

        // get 
        // {
        //    if (primeiro == null)
        //       return true;
        //    return false;
        // }
    }
    public void InserirAposFim(Dado novoDado)
    {
        NoLista<Dado> novoNo = new NoLista<Dado>(novoDado);

        if (EstaVazia)              // caso especial
            primeiro = novoNo;
        else
            ultimo.Prox = novoNo;


        ultimo = novoNo;
        quantosNos++;
    }

    public void InserirAntesDoInicio(Dado novoDado)
    {
        var novoNo = new NoLista<Dado>(novoDado);

        if (EstaVazia)          // se a lista est� vazia, estamos
            ultimo = novoNo;    // incluindo o 1o e o �ltimo n�s!
        else
            novoNo.Prox = primeiro;

        primeiro = novoNo;      // o n� inserido sempre passar� a ser o primeiro n� da lista
        quantosNos++;
    }

    public void ExibirNaTela()
    {
        atual = primeiro;
        while (atual != null)
        {
            Console.WriteLine(atual.Info);
            atual = atual.Prox;
        }
    }

    public void Listar(ListBox oListBox)
    {
        oListBox.Items.Clear(); // limpa o conte�do do listBox
        atual = primeiro;       // posiciona ponteiro no 1o n� da lista
        while (atual != null)   // percorre a lista ligada at� seu final
        {
            oListBox.Items.Add(atual.Info); // exibe os itens da lista ligada no listbox
            atual = atual.Prox;             // avan�a para o n� seguinte
        }
    }

    // exerc�cio 1
    public int ContarNos()
    {
        int contador = 0;
        atual = primeiro;               // posiciona no 1o n� da lista
        while (atual != null)
        {
            contador = contador + 1;    // contador++  ou contador += 1
            atual = atual.Prox;         // avan�a para o n� seguinte
        }
        return contador;
    }

    // exerc�cio 3

    public ListaSimples<Dado> Juntar(ListaSimples<Dado> aOutra)
    {
        var novaLista = new ListaSimples<Dado>();  // jun��o de this com aOutra
        atual = primeiro;  // da lista this
        aOutra.atual = aOutra.primeiro;
        while (atual != null && aOutra.atual != null)
        {
            if (atual.Info.CompareTo(aOutra.atual.Info) < 0)
            {
                novaLista.InserirAposFim(atual.Info);
                atual = atual.Prox;
            }
            else
                if (aOutra.atual.Info.CompareTo(atual.Info) < 0)
                {
                    novaLista.InserirAposFim(aOutra.atual.Info);
                    aOutra.atual = aOutra.atual.Prox;
                }
                else
                {
                    novaLista.InserirAposFim(atual.Info);
                    atual = atual.Prox;
                    aOutra.atual = aOutra.atual.Prox;
                }
        }

        while (atual != null)
        {
            novaLista.InserirAposFim(atual.Info);
            atual = atual.Prox;
        }

        while (aOutra.atual != null)
        {
            novaLista.InserirAposFim(aOutra.atual.Info);
            aOutra.atual = aOutra.atual.Prox;
        }

        return novaLista;
    }

}