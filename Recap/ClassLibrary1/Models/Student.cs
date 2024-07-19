using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
    [Table("StudentTable")]
    public class Student
    {
        [Key]
        public int StudentId { get; set; } 
        [Required]
        public string StudentName { get; set; }=string.Empty;
        [Required]
        public string StudentEmail { get; set; } = string.Empty;
        [Required]
        public long ContactNo { get; set; }
    }
}
