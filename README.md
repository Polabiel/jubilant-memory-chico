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
