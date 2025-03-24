using System;

public class NoLista<Dado> where Dado : IComparable<Dado>
{
    Dado info;
    NoLista<Dado> prox;

    public NoLista(Dado info) 
    {
        this.info = info;
        this.prox = null;
    }

    public Dado Info 
    { 
        get => info; 
        set => info = value; 
    }

    public NoLista<Dado> Prox 
    { 
        get => prox; 
        set => prox = value; 
    }
}