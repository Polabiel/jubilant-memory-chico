using System;
using System.Collections.Generic;

public class ListaDupla<Dado> where Dado : IComparable<Dado>, IRegistro
{
  NoListaDupla<Dado> primeiro, ultimo, atual;
  int quantosNos;
}

