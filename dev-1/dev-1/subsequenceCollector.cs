using System;

namespace dev_1
{
    /// <summary>
    /// This class collect the subsequences and show them.
    /// </summary>
    class SubsequenceCollector
    {
        string[] subsequences = { };
        /// <summary>
        /// This method collects subsequences into array subsequences.
        /// </summary>
        public void Collect(string sequence)
        {
            if (sequence.Length < 2)
            {
                Console.WriteLine("Your string is incorrect! (Length < 2)");
                return;
            }
            for (int i = 0; i < sequence.Length - 1; i++)
                for (int j = i; j < sequence.Length - 1; j++)
                {
                    if (sequence[j] == sequence[j + 1])
                        break;
                    string subsequence = sequence.Substring(i, j - i + 2);
                    Array.Resize(ref subsequences, subsequences.Length + 1);
                    subsequences[subsequences.Length - 1] = subsequence;
                }
        }
        /// <summary>
        /// This method shows the array with subsequences.
        /// </summary>
        public void ShowSubsequences()
        {
            for (int i = 0; i < subsequences.Length; i++)
                Console.WriteLine(subsequences[i]);
        }
    }
}
