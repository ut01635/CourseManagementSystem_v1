using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    public class Program
    {
        static void Main(string[] args)
        {
            CourseManager manager = new CourseManager();
            int choice;


            do
            {
                Console.Clear();
                Console.WriteLine("Course Management System: ");
                Console.WriteLine("1. Add a Course");
                Console.WriteLine("2. View All Courses");
                Console.WriteLine("3. Update a Course");
                Console.WriteLine("4. Delete a Course");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option:");



                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            CreateCourse();
                            break;
                        case 2:
                            Console.Clear();
                            ReadCourses();

                            break;
                        case 3:
                            Console.Clear();
                            UpdateCourse(manager);


                            break;
                        case 4:
                            Console.Clear();
                            DeleteCourse(manager);

                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine("Exiting the system. good bye");
                            Console.WriteLine("Press any key to exit");
                            Console.ReadKey();
                            break;
                        default:
                            //Console.Clear();
                            Console.WriteLine("Invalid opion please try again");
                            break;
                    }

                    if (choice != 5)
                    {
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            } while (choice != 5);




            ////////////////////////////////////Methods/////////////////////////////////////

            void CreateCourse()
            {
                Console.Write("Enter Course ID: ");
                string id = Console.ReadLine();

                Console.Write("Enter Course Title: ");
                string title = Console.ReadLine();

                Console.Write("Enter Course Duration: ");
                string Duration = Console.ReadLine();

                Console.Write("Enter Course Price: ");
                decimal Price = decimal.Parse(Console.ReadLine());

                manager.CreateCourse(id, title, Duration, Price);
            }

            

             void UpdateCourse(CourseManager manager1)
            {
                Console.Write("Enter Course ID to update: "); ;
                string id = Console.ReadLine();

                Console.Write("Enter new Title(leave blank to keep current): ");
                string title = Console.ReadLine();

                Console.Write("Enter new Duration(leave blank to keep current): ");
                string duration = Console.ReadLine();

               Console.WriteLine("EnEnter new Price(leave blank to keep current):");
                decimal priceInput = decimal.Parse(Console.ReadLine());


                manager1.(id, title, duration, priceInput);
            }


             void DeleteCourse(CourseManager manager1)
            {
                Console.WriteLine("Enter course ID  to delete:");
                int id = int.Parse(Console.ReadLine());

                //manager.DeleteCourse(id);
                
            }

             void ReadCourses()
            {

                manager.ReadAllCourses();
                
            }



        }

    }
}
