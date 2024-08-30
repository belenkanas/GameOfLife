using System.IO;

namespace Ucu.Poo.GameOfLife;

public class MatrizArchivo
{
    public static bool[,] Matriz(string[] contentLines)
    /*
     * Toma cada linea leída anteriormente por la clase LeerTablero y cambia los "1" por valo true
     * y los "0" por valor false; generando una tabla de tipo booleano.
     */
    {
        bool[,] board = new bool[contentLines[0].Length, contentLines.Length];
        for (int y = 0; y < contentLines.Length; y++)
        {
            for (int x = 0; x < contentLines[y].Length; x++)
            {
                if (contentLines[y][x] == '1')
                {
                    board[x, y] = true;
                }
            }
        }

        return board;
    }
}