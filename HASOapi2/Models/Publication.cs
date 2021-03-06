﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HASOapi2.Models
{
    public class Publication
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public string Contenus { get; set; }


        [ForeignKey("User")]
        public long IdUser { get; set; }


        [ForeignKey("Classe")]
        public long IdClasse { get; set; }


    }
}
