using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteRabbit2.Models
{
    //Table name is "Menu"
    [Table("Menu")]
    public class MyMenu
    {
        //Primary key
        [Key]
        public int Id { get; set; }

        public int CourseId { get; set; }
        public String CourseName { get; set; }
        public String TimeForCooking { get; set; }
        public String TimeForEating { get; set; }
    }
}
