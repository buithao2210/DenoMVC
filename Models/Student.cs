using System;
using System.ComponentModel.DataAnnotations;

namespace DenoMVC.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        
    }
}