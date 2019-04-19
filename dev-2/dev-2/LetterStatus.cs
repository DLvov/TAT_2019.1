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

        /// <summary>
        /// This constructor initialize letter.
        /// </summary>
        /// <param name="letter">Letter</param>
        public LetterStatus(char letter)
        {
            this.letter = letter;
        }

        /// <summary>
        /// This constructor initialize letter, pair of letter, isSpecial.
        /// </summary>
        /// <param name="letter">Letter</param>
        /// <param name="pair">Pair of the letter</param>
        /// <param name="isSpecial">Is letter a special symbol</param>
        public LetterStatus(char letter, char pair, bool isSpecial)
        {
            this.letter = letter;
            this.pair = pair;
            this.isSpecial = isSpecial;
        }

        /// <summary>
        /// This constructor initialize letter, isConsonant, isVoiced, isPaired, pair.
        /// </summary>
        /// <param name="letter">Letter</param>
        /// <param name="isConsonant">Is letter a consonant</param>
        /// <param name="isVoiced">Is letter a voiced vowel</param>
        /// <param name="isPaired">Is letter a paired</param>
        /// <param name="pair">Pair of the letter</param>
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