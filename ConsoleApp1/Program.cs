// See https://aka.ms/new-console-template for more information
string mensagemDeBoaVidas = "Boas vindas ao Screen Sound";

void ExibirMensagemDeBoasVindas()
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
    Console.WriteLine("\nDigite 1 para registrar uma bandas");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar as bandas");
    Console.WriteLine("Digite 4 para fazer as medias das bandas");
    Console.WriteLine("Digite 5 para sair");

    Console.WriteLine("\nDigite a opção desejada: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaInt = int.Parse(opcaoEscolhida);
    if (opcaoEscolhidaInt == 1)
    {
        Console.WriteLine("você digitou a opção: " + opcaoEscolhida);
    }
    
}
ExibirMensagemDeBoasVindas();
ExibirMenuOpções();

