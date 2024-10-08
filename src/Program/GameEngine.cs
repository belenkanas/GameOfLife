using System;
using System.IO;

public class GameEngine //Lógica del juego
{
    private bool[,] gameBoard;

    public bool[,] GameBoard      // Esto es para que el objeto pueda ser llamado en la ejecución del programa.
    {
        get { return gameBoard;}
        set { gameBoard = value; }
    }
    
    public void CloneBoard()
    {
        int boardWidth = gameBoard.GetLength(0);
        int boardHeight = gameBoard.GetLength(1);

        bool[,] cloneBoard = new bool[boardWidth, boardHeight];

        for (int x = 0; x < boardWidth; x++)
        {
            for (int y = 0; y < boardHeight; y++)
            {
                int aliveNeighbors = 0;
                for (int i = x-1; i<=x+1;i++)
                {
                    for (int j = y-1;j<=y+1;j++)
                    {
                        if(i>=0 && i<boardWidth && j>=0 && j < boardHeight && gameBoard[i,j])
                        {
                            aliveNeighbors++;
                        }
                    }
                }            

                if (gameBoard[x, y])
                {
                    aliveNeighbors--; // No contar la celda actual en el conteo de vecinos vivos
                }

                if (gameBoard[x, y] && aliveNeighbors < 2)
                {
                    // Celula muere por baja población
                    cloneBoard[x, y] = false;
                }
                else if (gameBoard[x, y] && aliveNeighbors > 3)
                {
                    // Celula muere por sobrepoblación
                    cloneBoard[x, y] = false;
                }
                else if (!gameBoard[x, y] && aliveNeighbors == 3)
                {
                    // Celula nace por reproducción
                    cloneBoard[x, y] = true;
                }
                else
                {
                    // Celula mantiene el estado que tenía
                    cloneBoard[x, y] = gameBoard[x, y];
                }
            }
        }

        gameBoard = cloneBoard;
    }
}
