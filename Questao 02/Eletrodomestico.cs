using System;

public class Eletrodomestico{
  public UInt64 Codigo{ get; set;}
  public String Nome{ get; set;}
  public Decimal Preco{ get; set;}

  public override string ToString(){
    return string.Format("Objeto: Eletrodoméstico" + "\nToString():" + "\nCódigo: {0:00-0000-00000-0}\nNome: {1}\nPreço: {2:R$0,000.00}\n", Codigo, Nome, Preco); 
  }
  
}