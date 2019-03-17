namespace dev_2
{
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

        public LetterStatus GetLetterStatus()
        {
            if (SpecialSignCheck())
            {
                return new LetterStatus(letter, pairLetter, SpecialSignCheck());
            }
            return new LetterStatus(letter, IsConsonant(), IsVoicedConsonant(), IsPaired(), pairLetter);
        }

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