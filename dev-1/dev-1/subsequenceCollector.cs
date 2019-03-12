using System;

namespace dev_1
{
    /// <summary>
    /// This class collect the subsequences and show them.
    /// </summary>
    class SubsequenceCollector
    {
        /// <summary>
        /// This array is storage for subsequences
        /// </summary>
        private string[] subsequenceStorage = Array.Empty<String>();
        private string inputedSequence = String.Empty;
        /// <summary>
        /// Constructor check input sequense
        /// </summary>
        public SubsequenceCollector(string inputedSequence)
        {
            if (inputedSequence.Length < 2)
            {
                throw new FormatException();
            }
            else
            {
                this.inputedSequence = inputedSequence;
            }
        }
            /// <summary>
            /// This method collects subsequences into subsequenceArray.
            /// </summary>
            public void CollectSubsequences()
        {
            for (int i = 0; i < inputedSequence.Length - 1; i++)
                for (int j = i; j < inputedSequence.Length - 1; j++)
                {
                    if (inputedSequence[j] == inputedSequence[j + 1])
                        break;
                    string subsequence = inputedSequence.Substring(i, j - i + 2);
                    Array.Resize(ref subsequenceStorage, subsequenceStorage.Length + 1);
                    subsequenceStorage[subsequenceStorage.Length - 1] = subsequence;
                }
        }
        /// <summary>
        /// This method shows the array with subsequences.
        /// </summary>
        public void ShowSubsequences()
        {
            foreach(string subsequence in subsequenceStorage)
                Console.WriteLine(subsequence);
        }
        public void CollectAndShowSubsequences()
        {
            CollectSubsequences();
            ShowSubsequences();
        }
    }
}
