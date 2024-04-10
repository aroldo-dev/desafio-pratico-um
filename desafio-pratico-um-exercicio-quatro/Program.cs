namespace desafio_pratico_um_exercicio_quatro
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Crie um programa em que o usuário digita uma ou mais palavras e é exibido a quantidade de caracteres que a palavra inserida tem.
            Console.WriteLine("Digite uma palavra: ");
            string sentenceOrWord = Console.ReadLine() ?? "";
            bool isSentence = sentenceOrWord.Contains(' ');
            string sentenceOrWordLabel = isSentence ? "frase" : "palavra";
            Console.WriteLine($"A {sentenceOrWordLabel} '{sentenceOrWord}' tem {sentenceOrWord.Length} caracteres.");




        }
    }
}
