//CLASSE DATETIMEEXTENSION
using System.Globalization;

//trocamos o namespace de TopicoEspecial2.Extensions para System.
//com isso dizemos que essa classe é do namespace system e NÃO precisamos importar ela
//utilizando o using. lembrando que o DateTime é do Tipo System. 
namespace System {
    //classe do tipo estatico!
    static class DateTimeExtensions {

        //metodo estatico para ElapsedTime que retorna um valor do tipo string
        //o tipo do metodo é definido logo no inicio(), ele é do tipo extension
        //representado pelo this e o parametro do tipo DateTime, alem disso
        //ele será uma referencia para o proprio objeto, então usamos o thisObj
        //para identificar que ele trabalhará com ele mesmo.
        //"extesion metodo que estende o tipo datetime"
        public static string ElapsedTime(this DateTime thisObj) {
            //transforma a data em uma duração usando o Now e depois subtrai
            //pegando o objeto thisObj pra isso.
            TimeSpan duracao = DateTime.Now.Subtract(thisObj);
            //se a duração for menor que 24 horas
            if (duracao.TotalHours < 24.0) {
                //faça o total de horas
                return duracao.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " horas";
            }
            else {
                //faça o total de dias se ela for maior que 24.0
                return duracao.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " Dias";
            }
        }
    }
}
