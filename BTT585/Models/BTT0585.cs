using System.ComponentModel;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BTT585.Models
{
   public class BTT0585
   {
       [Key]
     [StringLength(20)]
     [DisplayName("ID ")]

       public int BTTId { get; set; }

       [StringLength(a50)]
       [DisplayName("Tên người dùng")]

       public String BTTName { get; set; }


      [DisplayName("giới tính")]
       public string BTTGender { get; set; }
       }
}