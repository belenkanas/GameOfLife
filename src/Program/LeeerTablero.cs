using System.IO;

namespace Ucu.Poo.GameOfLife;

public class LeerTablero
{
    public static string[] Leer(string Url)
    /*
     * Toma como parámetro el enlace al texto que contiene la información del tablero que se usará en el juego,
     * para que luego poder ser interpretado en valores booleanos por la clase MatrizArchivo.
     */
    {
        string url = "board.txt";
        string content = File.ReadAllText(url);
        string[] contentLines = content.Split('\n');
        return contentLines;
    }
}

