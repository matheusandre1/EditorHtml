using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();


            Tela();
            OpcoesUsuarios();

            var opcao = short.Parse(Console.ReadLine());
            MenuOpcao(opcao);

        }

        public static void Tela()
        {
            Console.Write("+");
            for (int i = 0; i < 30; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");

            for (int linha = 0; linha <= 10; linha++)
            {
                Console.Write("|");
                for (int i = 0; i < 30; i++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");

            }

            Console.Write("+");
            for (int i = 0; i < 30; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");


        }


        public static void OpcoesUsuarios()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTMl");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("===========");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");




        }

        public static void MenuOpcao(short opcao)
        {
            switch (opcao)
            {
                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("Visualizar"); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;

            }
        }
    }
} 