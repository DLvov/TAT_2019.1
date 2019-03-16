using System;
using System.Text;

namespace dev_2
{
    class LetterStatusChecker
    {
        private const string CONSONANTS = "бвгджзйлмнрпфктшсхцчщ";
        private const string VOICED_CONSONANTS = "бвгджзйлмнр";
        private const string DEAF_CONSONANTS = "пфктшсхцчщ";
        private const string PAIRED_CONSONANT = "бвгджзпфктшс";
        private const string PAIR_FOR_CONSONANT = "пфктшсбвгджз";
        private const string VOWELS = "яюеёауэоиы";
        private const string DOUBLE_SOUND_VOWELS = "яюеё";
        private const string SINGLE_SOUND_VOWELS = "ауэоиы";
        private const string PAIR_FOR_VOWEL = "ауэо";

        string letter;
        StringBuilder letterStatus = new StringBuilder();

        public LetterStatusChecker(string letter)
        {
            this.letter = letter;
        }

        public string GetLetterStatus(string letter)
        {
            if (SpecialSignCheck(letter))
            {
                return letter;
            }
            GeneralCheck(letter);
            return letterStatus.ToString();
        }

        public bool SpecialSignCheck(string letter)
        {
            switch (letter)
            {
                case "+":
                    return true;
                case "ь":
                    return true;
                case "Ъ":
                    return true;
                default:
                    return false;
            }
        }

        public void GeneralCheck(string letter)
        {
            if (IsConsonant(letter))
            {
                letterStatus.Append("1");
                if (IsVoicedConsonant(letter))
                {
                    letterStatus.Append("1");
                    if (IsPairedConsonant(letter))
                    {
                        letterStatus.Append("1");
                        letterStatus.Append(PAIR_FOR_CONSONANT[PAIRED_CONSONANT.IndexOf(letter)]);
                    }
                    else
                    {
                        letterStatus.Append("0");
                    }
                }
                else
                {
                    letterStatus.Append("0");
                    if (IsPairedConsonant(letter))
                    {
                        letterStatus.Append("1");
                        letterStatus.Append(PAIR_FOR_CONSONANT[PAIRED_CONSONANT.IndexOf(letter)]);
                    }
                    else
                    {
                        letterStatus.Append("0");
                    }
                }
            }
            else
            {
                letterStatus.Append("0");
                if (IsDoubleSoundVowel(letter))
                {
                    letterStatus.Append("1");
                    letterStatus.Append(PAIR_FOR_VOWEL[DOUBLE_SOUND_VOWELS.IndexOf(letter)]);
                }
                else
                {
                    letterStatus.Append("0");
                }
            }
        }
        public bool IsConsonant(string letter)
        {
            return CONSONANTS.Contains(letter);
        }
        public bool IsVowel(string letter)
        {
            return VOWELS.Contains(letter);
        }
        public bool IsVoicedConsonant(string letter)
        {
            return VOICED_CONSONANTS.Contains(letter);
        }
        public bool IsDeafConsonant(string letter)
        {
            return DEAF_CONSONANTS.Contains(letter);
        }
        public bool IsPairedConsonant(string letter)
        {
            return PAIRED_CONSONANT.Contains(letter);
        }
        public bool IsDoubleSoundVowel(string letter)
        {
            return DOUBLE_SOUND_VOWELS.Contains(letter);
        }
        public bool IsSingleSoundVowel(string letter)
        {
            return SINGLE_SOUND_VOWELS.Contains(letter);
        }
    }
}