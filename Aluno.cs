using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apListaLigada_1_a_4
{
    public class Aluno : IComparable<Aluno>
    {
        // atributos da classe Aluno
        string ra;
        string nome;
        double nota;

        // mapeamento dos campos do arquivo texto de dados de alunos
        const int tamanhoRa = 5,
                  tamanhoNome = 30,
                  tamanhoNota = 4,
                  iniRa = 0,     // RA começa na posição 0 da linha de dados
                  iniNome = iniRa + tamanhoRa,
                  iniNota = iniNome + tamanhoNome;

        // exemplo de linha de dados
        //                                      3
        //   0    5                             5
        //   82362Francisco da Fonseca Rodrigues 6.1

        // Construtores da classe Aluno

        // construtor para ser chamado quando se lê uma linha de dados
        // do arquivo texto e se deseja converter seu conteúdo para
        // uma instância da classe Aluno
        public Aluno(string linhaDeDados)
        {
            Ra = linhaDeDados.Substring(iniRa, tamanhoRa);
            Nome = linhaDeDados.Substring(iniNome, tamanhoNome);
            Nota = double.Parse(linhaDeDados.Substring(iniNota, tamanhoNota));
        }
        public Aluno(string ra, string nome, double nota)
        {
            Ra = ra;
            Nome = nome;
            Nota = nota;
        }

        // propriedades acessadoras
        public string Ra 
        { 
            get => ra;
            set 
            {
                if (value == "")
                    throw new Exception("RA precisa ter um valor.");
                //         copia apenas os 5 primeiros caracteres de value     
                ra = value.PadLeft(tamanhoRa, '0').Substring(0, tamanhoRa);
                                              //  preenche com '0' à esquerda
                                              //  até completar 5 caracteres
            }
        }
        public string Nome 
        { 
            get => nome;
            set
            {
                if (value == "")
                    throw new Exception("Nome precisa ser digitado.");

                          // copia apenas os 30 primeiros caracteres de value     
                nome = value.PadRight(tamanhoNome, ' ').Substring(0, tamanhoNome);
                                                        //  preenche com ' ' à direita
                                                        //  até completar 30 caracteres
            }
        }
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

        public int CompareTo(Aluno outro)
        {
            return this.Ra.CompareTo(outro.Ra);
        }

        public override string ToString()
        {
            return Ra+" "+Nome+" "+Nota;
        }
    }
}
