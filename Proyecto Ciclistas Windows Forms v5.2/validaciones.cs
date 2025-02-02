using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Timers;

namespace WindowsFormsApp1
{
    public static class validaciones
    {

        //Método para validar la integridad del formato de DNI
        public static bool ValidarDNI(string dni)
        {
            // El DNI/NIE debe tener exactamente 9 caracteres
            if (dni.Length != 9)
                return false;

            // Comprobar si es un NIE (comienza con X, Y o Z)
            char primerCaracter = dni[0];
            if (char.IsLetter(primerCaracter) && "XYZ".Contains(primerCaracter.ToString().ToUpper()))
            {
                // Los 7 caracteres del medio deben ser números
                if (!int.TryParse(dni.Substring(1, 7), out _))
                    return false;

                // El último carácter debe ser una letra
                char letraFinal = dni[8];
                if (!char.IsLetter(letraFinal))
                    return false;

                return true;
            }
            else
            {
                // Validación de un DNI estándar
                // Los primeros 8 caracteres deben ser números
                if (!int.TryParse(dni.Substring(0, 8), out _))
                    return false;

                // El último carácter debe ser una letra
                char letraFinal = dni[8];
                if (!char.IsLetter(letraFinal))
                    return false;

                return true;
            }
        }

        /// <SUMMARY>
        /// Comprueba si una fecha es nula o vacía.
        /// </SUMMARY>
        public static bool ValidarFechaNoEsNull(DateTime? fecha)
        {
            return fecha.HasValue;
        }
        /// <SUMMARY>
        /// Comprueba si un valor es nulo o vacío.
        /// </SUMMARY>
        public static bool ValidarNoEsNull(string value)
        {
            return !string.IsNullOrEmpty(value);
        }


        /// <SUMMARY>
        /// Comprueba si un modelo de bicicleta es válido (sin caracteres especiales).
        /// </SUMMARY>
        public static bool ValidarModeloBicicleta(string modelo)
        {
            // Modelo no debe estar vacío y debe contener solo letras, números o espacios
            if (string.IsNullOrWhiteSpace(modelo))
                return false;

            //Longitud máxima 40 chars
            if (modelo.Length > 40)
                return false;

            // Patrón para validar que solo haya letras, números y espacios
            string pattern = "^[a-zA-Z0-9 ]+$";
            return Regex.IsMatch(modelo, pattern);
        }

        /// <SUMMARY>
        /// Valida si un nombre es válido (solo letras y espacios).
        /// </SUMMARY>
        public static bool ValidarNombre(string nombre)
        {
            // Nombre no debe estar vacío
            if (string.IsNullOrWhiteSpace(nombre))
                return false;

            //Longitud máxima 40 chars
            if (nombre.Length > 40)
                return false;

            // Patrón para permitir solo letras y espacios
            string pattern = "^[a-zA-Z ]+$";
                return Regex.IsMatch(nombre, pattern);
        }
    }
}
