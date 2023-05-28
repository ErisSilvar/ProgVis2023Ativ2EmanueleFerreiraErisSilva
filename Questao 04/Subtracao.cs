using System;

public class Subtracao{
  
  public Double ValorA { get; set; }
  public Double ValorB { get; set; }

  public override string ToString(){
    return string.Format("Operação: Subtração" + "\nToString():" + "\nValor A: {0}\nValor B: {1:0.0}\nSubtracao: {2}\n", ValorA, ValorB, Operar()); 
  }
  
  public Double Operar(){
    return ValorA - ValorB;
  }
  
}