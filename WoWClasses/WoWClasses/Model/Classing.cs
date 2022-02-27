using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WoWClasses.Model
{
    [Table("classes")]
    public partial class Classing
    {
        [Key]
        [Column("idx")]
        public int Idx { get; set; }
        [Column("wowclass")]
        [StringLength(50)]
        public string wowclass { get; set; }
    }
}
