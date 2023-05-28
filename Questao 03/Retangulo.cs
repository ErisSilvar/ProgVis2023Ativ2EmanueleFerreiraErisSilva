using System;

public class Retangulo{
  
  public Double LadoA { get; set; }
  public Double LadoB { get; set; }

  public override string ToString(){
    return string.Format("Objeto: Retângulo" + "\nToString():" + "\nLado A: {0:0.00}\nLado B: {1:0.00}\nÁrea: {2:0.00}\n", LadoA, LadoB, CalcularArea()); 
  }
  
  public Double CalcularArea(){
    return LadoA * LadoB;
  }
  
}