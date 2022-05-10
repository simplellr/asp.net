using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;
using System.Text;

namespace MVC2Assignment.Models
{
    public class Account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AccountNumber { get; set; }
        [Remote("CheckAccountNumber", "Home")]

        public string Name { get; set; }
        [StringLength(byte.MaxValue, MinimumLength = 2, ErrorMessage = "Minimum length must be 2")]
        [Required(ErrorMessage = "Name must be specified")]
        public double CurrentBalance { get; set; }
       [ Range(500, long.MaxValue, ErrorMessage = "Minimum balance must be  500")]
     }


}