namespace dev_2
{
    /// <summary>
    /// This class contains characteristics of letter
    /// </summary>
    class LetterStatus
    {
        public char letter;
        public bool isConsonant;
        public bool isVoiced;
        public bool isPaired;
        public bool isSpecial;
        public char pair;

        public LetterStatus(char letter)
        {
            this.letter = letter;
        }

        public LetterStatus(char letter, char pair, bool isSpecial)
        {
            this.letter = letter;
            this.pair = pair;
            this.isSpecial = isSpecial;
        }

        public LetterStatus(char letter, bool isConsonant, bool isVoiced, bool isPaired, char pair)
        {
            this.letter = letter;
            this.isConsonant = isConsonant;
            this.isVoiced = isVoiced;
            this.isPaired = isPaired;
            this.pair = pair;
        }
    }
}