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
    
    switch(opcaoEscolhidaInt)
    {
        case 1: Console.WriteLine("Você escolheu a opção: " + opcaoEscolhidaInt);
            break; case 2: Console.WriteLine("Você escolheu a opção: " + opcaoEscolhidaInt);
            break; case 3: Console.WriteLine("Você escolheu a opção: " + opcaoEscolhidaInt);
            break; case 4: Console.WriteLine("Você escolheu a opção: " + opcaoEscolhidaInt);
            break; case 5: Console.WriteLine("Tchau Tchau");
            break;
            default: Console.WriteLine("Opção inválida"); break;
    }
}
ExibirMensagemDeBoasVindas();
ExibirMenuOpções();

