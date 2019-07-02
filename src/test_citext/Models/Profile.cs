using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace test_citext.Models
{
    public class Profile
    {
        public long Id { get; set; }

        [Column(TypeName = "citext")]
        public string UserName { get; set; }
    }
}
