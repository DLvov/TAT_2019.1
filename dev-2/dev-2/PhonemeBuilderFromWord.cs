﻿using System;
using System.Collections.Generic;
using System.Text;

namespace dev_2
{
    /// <summary>
    /// This class can build and show phoneme of word.
    /// </summary>
    class PhonemeBuilderFromWord
    {
        string word;
        StringBuilder phoneme = new StringBuilder();

        /// <summary>
        /// This constructor checks the inputed word, and if it is longer than two, sets it.
        /// </summary>
        /// <param name="word">Inputed word</param>
        public PhonemeBuilderFromWord(string word)
        {
            if (word.Length < 2)
            {
                throw new FormatException();
            }
            this.word = word;
        }
        /// <summary>
        /// This method builds a phoneme based on data from a list of letter statuses of word.
        /// </summary>
        public void BuildPhoneme()
        {
            var statusList = new List<LetterStatus>();
            foreach (char letter in word)
            {
                var letterStatusMaker = new LetterStatusMaker(letter);
                statusList.Add(letterStatusMaker.GetLetterStatus());
            }
            for (var index = 0; index < statusList.Count; index++)
            {
                LetterStatus currentStatus = statusList[index];
                LetterStatus prevStatus = (index == 0 ? new LetterStatus('\0') : statusList[index - 1]);
                LetterStatus nextStatus = (index == statusList.Count - 1 ? new LetterStatus('\0') : statusList[index + 1]);
                switch (currentStatus.letter)
                {
                    case '+':
                        break;
                    case 'ъ':
                        break;
                    case 'ь':
                        phoneme.Append(currentStatus.pair);
                        break;
                    // No accent 'о' reads like 'а'.
                    case 'о':
                            phoneme.Append(nextStatus.letter == '+' ? 'о' : 'а');
                        break;
                    default:
                        // The vowels of "ю", "я", "ё", "е" : 
                        //   soften the previous consonant sound and transform into "y", "a", "o", "e" ,
                        //   at the beginning of the word, after other vowels 
                        //   and after "ь", "ъ" are converted into "йу", "йа", "йо", "йэ".
                        if (!currentStatus.isConsonant && currentStatus.isPaired)
                        {
                            if (prevStatus.letter == '\0' || !prevStatus.isConsonant || prevStatus.isSpecial)
                            {
                                phoneme.Append('й');
                            }
                            else
                            {
                                phoneme.Append('\'');
                            }
                            phoneme.Append(currentStatus.pair);
                            break;
                        }
                        // Voicing / stunning consonants - the voiced consonant in front of the deaf 
                        // and at the end of the word becomes deaf, and the deaf consonant in front 
                        // of the voiced becomes the voiced
                        if (currentStatus.isConsonant && currentStatus.isPaired)
                        {
                            if (currentStatus.isVoiced)
                            {
                                if (nextStatus.letter == '\0' || (!nextStatus.isVoiced && nextStatus.isConsonant && nextStatus.isPaired))
                                {
                                    phoneme.Append(currentStatus.pair);
                                    currentStatus.isVoiced = false;
                                    break;
                                }
                            }
                            else
                            {
                                if(nextStatus.isConsonant && nextStatus.isVoiced && nextStatus.isPaired)
                                {
                                    phoneme.Append(currentStatus.pair);
                                    currentStatus.isVoiced = true;
                                    break;
                                    
                                }
                            }

                        }
                        phoneme.Append(currentStatus.letter);
                        break;
                }
            }
        }
        // Shows a phoneme
        public void ShowPhoneme()
        {
            foreach(char c in phoneme.ToString())
            {
                Console.Write(c);
            }
        }
        public void BuildAndShowPhoneme()
        {
            BuildPhoneme();
            ShowPhoneme();
        }
    }
}