using System.IO;

namespace Ucu.Poo.GameOfLife;

public class LeerTablero
{
    public static string[] Leer(string Url)
    {
        string url = "board.txt";
        string content = File.ReadAllText(url);
        string[] contentLines = content.Split('\n');
        return contentLines;
    }
}

