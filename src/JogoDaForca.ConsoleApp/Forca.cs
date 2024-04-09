namespace JogoDaForca.ConsoleApp;
internal class Forca
{
    public int QuantidadeErros;
    public bool JogadorEnforcou;
    public string PalavraEscolhida;
    public char[] LetrasEncontradas;
    public string PalavraEncontrada;

    public string EscolherPalavraAleatoria()
    {
        string[] palavras = {
                "ABACATE",
                "ABACAXI",
                "ACEROLA",
                "ACAI",
                "ARACA",
                "ABACATE",
                "BACABA",
                "BACURI",
                "BANANA",
                "CAJA",
                "CAJU",
                "CARAMBOLA",
                "CUPUACU",
                "GRAVIOLA",
                "GOIABA",
                "JABUTICABA",
                "JENIPAPO",
                "MACA",
                "MANGABA",
                "MANGA",
                "MARACUJA",
                "MURICI",
                "PEQUI",
                "PITANGA",
                "PITAYA",
                "SAPOTI",
                "TANGERINA",
                "UMBU",
                "UVA",
                "UVAIA"
            };

        Random random = new Random();

        int indiceEscolhido = random.Next(palavras.Length);

        return palavras[indiceEscolhido];
    }

    public char[] InicializarLetrasEncontradas(string palavraEscolhida)
    {
        char[] letrasEncontradas = new char[palavraEscolhida.Length];

        for (int caractere = 0; caractere < letrasEncontradas.Length; caractere++)
        {
            letrasEncontradas[caractere] = '-';
        }

        return letrasEncontradas;
    }

    public  bool JogadorPerdeu(int quantidadeErros)
    {
        return quantidadeErros >= 5;
    }

    public bool JogadorAcertou(string palavraEscolhida, string palavraEncontrada)
    {
        return palavraEncontrada == palavraEscolhida;
    }
}
