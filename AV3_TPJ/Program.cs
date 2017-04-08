using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV3_TPJ
{
    /// <summary>
    /// Classe player para organização de nomes e pontuações
    /// </summary>
    public class Player
    {
        public int pontos;
        public string nome;

        /// <summary>
        /// Construtor da classe player
        /// </summary>
        /// <param name="n">Recebe o nome do player</param>
        /// <param name="p">Recebe a pontuação do player</param>
        public Player(string n, int p)
        {
            this.pontos = p;
            this.nome = n;
        }
    }

    class Program
    {
        private static Player[] players = new Player[10];

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            PopularArray();
            while (true)
            {
                MostrarLista();
                InserirNovoPlayer();
            }
        }
        
        /// <summary>
        /// Método para ordenar a posição dos players
        /// BubbleSort
        /// </summary>
        /// <param name="players">Recebe um array com todos os players</param>
        /// <returns>Retorna um array com as posições ordenadas</returns>
        private static Player[] OrdenarPosicoes(Player[] players)
        {
            Player playerIndice;

            for (int i = 0; i < players.Length; i++)
            {
                for (int j = 0; j < players.Length - 1; j++)
                {
                    if (players[j].pontos > players[j + 1].pontos)
                    {
                        playerIndice = players[j];
                        players[j] = players[j + 1];
                        players[j + 1] = playerIndice;
                    }
                }
            }
           return players;
        }

        /// <summary>
        /// Método para adicionar e testar novo player inserido pelo usuário
        /// </summary>
        /// <param name="novoPlayer">Recebe o novo player</param>
        /// <param name="players">Recebe todos os players</param>
        /// <returns>Retorna a nova lista dos players</returns>
        private static Player[] AdicionarNovoPlayer(Player novoPlayer, Player[] players)
        {
            Player playerIndice;

            for(int i = 0; i < players.Length; i++)
            {
                if(novoPlayer.pontos > players[i].pontos)
                {
                    playerIndice = players[i];
                    players[i] = novoPlayer;
                    if(i != 0)
                    {
                        players[i - 1] = playerIndice;
                    }
                }
            }
            return players;
        }

        /// <summary>
        /// Função para exibir a lista de players e pontos
        /// </summary>
        private static void MostrarLista()
        {
            Console.Clear();
            players = OrdenarPosicoes(players);
            Console.WriteLine("Lista ordenada... \n");
            for (int i = players.Length - 1; i >= 1; i--)
            {
                Console.WriteLine("{0} -  {1} pontos ", players[i].nome, players[i].pontos);
            }
            Console.WriteLine(" \n Deseja inserir um novo player? - S/N .... X");
        }

        /// <summary>
        /// Função para inserir os dados de um novo Player
        /// </summary>
        private static void InserirNovoPlayer()
        {
            ConsoleKey currentOption = Console.ReadKey().Key;
            switch (currentOption)
            {
                case ConsoleKey.X:
                    Console.Clear();
                    Console.WriteLine("Desenvlvido por Lucas Soares, Luca Alves e Juan Gonzalez \n Valeu Matheus!!");
                    Console.ReadKey();
                    break;

                case ConsoleKey.S:
                    Console.Clear();
                    Console.WriteLine("Digite o nome do player:");
                    string nomeUsuario = Console.ReadLine();
                    if (nomeUsuario == "")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Você não inseriu o nome do player");
                        Console.ReadKey();
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                        
                    try
                    {
                        Console.WriteLine("Digite a quantidade de pontos do player:");
                        int pontosUsuario = Convert.ToInt32(Console.ReadLine());
                        Player novoPlayer = new Player(nomeUsuario, pontosUsuario);
                        players = AdicionarNovoPlayer(novoPlayer, players);
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Digite um número válido para sua pontuação");
                        Console.ReadKey();
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    break;

                case ConsoleKey.N:
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
            }
        }

        /// <summary>
        /// Função para popular o array de players com alguns players
        /// </summary>
        private static void PopularArray()
        {
            players[0] = new Player("Lucas", 2);
            players[1] = new Player("Luis", 40);
            players[2] = new Player("Antoanne", 33);
            players[3] = new Player("Matheus", 500);
            players[4] = new Player("Jamv", 12);
            players[5] = new Player("Henrique", 9);
            players[6] = new Player("Daniel", 3);
            players[7] = new Player("Sandro", 70);
            players[8] = new Player("Letycia", 20);
            players[9] = new Player("Barbara", 200);
        }
    }
}
