using System;
using System.ComponentModel.DataAnnotations;

namespace DENOMVC.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        
    }
}