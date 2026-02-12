namespace JogoDaMemoria;

class Program
{
    static void Main(string[] args)
    {
        string[,] auxScreen = new string[4, 4];
        string[,] userScreen = new string[4, 4];
        string[,] symbolsScreen = new string[4, 4];
        GerenciarScreen gerenciadorTela = new GerenciarScreen();
        userScreen = gerenciadorTela.UserScreen(userScreen);
        auxScreen = gerenciadorTela.UserScreen(auxScreen);
        symbolsScreen = gerenciadorTela.InserirValoresSimbolos(symbolsScreen);
        gerenciadorTela.DesenharTela(symbolsScreen);
        Thread.Sleep(5000);
        int tentativas = 0;
        bool fimDoJogo = false;

        while (fimDoJogo == false)
        {
            Console.Clear();
            gerenciadorTela.DesenharTela(userScreen);
            Console.Write("Digite sua jogada: ");
            int jogada1 = int.Parse(Console.ReadLine()) - 1;

            int valorLinha1 = jogada1 / userScreen.GetLength(0);
            int valorColuna1 = jogada1 % userScreen.GetLength(1);

            userScreen[valorLinha1, valorColuna1] = symbolsScreen[valorLinha1, valorColuna1];

            gerenciadorTela.DesenharTela(userScreen);


            Console.Clear();
            gerenciadorTela.DesenharTela(userScreen);
            Console.Write("Digite sua jogada: ");
            int jogada2 = int.Parse(Console.ReadLine()) - 1;

            int valorLinha2 = jogada2 / userScreen.GetLength(0);
            int valorColuna2 = jogada2 % userScreen.GetLength(1);

            userScreen[valorLinha2, valorColuna2] = symbolsScreen[valorLinha2, valorColuna2];

            Console.Clear();
            gerenciadorTela.DesenharTela(userScreen);

            if(valorLinha1 == valorLinha2 && valorColuna1 == valorColuna2)
            {
                Console.WriteLine("Digite posicoes diferentes.");
                userScreen[valorLinha1, valorColuna1] = auxScreen[valorLinha1, valorColuna1];
                userScreen[valorLinha2, valorColuna2] = auxScreen[valorLinha2, valorColuna2];
                Thread.Sleep(1000);
                continue; 
            }
            if (userScreen[valorLinha1, valorColuna1] == userScreen[valorLinha2, valorColuna2])
            {
                userScreen[valorLinha1, valorColuna1] = "   ";
                userScreen[valorLinha2, valorColuna2] = "   ";
            }

            else
            {
                userScreen[valorLinha1, valorColuna1] = auxScreen[valorLinha1, valorColuna1];
                userScreen[valorLinha2, valorColuna2] = auxScreen[valorLinha2, valorColuna2];
                Thread.Sleep(2000);

            }
            gerenciadorTela.DesenharTela(userScreen);
            tentativas++;

            fimDoJogo = userScreen.Cast<string>().All(x => x == "   ");
        }

        Console.WriteLine($"Voce conseguiu em {tentativas} tentativas");

    }
}

public class GerenciarScreen
{
    public string[,] InserirValoresSimbolos(string[,] symbolsScreen)
    {
        symbolsScreen = InsertRandomSymbols(symbolsScreen, ":p");
        symbolsScreen = InsertRandomSymbols(symbolsScreen, ":p");
        symbolsScreen = InsertRandomSymbols(symbolsScreen, ":[");
        symbolsScreen = InsertRandomSymbols(symbolsScreen, ":[");
        symbolsScreen = InsertRandomSymbols(symbolsScreen, ":(");
        symbolsScreen = InsertRandomSymbols(symbolsScreen, ":(");
        symbolsScreen = InsertRandomSymbols(symbolsScreen, ":3");
        symbolsScreen = InsertRandomSymbols(symbolsScreen, ":3");
        symbolsScreen = InsertRandomSymbols(symbolsScreen, ":o");
        symbolsScreen = InsertRandomSymbols(symbolsScreen, ":o");
        symbolsScreen = InsertRandomSymbols(symbolsScreen, ":x");
        symbolsScreen = InsertRandomSymbols(symbolsScreen, ":x");
        symbolsScreen = InsertRandomSymbols(symbolsScreen, ":D");
        symbolsScreen = InsertRandomSymbols(symbolsScreen, ":D");
        symbolsScreen = InsertRandomSymbols(symbolsScreen, ":s");
        symbolsScreen = InsertRandomSymbols(symbolsScreen, ":s");
        return symbolsScreen;
    }
    public string[,] UserScreen(string[,] tabuleiro)

    {
        int controle = 1;
        for (int l = 0; l < tabuleiro.GetLength(0); l++)
        {
            for (int c = 0; c < tabuleiro.GetLength(1); c++)
            {
                if (controle < 10)
                {
                    tabuleiro[l, c] = $"#0{controle}";
                }
                else
                {

                    tabuleiro[l, c] = $"#{controle}";
                }
                controle++;

            }
        }

        return tabuleiro;
    }

    public string[,] InsertRandomSymbols(string[,] tabuleiro, string desenho)
    {
        var numeroAleatorio = new Random();
        var linhaAleatoria = numeroAleatorio.Next(tabuleiro.GetLength(0));
        var colunaAleatoria = numeroAleatorio.Next(tabuleiro.GetLength(1));

        if (tabuleiro[linhaAleatoria, colunaAleatoria] == null)
        {
            tabuleiro[linhaAleatoria, colunaAleatoria] = $"{desenho} ";
        }
        else
        {
            InsertRandomSymbols(tabuleiro, desenho);
        }

        return tabuleiro;
    }


    public void DesenharTela(string[,] tela)
    {
        for (var l = 0; l < tela.GetLength(0); l++)
        {
            for (var c = 0; c < tela.GetLength(1); c++)
            {
                Console.Write($"{tela[l, c]}   ");
                if (c == 3)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}