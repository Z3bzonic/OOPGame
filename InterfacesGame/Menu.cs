namespace InterfacesGame
{
    public class Menu
    {
        public int SelectMenu(params string[] menu)
        {
            InitiateMenu();
            int selection = 1;
            bool selected = false;
            ConsoleColor selectionForeground = Console.BackgroundColor;
            ConsoleColor selectionBackground = Console.ForegroundColor;
            while (!selected)
            {
                int teller = 0;
                foreach (var item in menu)
                {
                    teller++;
                    if (selection == teller)
                    {
                        Console.ForegroundColor = selectionForeground;
                        Console.BackgroundColor = selectionBackground;
                    }
                    Console.SetCursorPosition(30 + teller, 19 + teller);
                    Console.Write($"{item}{Environment.NewLine}");
                    Console.ResetColor();
                }
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        selection--;
                        break;

                    case ConsoleKey.DownArrow:
                        selection++;
                        break;

                    case ConsoleKey.Enter:
                        selected = true;
                        break;
                }
                selection = Math.Min(Math.Max(selection, 1), menu.Length);
            }
            Console.Clear();
            return selection;
        }

        private void InitiateMenu()
        {
            Console.WindowHeight = 40;
            Console.WindowWidth = 80;
            Console.CursorVisible = false;
            Console.Clear();
        }
    }
}