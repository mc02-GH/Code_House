using System;
using System.Threading;

public static class Program
{
    public static void Main()
    {
        new Block() { x = 5, y = 2, color = ConsoleColor.Cyan }.print();
        new Block() { x = 4, y = 3, color = ConsoleColor.Green }.print();
        new Block() { x = 6, y = 3, color = ConsoleColor.Green }.print();
    }
}
public class Block
{
    private int _x;
    private int _y;
    public ConsoleColor color;
    public int x
    {
        get { return _x; }
        set
        {
            if (value >= 0 && value <= 10)
            {
                _x = value;
            }

        }
    }
    public int y
    {
        get { return _y; }
        set
        {
            if (value >= 0 && value <= 10)
            {
                _y = value;
            }
        }
    }

    public void print()
    {
        hide();

        Console.SetCursorPosition(2 * _x, _y);
        Console.BackgroundColor = color;
        Console.Write("  ");
        Console.ResetColor();

    }
    public void hide()
    {

        Console.SetCursorPosition(2 * _x + 2, _y);


        Console.Write("\b\b");



    }


}
