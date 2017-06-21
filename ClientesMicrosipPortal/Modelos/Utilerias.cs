using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientesMicrosipPortal.Modelos
{
    public static class parametros
    {
        public static long vendedorId { get; set; }
        public static string userMicro { get; set; }
        public static long cobradorId { get; set; }
        public static long cpAnterior { get; set; }
        public static long cpNuevo { get; set; }

        public static string nomVendedor { get; set; }
        public static string nomCobrador { get; set; }

        public static string nomVenSis { get; set; }
        public static long venSisId { get; set; }

        public static string cpnNombre { get; set; }
        public static string cpaNombre { get; set; }
    }

    public static class ConectionString
    {
        public static clases.ConfiguracionMicrosip connFB { get; set; }
        public static clases.ConfiguracionMysql connMySQL { get; set; }
    }

    public class Utilerias
    {
        /// <summary>
        /// Performs the ROT13 character rotation.
        /// </summary>
        public static string Transform(string value)
        {
            char[] array = value.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                int number = (int)array[i];

                if (number >= 'a' && number <= 'z')
                {
                    if (number > 'm')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                else if (number >= 'A' && number <= 'Z')
                {
                    if (number > 'M')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                array[i] = (char)number;
            }
            return new string(array);
        }
    }
}
