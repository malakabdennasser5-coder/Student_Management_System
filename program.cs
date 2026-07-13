using System;
using System.Collections.Generic;
using System.Text;

////namespace student_managment_system
//{
// internal class program
// {
//        static List<student> students = new List<student>();
//        static void Main(string[] args)

//        {
//           // while (true)
//            {
//           // Console.WriteLine("1. Register Student");
//            //Console.WriteLine("2. View Students");
//          //  Console.WriteLine("3. Search Student");
//           // Console.WriteLine("4. Update Student");
//            Console.WriteLine("5. Delete Student");
//            Console.WriteLine("6. Exit");
//            Console.Write("Choose: ");
//                string choice = Console.ReadLine();
//                               Console.WriteLine();
//            switch (choice)
//            {
//                case "1":
//                    Register();
//                    break;

//                case "2":
//                    view();
//                    break;

//                case "3":
//                        Search Student();
//                    break;

//                case "4":
//                    Update();
//                    break;

//                case "5":
//                    Delete();
//                    break;

//                case "6":
//                        Console.WriteLine("EXiting the program");
//                        return;

//                default:
//                    Console.WriteLine("Invalid Choice");
//                    break;
//            }
//        }


//        static void Register()
//            {
//                Console.Write("Enter Student ID: ");
//                string id = Console.ReadLine();
//                if (students.Any(s => id == id))
//                {
//                    Console.WriteLine("Error: A student with this ID already exists.");
//                    return;
//                }

//                Console.Write("Enter Full Name: ");
//                string name = Console.ReadLine();

//                Console.Write("Enter Age: ");
//                if (!int.TryParse(Console.ReadLine(), out int age))
//                {
//                    Console.WriteLine("Error: Invalid age. Please enter a number.");
//                    return;
//                }

//                Console.Write("Enter Email Address: ");
//                string email = Console.ReadLine();

//                students.Add(new student { sid = id, fullname = name, age = age, email = email });
//                Console.WriteLine("Student registered successfully!");
//            }




//           // static void ViewAllStudents()
//            {
//                if (students.Count == 0)
//                {
//                    Console.WriteLine("No students registered yet.");
//                    return;
//                }

//                Console.WriteLine("List of all students:");
//                foreach (var student in students)
//                {
//                    Console.WriteLine(student);
//                }
//            }




//           // static void SearchStudent()
//            {
//                Console.Write("Enter Student ID to search: ");
//                string id = Console.ReadLine();

//                var student = students.FirstOrDefault(s => s.ID == id);

//                if (student == null)
//                {
//                    Console.WriteLine("Student not found.");
//                }
//                else
//                {
//                    Console.WriteLine("Student found:");
//                    Console.WriteLine(student);
//                }
//            }




//           // static void UpdateStudent()
//            {
//                Console.Write("Enter Student ID to update: ");
//                string id = Console.ReadLine();

//                var student = students.FirstOrDefault(s => s.ID == id);

//                if (student == null)
//                {
//                    Console.WriteLine("Error: Student not found.");
//                    return;
//                }

//                Console.WriteLine("Current information:");
//                Console.WriteLine(student);

//                Console.WriteLine("\nEnter new information (press Enter to keep current value):");

//                Console.Write($"Full Name ({student.FullName}): ");
//                string name = Console.ReadLine();
//                if (!string.IsNullOrWhiteSpace(name))
//                    student.FullName = name;

//                Console.Write($"Age ({student.Age}): ");
//                string ageInput = Console.ReadLine();
//                if (!string.IsNullOrWhiteSpace(ageInput) && int.TryParse(ageInput, out int age))
//                    student.Age = age;

//                Console.Write($"Email ({student.Email}): ");
//                string email = Console.ReadLine();
//                if (!string.IsNullOrWhiteSpace(email))
//                    student.Email = email;

//                Console.WriteLine("Student information updated successfully!");
//            }

//           // static void RemoveStudent()
//            {
//                Console.Write("Enter Student ID to remove: ");
//                string id = Console.ReadLine();

//                var student = students.FirstOrDefault(s => s.ID == id);

//                if (student == null)
//                {
//                    Console.WriteLine("Error: Student not found.");
//                    return;
//                }

//                students.Remove(student);
//                Console.WriteLine("Student removed successfully!");
//            }
//        }

//    }
//}





namespace StudentManagementSystem
{
    class Student
    {
        public string ID { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return "ID: {ID}, Name: {FullName}, Age: {Age}, Email: {Email}";
        }
    }

    class Program
    {
        static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n=== Student Management System ===");
                Console.WriteLine("1. Register New Student");
                Console.WriteLine("2. View All Students");
                Console.WriteLine("3. Search Student by ID");
                Console.WriteLine("4. Update Student Information");
                Console.WriteLine("5. Remove Student");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option (1-6): ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1": RegisterStudent(); break;
                    case "2": ViewAllStudents(); break;
                    case "3": SearchStudent(); break;
                    case "4": UpdateStudent(); break;
                    case "5": RemoveStudent(); break;
                    case "6":
                        Console.WriteLine("Exiting application. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void RegisterStudent()
        {
            Console.Write("Enter Student ID: ");
            string id = Console.ReadLine();

            // Check if ID already exists
            if (students.Any(s => s.ID == id))
            {
                Console.WriteLine("Error: A student with this ID already exists.");
                return;
            }

            Console.Write("Enter Full Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            if (!int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine("Error: Invalid age. Please enter a number.");
                return;
            }

            Console.Write("Enter Email Address: ");
            string email = Console.ReadLine();

            students.Add(new Student { ID = id, FullName = name, Age = age, Email = email });
            Console.WriteLine("Student registered successfully!");
        }

        static void ViewAllStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students registered yet.");
                return;
            }

            Console.WriteLine("List of all students:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        static void SearchStudent()
        {
            Console.Write("Enter Student ID to search: ");
            string id = Console.ReadLine();

            var student = students.FirstOrDefault(s => s.ID == id);

            if (student == null)
            {
                Console.WriteLine("Student not found.");
            }
            else
            {
                Console.WriteLine("Student found:");
                Console.WriteLine(student);
            }
        }

        static void UpdateStudent()
        {
            Console.Write("Enter Student ID to update: ");
            string id = Console.ReadLine();

            var student = students.FirstOrDefault(s => s.ID == id);

            if (student == null)
            {
                Console.WriteLine("Error: Student not found.");
                return;
            }

            Console.WriteLine("Current information:");
            Console.WriteLine(student);

            Console.WriteLine("\nEnter new information (press Enter to keep current value):");

            Console.Write($"Full Name ({student.FullName}): ");
            string name = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(name))
                student.FullName = name;

            Console.Write($"Age ({student.Age}): ");
            string ageInput = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(ageInput) && int.TryParse(ageInput, out int age))
                student.Age = age;

            Console.Write($"Email ({student.Email}): ");
            string email = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(email))
                student.Email = email;

            Console.WriteLine("Student information updated successfully!");
        }

        static void RemoveStudent()
        {
            Console.Write("Enter Student ID to remove: ");
            string id = Console.ReadLine();

            var student = students.FirstOrDefault(s => s.ID == id);

            if (student == null)
            {
                Console.WriteLine("Error: Student not found.");
                return;
            }

            students.Remove(student);
            Console.WriteLine("Student removed successfully!");
        }
    }
}