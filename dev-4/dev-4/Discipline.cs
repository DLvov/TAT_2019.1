using System.Collections.Generic;

namespace dev_4
{
    /// <summary>
    /// This class corresponds to the training discipline.
    /// </summary>
    class Discipline : EntityInfo
    {
        List<Lecture> lectures = new List<Lecture>();

        /// <summary>
        /// This constructor sets the text decsription and GUID.
        /// </summary>
        /// <param name="disciplineName">Name of the training discipline</param>
        public Discipline(string disciplineName = "TrainingSubject")
        {
            TextDescription = disciplineName;
            GUID.SetGUID(this);
        }

        /// <summary>
        /// This indexator returns list with lecture by index and the corresponding seminars and labs.
        /// </summary>
        /// <param name="index">index of the lecture</param>
        /// <returns>List with lecture and the corresponding seminars and labs</returns>
        public List<Lesson> this[int index]
        {
            get
            {
                List<Lesson> lessonsForLecture = new List<Lesson>();
                lessonsForLecture.Add(lectures[index]);
                foreach (Seminar seminar in lectures[index].seminars)
                {
                    lessonsForLecture.Add(seminar);
                }
                foreach (LabLesson labLesson in lectures[index].labs)
                {
                    lessonsForLecture.Add(labLesson);
                }
                return lessonsForLecture;
            }
        }

        /// <summary>
        /// This method adds the lecture to the discipline list of the lectures.
        /// </summary>
        /// <param name="lectureNumber">Lecture number that is added</param>
        public void AddLecture(int lectureNumber)
        {
            lectures.Add(new Lecture(lectureNumber));
        }
    }
}