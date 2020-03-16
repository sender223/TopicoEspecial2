using System.Globalization;

//trocamos o namespace de TopicoEspecial2.Extensions para System.
//com isso dizemos que essa classe é do namespace system e NÃO precisamos importar ela
//utilizando o using. lembrando que o DateTime é do Tipo System. 
namespace System {
    //classe do tipo estatico!
    static class DateTimeExtensions {

        public static string ElapsedTime(this DateTime thisObj) {
            TimeSpan duracao = DateTime.Now.Subtract(thisObj);

            if (duracao.TotalHours < 24.0) {
                return duracao.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " horas";
            }
            else {
                return duracao.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " Dias";
            }
        }
    }
}
