// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

string mensagemDeBoaVidas = "Boas vindas ao Screen Sound";
//List<string> listaDasBandas = new List<string> { "fsadf", " asdfasf"};

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Link", new List<int> { 10, 9, 8, 7, 6 });
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 9, 8, 7, 6 });
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
            break;
        case 2:MostrarBandasRegistras();
            break; case 3: AvaliarUmaBanda();
            break; case 4: Console.WriteLine("Você escolheu a opção: " + opcaoEscolhidaInt);
            break; case 5: Console.WriteLine("Tchau Tchau");
            break;
            default: Console.WriteLine("Opção inválida"); break;
    }
}
    void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registrar uma banda");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenuOpções();
}
    void MostrarBandasRegistras()
{
    Console.Clear();
    ExibirTituloDaOpcao("Mostrar bandas registradas");
    //for (int i =0; i < listaDasBandas.Count; i++)
    //{
    //   Console.WriteLine($"Banda : {listaDasBandas[i]}");

    //}
    foreach (string banda in bandasRegistradas.Keys)
    {
Console.WriteLine($"Banda : {banda}");
    }
    Console.WriteLine("\nDigite um tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirMenuOpções();

}
void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos);
    Console.WriteLine(asteriscos = "\n");
}
void AvaliarUmaBanda()
{
    //digite qual banda deseja avaliar
    //se a banda exitir no dicionario >> atribuir uma nota
    //se a banda não existir >> mostrar mensagem de menu principal
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar uma banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if ( bandasRegistradas.ContainsKey(nomeDaBanda))
    {
    Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
    int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"A nota {nota} foi registrada com sucesso  para a banda{nomeDaBanda}");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirMenuOpções();
    } else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Pressione uma tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirMenuOpções();
    }
}

ExibirMenuOpções();

