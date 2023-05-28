using System;

class Program
{
    public static void Main(string[] args)
    {
        ProcessarQuestao1();
        ProcessarQuestao2();
        ProcessarQuestao3();
        ProcessarQuestao4();
        ProcessarQuestao5();
    }

    private static void ProcessarQuestao1()
    {
        Paciente pa = new Paciente();
        pa.Nome = "Beatriz Yana";
        pa.Cns = 227683387130006;

        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Resposta da Questão 01");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine(pa);
    }

    private static void ProcessarQuestao2()
    {
        Eletrodomestico el = new Eletrodomestico();
        el.Codigo = 851796157395;
        el.Nome = "Refrigerador";
        el.Preco = 3253.12m;

        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Resposta da Questão 02");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine(el);
    }

    private static void ProcessarQuestao3()
    {
        Circulo ci = new Circulo();
        ci.Raio = 2.00;

        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Resposta da Questão 03");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine(ci);

        Quadrado qua = new Quadrado();
        qua.Lado = 2.00;
        Console.WriteLine(qua);

        Retangulo re = new Retangulo();
        re.LadoA = 2.00;
        re.LadoB = 3.00;
        Console.WriteLine(re);

        Losango lo = new Losango();
        lo.DiagonalA = 2.00;
        lo.DiagonalB = 3.00;
        Console.WriteLine(lo);
    }

    private static void ProcessarQuestao4()
    {
        Soma so = new Soma();
        so.ValorA = 2.5;
        so.ValorB = -3.0;

        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Resposta da Questão 04");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine(so);

        Subtracao sub = new Subtracao();
        sub.ValorA = 2.5;
        sub.ValorB = -3.0;
        Console.WriteLine(sub);

        Multiplicacao mul = new Multiplicacao();
        mul.ValorA = 2.5;
        mul.ValorB = -3.0;
        Console.WriteLine(mul);

        Divisao div = new Divisao();
        div.ValorA = 2.5;
        div.ValorB = -3.0;
        Console.WriteLine(div);
    }

    private static void ProcessarQuestao5()
    {
        Usuario usuario = new Usuario()
        {
            Nome = "Ana Zaira",
            Email = "ana.zaira@gmail.com",
            Nascimento = new DateTime(1999, 02, 28),
            Ativo = false
        };

        Usuario usuario2 = new Usuario()
        {
            Nome = "Beatriz Yana",
            Email = "beatriz.yana@gmail.com",
            Nascimento = new DateTime(1998, 03, 30),
            Ativo = true
        };
        
        string user = usuario.ToString();
        string user2 = usuario2.ToString();

        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Resposta da Questão 05");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine(user + "\n");
        Console.WriteLine(user2);

    }


}