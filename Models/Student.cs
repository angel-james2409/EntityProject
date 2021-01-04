using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityProject.Models
{
    public class Student
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth  { get; set; }
        public byte[] onPhoto { get; set; }


    }
}
