// See https://aka.ms/new-console-template for more information
using PrimeiroProjeto;

Console.WriteLine("Hello, World!");

Pessoa novaPessoa = new Pessoa("João Victor", 21);

Console.WriteLine("Nome: " + novaPessoa.ObterNome());
Console.WriteLine("Idade: " + novaPessoa.ObterIdade());