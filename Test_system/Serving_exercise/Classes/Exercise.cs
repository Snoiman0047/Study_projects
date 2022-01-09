using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serving_exercise.Classes
{
    class Exercise
    {

        [Key, MaxLength(4), MinLength(4), DatabaseGenerated(DatabaseGeneratedOption.None)] public string Id { get; set; }
        [Required, MinLength(6), MaxLength(6)] public string Test_ID { get; set; }
        [Required]public string _Exercise { get; set; }
        [Required]public string Solution { get; set; }
        public double Points { get; set; }

    }
}
