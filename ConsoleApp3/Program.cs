using ConsoleApp3;

class Menu
{
    static void Main(string[] args)
    {
        int opt = 1;
        while(opt != 3)
        {
            Console.Clear();
            switch (opt)
            {
                case 1:
                    Console.WriteLine("Digite seu usuario");
                    string username = Console.ReadLine();
                    Console.WriteLine("Digite sua senha");
                    string password = Console.ReadLine();
                    if (!Repository.Add(new User(username, password))) Console.WriteLine("Não foi possivel cadastrar");
                    else Console.WriteLine("Cadastrado Com Sucesso");
                    break;
                case 2:
                    bool flag = false;
                    for (int i = 0; i < 3 && !flag; i++)
                    {
                        Console.WriteLine("Digite seu usuario");
                        username = Console.ReadLine();
                        Console.WriteLine("Digite sua senha");
                        password = Console.ReadLine();
                        flag = Repository.Auth(username, password);
                    }
                    if (!flag) Console.WriteLine("Erro, não foi possivel logar");
                    break;
                default:
                    Console.WriteLine("Opção Invalida, Digite Denovo");
                    break;
            }
            showMenu();
            int.TryParse(Console.ReadLine(), out opt);
        }
    }

    static void showMenu()
    {
        Console.WriteLine("Digite 1 Para Cadastrar um novo Usuario");
        Console.WriteLine("Digite 2 Para Logar");
        Console.WriteLine("Digite 3 Para Sair");
    }
}