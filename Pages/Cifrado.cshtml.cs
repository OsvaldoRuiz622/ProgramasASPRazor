using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Programas_Tarea.Pages
{
    public class CifradoModel : PageModel
    {
        [BindProperty]
        public string Mensaje { get; set; }

        [BindProperty]
        public int Desplazamiento { get; set; }

        public string ResultadoCifrado { get; private set; }

        public void OnPost()
        {
            if (!string.IsNullOrEmpty(Mensaje))
            {
                ResultadoCifrado = CifrarMensaje(Mensaje, Desplazamiento);
            }
        }

        private string CifrarMensaje(string mensaje, int desplazamiento)
        {
            string mensajeCifrado = "";
            foreach (char caracter in mensaje)
            {
                if (char.IsLetter(caracter))
                {
                    char baseLetra = char.IsUpper(caracter) ? 'A' : 'a';
                    char letraCifrada = (char)(((caracter - baseLetra + desplazamiento) % 26) + baseLetra);
                    mensajeCifrado += letraCifrada;
                }
                else
                {
                    mensajeCifrado += caracter;
                }
            }
            return mensajeCifrado;
        }
        public void OnGet()
        {
        }
    }
}
