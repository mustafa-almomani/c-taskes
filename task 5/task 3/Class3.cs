using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class peson
    {
       public int age ;
        public string Gender;
        public string Name ;
        public string E_Mail ;
        public int ID = 5;
        public int phon_number ;
        public peson()
        {
             age =20;
             Gender = "male";
             Name="mustafa";
            E_Mail ="almomani363@gmail.com";
             ID=5;
             phon_number=0795305456;
        }
        public void getperson()
        {
            Console.WriteLine($"id : {ID} name : {Name} age: {age} gender:{Gender} email : {E_Mail} phon number :{phon_number}");
        }


    }
}
