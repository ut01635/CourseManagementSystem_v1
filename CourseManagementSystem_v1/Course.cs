using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    public class Course
    {
         private string courseId {  get; set; }
         private string title { get; set; }
         private string Duration { get; set; }
         private decimal Price { get; set; }

        public Course(string courseId, string title, string duration, decimal price)
        {
            this.courseId = courseId;
            this.title = title;
             Duration = duration;
            Price = price;
        }

        public override string ToString()
        {
            return $"ID: {courseId}, Title: {title}, Duration: {Duration}, Price: {Price}";
        }

        public virtual string DisplayCourseInfo()
        {
            return $"ID: {courseId}, Title: {title}, Duration: {Duration}, Price: {Price}";

        }

        //Course course1 = {  courseId: "C_001", 
        //                    title: "python for beginners", 
        //                    Duration: "3 months", 
        //                    Price: 10.00 
        //                  }
    }
}
