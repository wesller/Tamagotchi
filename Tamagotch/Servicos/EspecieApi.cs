using Tamagotch.Modelos;
using System.Text.Json;
using System.Collections.Generic;
using System.Threading.Tasks.Sources;


namespace Tamagotch.Servicos;

internal class EspecieApi
{
    public static EspeciePacote BuscarEspecies(int limit = 20, int offset = 20)
    {
        try
        {
            HttpClient client = new HttpClient();
            Task<string> tarefa = client.GetStringAsync($"https://pokeapi.co/api/v2/pokemon-species?offset={offset}&limit={limit}");
            string resposta = tarefa.Result;
            client.Dispose();
            //Console.WriteLine(resposta);
            return JsonSerializer.Deserialize<EspeciePacote>(resposta);

        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nTemos um problema: {ex.Message}");
            return new EspeciePacote();
        }
     
    }

    public static string Caracteristicas(string especie)
    {
        try
        {
            HttpClient client = new HttpClient();
            Task<string> tarefa = client.GetStringAsync($"https://pokeapi.co/api/v2/pokemon/{especie}/");
            string resposta = tarefa.Result;
            client.Dispose();
            Mascote mascote = JsonSerializer.Deserialize<Mascote>(resposta);

            Console.WriteLine($"Nome Pokemon: {especie}");
            Console.WriteLine($"Altura: {mascote.Altura}");
            Console.WriteLine($"Peso: {mascote.Peso}");
            Console.WriteLine("Habilidades:");
            foreach (var item in mascote.abilities) {
            Console.WriteLine(item.ability.Name);
            }
            return resposta;

        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nTemos um problema: {ex.Message}");
            return "";
        }
    }
}
 