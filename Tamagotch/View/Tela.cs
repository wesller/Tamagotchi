using Tamagotch.Modelos;

namespace Tamagotch.View;

internal class Tela
{
    static public void ExibirMenu(string nome)
    {
        Separador("MENU");
        Console.WriteLine($"{nome} Você deseja?");
        Console.WriteLine("1 - Adotar um mascote virtual ");
        Console.WriteLine("2 - Ver seus mascotes");
        Console.WriteLine("3 - Sair");
    }

    static public void ExibirMenuAdocao(string nome, Especie[] especies)
    {
        PularLinha(2);
        Separador("ADOTAR UM MASCOTE");
        Console.WriteLine($"{nome} Escolha uma espécie");
        foreach( Especie especie in especies ) Console.WriteLine(especie.Nome);

    }

    static public void ExibirMenuMascote(string nome, string? nomeMascote)
    {
        PularLinha(2);
        Separador("");
        Console.WriteLine($"{nome} Você deseja?");
        Console.WriteLine($"1 - Saber mais sobre {nomeMascote}");
        Console.WriteLine($"2 - Adotar {nomeMascote}");
        Console.WriteLine("3 - Voltar");
    }

    static public void SolicitarNome()
    {
        Console.Write("Qual é o seu nome?");
    } 
    
    static public void PularLinha(int Quantidade = 1)
    {
        for (int i = 0; i < Quantidade; i++)
        {
            Console.WriteLine();
        }
    }

    static public void Separador(string msg)
    {
        int tamanho = 30 - msg.Length;
        string separador = string.Empty.PadLeft(tamanho, '=');
        if (msg.Length > 0 )
        {
            separador += " " + msg + " ";
        }
        separador += string.Empty.PadLeft(tamanho, '=');
        Console.WriteLine(separador);
    }

    static public void Titulo()
    {
        Console.WriteLine(@"
████████╗░█████╗░███╗░░░███╗░█████╗░░██████╗░░█████╗░████████╗░█████╗░██╗░░██╗
╚══██╔══╝██╔══██╗████╗░████║██╔══██╗██╔════╝░██╔══██╗╚══██╔══╝██╔══██╗██║░░██║
░░░██║░░░███████║██╔████╔██║███████║██║░░██╗░██║░░██║░░░██║░░░██║░░╚═╝███████║
░░░██║░░░██╔══██║██║╚██╔╝██║██╔══██║██║░░╚██╗██║░░██║░░░██║░░░██║░░██╗██╔══██║
░░░██║░░░██║░░██║██║░╚═╝░██║██║░░██║╚██████╔╝╚█████╔╝░░░██║░░░╚█████╔╝██║░░██║
░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░░░░╚═╝╚═╝░░╚═╝░╚═════╝░░╚════╝░░░░╚═╝░░░░╚════╝░╚═╝░░╚═╝");
        Console.WriteLine();
        Console.WriteLine();
    }

}
