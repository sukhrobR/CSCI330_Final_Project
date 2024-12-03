using System;
using cs330_proj1;
using System.Collections.Generic;

namespace cs330courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("My name is Sukhrob ");
            
            CourseServices service = new CourseServices();

            try
            {
                Console.WriteLine("---------");
                List<CourseOffering> theList = service.getOfferingsByGoalIdAndSemester("CG2", "Spring 2021");
                
                if (theList != null && theList.Count > 0)
                {
                    foreach (CourseOffering c in theList)
                    {
                        Console.WriteLine(c);
                    }
                }
                else
                {
                    Console.WriteLine("No course offerings found for CG2 in Spring 2021.");
                }
                Console.WriteLine("---------");

                List<Course> theList2 = service.getCourses();
                
                if (theList2 != null && theList2.Count > 0)
                {
                    foreach (Course c in theList2)
                    {
                        Console.WriteLine(c);
                    }
                }
                else
                {
                    Console.WriteLine("No courses available.");
                }
                Console.WriteLine("---------");

                // Uncomment and add error handling for the next sections as needed
                /*
                List<CourseOffering> theList3 = service.getCourseOfferingsBySemester("Fall 2020");
                if (theList3 != null && theList3.Count > 0)
                {
                    foreach (CourseOffering c in theList3)
                    {
                        Console.WriteLine(c);
                    }
                }
                else
                {
                    Console.WriteLine("No course offerings found for Fall 2020.");
                }
                Console.WriteLine("---------");

                List<CourseOffering> theList4 = service.getCourseOfferingsBySemesterAndDept("Fall 2020", "CSCI");
                if (theList4 != null && theList4.Count > 0)
                {
                    foreach (CourseOffering c in theList4)
                    {
                        Console.WriteLine(c);
                    }
                }
                else
                {
                    Console.WriteLine("No course offerings found for Fall 2020 in CSCI.");
                }
                Console.WriteLine("---------");

                List<Course> theList5 = service.getCoursesByGoalId("CG2");
                if (theList5 != null && theList5.Count > 0)
                {
                    foreach (Course c in theList5)
                    {
                        Console.WriteLine(c);
                    }
                }
                else
                {
                    Console.WriteLine("No courses found for CG2.");
                }
                Console.WriteLine("---------");

                List<Course> theList6 = service.getCoursesByGoalIds("CG2", "CG1");
                if (theList6 != null && theList6.Count > 0)
                {
                    foreach (Course c in theList6)
                    {
                        Console.WriteLine(c);
                    }
                }
                else
                {
                    Console.WriteLine("No courses found for CG2 and CG1.");
                }
                Console.WriteLine("---------");

                List<CoreGoal> theList7 = service.getCoreGoalsThatAreNotCoveredBySemester("Fall 2020");
                if (theList7 != null && theList7.Count > 0)
                {
                    foreach (CoreGoal c in theList7)
                    {
                        Console.WriteLine(c);
                    }
                }
                else
                {
                    Console.WriteLine("No core goals found that are not covered by Fall 2020.");
                }
                Console.WriteLine("---------");
                */

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        } //end main
    }
}
