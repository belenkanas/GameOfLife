using System;
using System.Text;

namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] contentLines = LeerTablero.Leer("board.txt"); // Toma el tablero de board.txt
            bool[,] gameBoard = MatrizArchivo.Matriz(contentLines);   // y luego lo transforma según las instrucciones de la matriz
            
            // Crea una instancia de GameEngine para inicializar el tablero
            GameEngine gameEngine = new GameEngine();
            gameEngine.GameBoard = gameBoard;

            Console.WriteLine("Inicio del juego:");

            for (int i = 0; i < 100; i++)  // Hace el proceso hasta 100 veces (ese valor puede cambiar)
            {
                // Imprime el tablero actual
                ImprimirTablero.Imprimir(gameBoard);

                // Calcular la siguiente linea
                gameEngine.CloneBoard();

                // Actualiza el tablero
                gameBoard = gameEngine.GameBoard;
            }
        }
    }
}