using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Page.Models
{
    public class Add
    {
        [Key]
        [Column(TypeName = "varchar(20)")]
        public int AddId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string AddName { get; set; }
    }
}