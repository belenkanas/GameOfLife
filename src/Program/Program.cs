using System;
using System.Text;

namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            LeerTablero lector = new LeerTablero();
            string[] contentLines = lector.Leer();
            bool[,] gameBoard = MatrizArchivo.Matriz(contentLines);
            
            // Crear una instancia de GameEngine e inicializar el tablero
            GameEngine gameEngine = new GameEngine();
            gameEngine.SetGameBoard(gameBoard);

            Console.WriteLine("Inicio del juego:");

            while (true)
            {
                // Imprimir el tablero actual
                ImprimirTablero.Imprimir(gameBoard);

                // Calcular la siguiente generación
                gameEngine.CloneBoard();

                // Actualizar el tablero
                gameBoard = gameEngine.GetGameBoard();
            }
        }
    }
}
            
            
            
            
            
          /*  LeerTablero.Leer("board.txt");
            //MatrizArchivo.Matriz(bool[,]);
            //GameEngine.CloneBoard();
            ImprimirTablero.Imprimir(bool[,]);
            Console.WriteLine("Inicio del juego:");
            
            gameEngine.CloneBoard();
            ImprimirTablero imprimirTablero = new ImprimirTablero();

        }
    }
}*/
