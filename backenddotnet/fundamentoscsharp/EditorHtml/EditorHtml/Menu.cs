using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            DrawScreen(30, 10);
            WriteOptions();

            short option;
            
            var hasOption = short.TryParse(Console.ReadLine(), out option);
            if(hasOption){
                HandleMenuOption(option);
            }
            else {
                Console.WriteLine("Erro ao escolher opção! Tente novamente.");
                Show();
            }
        }

        public static void HandleMenuOption(short option)
        {
            switch(option) 
            {
                case 1: {
                    Console.WriteLine("Editor"); 
                    break;
                }
                case 2: {
                    Console.WriteLine("View");
                    break;
                }
                case 0: {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
                default: {
                    Show();
                    break;
                }
            }
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("-----------");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção:");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir arquivo");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");
        }

        public static void DrawScreen(int columns, int rows)
        {
            DrawBottomTop(columns);
            DrawCenter(columns, rows);
            DrawBottomTop(columns);
        }

        public static void DrawBottomTop(int columns)
        {
            Console.Write("+");
            for (int i = 0; i <= columns; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
        }

        public static void DrawCenter(int columns, int rows)
        {
            for (int lines = 0; lines <= rows; lines++)
            {
                Console.Write("|");   
                for (int i = 0; i <= columns; i++)
                {
                    Console.Write(" ");
                }  
                Console.Write("|");   
                Console.Write("\n");
            }
        }
    }
}