using Tamagotch.Modelos;
using Tamagotch.View;

namespace Tamagotch.Servicos;

internal class Menu
{
    public string NomeMascote { get; set; }

    private List<string> mascotes = new List<string>();

    private string TelaMenu(string nome)
    {
        Console.Clear();
        Tela.Titulo();
        if (nome.Length == 0) 
        { 
            Tela.SolicitarNome();
            nome = Console.ReadLine();
        }
        Tela.PularLinha(2);
        Tela.ExibirMenu(nome);
        return nome;
    }

    public void AbriTela()
    {
        string nome = string.Empty;
        nome = TelaMenu(nome);
        int opcao = int.Parse(Console.ReadLine());

        while (opcao != 3)
        {
            switch (opcao)
            {
                case 1:
                    AdotarMascote(nome);
                    break;

                case 2:
                    VerMascotes();
                    break;
            }
            TelaMenu(nome);
            opcao = int.Parse(Console.ReadLine());
        }
    }

    private void VerMascotes()
    {
        foreach (string mascote in mascotes)
        {
            Console.WriteLine(mascote);
        }
        Console.WriteLine("Pressione uma tecla para voltar");
        Console.ReadLine();
    }

    private void AdotarMascote(string nome)
    {
        EspeciePacote pacote = EspecieApi.BuscarEspecies(10, 0);
        Tela.ExibirMenuAdocao(nome, pacote.Especies);
        NomeMascote = Console.ReadLine();
        Tela.ExibirMenuMascote(nome, NomeMascote);
        int opcao = int.Parse(Console.ReadLine());
        while (opcao != 3)
        {
            switch (opcao)
            {
                case 1:
                    SaberMais(nome);
                    break;
                case 2: Adotar(nome);
                    break;
            }
            Tela.ExibirMenuMascote(nome, NomeMascote);
            opcao = int.Parse(Console.ReadLine());
        }
    }

    private void SaberMais(string nome)
    {
        Tela.PularLinha(2);
        string detalhe = EspecieApi.Caracteristicas(NomeMascote);
    }

    private void Adotar(string nome)
    {
        mascotes.Add(NomeMascote);
        Console.WriteLine($"{nome} MASCOTE ADOTADO COM SUCESSO, O OVO ESTÁ CHOCANDO!");
        Console.WriteLine("Adotado com sucesso !");
    }
 }
