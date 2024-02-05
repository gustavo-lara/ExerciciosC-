using Exercicios;
using System.Numerics;

internal class Program
{
    public static ContaCorrente ContaCorrente { get; private set; }

    private static void Main(string[] args)
    {

        //classe Abstrat: classe que só pode ser herdada, não pode ser chamada diretamente. Tem que sobreescrever na classe filho "public void override Nome()"
        //classe Stact: Função que não muda, comportamento não muda, não pode ser sobreescrevido
        //Modificadores de comportamento

        //Public: Uso Geral, pode ser "Chamado"
        //Private: Só pode ser usado dentro do arquivo
        //Internal: Uso interno, pose ser chamado no Program 
        //Protect: Só usado em classes herdadas e em sua própia, não é chamado diretamnte no Program
        //São modificadores de acesso 


        //Exercicio 1
        Livro livro1 = new Livro();
        Livro livro2 = new Livro();
        Livro livro3 = new Livro();

        livro1.Titulo = "Solo Leving";
        livro1.Autor = "Chu-Gong";
        livro1.Editora = "NewPop";
        livro1.AnoDeLanca = 2016;

        livro2.Titulo = "Tokyo Ghoul";
        livro2.Autor = "Sui Ishida";
        livro2.Editora = "Panini";
        livro2.AnoDeLanca = 2011;

        livro3.Titulo = "Tokyo Ghoul: Re";
        livro3.Autor = "Sui Ishida";
        livro3.Editora = "Panini";
        livro3.AnoDeLanca = 2018;

        Console.WriteLine("Exercício 1");

        Console.WriteLine("LIVROS:");

        Console.WriteLine($"Título: {livro1.Titulo}, Autor: {livro1.Autor}, Editora: {livro1.Editora}, Ano de lançamento: {livro1.AnoDeLanca}");
        Console.WriteLine($"Título: {livro2.Titulo}, Autor: {livro2.Autor}, Editora: {livro2.Editora}, Ano de lançamento: {livro2.AnoDeLanca}");
        Console.WriteLine($"Título: {livro3.Titulo}, Autor: {livro3.Autor}, Editora: {livro3.Editora}, Ano de lançamento: {livro3.AnoDeLanca}");


        //Exercicio 2
        Aluno aluno1 = new Aluno();
        Aluno aluno2 = new Aluno();
        Aluno aluno3 = new Aluno();

        aluno1.RM = 5086;
        aluno1.Nome = "Gustavo";
        aluno1.Nascimento = 2006;
        aluno1.Email = "gustavo@gmail.com";

        aluno2.RM = 1010;
        aluno2.Nome = "Felipe";
        aluno2.Nascimento = 2006;
        aluno2.Email = "felipe@gmail.com";

        aluno3.RM = 5082;
        aluno3.Nome = "Cauã";
        aluno3.Nascimento = 2006;
        aluno3.Email = "caua@gmail.com";

        Console.WriteLine();
        Console.WriteLine("Exercício 2");
        Console.WriteLine("ALUNOS:");
        Console.WriteLine($"RM: {aluno1.RM}, Nome: {aluno1.Nome}, Nascimento: {aluno1.Nascimento}, Email: {aluno1.Email}");
        Console.WriteLine($"RM: {aluno2.RM}, Nome: {aluno2.Nome}, Nascimento: {aluno2.Nascimento}, Email: {aluno2.Email}");
        Console.WriteLine($"RM: {aluno3.RM}, Nome: {aluno3.Nome}, Nascimento: {aluno3.Nascimento}, Email: {aluno3.Email}");


        //Exercicio 3

        Carro carro1 = new Carro();
        Carro carro2 = new Carro();
        Carro carro3 = new Carro();

        carro1.Marca = "Porsche";
        carro1.Modelo = "911";
        carro1.Velocidade = 50;

        carro2.Marca = "Ferrari";
        carro2.Modelo = "458 Itália";
        carro2.Velocidade = 65;

        carro3.Marca = "Lamborghini";
        carro3.Modelo = "Huracan";
        carro3.Velocidade = 60;

        Console.WriteLine();
        Console.WriteLine("Exercício 3");
        Console.WriteLine($"Marca: {carro1.Marca}, Modelo: {carro1.Modelo}, Velocidade: {carro1.Velocidade}");
        carro1.Acelerar();
        Console.WriteLine($"Velocidade: {carro1.Velocidade}");

        Console.WriteLine($"Marca: {carro2.Marca}, Modelo: {carro2.Modelo}, Velocidade: {carro2.Velocidade}");
        carro2.Desacelerar();
        Console.WriteLine($"Velocidade: {carro2.Velocidade}");

        Console.WriteLine($"Marca: {carro3.Marca}, Modelo: {carro3.Modelo}, Velocidade: {carro3.Velocidade}");
        carro3.Acelerar();
        carro3.Acelerar();
        Console.WriteLine($"Velocidade: {carro3.Velocidade}");
        carro3.Desacelerar();
        Console.WriteLine($"Velocidade: {carro3.Velocidade}");
        carro3.Desacelerar();
        Console.WriteLine($"Velocidade: {carro3.Velocidade}");


        //Exercicio 4

        Funcionarios funcionarios1 = new Funcionarios();
        Funcionarios funcionarios2 = new Funcionarios();
        Funcionarios funcionarios3 = new Funcionarios();

        funcionarios1.Nome = "Chico";
        funcionarios1.Idade = 19;
        funcionarios1.Profissao = "Atendente";

        funcionarios2.Nome = "Gustavo";
        funcionarios2.Idade = 17;
        funcionarios2.Profissao = "Office boy";

        funcionarios3.Nome = "Eduardo";
        funcionarios3.Idade = 16;
        funcionarios3.Profissao = "Desempregado";

        Console.WriteLine();
        Console.WriteLine("Exercício 4");
        Console.WriteLine($"Nome: {funcionarios1.Nome}, Idade: {funcionarios1.Idade}, Profissao: {funcionarios1.Profissao}");
        funcionarios1.Envelhecer();
        Console.WriteLine($"Idade depois de um tempo: {funcionarios1.Idade}");

        Console.WriteLine($"Nome: {funcionarios2.Nome}, Idade: {funcionarios2.Idade}, Profissao: {funcionarios2.Profissao}");
        funcionarios2.Envelhecer();
        Console.WriteLine($"Idade depois de um tempo: {funcionarios2.Idade}");

        Console.WriteLine($"Nome: {funcionarios3.Nome}, Idade: {funcionarios3.Idade}, Profissao: {funcionarios3.Profissao}");
        funcionarios3.Envelhecer();
        Console.WriteLine($"Idade depois de um tempo: {funcionarios3.Idade}");


        //Exercicio 5

        Console.WriteLine();
        Console.WriteLine("Exercício 5");

        Pessoas p = new Pessoas();
        p.Nome = "João";
        p.Idade = 19;

        People p2 = new People("Joca", 12);

        Console.WriteLine($"Nome: {p.Nome} - Idade: {p.Idade}");
        Console.WriteLine("Nome: {0} - Idade: {1}", p2.Nome, p2.Idade);

        //Exercicio 6
        Console.WriteLine();
        Console.WriteLine("Exercício 6");

        //Adicionando esse comando lá em cima:
        //public static ContaCorrente ContaCorrente { get; private set; }

        ContaCorrente c1 = new("Banco do Brasil", 1234, 500, 50, 10, 60);

        c1.MinhaConta();
        c1.Depositar();
        c1.Depositar();
        c1.Depositar();
        c1.Depositar();
        c1.Depositar();
        c1.Depositar();
        c1.Depositar();
        c1.Depositar();
        c1.Depositar();
        c1.Depositar();
        c1.Sacar();

    }
}