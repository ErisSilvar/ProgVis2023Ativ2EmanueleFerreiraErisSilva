using System;

public class Circulo{
  public Double Raio { get; set; }

  public override string ToString() {
    return string.Format("Objeto: Círculo" + "\nToString():" + "\nRaio: {0:0.00}\nÁrea: {1}\n", Raio, CalcularArea());
  }

    public double CalcularArea() {
    const double Pi = 3.1415;
    return Pi * Raio * Raio;
  }
  
}