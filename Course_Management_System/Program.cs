using System.Numerics;

namespace Course_Management_System
{
    class Course {
        public static int coursecnt=0;
        public string title;
        public int credit;
        public int id;
        
        public Course(int id,string title, int credit)
        {
            this.id = id;
            this.title = title;
            this.credit = credit;
        }
   

        public void Getdetails()
        {
            Console.WriteLine(id+"    Course        "+"   Title : "+title+ ", Credits : " + credit);
        }

    }

    class Seminar { 
        public static int seminalcnt = 0;
        public string title;
        public double duration;
        public int id;

      public Seminar(int id,string title, double duration)
        {
            this.id = id;
            this.title = title;
            this.duration = duration;
        }
    

        public void Getdetails()
        {
            Console.WriteLine(id+"     Seminar       " + "   Title : " + title + ", Duration : " + duration);
        }
    }

    class Lab {
        public static int labcnt = 0;
        public string title;
        public int equipment_count;
        public int id;  

        public Lab(int id,string title, int equipment_count)
        {
            this.id = id;
            this.title = title;
            this.equipment_count = equipment_count;
        }
      

        public void Getdetails()
        {
            Console.WriteLine(id+"      Lab       " + "   Title : " + title + ", Equipment Count : " + equipment_count);
        }
    }




    internal class Program
    {
        static void Main(string[] args)
        {
            List<Course> courses = new List<Course>();
            List<Seminar> seminars = new List<Seminar>();
            List<Lab> labs = new List<Lab>();

            while (true)
            {
                Console.WriteLine("University Course Management System Manu : \n1. Add a Course\n2. Add a Seminar \n3. Add a Lab\n4. List Subjects\n5. Exit");
                Console.WriteLine("Enter your choice : ");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                  
                        Console.WriteLine("Enter Course Title : ");
                        string course_title = Console.ReadLine();
                        if (course_title=="")
                        {
                            Console.WriteLine("Invalid Course Title. Please try again.");
                            break;
                        }
                        Console.WriteLine("Enter Course Credits : ");
                        int course_credit = Convert.ToInt32(Console.ReadLine());
                        if(course_credit<0)
                        {
                            Console.WriteLine("Invalid Credit Count. Please try again.");
                            break;
                        }
                        Course.coursecnt++;
                        int id = Course.coursecnt;

                        courses.Add(new Course(id,course_title, course_credit));
                        break;
                    case 2:
                  
                        Console.WriteLine("Enter Seminar Title : ");
                        string seminar_title = Console.ReadLine();
                        if (seminar_title == "")
                        {
                            Console.WriteLine("Invalid Seminar Title. Please try again.");
                            break;
                        }
                        Console.WriteLine("Enter Seminar Duration : ");
                        double seminar_duration = Convert.ToDouble(Console.ReadLine());
                        if (seminar_duration < 0)
                        {
                            Console.WriteLine("Invalid Seminar Duration. Please try again.");
                            break;

                        }
                        Seminar.seminalcnt++;
                        int seminar_id = Seminar.seminalcnt;



                        seminars.Add(new Seminar(seminar_id,seminar_title, seminar_duration));
                        break;
                    case 3:

                      
                        Console.WriteLine("Enter Lab Title : ");
                        string lab_title = Console.ReadLine();
                        if (lab_title == "")
                        {
                            Console.WriteLine("Invalid Lab Title. Please try again.");
                            break;
                        }
                    
                        Console.WriteLine("Enter Equipment Count : ");
                        int equipment_count = Convert.ToInt32(Console.ReadLine());
                        if (equipment_count < 0)
                        {
                            Console.WriteLine("Invalid Equipment Count. Please try again.");
                            break;
                        }
                        Lab.labcnt++;
                        int lab_id = Lab.labcnt;
                        labs.Add(new Lab(lab_id, lab_title, equipment_count));
                        break;
                    case 4:
                        Console.WriteLine("---------Courses---------");
                        Console.WriteLine("ID         Type         Details ");
                        foreach (var course in courses)
                            course.Getdetails();

                        Console.WriteLine("---------Seminars---------");
                        Console.WriteLine("ID         Type         Details ");

                        foreach (var seminar in seminars)
                            seminar.Getdetails();
                        
                        Console.WriteLine("---------Labs---------");
                        Console.WriteLine("ID         Type         Details ");
                        foreach (var lab in labs)
                            lab.Getdetails();


                        Console.WriteLine("Total Courses : " + Course.coursecnt);
                        Console.WriteLine("Total Seminars : " + Seminar.seminalcnt);
                        Console.WriteLine("Total Labs : " + Lab.labcnt);

                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

            }

        }
    }
}
