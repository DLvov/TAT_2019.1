namespace dev_4
{
    /// <summary>
    /// This class corresponds to the lab lesson.
    /// </summary>
    class LabLesson : Lesson
    {
        /// <summary>
        /// This constructor inicialize the text description and GUID.
        /// </summary>
        /// <param name="labLessonNumber"></param>
        public LabLesson(int labLessonNumber)
        {
            TextDescription = "LabLesson" + labLessonNumber;
            GUID.SetGUID(this);
        }
    }
}