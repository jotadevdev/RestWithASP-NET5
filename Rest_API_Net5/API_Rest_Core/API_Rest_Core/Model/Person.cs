using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API_Rest_Core.Model
{
    public class Person
    {
        public long Id { get; set; }

        [Column("First_name")] //Anotações para o nome ser igual ao da base de dados
        public string FirstName { get; set; }

        [Column("Last_name")]
        public string LastName { get; set; }

        public string Address { get; set; }

        [Column("gender")]
        public string Gender { get; set; }


    }
}
