using System;

public class Losango{
  public Double DiagonalA { get; set;}
  public Double DiagonalB { get; set; }

  public override string ToString(){
    return string.Format("Objeto: Losango" + "\nToString(): " + "\nDiagonal A: {0:0.00}\nDiagonal B: {1:0.00}\nÁrea: {2:0.00}\n", DiagonalA, DiagonalB, CalcularArea());
  }

  public Double CalcularArea(){
    return DiagonalA * DiagonalB / 2;
  }
  
}