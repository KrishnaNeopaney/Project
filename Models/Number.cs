using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Krish.Models
{
    public class Number
    {
        [Required]
        public int Id { get; set; }
        public string Employee { get; set; }

        [Required]
        [RegularExpression(@"^([0-9]{4})$", ErrorMessage = "Please Add Only Four Digits Number")]
        [StringLength(50)]
        [Index(IsUnique = true)]
        [Remote("IsExist", "User", AdditionalFields = "Id",
                ErrorMessage = "This Luck Number already Pick!! Please Choose Another Good Luck")]
        public string WNumber { get; set; }
        public int Qty { get; set; }
        public int  AllQty { get; set; }

        public bool IsWinner { get; set; }
        public Draw Draw { get; set; }

        [Required]
        public int DrawId { get; set; }

    }
}