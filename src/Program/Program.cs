using System;
using System.Text;

namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] contentLines = LeerTablero.Leer("board.txt");
            bool[,] gameBoard = MatrizArchivo.Matriz(contentLines);
            
            // Crear una instancia de GameEngine e inicializar el tablero
            GameEngine gameEngine = new GameEngine();
            gameEngine.GameBoard = gameBoard;

            Console.WriteLine("Inicio del juego:");

            while (ImprimirTablero.Imprimir(gameBoard))
            {
                // Imprimir el tablero actual
                ImprimirTablero.Imprimir(gameBoard);

                // Calcular la siguiente generación
                gameEngine.CloneBoard();

                // Actualizar el tablero
                gameBoard = gameEngine.GameBoard;
            }
        }
    }
}