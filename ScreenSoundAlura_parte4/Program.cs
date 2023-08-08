using ScreenSoundAlura_parte4.Filtros;
using ScreenSoundAlura_parte4.Modelos;
using System.Collections.Generic;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        LinqFilter.FiltrarMusicasEmCSharp(musicas);

        //musicas[0].ExibirDetalheDaMusica();
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistaOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "hip hop");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Michael Jackson");

        //var musicaPreferidasDaIsa = new MusicasPreferidas("Isadora");
        //musicaPreferidasDaIsa.AdicionarMusicasFavoritas(musicas[5]);
        //musicaPreferidasDaIsa.AdicionarMusicasFavoritas(musicas[307]);
        //musicaPreferidasDaIsa.AdicionarMusicasFavoritas(musicas[9]);
        //musicaPreferidasDaIsa.AdicionarMusicasFavoritas(musicas[6]);
        //musicaPreferidasDaIsa.AdicionarMusicasFavoritas(musicas[1487]);

        //musicaPreferidasDaIsa.ExibirMusicasFavoritas();

        //var musicasPreferidasEmilly = new MusicasPreferidas("Emy");

        //musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[500]);
        //musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[637]);
        //musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[428]);
        //musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[13]);
        //musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[71]);

        //musicasPreferidasEmilly.ExibirMusicasFavoritas();
        //musicaPreferidasDaIsa.GerarArquivoJson();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"temos um problema: {ex.Message}");
    }



}