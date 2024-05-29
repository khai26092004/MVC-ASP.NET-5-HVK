using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HvkLesson06.Models
{
    public class HvkSong
    {
        [Key]
        public long Id { get; set; }
        [Required(ErrorMessage ="Hvk:Hãy nhập tiêu đề")]
        [DisplayName("Tiêu Đề")]
        public string HvkTitle { get; set; }
        [Required(ErrorMessage ="Hvk:Hãy nhập tác giả")]
        [DisplayName("Tác Giả")]
        public string HvkAuthor { get; set;}
        [Required(ErrorMessage ="Hvk:Hãy nhập nghệ sĩ")]
        [DisplayName("Nghệ sĩ")]
        [StringLength(50,MinimumLength =2,ErrorMessage ="Hvk:Tên nghệ sĩ có tối thiểu 2 kí tự,tối đa 50 kí tự")]

        public string HvkArtist { get; set;}
        [Required(ErrorMessage ="Hvk:Hãy nhập năm xuất bản")]
        [RegularExpression(@"[0-9]{4}",ErrorMessage ="Hvk:Nhập xuất bản phải có 2 kí tự số")]
        [Range(1900,2024,ErrorMessage ="Hvk:Năm xuất bản trong khoảng 1900-2024")]
        [DisplayName("Năm xuất bản")]
        public int HvkYearRelease { get; set;}

    }
}