using System.Text.RegularExpressions;

namespace Validation
{
    /// <summary>
    /// Felhasználó input ellenőrző függvénykönyvtár
    /// </summary>
    public static class InputValidation
    {
		/// <summary>
        /// Metódus, amely ellenőrzi az input üres karakterlánc-e
        /// </summary>
        /// <param name="input">Bemenet</param>
        /// <returns>Ha üres a bemenet logikai igazzal téri vissza a függvény, ellenkező esetben logikai hamissal</returns>
        public static bool IsEmpty(string input)
        {
            return string.IsNullOrWhiteSpace(input) ? true : false;
        }

        /// <summary>
        /// Metódus, amely ellenőrzi az input nulla-e vagy negatív szám-e
        /// </summary>
        /// <param name="input">Bemenet</param>
        /// <returns>Ha a bemenet nulla vagy negatív szám logikai igazzal tér vissza a függvény, ellenkező esetben logikai hamissal</returns>
        public static bool IsZeroOrNegative(int input)
        {
            return input <= 0 ? true : false;
        }

        /// <summary>
        /// Metódus, amely ellenőrzi az input tartalmaz-e vezérlőbillentyű karaktert
        /// </summary>
        /// <param name="input">Bemenet</param>
        /// <returns>Ha a bemenet tartalmaz vezérlőbillentyű karaktert logikai igazzal tér vissza a függvény, ellenkező esetben logikai hamissal</returns>
        public static bool ContainsControlCharacters(string input)
        {
            bool criticalIndex = false;

            for (int index = 0; index < input.Length; index++)
            {
                if (char.IsControl(input[index]))
                {
                    criticalIndex = true;
                }
            }

            return criticalIndex;
        }

        /// <summary>
        /// Metódus, amely ellenőrzi az input tartalmaz-e speciális karaktert
        /// </summary>
        /// <param name="input">Bemenet</param>
        /// <returns>Ha a bemenet tartalmaz speciális karaktert logikai igazzal tér vissza a függvény, ellenkező esetben logikai hamissal</returns>
        public static bool ContainsSpecialCharacters(string input)
        {
            throw new System.NotImplementedException("Metódus fejlesztés alatt!");
        }

        /// <summary>
        /// Metódus, amely ellenőrzi az input tartalmaz-e számot
        /// </summary>
        /// <param name="input">Bemenet</param>
        /// <returns>Ha a bemenet tartalmaz számot logikai igazzal tér vissza a függvény, ellenkező esetben logikai hamissal</returns>
        public static bool ContainsDigitCharacters(string input)
        {
            bool criticalIndex = false;

            for (int index = 0; index < input.Length; index++)
            {
                if (char.IsDigit(input[index]))
                {
                    criticalIndex = true;
                }
            }

            return criticalIndex;
        }

        /// <summary>
        /// Metódus, amely ellenőrzi az input tartalmaz-e betűt
        /// </summary>
        /// <param name="input">Bemenet</param>
        /// <returns>Ha a bemenet tartalmaz betűt logikai igazzal tér vissza a függvény, ellenkező esetben logikai hamissal</returns>
        public static bool ContainsLetterCharacters(string input)
        {
            bool criticalIndex = false;

            for (int index = 0; index < input.Length; index++)
            {
                if (char.IsLetter(input[index]))
                {
                    criticalIndex = true;
                }
            }

            return criticalIndex;
        }

        /// <summary>
        /// Metódus, amely ellenőrzi az input tartalmaz-e nagybetűs karaktert
        /// </summary>
        /// <param name="input">Bemenet</param>
        /// <returns>Ha a bemenet tartalmaz nagybetűs karaktert logikai igazzal tér vissza a függvény, ellenkező esetben logikai hamissal</returns>
        public static bool ContainsUppercaseCharacters(string input)
        {
            bool criticalIndex = false;

            for (int index = 0; index < input.Length; index++)
            {
                if (char.IsUpper(input[index]))
                {
                    criticalIndex = true;
                }
            }

            return criticalIndex;
        }

