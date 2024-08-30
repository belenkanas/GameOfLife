using System;
using System.Text;
using System.Threading;

namespace Ucu.Poo.GameOfLife;

public class ImprimirTablero

{
    public static bool Imprimir(bool[,]gameBoard)
    {
        
        int width = gameBoard.GetLength(0); // Toma los valores del largo y ancho del gameBoard de la lógica del juego
        int height = gameBoard.GetLength(1);
        {
            Console.Clear();
            StringBuilder s = new StringBuilder(); // Crea una nueva línea de tipo string,
            for (int y = 0; y < height; y++)       // evalúa en cada carácter la presencia de una célula
            {
                for (int x = 0; x < width; x++)
                {
                    if (gameBoard[x, y])            // es decir, si el valor es true o false
                    {
                        s.Append("|X|");            //Si es true, a la linea le agrega X, de lo contrario agrega _.
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
