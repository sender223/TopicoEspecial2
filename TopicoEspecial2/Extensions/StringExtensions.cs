//CLASSE STRINGEXTENSION
namespace System {
    //classe statica
    static class StringExtensions {
        //criamos um metodo para cortar uma frase e acrescentar "..." quando acabar
        //de contar até o determinado numero.
        //metodo do tipo extension, que utiliza o this com parametro do tipo string
        //utilizando o thisObj e recebe tbm um numero inteiro do tipo int. 
        public static string Cortar(this string thisObj, int count) {
            //se o thisObj.Length for menor ou igual ao count 
            //retorna o proprio obj
            if (thisObj.Length <= count) {
                return thisObj;
            }
            else {
                //se não, returna a substring começando na posição 0
                //retornando o count e quando acabar, concatena com o ...
                return thisObj.Substring(0, count) + "...";
            }
        }
    }
}
