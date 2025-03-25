# jubilant-memory-chico
📖 A repository to study a little of what I learned in class (cotuca)
------

### **Visão Geral dos Arquivos**

1. **Aluno.cs**
2. **Form1.cs**
3. **dadosAlunos.txt**
4. **ListaSimples.cs**
5. **NoLista.cs**

### **1. Aluno.cs**

**O que é?**
- Este arquivo define a classe `Aluno`, que representa um aluno com um número de identificação (RA), nome e nota.

**O que faz?**
- Cria objetos `Aluno` que podem ser comparados e convertidos para texto.
- Tem construtores para inicializar um aluno a partir de uma linha de dados ou de valores específicos.
- Define propriedades para acessar e modificar os atributos do aluno (RA, Nome, Nota).

**Código Principal:**
```csharp
public class Aluno : IComparable<Aluno>
{
    string ra;
    string nome;
    double nota;

    public Aluno(string linhaDeDados) { /* inicializa a partir de uma linha de dados */ }
    public Aluno(string ra, string nome, double nota) { /* inicializa com valores específicos */ }

    public string Ra { get; set; }
    public string Nome { get; set; }
    public double Nota { get; set; }

    public int CompareTo(Aluno outro) { /* compara alunos pelo RA */ }
    public override string ToString() { /* converte para string */ }
}
```

### **2. Form1.cs**

**O que é?**
- Este arquivo define a interface gráfica da aplicação (formulário) e como interagir com a lista de alunos.

**O que faz?**
- Inicializa componentes do formulário.
- Define eventos para incluir alunos e ler dados de alunos a partir de um arquivo.
- Manipula listas de alunos utilizando a classe `ListaSimples`.

**Código Principal:**
```csharp
public partial class FrmListaLigada : Form
{
    ListaSimples<Aluno> lista1, lista2;

    public FrmListaLigada() { InitializeComponent(); }

    private void FrmListaLigada_Load(object sender, EventArgs e)
    {
        lista1 = new ListaSimples<Aluno>();
    }

    private void btnIncluir_Click(object sender, EventArgs e)
    {
        // Adiciona um novo aluno à lista
    }

    private void FazerLeitura(ref ListaSimples<Aluno> qualLista, ListBox lsb)
    {
        // Lê dados de alunos a partir de um arquivo
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
```

### **3. dadosAlunos.txt**

**O que é?**
- Um arquivo de texto que contém dados de alunos.

**O que faz?**
- Armazena informações dos alunos em linhas, onde cada linha contém o RA, nome e nota de um aluno.

**Exemplo de Linha:**
```
12345FRANCISCO DA FONSECA RODRIGUES 0,0
```

### **4. ListaSimples.cs**

**O que é?**
- Este arquivo define a classe `ListaSimples`, que representa uma lista ligada simples de qualquer tipo de dado.

**O que faz?**
- Permite inserir dados no início ou no fim da lista.
- Conta quantos nós (itens) tem na lista.
- Exibe a lista na tela ou em um `ListBox`.
- Junta duas listas em uma nova lista.

**Código Principal:**
```csharp
public class ListaSimples<Dado> where Dado : IComparable<Dado>
{
    NoLista<Dado> primeiro, ultimo, atual, anterior;
    int quantosNos;

    public ListaSimples() { /* inicializa a lista vazia */ }

    public bool EstaVazia { get => primeiro == null; }

    public void InserirAposFim(Dado novoDado) { /* insere no final da lista */ }
    public void InserirAntesDoInicio(Dado novoDado) { /* insere no início da lista */ }
    public void ExibirNaTela() { /* exibe a lista no console */ }
    public void Listar(ListBox oListBox) { /* exibe a lista em um ListBox */ }
    public int ContarNos() { /* conta os nós da lista */ }
    public ListaSimples<Dado> Juntar(ListaSimples<Dado> aOutra) { /* junta duas listas */ }
}
```

### **5. NoLista.cs**

**O que é?**
- Este arquivo define a classe `NoLista`, que representa um nó na lista ligada.

**O que faz?**
- Armazena um dado e a referência para o próximo nó na lista.

**Código Principal:**
```csharp
public class NoLista<Dado> where Dado : IComparable<Dado>
{
    Dado info;
    NoLista<Dado> prox;

    public NoLista(Dado info) { this.info = info; this.prox = null; }

    public Dado Info { get => info; set => info = value; }
    public NoLista<Dado> Prox { get => prox; set => prox = value; }
}
```

### **Como Tudo se Conecta?**

1. **Criação de Alunos:**
   - No `Aluno.cs`, definimos o que é um aluno e como ele deve ser criado e manipulado.

2. **Manipulação da Lista:**
   - No `ListaSimples.cs` e `NoLista.cs`, definimos como criar uma lista de alunos e como adicionar, contar e listar alunos.

3. **Interface Gráfica:**
   - No `Form1.cs`, criamos um formulário que permite ao usuário interagir com a lista de alunos, adicionando novos alunos e lendo de um arquivo (`dadosAlunos.txt`).

4. **Dados de Alunos:**
   - No `dadosAlunos.txt`, armazenamos os dados dos alunos que podem ser carregados para a lista por meio da interface gráfica.

### **Resumindo:**
- **Aluno.cs** define o aluno.
- **ListaSimples.cs** e **NoLista.cs** gerenciam a lista de alunos.
- **Form1.cs** permite que o usuário interaja com a lista.
- **dadosAlunos.txt** contém os dados dos alunos.

Espero que isso ajude a entender como esses arquivos trabalham juntos para criar e gerenciar uma lista de alunos! Se precisar de mais alguma coisa, estou à disposição.
### **Resumo das Funções:**
- Inicialização de componentes e listas.
- Manipulação de eventos de clique para inclusão de elementos e leitura de arquivos.
- Contagem e junção de listas ligadas.
