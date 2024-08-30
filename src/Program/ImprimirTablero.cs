using System;
using System.Text;
using System.Threading;

namespace Ucu.Poo.GameOfLife;

public class ImprimirTablero
{
    public static bool Imprimir(bool[,]gameBoard)
    {
        
        int width = gameBoard.GetLength(0);
        int height = gameBoard.GetLength(1);
        {
            Console.Clear();
            StringBuilder s = new StringBuilder();
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (gameBoard[x, y])
                    {
                        s.Append("|X|");
                    }
                    else
                    {
                        s.Append("___");
                    }
                }

                s.Append("\n");
            }

            Console.WriteLine(s.ToString());
            //=================================================
            //Invocar método para calcular siguiente generación
            //=================================================
            Thread.Sleep(300);
        }
        return true;
    }
}
