using System;

public class Quadrado{
  public Double Lado { get; set; }

  public override string ToString(){
    return string.Format("Objeto: Quadrado" + "\nToString(): " + "\nLado: {0:0.00}\nÁrea: {1:0.00}\n", Lado, CalcularArea());
  }

  public double CalcularArea(){
    return Lado * Lado;
  }
  
}