using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class User
    {
     [Display(Name="ชื่อ")]
     [Required(AllowEmptyStrings=false,ErrorMessage ="กรุณากรอกชื่อ")]
     public string Fname { get; set; }

     [Display(Name = "นามสกุล")]
     [Required(AllowEmptyStrings = false,ErrorMessage ="กรุณากรอกนามสกุล")]
     [RegularExpression("[ก-๙A-z]",ErrorMessage="กรุณากรอกชื่อให้เป็นภาษาไทยหรืออังกฤษเท่านั้น")]
     public string Lname { get; set; }

     [Display(Name = "อีเมล")]
     [EmailAddress]
     [Required(AllowEmptyStrings = false,ErrorMessage ="กรุณากรอกอีเมล")]
     public string Email { get; set; }

     [Display(Name = "เบอร์ที่ติดต่อได้")]
     [Phone]
     [Required(AllowEmptyStrings = false,ErrorMessage ="กรุณากรอกเบอร์ที่ติดต่อได้")]
     public string Tel { get; set; }

     [Display(Name = "ที่อยู่")]
     [Required(AllowEmptyStrings = false,ErrorMessage ="กรุณากรอกที่อยู่")]
     public string Address { get; set; }

    
     [Display(Name ="จังหวัด")]
     [Required(AllowEmptyStrings =false,ErrorMessage ="กรุณาใส่จังหวัด")]
     public string City { get; set; }
     
     [Display(Name ="รหัสไปรษณีย์")]
     [Required(AllowEmptyStrings =false,ErrorMessage ="กรุณาใส่รหัสไปรษณีย์")]
     public string ZipCode { get; set; }
  
     [Display(Name = "รหัสผ่าน")]
     [Required(AllowEmptyStrings = false,ErrorMessage = "กรุณากรอกรหัสผ่าน")]
     [MinLength(6,ErrorMessage ="รหัสผ่านต้องมี6ตัวขึ้นไปและไม่เกิน12ตัว")]
     [MaxLength(12, ErrorMessage = "รหัสผ่านต้องมี6ตัวขึ้นไปและไม่เกิน12ตัว")]
     public string Password { get; set; }
     
     [Display(Name = "ยืนยันรหัสผ่าน")]
     [Required(AllowEmptyStrings =false,ErrorMessage ="กรุณากรอกยืนยันรหัสผ่าน")]
     [Compare("Password",ErrorMessage ="รหัสผ่านกับยืนยันรหัสผ่านไม่ตรงกัน")]
     [MinLength(6, ErrorMessage = "รหัสผ่านต้องมี6ตัวขึ้นไปและไม่เกิน12ตัว")]
     [MaxLength(12, ErrorMessage = "รหัสผ่านต้องมี6ตัวขึ้นไปและไม่เกิน12ตัว")]
     public string ConfirmPassword { get; set; }
    }
}
