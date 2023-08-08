using ScreenSoundAlura_parte4.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSoundAlura_parte4.Filtros
{
    internal class LinqOrder
    {
        public static void ExibirListaDeArtistaOrdenados(List<Musica> musicas)
        {
            var artistasOrdenados = musicas.OrderBy(musica => musica.Artista)
                .Select(musica => musica.Artista).Distinct().ToList();
            Console.WriteLine("lista de artistas ordenados");
            foreach (var artista in artistasOrdenados)
            {
                Console.WriteLine($"- {artista}");
            }
        }
    }
}
