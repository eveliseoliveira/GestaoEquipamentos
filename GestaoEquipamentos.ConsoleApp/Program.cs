using System;

namespace GestaoEquipamentos.ConsoleApp
{
    internal class Program
    {
        static string[] nome_equipamento = new string[1000];
        static decimal[] preco_equipamento = new decimal[1000];
        static string[] numero_serie = new string[1000];
        static string[] data_fabricacao = new string[1000];
        static string[] nome_fabricante = new string[1000];

        static string[] titulo_chamado = new string[1000];
        static string[] descricao_chamado = new string[1000];
        static string[] data_chamado = new string[1000];

        static int contador_equipamento = 0;
        static int contador_chamado = 0;
        static void Main(string[] args)
        {
            while (true)
            {
                string opcao = Menu_Principal();

                if (opcao == "S" || opcao == "s")
                    break;

                if (opcao == "1")
                {
                    string opcao_submenu = SubMenu_Equipamento();

                    if (opcao_submenu == "S" || opcao_submenu == "s")
                        continue;

                    if (opcao_submenu == "1")
                        Inserir_Equipamento();

                    else if (opcao_submenu == "2")
                        Visualizar_Equipamento();

                    else if (opcao_submenu == "3")
                        Editar_Equipamento();

                    else if (opcao_submenu == "4")
                        Excluir_Equipamento();
                }
                else if (opcao == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Gestão de Equipamentos\n");

                    Console.WriteLine("[1] Inserir Novo Chamado\n[2] Visualizar Chamado\n" +
                        "[3] Editar Chamado\n[4] Excluir Chamado\n[S] Sair\n");

                    string opcao_submenu = Console.ReadLine();

                    if (opcao_submenu == "S" || opcao_submenu == "s")
                        continue;

                    if (opcao == "1")
                    {
                        opcao_submenu = SubMenu_Chamados();

                        if (opcao_submenu == "S" || opcao_submenu == "s")
                            continue;

                        if (opcao_submenu == "1")
                            Inserir_Chamado();

                        else if (opcao_submenu == "2")
                            Visualizar_Chamado();

                        else if (opcao_submenu == "3")
                            Editar_Chamado();

                        else if (opcao_submenu == "4")
                            Excluir_Chamado();
                    }
                }
                Console.ReadLine();
            }
        }

        #region Cadastro de Equipamentos
        static string Menu_Principal()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Equipamentos\n");

            Console.WriteLine("[1] Cadastro de Equipamentos\n[2] Controle de Chamados\n[S] Sair\n");

            string opcao = Console.ReadLine();

            return opcao;
        }

        static string SubMenu_Equipamento()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Equipamentos\n");

            Console.WriteLine("[1] Inserir Novo Equipamento\n[2] Visualizar Equipamento\n" +
                "[3] Editar Equipamento\n[4] Excluir Equipamento\n[S] Sair\n");

            string opcao_submenu = Console.ReadLine();

