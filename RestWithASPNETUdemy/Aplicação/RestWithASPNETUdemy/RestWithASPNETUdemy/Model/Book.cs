using RestWithASPNETUdemy.Model.Context.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Model
{
    [Table("books")]
    public class Book : BaseEntity
    {

        public string title { get; set; }

        public string author { get; set; }

        public decimal price { get; set; }

        [Column("launch_date")]
        public DateTime launchDate { get; set; }
    }
}
