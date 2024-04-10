


using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main(string[] args)
    {
        //Crie um programa que concatene um nome e um sobrenome inseridos pelo usuário e ao final exiba o nome completo.
        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite seu sobrenome: ");
        string sobrenome = Console.ReadLine();
        Console.WriteLine($"Nome completo: {nome} {sobrenome}");
        Console.WriteLine();
    }
}








