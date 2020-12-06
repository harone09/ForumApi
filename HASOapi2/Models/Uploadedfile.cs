using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HASOapi2.Models
{
    public class Uploadedfile
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public string path { get; set; }

        [ForeignKey("User")]
        public long IdUser { get; set; }

        [ForeignKey("Publication")]
        public long IdPublication { get; set; }
    }
}
