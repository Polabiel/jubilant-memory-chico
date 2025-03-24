# jubilant-memory-chico
📖 A repository to study a little of what I learned in class (cotuca)
------

O arquivo `Aluno.cs` define uma classe `Aluno` dentro do namespace `apListaLigada_1_a_4`. Aqui está uma explicação detalhada do conteúdo:

### Definições e Atributos
- **Namespace e Usings**: A classe está dentro do namespace `apListaLigada_1_a_4` e utiliza várias bibliotecas do .NET (`System`, `System.Collections.Generic`, etc.).
- **Atributos da Classe**: A classe `Aluno` possui três atributos privados:
  - `string ra` - Registro Acadêmico.
  - `string nome` - Nome do aluno.
  - `double nota` - Nota do aluno.

### Constantes
- **Constantes para Mapeamento**: A classe define várias constantes para mapear os campos de um arquivo texto de dados de alunos:
  - `tamanhoRa`, `tamanhoNome`, `tamanhoNota` - Tamanhos dos campos.
  - `iniRa`, `iniNome`, `iniNota` - Posições iniciais dos campos na linha de dados.

### Construtores
- **Construtor com Linha de Dados**: Constrói um objeto `Aluno` a partir de uma linha de dados do arquivo texto.
  ```csharp
  public Aluno(string linhaDeDados)
  {
      Ra = linhaDeDados.Substring(iniRa, tamanhoRa);
      Nome = linhaDeDados.Substring(iniNome, tamanhoNome);
      Nota = double.Parse(linhaDeDados.Substring(iniNota, tamanhoNota));
  }
  ```
- **Construtor com Parâmetros**: Constrói um objeto `Aluno` a partir de valores individuais.
  ```csharp
  public Aluno(string ra, string nome, double nota)
  {
      Ra = ra;
      Nome = nome;
      Nota = nota;
  }
  ```

### Propriedades
- **Propriedade `Ra`**: Garante que o RA tenha exatamente 5 caracteres, preenchendo com zeros à esquerda se necessário.
  ```csharp
  public string Ra 
  { 
      get => ra;
      set 
      {
          if (value == "")
              throw new Exception("RA precisa ter um valor.");
          ra = value.PadLeft(tamanhoRa, '0').Substring(0, tamanhoRa);
      }
  }
  ```
- **Propriedade `Nome`**: Garante que o nome tenha exatamente 30 caracteres, preenchendo com espaços à direita se necessário.
  ```csharp
  public string Nome 
  { 
      get => nome;
      set
      {
          if (value == "")
              throw new Exception("Nome precisa ser digitado.");
          nome = value.PadRight(tamanhoNome, ' ').Substring(0, tamanhoNome);
      }
  }
  ```
- **Propriedade `Nota`**: Valida que a nota esteja entre 0 e 10.
  ```csharp
  public double Nota 
  { 
      get => nota;
      set
      {
          if (value < 0 || value > 10)
              throw new Exception("Nota inválida!");
          nota = value;
      }
  }
  ```

### Métodos
- **CompareTo**: Implementa a interface `IComparable<Aluno>` para comparar alunos pelo RA.
  ```csharp
  public int CompareTo(Aluno outro)
  {
      return this.Ra.CompareTo(outro.Ra);
  }
  ```
- **ToString**: Sobrescreve o método `ToString` para retornar uma representação textual do aluno.
  ```csharp
  public override string ToString()
  {
      return Ra + " " + Nome + " " + Nota;
  }
  ```

### Resumo
A classe `Aluno` é usada para representar dados de alunos, incluindo métodos para construir instâncias a partir de linhas de texto e para garantir que os dados estejam no formato correto.

--------

Aqui está uma explicação detalhada do arquivo `Form1.cs` e das funções que ele contém:

### **Descrição do Arquivo:**
Este arquivo contém a implementação de uma aplicação Windows Forms em C#. A aplicação é voltada para a manipulação de uma lista ligada de objetos do tipo `Aluno`.

