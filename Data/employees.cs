using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NavistarGL.Data
{
    public class employees
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int EID { get; set; }
        public string EFN { get; set; }
        public string ELN { get; set; }
        [ForeignKey("DID")]
        public departments Depts { get; set; }
    }
}
