namespace OlimpiaIT.WinApplicacion.FileValidator
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Clase de extensiones
    /// </summary>
    public static class OlimpiaITStringExtension
    {
        private const int MinCharacterPerLine = 50;
        private const int MaxCharacterPerLine = 1000;

        /// <summary>
        /// Valida que el tamaño de la linea esté en 50 y 1000 caracteres
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public static bool IsValidLineCount(this string line)
        {
            return (line.Trim().Length >= MinCharacterPerLine && line.Trim().Length <= MaxCharacterPerLine);
        }

        /// <summary>
        /// Verifica que la cadena sea un numero
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public static bool IsNumber(this string line)
        {
            var isNumeric = System.Numerics.BigInteger.TryParse(line.Trim(), out _);
            return isNumeric;
        }

        /// <summary>
        /// Valida si el numero en la linea es multiplo del valor enviado por parametro
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public static string IsMultiplotOf(this string line, int multiplo)
        {
            IEnumerable<int> lineNum = line.Select(x => int.Parse(x.ToString())).ToArray();
            var sumAll = lineNum.Aggregate((prev, next) => prev + next);
            return (sumAll % multiplo == 0) ? "SI" : "NO";
        }
    }
}
