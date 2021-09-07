using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
//Used for specifying table name in DB, code below used for that [Table("tb_student")]
using System.ComponentModel.DataAnnotations.Schema;

namespace WebCodeFirstApproach.Models
{
    //code to Name tb_student as table name
    [Table("tb_student")]    
    public class Student
    {
        [Key]
        public int Studentid { get; set; }

        [Required(ErrorMessage ="Must Enter Name")]
        [StringLength(25,ErrorMessage ="Length must be less than 25")]
        public string Name { get; set; }
        
        [Required(ErrorMessage ="required field")]
        [MaxLength(30,ErrorMessage ="lenght must less than 30 charecters")]
        public string Address { get; set; }
        
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "required field")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "required field")]
        public string Gender { get; set; }
        
        [Required(ErrorMessage = "required field")]
        [Range(18,60,ErrorMessage ="age must b/w 18-60")]
        public int Age { get; set; }
        
        [Required(ErrorMessage = "required field")]
        public string Password { get; set; }
        
        [Required(ErrorMessage = "required field")]
        [Compare("Password",ErrorMessage ="password must be same")]
        public string Confirmpassword { get; set; }
    }

    public DB:db
}