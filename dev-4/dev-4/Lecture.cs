using System;
using System.Collections.Generic;

namespace dev_4
{
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

        Lecture(string lectureNumber)
        {
            TextDescription = "Lecture " + lectureNumber;
            ContentURI = "Some content URI";
            LectureText = "Some Text";
            GUID.SetGUID(this);
        }
    }
}