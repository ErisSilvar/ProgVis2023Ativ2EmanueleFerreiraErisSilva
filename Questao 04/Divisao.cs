using System;

public class Divisao{
  
  public Double ValorA { get; set; }
  public Double ValorB { get; set; }

  public override string ToString(){
    return string.Format("Operação: Divisão" + "\nToString():" + "\nValor A: {0}\nValor B: {1:0.0}\nDivisão: {2:0.0000000}\n", ValorA, ValorB, Operar()); 
  }
  
  public Double Operar(){
    return ValorA / ValorB;
  }
  
}