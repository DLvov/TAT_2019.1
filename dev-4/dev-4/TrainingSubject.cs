using System.Collections.Generic;

namespace dev_4
{
    class TrainingSubject : EntityInfo
    {
        List<Lecture> Lectures = new List<Lecture>();

        TrainingSubject()
        {
            TextDescription = "TrainingSubject";
        }
    }
}