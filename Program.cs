using System;

public class KeyListener
{
    public event Action EnterKeyPressed;
    public event Action SpaceKeyPressed;
    public event Action EscapeKeyPressed;
    public event Action F1KeyPressed;
    public event Action LeftKeyPressed;
    public event Action RightKeyPressed;
    public event Action UpKeyPressed;
    public event Action DownKeyPressed;

    public void Listen()
    {
        while (true)
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.Enter:
                        EnterKeyPressed?.Invoke();
                        break;
                    case ConsoleKey.Spacebar:
                        SpaceKeyPressed?.Invoke();
                        break;
                    case ConsoleKey.Escape:
                        EscapeKeyPressed?.Invoke();
                        break;
                    case ConsoleKey.F1:
                        F1KeyPressed?.Invoke();
                        break;
                    case ConsoleKey.LeftArrow:
                        LeftKeyPressed?.Invoke();
                        break;
                    case ConsoleKey.RightArrow:
                        RightKeyPressed?.Invoke();
                        break;
                    case ConsoleKey.UpArrow:
                        UpKeyPressed?.Invoke();
                        break;
                    case ConsoleKey.DownArrow:
                        DownKeyPressed?.Invoke();
                        break;
                }
            }
        }
    }
}

public class Person
{
    public void Jump()
    {
        Console.WriteLine("Jump method called");
    }

    public void Select()
    {
        Console.WriteLine("Select method called");
    }

    public void Move()
    {
        Console.WriteLine("Move method called");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var keyListener = new KeyListener();
        var person = new Person();

        keyListener.SpaceKeyPressed += person.Jump;
        keyListener.EnterKeyPressed += person.Select;
        keyListener.LeftKeyPressed += person.Move;
        keyListener.RightKeyPressed += person.Move;
        keyListener.UpKeyPressed += person.Move;
        keyListener.DownKeyPressed += person.Move;

        keyListener.Listen();
    }
}
