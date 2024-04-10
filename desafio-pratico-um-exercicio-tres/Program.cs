using System.Runtime.Intrinsics.X86;

namespace desafio_pratico_um_exercicio_tres;

internal class Program
{
    static void Main(string[] args)
    {

        //1.Crie um programa com 2 valores do tipo `**double`**já declarados**** que retorne:
        //-A soma entre esses dois números;
        //-A subtração entre os dois números;
        //-A multiplicação entre os dois números;
        //-A divisão entre os dois números(vale uma verificação se o segundo número é 0!);
        //-A média entre os dois números.

        //Você pode ir além e permitir que o usuário insira dois números aleatórios! 
        Console.WriteLine("Digite o primeiro número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double soma = num1 + num2;
        double subtracao = num1 - num2;
        double multiplicacao = num1 * num2;
        double divisao = num2 != 0 ? num1 / num2 : 0;
        double media = (num1 + num2) / 2;

        Console.WriteLine($"Soma: {soma}");
        Console.WriteLine($"Subtração: {subtracao}");
        Console.WriteLine($"Multiplicação: {multiplicacao}");
        Console.WriteLine($"Divisão: {divisao}");
        Console.WriteLine($"Média: {media}");
        Console.WriteLine();


      

        

    }
}

