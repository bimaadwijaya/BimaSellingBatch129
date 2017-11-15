using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Selling.Model
{
    public class MstUser
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "Varchar")]
        [StringLength(15)]
        public string Username { get; set; }
        [Required]
        [Column(TypeName = "Varchar")]
        [StringLength(15)]
        public string Password { get; set; }
        [Required]
        [Column(TypeName = "Varchar")]
        [StringLength(5)]
        public string OfficerCode { get; set; }
        [Required]
        public bool Active { get; set; }
    }
}
