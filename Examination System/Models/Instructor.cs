﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;

namespace Examination_System.Models
{
    public class Instructor
    {
        public int InstructorId { get; set; }

        //[Required]
        //public string InstructorName { get; set;}

        //public string InstructorPassword { get; set;}

        //[NotMapped]

        //public string InstructorConfirmPassword { get; set;}

        public List<Department> Departments { get; set;}

        public Department Department { get; set; }

        public List<Course> Courses { get; set; }

       



        public int UserId { get; set; }

        public User User { get; set; }

        public Boolean isDeleted { get; set; } = false;




    }
}
