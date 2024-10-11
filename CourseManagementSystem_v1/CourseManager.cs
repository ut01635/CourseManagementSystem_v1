using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    internal class CourseManager
    {
        public List<Course> courses = new List<Course>();



        public void CreateCourse(string id ,string title, string Duration, decimal Price)
        {


            Course course = new Course(id, title, Duration, Price);
            courses.Add(course);
            Console.WriteLine("Course added successfully");

        }

        public void ReadAllCourses()
        {
            if (courses.Count == 0)
            {
                Console.WriteLine("No Courses Available here");
            }
            else
            {
                Console.WriteLine("--------Available Courses-------");
                foreach (var course in courses)
                {
                    Console.WriteLine(course);
                }
            }

        }

        public void UpdateCourse(string courseId, string title, string duration, decimal price)
        {


            if (courseId != null)
            {
                var course = courses.FirstOrDefault(a => a.courseId == courseId);
                if (course != null)
                {
                    course.Title = title;
                    course.Duration = duration;
                    course.Price = price;
                    Console.WriteLine("Program updated successfully");
                }
                else
                {
                    Console.WriteLine("Course not found");
                }

            }
            else
            {
                Console.WriteLine("Invalid Course Id");
            }


        }

        public void DeleteCourse(string Id)
        {

            if (Id != null)
            {
                var course = courses.FirstOrDefault(c => c.CourseId == Id);
                if (course != null)
                {
                    courses.Remove(course);
                    Console.WriteLine("Course deleted successfully. ");

                }
                else
                {
                    Console.WriteLine("Course not found. ");
                }
            }
            else
            {
                Console.WriteLine("Invalid Course Id");
            }

        }



    }
}
