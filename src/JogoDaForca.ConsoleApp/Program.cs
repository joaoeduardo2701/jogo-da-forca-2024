namespace JogoDaForca.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("----------- Jogo da Forca -----------");
        Console.WriteLine("-------------------------------------");
        Console.WriteLine();

        Console.WriteLine(" ___________");
        Console.WriteLine(" |/        |");
        Console.WriteLine(" |");
        Console.WriteLine(" |");
        Console.WriteLine(" |");
        Console.WriteLine(" |");
        Console.WriteLine(" |");
        Console.WriteLine(" |");
        Console.WriteLine("_|____");
        Console.WriteLine();

        string[] frutas = new string[29] { "ABACATE", "ABACAXI", "ACEROLA", "AÇAÍ", "ARAÇA", "BACABA", "BACURI", "BANANA", "CAJA", "CAJU", "CARAMBOLA", "CUPUAÇU", "GRAVIOLA", "GOIABA", "JABUTICABA", "JENIPAPO", "MAÇA", "MANGABA", "MANGA", "MARACUJA", "MURICI", "PEQUI", "PITANGA", "PITAYA", "SAPOTI", "BERGAMOTA", "UMBU", "UVA", "UVAIA" };

        Random r = new Random();
        string frutaAleatoria = frutas[r.Next(frutas.Length)];

        char chute = 'a';

        Console.WriteLine(frutaAleatoria);

        char[] palavraForca = new char[frutaAleatoria.Length];

        for (int i = 0; i < palavraForca.Length; i++)
        {
            palavraForca[i] = '_';
        }

        Console.WriteLine(palavraForca);
        Console.WriteLine();

        for (int palavraTerminou = 1; palavraTerminou <= frutaAleatoria.Length; palavraTerminou++)
        {
            Console.Write($"Qual o seu {palavraTerminou}° chute: ");
            chute = char.Parse(Console.ReadLine());

            for (int i = 0; i < frutaAleatoria.Length; i++)
            {
                if (chute == frutaAleatoria[i])
                {
                    palavraForca[i] = chute;

                }
            }
            
            string palavraEncontrada = string.Join("", palavraForca);

            if (palavraEncontrada == frutaAleatoria)
                {
                Console.WriteLine("Você acertou a palavra!");
                break;
            }
            
            Console.WriteLine(palavraForca);
            Console.WriteLine();
        }
    }
}
