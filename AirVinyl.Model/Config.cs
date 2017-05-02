using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AirVinyl.Model
{
    // [DatabaseGenerated(DatabaseGeneratedOption.None)]
    
    public class CONFIG
    {
        [Key]
        public int KEY { get; set; }
        [StringLength(10)]
        public string WORKSHEET_CODE { get; set; }
        [StringLength(10)]
        public string WORKSHEET_TYPE { get; set; }
        [StringLength(50)]
        public string FLAG_NAME { get; set; }
        [StringLength(50)]
        public string VALUE { get; set; }


    }
}
