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
       


        public Course CreateCourse(Course course)
        {
            Course newCourse = (course);
            courses.Add(newCourse);
            Console.WriteLine("Course Created successfully");
            return newCourse;
        }

        public void ReadCourses()
        {
            if( courses.Count == 0)
            {
                Console.WriteLine("course Not found");
            }
            else
            {
                Console.WriteLine("---------Available Courses-----------");
                foreach(var course in courses)
                {
                    Console.WriteLine(course);
                }
            }
        }

        public Course UpdateCourse (string id,Course course)
        {
            Course newCourse = courses.Find(x =>
            courses.Remove(course);
            Console.WriteLine("course updated successfully");
            return course;
        }

        public void DeleteCourse(Course course)
        {
            c
        } 



    }
}
