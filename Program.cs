using System;
using System.Threading;

class Program
{
    static int[] firstOctave = new int[12] { 37, 39, 41, 41, 45, 48, 50, 53, 57, 61, 65, 69 };
    static int[] secondOctave = new int[12] { 65, 69, 73, 78, 82, 87, 93, 98, 103, 110, 116, 123 };
    static int[] thirdOctave = new int[12] { 130, 138, 146, 155, 164, 174, 185, 194, 207, 220, 223, 246 };
    static int[] osnOctave = firstOctave;

    static void Main()
    {
        Console.WriteLine("Переключение между октавами F1-F3");
        Console.WriteLine("Первая октава");
        Console.WriteLine("Для выхода нажмите ESC");

        while (true)
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Escape)
                {
                    break;
                }
                else if (key.Key >= ConsoleKey.F1 && key.Key <= ConsoleKey.F3)
                {
                    ChangeOctave((int)key.Key - (int)ConsoleKey.F1 + 1);
                }
                else
                {
                    Vivod(key); 
                }
            }
        }
    }

    static void ChangeOctave(int octave)
    {
        switch (octave)
        {
            case 1:
                osnOctave = firstOctave;
                Console.WriteLine("Переключено на первую октаву.");
                break;
            case 2:
                osnOctave = secondOctave;
                Console.WriteLine("Переключено на вторую октаву.");
                break;
            case 3:
                osnOctave = thirdOctave;
                Console.WriteLine("Переключено на третью октаву.");
                break;
            default:
                Console.WriteLine("Неверный выбор октавы.");
                break;
        }
    }

    static void Vivod(ConsoleKeyInfo key)
    {
        switch (key.Key)
        {
            case ConsoleKey.D1:
                Console.Beep(osnOctave[0], 500);
                break;
            case ConsoleKey.D2:
                Console.Beep(osnOctave[2], 500);
                break;
            case ConsoleKey.D3:
                Console.Beep(osnOctave[4], 500);
                break;
            case ConsoleKey.D4:
                Console.Beep(osnOctave[5], 500);
                break;
            case ConsoleKey.D5:
                Console.Beep(osnOctave[7], 500);
                break;
            case ConsoleKey.D6:
                Console.Beep(osnOctave[9], 500);
                break;
            case ConsoleKey.D7:
                Console.Beep(osnOctave[11], 500);
                break;
            case ConsoleKey.A:
                Console.Beep(osnOctave[1], 500);
                break;
            case ConsoleKey.S:
                Console.Beep(osnOctave[3], 500);
                break;
            case ConsoleKey.D:
                Console.Beep(osnOctave[6], 500);
                break;
            case ConsoleKey.F:
                Console.Beep(osnOctave[8], 500);
                break;
            case ConsoleKey.G:
                Console.Beep(osnOctave[10], 500);
                break;
        }
    }
}
