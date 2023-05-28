using System;

public class Paciente{
  public String Nome { get; set; }
  public UInt64 Cns { get; set; }

  public override string ToString(){
    return string.Format("Objeto: Paciente" + "\nToString(): " + "\nNome: {0}\nCns: {1:000 0000 0000 0000}\n", Nome, Cns);
  }
  
}