using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace API_longestWord.Models
{
    [Table("tbl_LogicWord")]
    public class CLongest
    {
       

        public long Id { get; set; }
        [Required]
        public string Inputvalue { get; set; }
        public string Outputvalue { get; set; }
    
    }
} 