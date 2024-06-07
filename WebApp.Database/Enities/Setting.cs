using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Database
{
    public class Setting
    {
        [Required]

        public int Id { get; set; }
        public string Name {get; set;}
        public string Value { get; set; }


        [ForeignKey("User")]
        public string UserId { get; set; }
       public virtual ApplicationUser User { get; set; }

    }
}
