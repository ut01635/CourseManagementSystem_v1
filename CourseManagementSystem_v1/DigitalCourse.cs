namespace CourseManagementSystem_v1
{
    public class DigitalCourse : Course
    {
        public string CourseLink { get; set; }
        public string FileSize { get; set; }

        public DigitalCourse(string courseId, string title, string duration, decimal price, string courseLink, string fileSize) : base(courseId, title, duration, price)
        {
            CourseLink = fileSize;
            FileSize = courseLink;
        }
    }
}
