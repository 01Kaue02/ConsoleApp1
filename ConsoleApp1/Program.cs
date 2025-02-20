// See https://aka.ms/new-console-template for more information
string mensagemDeBoaVidas = "Boas vindas ao Screen Sound";
List<string> listaDasBandas = new List<string>();

void ExibirLogo ()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░

");
    Console.WriteLine(mensagemDeBoaVidas);
}

void ExibirMenuOpções ()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma bandas");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar as bandas");
    Console.WriteLine("Digite 4 para fazer as medias das bandas");
    Console.WriteLine("Digite 5 para sair");

    Console.WriteLine("\nDigite a opção desejada: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaInt = int.Parse(opcaoEscolhida);
    
    switch(opcaoEscolhidaInt)
    {
        case 1: RegistrarBanda();
            break; case 2: Console.WriteLine("Você escolheu a opção: " + opcaoEscolhidaInt);
            break; case 3: Console.WriteLine("Você escolheu a opção: " + opcaoEscolhidaInt);
            break; case 4: Console.WriteLine("Você escolheu a opção: " + opcaoEscolhidaInt);
            break; case 5: Console.WriteLine("Tchau Tchau");
            break;
            default: Console.WriteLine("Opção inválida"); break;
    }
}
    void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDasBandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenuOpções();
}

ExibirMenuOpções();

