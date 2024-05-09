using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceClass
{
    internal class ParentClass
    {
        protected string ParentName { get; set; }
        protected int ParentAge {  get; set; }
        protected string ParentEmail {  get; set; }

        protected ParentClass(string parentName, int parentAge, string parentEmail)
        {
            ParentName = parentName;
            ParentAge = parentAge;
            ParentEmail = parentEmail;
        }
    }

 internal class ChildClass : ParentClass
    {
        protected string ChildName { get; set; }
        protected int ChildAge { get; set; }
        protected string ChildEmail { get; set; }
        public ChildClass(string name, int age, string email,string parentName, int parentage,string parentemail) : base("SHANMUGAVEL", 54, "SHANMUGAVEL@GMAIL.COM")
        {
            ChildName = name;
            ChildAge = age;
            ChildEmail = email;

        }
        public  void displaydetails()
        {
            Console.WriteLine(ChildName + " " + ChildAge + " " + ChildEmail);
            Console.WriteLine(ParentName + " " + ParentAge + " " + ParentEmail);

        }
    }
     internal class Operations

    {


        public static void Main()
        {
            ChildClass childclass = new ChildClass("Aarhti", 23, "Ras@gmail.com", "Balakrishnan", 54, "balu@gmail.com");
            childclass.displaydetails();
        }

    }
}






