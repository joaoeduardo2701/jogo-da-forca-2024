namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Forca forca = new Forca();

            forca.QuantidadeErros = 0;
            forca.PalavraEscolhida = forca.EscolherPalavraAleatoria();
            forca.LetrasEncontradas = forca.InicializarLetrasEncontradas(forca.PalavraEscolhida);
            forca.PalavraEncontrada = "";

            do
            {
                DesenharForca(forca.QuantidadeErros);

                ExibirLetrasEncontradas(forca.LetrasEncontradas);

                char chute = ObterChute();

                bool letraFoiEncontrada = false;

                for (int i = 0; i < forca.PalavraEscolhida.Length; i++)
                {
                    char letraAtual = forca.PalavraEscolhida[i];

                    if (chute == letraAtual)
                    {
                        forca.LetrasEncontradas[i] = letraAtual;
                        letraFoiEncontrada = true;
                    }
                }

                if (letraFoiEncontrada == false)
                    forca.QuantidadeErros++;

                forca.PalavraEncontrada = string.Join("", forca.LetrasEncontradas);

                if (forca.JogadorAcertou(forca.PalavraEscolhida, forca.PalavraEncontrada))
                    Console.WriteLine("\nVocê acertou a palavra secreta, parabéns!");

                else if (forca.JogadorPerdeu(forca.QuantidadeErros))
                    Console.WriteLine("\nQue azar! Tente novamente!");

            } while (forca.JogadorAcertou(forca.PalavraEscolhida, forca.PalavraEncontrada) == false && forca.JogadorPerdeu(forca.QuantidadeErros) == false);

            Console.ReadLine();
        }

        private static void DesenharForca(int quantidadeErros)
        {
            string cabecaDoBoneco = quantidadeErros >= 1 ? " o " : " ";
            string tronco = quantidadeErros >= 2 ? "x" : " ";
            string troncoBaixo = quantidadeErros >= 2 ? " x " : " ";
            string bracoEsquerdo = quantidadeErros >= 3 ? "/" : " ";
            string bracoDireito = quantidadeErros >= 3 ? @"\" : " ";
            string pernas = quantidadeErros >= 4 ? "/ \\" : " ";

            Console.Clear();
            Console.WriteLine(" ___________        ");
            Console.WriteLine(" |/        |        ");
            Console.WriteLine(" |        {0}       ", cabecaDoBoneco);
            Console.WriteLine(" |        {0}{1}{2} ", bracoEsquerdo, tronco, bracoDireito);
            Console.WriteLine(" |        {0}       ", troncoBaixo);
            Console.WriteLine(" |        {0}       ", pernas);
            Console.WriteLine(" |                  ");
            Console.WriteLine(" |                  ");
            Console.WriteLine("_|____              ");
        }

        private static char ObterChute()
        {
            Console.Write("Digite uma letra: ");

            char chute = Console.ReadLine()[0];

            return chute;
        }

        private static void ExibirLetrasEncontradas(char[] letrasEncontradas)
        {
            Console.WriteLine("\n" + string.Join("", letrasEncontradas));
        }  
    }
}
