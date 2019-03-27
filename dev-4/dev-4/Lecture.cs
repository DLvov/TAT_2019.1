using System;
using System.Collections.Generic;

namespace dev_4
{
    /// <summary>
    /// This class corresponds to the lecture lesson.
    /// </summary>
    class Lecture : Lesson
    {
        public List<Seminar> seminars = new List<Seminar>();
        public List<LabLesson> labs = new List<LabLesson>();
        string ContentURI { get; set; }
        private string _lectureText;
        private string _formatPresention;

        public string LectureText
        {
            get
            {
                return _lectureText;
            }
            set
            {
                if (value.Length > 100000)
                {
                    throw new FormatException("Lecture text length > 100000");
                }
                _lectureText = value;
            }
        }

        public string FormatPresentation
        {
            get
            {
                return _formatPresention;
            }
            set
            {
                switch (value)
                {
                    case "PPT":
                        _formatPresention = "PPT";
                        break;
                    case "PDF":
                        _formatPresention = "PDF";
                        break;
                    default:
                        _formatPresention = "Unknown";
                        break;
                }
            }
        }

        /// <summary>
        /// This constructor inicialize contenr URI, lecture text, GUID.
        /// And inicialize text description of the lecture by lecture number. 
        /// </summary>
        /// <param name="lectureNumber">Number of the lecture</param>
        public Lecture(int lectureNumber)
        {
            TextDescription = "Lecture " + lectureNumber;
            ContentURI = "Some content URI";
            LectureText = "Some Text";
            GUID.SetGUID(this);
        }

        /// <summary>
        /// This constructor inicialize contenr URI, lecture text, GUID.
        /// And inicialize text description of the lecture by lecture name. 
        /// </summary>
        /// <param name="lectureName">Name of the lecture</param>
        public Lecture(string lectureName)
        {
            TextDescription = lectureName;
            ContentURI = "Some content URI";
            LectureText = "Some Text";
            GUID.SetGUID(this);
        }

        /// <summary>
        /// This method adds the seminar to the lecture list of the seminars.
        /// </summary>
        /// <param name="seminarNumber">Number of the seminar</param>
        public void AddSeminar(int seminarNumber)
        {
            seminars.Add(new Seminar(seminarNumber));
        }

        /// <summary>
        /// This method adds the lab lesson to the lecture list of the lab lessons.
        /// </summary>
        /// <param name="labLessonNumber">Number of the lab lesson</param>
        public void AddLabLesson(int labLessonNumber)
        {
            labs.Add(new LabLesson(labLessonNumber));
        }
    }
}