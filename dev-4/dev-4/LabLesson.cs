namespace dev_4
{
    class LabLesson : Lesson
    {
        LabLesson(string labLessonNumber)
        {
            TextDescription = "LabLesson" + labLessonNumber;
            GUID.SetGUID(this);
        }
    }
}