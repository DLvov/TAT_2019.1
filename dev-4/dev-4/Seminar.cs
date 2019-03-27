using System.Collections.Generic;

namespace dev_4
{
    /// <summary>
    /// This class corresponds to the seminar lesson.
    /// </summary>
    class Seminar : Lesson
    {
        Dictionary<string, string> questionAnswer = new Dictionary<string, string>();

        /// <summary>
        /// This constructor initializes the text description and GUID and fills the dictionary with questions and answers.
        /// </summary>
        /// <param name="seminarNumber">Number of the seminar</param>
        /// <param name="questionAmount">Amount of the questions</param>
        public Seminar(int seminarNumber, int questionAmount = 5)
        {
            TextDescription = "Seminar " + seminarNumber;
            for (int i = 1; i <= questionAmount; i++)
            {
                questionAnswer.Add("Question " + i, "Answer " + i);
            }
            GUID.SetGUID(this);
        }
    }
}