            return opcao_submenu;
        }

        static void Inserir_Equipamento()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Equipamentos\n");

            Console.WriteLine("Cadastro Novo Equipamento:\n");


            Console.WriteLine("\nNome do equipamento: ");
            string nome = Console.ReadLine();
            nome_equipamento[contador_equipamento] = nome;

            Console.WriteLine("Preço do equipamento: ");
            decimal preco = Convert.ToInt32(Console.ReadLine());
            preco_equipamento[contador_equipamento] = preco;

            Console.WriteLine("Número de série: ");
            string serie = Console.ReadLine();
            numero_serie[contador_equipamento] = serie;

            Console.WriteLine("Data de fabricação: ");
            string data = Console.ReadLine();
            data_fabricacao[contador_equipamento] = data;

            Console.WriteLine("Nome do fabricante: ");
            string fabricante = Console.ReadLine();
            nome_fabricante[contador_equipamento] = fabricante;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Equipamento Cadastrado!");
            Console.ResetColor();

            contador_equipamento++;
        }

        static void Visualizar_Equipamento()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Equipamentos\n");

            Console.WriteLine("Visualizando Equipamentos:");

            for (int i = 0; i < 1000; i++)
            {
                if (nome_equipamento[i] != null)
                {
                    Console.WriteLine("\nNome do equipamento: " + nome_equipamento[i]);
                    Console.WriteLine("Preço do equipamento: " + preco_equipamento[i]);
                    Console.WriteLine("Número de série: " + numero_serie[i]);
                    Console.WriteLine("Data de fabricação: " + data_fabricacao[i]);
                    Console.WriteLine("Nome do fabricante: " + nome_fabricante[i]);
                }
            }
        }

        private static void Editar_Equipamento()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Equipamentos\n");

            Console.WriteLine("Editar Equipamento:\n");

            Console.ReadLine();

            Console.WriteLine("O que deseja editar?");

            Console.WriteLine("[1] Nome do Equipamento\n[2] Preço do equipamento\n[3] Número de série\n" +
                "[4] Data de fabricação\n[5] Nome do fabricante");
            string opcao = Console.ReadLine();

            Console.WriteLine("Qual posição do equipamento que deseja editar: ");
            contador_equipamento = int.Parse(Console.ReadLine());

            if (opcao == "1")
            {
                Console.WriteLine("\nNome equipamento: ");
                nome_equipamento[contador_equipamento] = Convert.ToString(Console.ReadLine());
            }
            else if (opcao == "2")
            {
                Console.WriteLine("Preço do equipamento: ");
                preco_equipamento[contador_equipamento] = Convert.ToDecimal(Console.ReadLine());
            }
            else if (opcao == "3")
            {
                Console.WriteLine("Número de série: ");
                numero_serie[contador_equipamento] = Convert.ToString(Console.ReadLine());
            }
            else if (opcao == "4")
            {
                Console.WriteLine("Data de fabricação: ");
                data_fabricacao[contador_equipamento] = Convert.ToString(Console.ReadLine());
            }
            else if (opcao == "5")
            {
                Console.WriteLine("Nome do fabricante: ");
                nome_fabricante[contador_equipamento] = Convert.ToString(Console.ReadLine());
            }

            contador_equipamento++;

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Equipamento Editado!");
            Console.ResetColor();
        }

        private static void Excluir_Equipamento()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Equipamentos\n");

            Console.WriteLine("Excluir Equipamento:\n");

            Console.ReadLine();

            Console.WriteLine("Informe a posição do equipamento: ");
            contador_equipamento = Convert.ToInt32(Console.ReadLine());

            for (int i = contador_equipamento - 1; i < 1000; i++)
            {
                nome_equipamento[i] = nome_equipamento[i + 1];
                preco_equipamento[i] = preco_equipamento[i + 1];
                numero_serie[i] = numero_serie[i + 1];
                data_fabricacao[i] = data_fabricacao[i + 1];
                nome_fabricante[i] = nome_fabricante[i + 1];
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Equipamento Excluido!");
            Console.ResetColor();
        }
        #endregion

        #region Controle de Chamados
        private static string SubMenu_Chamados()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Chamados\n");

            Console.WriteLine("[1] Inserir Novo Chamado\n[2] Visualizar Chamado\n" +
                "[3] Editar Chamado\n[4] Excluir Chamado\n[S] Sair\n");

            string opcao_submenu = Console.ReadLine();

            return opcao_submenu;
        }

        private static void Inserir_Chamado()
        {
            Console.Clear();
            Console.WriteLine("Controle de Chamados\n");

            Console.WriteLine("Cadastro Novo Chamado:\n");


            Console.WriteLine("\nTítulo do chamado: ");
            string titulo = Console.ReadLine();
            titulo_chamado[contador_chamado] = titulo;

            Console.WriteLine("Descrição do chamado: ");
            string descricao = Console.ReadLine();
            descricao_chamado[contador_chamado] = descricao;

            Console.WriteLine("Data de abertura: ");
            string data = Console.ReadLine();
            data_chamado[contador_chamado] = data;

            Console.WriteLine("Insira a posição equivalente ao equipamento: ");
            contador_equipamento = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < contador_equipamento; i++)
            {
                if (nome_equipamento[contador_equipamento] == nome_equipamento[i])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Equipamento encontrado!");
                    Console.ResetColor();
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Equipamento não encontrado!");
                    Console.ResetColor();
                    continue;
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Chamado Cadastrado!");
            Console.ResetColor();

            contador_chamado++;
        }

        private static void Visualizar_Chamado()
        {
            Console.Clear();
            Console.WriteLine("Controle de Chamado\n");

            Console.WriteLine("Visualizando Chamados:");

            for (int i = 0; i < 1000; i++)
            {
                if (titulo_chamado[i] != null)
                {
                    Console.WriteLine("\nTítulo do chamado: " + titulo_chamado[i]);
                    Console.WriteLine("Equipamento: " + nome_equipamento[i]);
                    Console.WriteLine("Data de abertura: " + data_chamado[i]);

                    DateTime data_chamado = Convert.ToDateTime(data_chamado);
                    TimeSpan diferenca = DateTime.Today - data_chamado;
                    double dias = diferenca.TotalDays;

                    Console.WriteLine("Número de dias que o chamado está aberto: " + data_chamado, dias);
                }
            }
        }

        private static void Editar_Chamado()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Equipamentos\n");

            Console.WriteLine("Editar Chamados:\n");

            Console.ReadLine();

            Console.WriteLine("O que deseja editar?");

            Console.WriteLine("[1] Título do chamado\n[2] Descrição do chamado\n" +
                "[3] Equipamento\n[4] Data do chamado");

            string opcao = Console.ReadLine();

            Console.WriteLine("Qual posição do chamado que deseja editar: ");
            contador_chamado = int.Parse(Console.ReadLine());

            if (opcao == "1")
            {
                Console.WriteLine("\nTítulo do chamado: ");
                titulo_chamado[contador_chamado] = Convert.ToString(Console.ReadLine());
            }
            else if (opcao == "2")
            {
                Console.WriteLine("Descrição do chamado: ");
                descricao_chamado[contador_chamado] = Convert.ToString(Console.ReadLine());
            }
            else if (opcao == "3")
            {

                Console.WriteLine("Editar equipamento:\n");

                Console.WriteLine("Qual posição do equipamento que deseja editar: ");
                contador_equipamento = int.Parse(Console.ReadLine());

                Console.WriteLine("\nNome equipamento: ");
                nome_equipamento[contador_equipamento] = Convert.ToString(Console.ReadLine());


                Console.WriteLine("Preço do equipamento: ");
                preco_equipamento[contador_equipamento] = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Número de série: ");
                numero_serie[contador_equipamento] = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Data de fabricação: ");
                data_fabricacao[contador_equipamento] = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Nome do fabricante: ");
                nome_fabricante[contador_equipamento] = Convert.ToString(Console.ReadLine());

                contador_equipamento++;
            }
            else if (opcao == "4")
            {
                Console.WriteLine("Data de abertura: ");
                data_chamado[contador_equipamento] = Convert.ToString(Console.ReadLine());
            }

            contador_chamado++;

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Chamado Editado!");
            Console.ResetColor();
        }

        private static void Excluir_Chamado()
        {
            Console.Clear();
            Console.WriteLine("Controle de Chamados\n");

            Console.WriteLine("Excluir Chamado:\n");

            Console.ReadLine();

            Console.WriteLine("Informe a posição do chamado: ");
            contador_chamado = Convert.ToInt32(Console.ReadLine());

            for (int i = contador_chamado - 1; i < 1000; i++)
            {
                titulo_chamado[i] = titulo_chamado[i + 1];
                preco_equipamento[i] = preco_equipamento[i + 1];
                descricao_chamado[i] = descricao_chamado[i + 1];
                data_chamado[i] = data_chamado[i + 1];
                nome_equipamento[i] = nome_equipamento[i + 1];
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Chamado Excluido!");
            Console.ResetColor();
        }
        #endregion
    }
}

