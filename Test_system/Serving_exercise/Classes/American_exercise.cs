using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serving_exercise.Classes
{
    //[Table("American_exercise")]
    class American_exercise : Exercise
    {

        [Required] public string Solution_1 { get; set; }
        [Required] public string Solution_2 { get; set; }
        public string Solution_3 { get; set; }

    }
}
