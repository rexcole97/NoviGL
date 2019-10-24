using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NavistarGL.Data
{
    public class departments
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int DID { get; set; }
        [Display(Name = "Department ID")]
        public string Dname { get; set; }
        [Display(Name = "Department Location")]
        public string Dlocation { get; set; }
        [Display(Name = "Department Head")]
        public int Dhead { get; set; }
    }
}
