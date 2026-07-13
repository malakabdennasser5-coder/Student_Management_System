using System;
using System.Collections.Generic;
using System.Text;

namespace student_managment_system
{
    internal class student
    {
        int  age;
        string fullname, emailaddress, id;
        private string Sid
        {
            get { return id; }
            set { id = value; }
        }
        private int Sage
        {
            get { return age; }
            set { age = value; }
        }
        private string Sfullname
        {
            get { return fullname; }
            set { fullname = value; }
        }
        private string Semailaddress
        {
            get { return emailaddress; }
            set { emailaddress = value; }
        }
        public void displaystudent()
        {
            Console.WriteLine("Student ID: " + Sid);
            Console.WriteLine("Full Name: " + Sfullname);
            Console.WriteLine("Age: " + Sage);
            Console.WriteLine("Email Address: " + Semailaddress);
        }
    }
}
