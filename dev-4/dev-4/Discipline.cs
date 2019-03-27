using System.Collections.Generic;

namespace dev_4
{
    class Discipline : EntityInfo
    {
        List<Lecture> Lectures = new List<Lecture>();

        Discipline(string disciplineName = "TrainingSubject")
        {
            TextDescription = disciplineName;
            GUID.SetGUID(this);
        }

        public List<Lesson> this[int index]
        {
            get
            {
                List<Lesson> lessonsForLecture = new List<Lesson>();
                lessonsForLecture.Add(Lectures[index]);
                foreach (Seminar seminar in Lectures[index].seminars)
                {
                    lessonsForLecture.Add(seminar);
                }
                foreach (LabLesson labLesson in Lectures[index].labs)
                {
                    lessonsForLecture.Add(labLesson);
                }
                return lessonsForLecture;
            }
        }
    }
}