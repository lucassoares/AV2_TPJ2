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

            players = ordenarPosicoes(players);
            Console.WriteLine("Lista ordenada... \n");
            for (int i = players.Length - 1; i >= 1; i--)
            {
                Console.WriteLine("{0} -  {1} pontos ", players[i].nome, players[i].pontos);
            }
            Console.ReadKey();
        }
        

        /// <summary>
        /// Método para ordenar a posição dos players
        /// </summary>
        /// <param name="players">Recebe um array com todos os players</param>
        /// <returns>Retorna um array com as posições ordenadas</returns>
        private static Player[] ordenarPosicoes(Player[] players)
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
    }
}
