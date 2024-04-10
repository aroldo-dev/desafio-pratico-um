using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;

namespace desafio_pratico_um_exercicio_seis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos:
            //-Formato completo(dia da semana, dia do mês, mês, ano, hora, minutos, segundos).
            //-Apenas a data no formato "01/03/2024".
            //- Apenas a hora no formato de 24 horas.
            //- A data com o mês por extenso.
            Console.WriteLine("Data atual:");
            DateTime now = DateTime.Now;
            Console.WriteLine($"Formato completo: {now.ToString("F")}");
            Console.WriteLine($"Apenas a data: {now.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Apenas a hora: {now.ToString("HH:mm:ss")}");
            Console.WriteLine($"Data com o mês por extenso: {now.ToString("dd/MMMM/yyyy")}");






        }
    }
}