        /// <summary>
        /// Metódus, amely ellenőrzi az input tartalmaz-e nagybetűs karaktert az első betű után
        /// </summary>
        /// <param name="input">Bemenet</param>
        /// <returns>Ha a bemenet tartalmaz nagybetűs karaktert logikai igazzal tér vissza a függvény, ellenkező esetben logikai hamissal</returns>
        public static bool ContainsUppercaseCharactersAfterFirstLetter(string input)
        {
            bool criticalIndex = false;

            for (int index = 1; index < input.Length; index++)
            {
                if (char.IsUpper(input[index]))
                {
                    criticalIndex = true;
                }
            }

            return criticalIndex;
        }

        /// <summary>
        /// Metódus, amely ellenőrzi az input tartalmaz-e kisebtűs karaktert
        /// </summary>
        /// <param name="input">Bemenet</param>
        /// <returns>Ha a bemenet tartlamaz kisebetűs karaktert logikai igazzal tér vissza a függvény, ellenkező esetben logikai hamissal</returns>
        public static bool ContainsLowercaseCharacter(string input)
        {
            bool criticalIndex = false;

            for (int index = 0; index < input.Length; index++)
            {
                if (char.IsLower(input[index]))
                {
                    criticalIndex = true;
                }
            }

            return criticalIndex;
        }

        /// <summary>
        /// Metódus, amely ellenőrzi az input tartalmaz-e kisebtűs karaktert
        /// </summary>
        /// <param name="input">Bemenet</param>
        /// <returns>Ha a bemenet tartlamaz kisebetűs karaktert logikai igazzal tér vissza a függvény, ellenkező esetben logikai hamissal</returns>
        public static bool ContainsLowercaseCharacterAfterFirstLetter(string input)
        {
            bool criticalIndex = false;

            for (int index = 1; index < input.Length; index++)
            {
                if (char.IsLower(input[index]))
                {
                    criticalIndex = true;
                }
            }

            return criticalIndex;
        }

        /// <summary>
        /// Metódus, amely ellenőrzi, hogy az input első karaktere nagybetű-e
        /// </summary>
        /// <param name="input">Bemenet</param>
        /// <returns>Ha a bemenet első betűje nagybetűs karakter logikai igazzal tér vissza a függvény, ellenkező esetben logikai hamissal</returns>
        public static bool FirstLetterIsUppercaseCharacter(string input)
        {
            if (char.IsUpper(input[0]))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Metódus, amely ellenőrzi, hogy az input első karaktere kisbetű-e
        /// </summary>
        /// <param name="input">Bemenet</param>
        /// <returns>Ha a bemenet első betűje kisbetűs karakter logikai igazzal tér vissza a függvény, ellenkező esetben logikai hamissal</returns>
        public static bool FirstLetterIsLowercaseCharacter(string input)
        {
            if (char.IsLower(input[0]))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Metódus, amely ellenőrzi helyes formátumú minta-e a felhasználó által bevitt email cím
        /// </summary>
        /// <param name="input">Bemenet</param>
        /// <returns>Ha megfelelő a formátum logikai igazzal tér vissz a függvény, ellenkező esetben logikai hamissal</returns>
        public static bool IsValidEmailAddress(string input)
        {
            bool valid = false;

            Regex validEmail =
                new Regex(
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");

            if (validEmail.IsMatch(input))
            {
                valid = true;
            }

            return valid;
        }

        /// <summary>
        /// Metódus, amely ellenőrzi helyes formátumú minta-e a felhasználó által bevitt születési dátum
        /// </summary>
        /// <param name="input">Bemenet</param>
        /// <returns>Ha megfelelő a formátum logikai igazzal tér vissza a függvény, ellenkező esetben logikai hamissal</returns>
        public static bool IsValidBirthDate(string input)
        {
            bool valid = false;

            Regex validBirthDate = new Regex(@"([12]\d{3}-(0[1-9]|1[0-2])-(0[1-9]|[12]\d|3[01]))");

            if (validBirthDate.IsMatch(input))
            {
                valid = true;
            }

            return valid;
        }
	}
}
