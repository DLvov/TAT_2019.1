using System;
using System.Collections.Generic;
using System.Text;

namespace dev_2
{
    class PhonemeBuilder
    {
        public string BuildPhoneme(string word)
        {
            var phoneme = new StringBuilder();
            var statusList = new List<LetterStatus>();
            foreach (char letter in word)
            {
                var letterStatusChecker = new LetterStatusMaker(letter);
                statusList.Add(letterStatusChecker.GetLetterStatus());
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
                    case 'о':
                        if (nextStatus.letter == '\0')
                        {
                            phoneme.Append('a');
                        }
                        else
                        {
                            phoneme.Append(nextStatus.letter == '+' ? 'о' : 'а');
                        }
                        break;
                    default:
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

            return phoneme.ToString();
        }
        public void ShowPhoneme(string phoneme)
        {
            foreach(char c in phoneme)
            {
                Console.Write(c);
            }
        }
    }
}