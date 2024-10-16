﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    internal class OnPremisCourse : Course
    {
        public string Schedule {  get; set; }
        public string ClassroomCapacity { get; set; }

        public OnPremisCourse(int totalCourses, string courseId, string title, string duration, decimal price, string schedule, string classroomCapacity) : base(totalCourses,courseId, title, duration, price)
        {
            Schedule = schedule;
            ClassroomCapacity = classroomCapacity;
        }


        public string DisplayOnPremisCourseInfo()
        {
            return $"Schedule: {Schedule}, ClassroomCapacity: {ClassroomCapacity}";
        }

        public override string DisplayCourseInfo()
        {
            return base.DisplayCourseInfo() + this.DisplayOnPremisCourseInfo();
        }
    }
}
