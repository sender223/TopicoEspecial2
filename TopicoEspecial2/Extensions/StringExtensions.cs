namespace System {
    //classe statica
    static class StringExtensions {
        //criamos um metodo para cortar uma frase e acrescentar ... quando acabar
        //de contar até o determinado numero.
        public static string Cortar(this string thisObj, int count) {
            if (thisObj.Length <= count) {
                return thisObj;
            }
            else {
                return thisObj.Substring(0, count) + "...";
            }
        }

    }
}
