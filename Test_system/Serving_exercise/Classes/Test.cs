using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serving_exercise.Classes
{
    class Test
    {

        [Key, MaxLength(6), MinLength(6), DatabaseGenerated(DatabaseGeneratedOption.None)] public string Id { get; set; }
        [Required, MaxLength(50)]public string Topic { get; set; }

    }
}
