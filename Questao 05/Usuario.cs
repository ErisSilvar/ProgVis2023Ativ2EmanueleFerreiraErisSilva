using System;

public class Usuario
{
    public String Nome { get; set; }
    public String Email { get; set; }
    public DateTime Nascimento { get; set; }
    public Boolean Ativo { get; set; }

    public override string ToString()
    {
        string status = Ativo ? "Ativo" : "Inativo";
        int idade = DateTime.Today.Year - Nascimento.Year;

        string dataNascimentoFormatada = Nascimento.ToString("dd/MM/yyyy");
        string idadeFormatada = idade == 1 ? "1 ano" : idade + " anos";

        return string.Format("Nome = {0}\nEmail = {1}\nNascimento = {2}\nIdade = {3}\n{4}", Nome, Email, dataNascimentoFormatada, idadeFormatada, status);
    }
  
}
