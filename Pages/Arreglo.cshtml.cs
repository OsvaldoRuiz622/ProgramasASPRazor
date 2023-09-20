using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Programas_Tarea.Pages
{
    public class ArregloModel : PageModel
    {
        public List<int> NumerosGenerados { get; set; }
        public int Suma { get; set; }
        public double Promedio { get; set; }
        public int Moda { get; set; }
        public double Mediana { get; set; }

        public void OnPost()
        {
            // Generar 20 n�meros aleatorios entre 0 y 100
            Random rand = new Random();

            NumerosGenerados = Enumerable.Range(0, 20).Select(_ => rand.Next(0, 101)).ToList();

            // Calcular la suma
            Suma = NumerosGenerados.Sum();

            // Calcular el promedio
            Promedio = NumerosGenerados.Average();

            // Calcular la moda (valor m�s frecuente)
            Moda = NumerosGenerados.GroupBy(x => x)
                                  .OrderByDescending(x => x.Count())
                                  .First().Key;

            // Calcular la mediana (valor central)
            NumerosGenerados.Sort();
            Mediana = NumerosGenerados[NumerosGenerados.Count / 2];
        }
        public void OnGet()
        {
        }
    }
}
