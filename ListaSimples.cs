using System;
using System.IO;
using System.Windows.Forms;

public class ListaSimples<Dado> where Dado : IComparable<Dado>, IRegistro, 
                                             ICriterioDeSeparacao
{
    NoLista<Dado> primeiro, ultimo, atual, anterior;

    int quantosNos;

    public ListaSimples()
    {
        primeiro = ultimo = atual = anterior = null;
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
    public NoLista<Dado> Atual { get => atual; }
    public NoLista<Dado> Anterior { get => anterior; }

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

    public void InserirAposFim(NoLista<Dado> umNo)
    {
        if (EstaVazia)              // caso especial
            primeiro = umNo;
        else
            ultimo.Prox = umNo;

        ultimo = umNo;
        quantosNos++;
    }

    public void InserirAntesDoInicio(Dado novoDado)
    {
        var novoNo = new NoLista<Dado>(novoDado);

        if (EstaVazia)          // se a lista está vazia, estamos
            ultimo = novoNo;    // incluindo o 1o e o último nós!
        else
            novoNo.Prox = primeiro;

        primeiro = novoNo;      // o nó inserido sempre passará a ser o primeiro nó da lista
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
        oListBox.Items.Clear(); // limpa o conteúdo do listBox
        atual = primeiro;       // posiciona ponteiro no 1o nó da lista
        while (atual != null)   // percorre a lista ligada até seu final
        {
            oListBox.Items.Add(atual.Info); // exibe os itens da lista ligada no listbox
            atual = atual.Prox;             // avança para o nó seguinte
        }
    }

    public bool Existe(Dado procurado)
    {
        atual = primeiro;
        anterior = null;

        // Em seguida, é verificado se a lista está vazia. Caso esteja, é
        // retornado false ao local de chamada, indicando que a chave não foi
        // encontrada, e atual e anterior ficam valendo null

        if (EstaVazia)
            return false;

        // aqui o fluxo vem quando a lista não está vazia

        // dado procurado é menor que o primeiro dado da lista:
        // portanto, dado procurado não existe

        if (procurado.CompareTo(primeiro.Info) < 0)  // não existe
            return false;

        if (procurado.CompareTo(ultimo.Info) > 0)   // não existe
        {
            anterior = ultimo;  // útil para incluir e excluir nós em ordem
            atual = null;
            return false;
        }

        // caso não tenha sido definido que a chave está fora dos limites de 
        // chaves da lista, vamos procurar no seu interior
        // o apontador atual indica o primeiro nó da lista e consideraremos que
        // ainda não achou a chave procurada nem chegamos ao final da lista
        bool achou = false;
        bool fim = false;
        // repete os comandos abaixo enquanto não achou o RA nem chegou ao
        // final da lista
        while (!achou && !fim)
        {
            // se o apontador atual vale null, indica final da lista
            if (atual == null)
                fim = true;
            // se não chegou ao final da lista, verifica o valor da chave atual
            else
            // verifica igualdade entre chave procurada e chave do nó atual
            if (procurado.CompareTo(atual.Info) == 0)
                achou = true;
            else
            // se chave atual é maior que a procurada, significa que
            // a chave procurada não existe na lista ordenada e, assim,
            // termina a pesquisa indicando que não achou. Anterior
            // aponta o anterior ao atual, que foi acessado por
            // último
            if (atual.Info.CompareTo(procurado) > 0)
                fim = true;
            else
            {

                // se não achou a chave procurada nem uma chave > que ela,
                // então a pesquisa continua, de maneira que o apontador
                // anterior deve apontar o nó atual e o apontador atual
                // deve seguir para o nó seguinte
                anterior = atual;
                atual = atual.Prox;
            }
        }
        // por fim, caso a pesquisa tenha terminado, o apontador atual
        // aponta o nó onde está a chave procurada, caso ela tenha sido
        // encontrada, ou o nó onde ela deveria estar para manter a
        // ordenação da lista. O apontador anterior aponta o nó anterior
        // ao atual
        return achou; // devolve o valor da variável achou, que indica
    } // se a chave procurada foi ou não encontrado

    public bool InserirEmOrdem(Dado dados)
    {
      if (Existe(dados)) // Existe configura anterior e atual
         return false;   // já existe, não podemos incluir repetido
     
      // aqui temos certeza de que a chave não existe
      // guarda dados no novo nó
      
      if (EstaVazia) // se a lista está vazia, então o 
        InserirAntesDoInicio(dados); // novo nó é o primeiro da lista
      else
      // testa se nova chave < primeira chave
      if (anterior == null && atual != null)
        InserirAntesDoInicio(dados); // liga novo antes do primeiro
      else
      // caso que ocorre se nova chave > última chave
      if (anterior != null && atual == null)
         InserirAposFim(dados);
      else
        InserirNoMeio(dados); // insere entre os nós anterior e atual
      return true;            // foi inserido na lista, em ordem
    }

    private void InserirNoMeio(Dado dados)
    {
      // Existe() encontrou intervalo de inclusão do novo nó

    // cria um nó para armazenar a informação recebida para incluir
      var novo = new NoLista<Dado>(dados);

      anterior.Prox = novo; // liga anterior ao novo
      novo.Prox = atual;    // e novo no atual

      if (anterior == ultimo) // se incluiu ao final da lista,
         ultimo = novo;       // atualiza o apontador ultimo

      quantosNos++; // incrementa número de nós da lista }
    }

  public bool Remover(Dado dadoARemover)
  {
    if (!Existe(dadoARemover))
       return false;            // não conseguiu excluir porque não existe

    // aqui, sabemos que Existe configurou os ponteiros Anterior e Atual
    if (anterior == null && atual == primeiro)
    {
      primeiro = primeiro.Prox;
      if (primeiro == null)   // esvaziou a lista
        ultimo = null;
    }
    else
    if (atual == ultimo)    // é o último nó
    {
      anterior.Prox = null;
      ultimo = anterior;
    }
    else  // nó interno a excluir
    {
      anterior.Prox = atual.Prox;
    }
    quantosNos--;
    return true;    // indica que excluiu o nó desejado
  }

  public void GravarDados(string nomeDoArquivo)
  {
    var arquivo = new StreamWriter(nomeDoArquivo);
    atual = primeiro;       // posiciona ponteiro no 1o nó da lista
    while (atual != null)   // não chegou no final da lista
    {
      arquivo.WriteLine(atual.Info.FormatoDeArquivo());
      atual = atual.Prox;
    }
    arquivo.Close();
  }

  public void Ordenar()
  {
  }

// exercício 1
    public int ContarNos()
    {
        int contador = 0;
        atual = primeiro;               // posiciona no 1o nó da lista
        while (atual != null)
        {
            contador = contador + 1;    // contador++  ou contador += 1
            atual = atual.Prox;         // avança para o nó seguinte
        }
        return contador;
    }

    // exercicio 2

    public void Separar(ref ListaSimples<Dado> par, 
                        ref ListaSimples<Dado> impar)
    {
        par = new ListaSimples<Dado>();
        impar = new ListaSimples<Dado>();
        atual = primeiro;
        while (atual != null)
        {
            var seguinte = atual.Prox;
            if (atual.Info.DeveSeparar())
                par.InserirAposFim(atual);
            else
                impar.InserirAposFim(atual);
            atual = seguinte;
        }
        par.ultimo.Prox = null;
        impar.ultimo.Prox = null;
    }

    // exercício 3

    public ListaSimples<Dado> Juntar(ListaSimples<Dado> aOutra)
    {
        var novaLista = new ListaSimples<Dado>();  // junção de this com aOutra
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

    // exercício 4

    public void Inverter()
    {
        if (!EstaVazia)     // testar os casos limítrofes ou especiais
        {
            var um = primeiro;
            var dois = primeiro.Prox;
            while (dois != null)
            {
                var tres = dois.Prox;
                dois.Prox = um;
                um = dois;
                dois = tres;
            }
            ultimo = primeiro;
            primeiro.Prox = null;
            primeiro = um;
        }
    }

}