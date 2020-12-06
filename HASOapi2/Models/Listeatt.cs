using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HASOapi2.Models
{
    public class Listeatt
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string name { get; set; }

        [ForeignKey("User")]
        public long ide { get; set; }

        [ForeignKey("Classe")]
        public long idc { get; set; }
    }
}
