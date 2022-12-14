using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatbasÖvningEF2.Model
{
    public class VacayTable
    {
        [Key]
        public int VacayId { get; set; }
        [Required]
        [StringLength(15)]
        public string Personel { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        [StringLength(15)]
        public string TypeOfVacay { get; set; }
        public int NumberOfDaysOff { get; set; }
        public int AgeOfPersonel { get; set; }

    }
}
