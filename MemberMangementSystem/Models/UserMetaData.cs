using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MemberMangementSystem.Models
{
    [MetadataType(typeof(UserMetaData))]
    public partial class User
    {
        public class UserMetaData
        {
            
            public int Id { get; set; }

            [StringLength(15, ErrorMessage = "姓名請輸入3~15個字",MinimumLength =3)]
            public string Name { get; set; }

            [Range(0,100,ErrorMessage="年齡不對")]
            [Required(ErrorMessage = "hihih")]
            public int Age { get; set; }
            public string Address { get; set; }
            [RegularExpression(@"^09[0-9]{2}-[0-9]{6}$", ErrorMessage="電話格式錯誤")]
            public string Tel { get; set; }
        }
    }

}