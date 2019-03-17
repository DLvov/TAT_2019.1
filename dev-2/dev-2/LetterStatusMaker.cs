namespace dev_2
{
    /// <summary>
    /// This class can make LatterStatus of letter.
    /// </summary>
    class LetterStatusMaker
    {
        private const string CONSONANTS = "бвгджзйлмнрпфктшсхцчщ";
        private const string VOICED_CONSONANTS = "бвгджзйлмнр";
        private const string PAIRED_CONSONANT = "бвгджзпфктшс";
        private const string PAIR_FOR_CONSONANT = "пфктшсбвгджз";
        private const string DOUBLE_SOUND_VOWELS = "яюеё";
        private const string SINGLE_SOUND_VOWELS = "ауэоиы";

        char letter;
        char pairLetter;

        public LetterStatusMaker(char letter)
        {
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
        /// All methods below check some characteristics of the letter and returns them.
        /// </summary>
        public bool SpecialSignCheck()
        {
            if (letter == 'ь')
            {
                pairLetter = '\'';
            }
            return letter == '+' || letter == 'ь' || letter == 'ъ';
        }
        public bool IsConsonant()
        {
            return CONSONANTS.Contains(letter.ToString());
        }
        public bool IsVoicedConsonant()
        {
            return VOICED_CONSONANTS.Contains(letter.ToString());
        }
        public bool IsPaired()
        {
            return IsPairedConsonant() || IsDoubleSoundVowel();
        }
        public bool IsPairedConsonant()
        {
            if (PAIRED_CONSONANT.Contains(letter.ToString()))
            {
                pairLetter = PAIR_FOR_CONSONANT[PAIRED_CONSONANT.IndexOf(letter)];
            }
            return PAIRED_CONSONANT.Contains(letter.ToString());
        }
        public bool IsDoubleSoundVowel()
        {
            if (DOUBLE_SOUND_VOWELS.Contains(letter.ToString()))
            {
                pairLetter = SINGLE_SOUND_VOWELS[DOUBLE_SOUND_VOWELS.IndexOf(letter)];
            }
            return DOUBLE_SOUND_VOWELS.Contains(letter.ToString());
        }
    }
}