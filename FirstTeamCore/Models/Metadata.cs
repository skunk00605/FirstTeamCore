using FirstTeamCore.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FirstTeamCore.Models
{  
        //public class TCustomerMetadata
        //{

        //    public int FId { get; set; }

        //    [Display(Name = "姓名")]
        //    public string FName { get; set; }

        //    [Display(Name = "電話")]
        //    public string FPhone { get; set; }
      
        //[Display(Name = "電子郵件")]
        //public string FEmail { get; set; }
        //    public string FAddress { get; set; }
        //    public string FPassword { get; set; }
        //}
    public class MemberInfoMetadata
    {
        public MemberInfoMetadata()
        {
            SelfOrders = new HashSet<SelfOrder>();
            SetOrders = new HashSet<SetOrder>();
            ShopOrders = new HashSet<ShopOrder>();
        }

        public int 會員id { get; set; }
        [DisplayName("姓名")]
        [Required(ErrorMessage ="姓名不可空白")]
        public string 姓名 { get; set; } = null!;
        public bool? 性別 { get; set; }
        public DateTime 出生日期 { get; set; }
        [DisplayName("電話號碼")]
        [Required(ErrorMessage = "電話號碼不可空白")]
        public string? 電話號碼 { get; set; }
        public string 連絡信箱 { get; set; } = null!;
        public string 會員帳號 { get; set; } = null!;
        public string 會員密碼 { get; set; } = null!;
        public string? 照片 { get; set; }
        public bool? 權限 { get; set; }
        public DateTime? 建立時間 { get; set; }
        public DateTime? 修改時間 { get; set; }
        public string? 修改人 { get; set; }

        public virtual ICollection<SelfOrder> SelfOrders { get; set; }
        public virtual ICollection<SetOrder> SetOrders { get; set; }
        public virtual ICollection<ShopOrder> ShopOrders { get; set; }
    }


}