### **Funções e Sua Descrição:**

1. **FrmListaLigada()**
   - **Localização:** Linha 17
   - **Descrição:** Construtor da classe `FrmListaLigada`. Inicializa os componentes do formulário.
   - **Código:**
     ```csharp
     public FrmListaLigada()
     {
         InitializeComponent();
     }
     ```

2. **FrmListaLigada_Load(object sender, EventArgs e)**
   - **Localização:** Linha 25
   - **Descrição:** Tratador do evento `Load`, que é acionado quando o formulário está sendo carregado. Inicializa a lista `lista1`.
   - **Código:**
     ```csharp
     private void FrmListaLigada_Load(object sender, EventArgs e)
     {
         lista1 = new ListaSimples<Aluno>();
     }
     ```

3. **btnIncluir_Click(object sender, EventArgs e)**
   - **Localização:** Linha 32
   - **Descrição:** Tratador do evento `Click` do botão `btnIncluir`. Adiciona um novo aluno à lista `lista1` e atualiza a visualização na `ListBox`.
   - **Código:**
     ```csharp
     private void btnIncluir_Click(object sender, EventArgs e)
     {
         if (txtRA.Text != "" && txtNome.Text != "")
         {
             var novoAluno = new Aluno(txtRA.Text, txtNome.Text, (double)udNota.Value);
             lista1.InserirAposFim(novoAluno);
             lista1.Listar(lsbUm);
         }
     }
     ```

4. **FazerLeitura(ref ListaSimples<Aluno> qualLista, ListBox lsb)**
   - **Localização:** Linha 43
   - **Descrição:** Realiza a leitura de um arquivo selecionado pelo usuário e popula a lista passada por referência (`qualLista`).
   - **Código:**
     ```csharp
     private void FazerLeitura(ref ListaSimples<Aluno> qualLista, ListBox lsb)
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
     ```

5. **btnLerArquivo1_Click(object sender, EventArgs e)**
   - **Localização:** Linha 60
   - **Descrição:** Tratador do evento `Click` do botão `btnLerArquivo1`. Chama a função `FazerLeitura` para ler um arquivo e popular a lista `lista1`.
   - **Código:**
     ```csharp
     private void btnLerArquivo1_Click(object sender, EventArgs e)
     {
         FazerLeitura(ref lista1, lsbUm);
     }
     ```

6. **btnLerArquivo2_Click(object sender, EventArgs e)**
   - **Localização:** Linha 65
   - **Descrição:** Tratador do evento `Click` do botão `btnLerArquivo2`. Chama a função `FazerLeitura` para ler um arquivo e popular a lista `lista2`.
   - **Código:**
     ```csharp
     private void btnLerArquivo2_Click(object sender, EventArgs e)
     {
         FazerLeitura(ref lista2, lsbDois);
     }
     ```

7. **btnExercicio3_Click(object sender, EventArgs e)**
   - **Localização:** Linha 70
   - **Descrição:** Tratador do evento `Click` do botão `btnExercicio3`. Junta as listas `lista1` e `lista2` e exibe a lista resultante na `ListBox`.
   - **Código:**
     ```csharp
     private void btnExercicio3_Click(object sender, EventArgs e)
     {
         var lista3 = lista1.Juntar(lista2);
         lista3.Listar(lsbTres);
     }
     ```

8. **btnExercicio1_Click(object sender, EventArgs e)**
   - **Localização:** Linha 76
   - **Descrição:** Tratador do evento `Click` do botão `btnExercicio1`. Conta e exibe o número de nós na lista `lista1`.
   - **Código:**
     ```csharp
     private void btnExercicio1_Click(object sender, EventArgs e)
     {
         if (lista1 != null)
         {
             lbQuantosNos.Text = "Quantos nós: " + lista1.ContarNos();
         }
     }
     ```

### **Resumo das Funções:**
- Inicialização de componentes e listas.
- Manipulação de eventos de clique para inclusão de elementos e leitura de arquivos.
- Contagem e junção de listas ligadas.
