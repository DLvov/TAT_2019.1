using System;

namespace dev_2
{
    /// <summary>
    /// This class can make LatterStatus of letter.
    /// </summary>
    public class LetterStatusMaker
    {
        private static readonly string CONSONANTS = "бвгджзйлмнрпфктшсхцчщ";
        private static readonly string VOICED_CONSONANTS = "бвгджзйлмнр";
        private static readonly string PAIRED_CONSONANT = "бвгджзпфктшс";
        private static readonly string PAIR_FOR_CONSONANT = "пфктшсбвгджз";
        private static readonly string DOUBLE_SOUND_VOWELS = "яюеё";
        private static readonly string SINGLE_SOUND_VOWELS = "ауэоиы";
        private static readonly string AVAILIABLE_SYMBOLS = "бвгджзйлмнрпфктшсхцчщяюеёауэоиы+ьъ";

        char letter;
        char pairLetter;

        /// <summary>
        /// This constructor initialize letter.
        /// </summary>
        /// <param name="letter">Letter</param>
        public LetterStatusMaker(char letter)
        {
            AvailiableSymbolCheck(letter);
            this.letter = letter;
        }

        /// <summary>
        /// This method returns LetterStatus.
        /// </summary>
        /// <returns>Status of the letter</returns>
        public LetterStatus GetLetterStatus()
        {
            if (SpecialSignCheck())
            {
                return new LetterStatus(letter, pairLetter, SpecialSignCheck());
            }
            return new LetterStatus(letter, IsConsonant(), IsVoicedConsonant(), IsPaired(), pairLetter);
        }

        /// <summary>
        /// This method returns result of special sign checking.
        /// </summary>
        /// <returns>Result of special sign checking</returns>
        public bool SpecialSignCheck()
        {
            if (letter == 'ь')
            {
                pairLetter = '\'';
            }
            return letter == '+' || letter == 'ь' || letter == 'ъ';
        }

        /// <summary>
        /// This method returns result of consonant checking.
        /// </summary>
        /// <returns>Result of consonant checking</returns>
        public bool IsConsonant()
        {
            return CONSONANTS.Contains(letter.ToString());
        }

        /// <summary>
        /// This method returns result of voiced consonant checking.
        /// </summary>
        /// <returns>Result of voiced consonant checking</returns>
        public bool IsVoicedConsonant()
        {
            return VOICED_CONSONANTS.Contains(letter.ToString());
        }

        /// <summary>
        /// This method returns result of pair checking.
        /// </summary>
        /// <returns>Result of pair checking</returns>
        public bool IsPaired()
        {
            return IsPairedConsonant() || IsDoubleSoundVowel();
        }

        /// <summary>
        /// This method returns result of pair consonant checking, if it true sets pair letter.
        /// </summary>
        /// <returns>Result of pair consonant checking</returns>
        public bool IsPairedConsonant()
        {
            if (PAIRED_CONSONANT.Contains(letter.ToString()))
            {
                pairLetter = PAIR_FOR_CONSONANT[PAIRED_CONSONANT.IndexOf(letter)];
            }
            return PAIRED_CONSONANT.Contains(letter.ToString());
        }

        /// <summary>
        /// This method returns result of pair vowel checking, if it true sets pair letter.
        /// </summary>
        /// <returns>Result of pair vowel checking</returns>
        public bool IsDoubleSoundVowel()
        {
            if (DOUBLE_SOUND_VOWELS.Contains(letter.ToString()))
            {
                pairLetter = SINGLE_SOUND_VOWELS[DOUBLE_SOUND_VOWELS.IndexOf(letter)];
            }
            return DOUBLE_SOUND_VOWELS.Contains(letter.ToString());
        }

        /// <summary>
        /// This method checks if the symbol incorrect and throw exception if it is.
        /// </summary>
        /// <param name="symbol">Symbol will be checked</param>
        public static void AvailiableSymbolCheck(char symbol)
        {
            if (!AVAILIABLE_SYMBOLS.Contains(symbol.ToString()))
            {
                throw new Exception("Unknown symbol!");
            }
        }
    }
}