using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NoListaDupla<Dado> where Dado : IComparable<Dado>, IRegistro
{
  NoListaDupla<Dado> ant;
  Dado info;
  NoListaDupla<Dado> prox;
}

