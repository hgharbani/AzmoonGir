using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzmoonGir.Model
{
    [Table("Histories")]
   public class History
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public long UserId { get; set; }
        public string DatePass { get; set; }
        public string GroupName { get; set; }
        public int TrueItem { get; set; }
        public int FalseItem { get; set; }
        public int NoneItem { get; set; }

    }
}
