using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lab05.Models
{
    public class HvkMember
    {
        [Required(ErrorMessage = "Hvk: Hãy nhập mã số")]
        [DataType(DataType.Currency)]
        public int? Id { get; set; }
        [Required(ErrorMessage = "Hvk: Hãy nhập tên đăng nhập")]
        public string HvkUsername { get; set; }
        [Required(ErrorMessage = "Hvk: Hãy nhập họ và tên")]
        public string HvkFullName { get; set; }
        [Required(ErrorMessage = "Hvk: Hãy nhập mật khẩu")]
        [DataType(DataType.Password)]
        public string HvkPassword { get; set; }
        [Required(ErrorMessage = "Hvk: Hãy nhập tuổi")]
        [Range(18, 50, ErrorMessage = "Hvk: Tuổi từ 18 - 50")]
        public int? HvkAge { get; set; }
        [Required(ErrorMessage = " Hãy nhập email")]
        [RegularExpression(@"[A-Za - z0-9._%+-] + @[A-Za - z0-9.-]+\.[A-Za - z] {2 - 4}", ErrorMessage = "Hvk: Email phải đúng định dạng")]
        public string HvkEmail { get; set; }
    }
}