using System.Runtime.ConstrainedExecution;

namespace desafio_pratio_um_exercicio_cinco
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //.Crie um programa em que o usuário precisa digitar a placa de um veículo e o programa verifica se a placa é válida, seguindo o padrão brasileiro válido até 2018:
            //-A placa deve ter 7 caracteres alfanuméricos;
            //-Os três primeiros caracteres são letras(maiúsculas ou minúsculas);
            //-Os quatro últimos caracteres são números;
            //Ao final, o programa deve exibir*** Verdadeiro***se a placa for válida e ***Falso * **caso contrário.
            Console.WriteLine("Digite a placa do veículo: ");
            string plate = Console.ReadLine() ?? "";
            bool isValidPlate = plate.Length == 7 &&
                                char.IsLetter(plate[0]) &&
                                char.IsLetter(plate[1]) &&
                                char.IsLetter(plate[2]) &&
                                char.IsDigit(plate[3]) &&
                                char.IsDigit(plate[4]) &&
                                char.IsDigit(plate[5]) &&
                                char.IsDigit(plate[6]);
            Console.WriteLine("A placa é:");
            Console.WriteLine(isValidPlate ? "Verdadeira" : "Falsa");

        }
    }
}
