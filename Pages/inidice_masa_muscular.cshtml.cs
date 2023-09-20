using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Programas_Tarea.Pages
{
    public class inidice_masa_muscularModel : PageModel
    {
        [BindProperty]
        public double Peso { get; set; }
        [BindProperty]
        public double Altura { get; set; }
        public string Resultado { get; set; }
        public string Mensaje { get; set; }

        public void OnPost()
        {
            // Calcular el IMC
            double imc = Peso / (Altura * Altura);

            // Determinar el mensaje según el IMC
            if (imc < 17.9)
            {
                Resultado = imc.ToString("0.00");
                Mensaje = "Tiene un Peso Bajo :s";
            }
            else if (imc >= 18 && imc < 24.9)
            {
                Resultado = imc.ToString("0.00");
                Mensaje = "Tiene un Peso Normal :D";
            }
            else if (imc >= 25 && imc < 27.9)
            {
                Resultado = imc.ToString("0.00");
                Mensaje = "Tiene Sobre peso :l, Deberías cambiar tus habitos alimenticios para mejorar";
            }
            else if (imc >= 28 && imc < 29.9)
            {
                Resultado = imc.ToString("0.00");
                Mensaje = "Usted tiene Obesidad tipo 1 :(, Debe de ir con un nutriologo a la brevedad";
            }

            else if (imc >= 30 && imc < 39.9)
            {
                Resultado = imc.ToString("0.00");
                Mensaje = "Usted tiene Obesidad tipo 2 :(, Debe de ir con un nutriologo a la brevedad";
            }

            else
            {
                Resultado = imc.ToString("0.00");
                Mensaje = "Usted tiene Obesidad tipo 3:(, Debe de ir con un nutriologo a la brevedad";
            }
        }

        public void OnGet()
        {
        }
    }
}
