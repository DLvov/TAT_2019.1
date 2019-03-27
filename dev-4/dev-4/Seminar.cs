using System.Collections.Generic;

namespace dev_4
{
    class Seminar : Lesson
    {
        Dictionary<string, string> questionAnswer = new Dictionary<string, string>();
        Seminar(string seminarNumber, int questionAmount = 5)
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