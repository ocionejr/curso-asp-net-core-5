using RestWithASPNETUdemy.Model.Context.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Model
{
    [Table("person")]
    public class Person : BaseEntity
    {

        [Column("first_name")]
        public string firstName { get; set; }

        [Column("last_name")]
        public string lastName { get; set; }

        public string address { get; set; }

        public string gender { get; set; }

        public bool enabled { get; set; }

    }
}
