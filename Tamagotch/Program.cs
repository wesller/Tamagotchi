using System.Text.Json;
using System.Text.Json.Nodes;
using Tamagotch.Modelos;
using Tamagotch.Servicos;

internal class Program
{
    private static void Main(string[] args)
    {
        EspeciePacote pacote = EspecieApi.BuscarEspecies(100,0);
        Console.WriteLine($"Retornou {pacote.Count} espécies");
        foreach(var especie in pacote.Especies)
        {
            Console.WriteLine($"Espécie -> {especie.Nome}");
        }
        
        Console.Write("Digite uma especie para maiores informações:");
        string especieDetalhada = Console.ReadLine();
        Console.Clear();
        Console.WriteLine(new string('-',40));
        string detalhe = EspecieApi.Caracteristicas(especieDetalhada);
    }
}

