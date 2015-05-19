using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteRabbit2.Models
{
    // model Course. 
    // Id from 100 to 199 means Snacks
    // Id from 200 to 299 means Database
    // Id from 300 to 399 means Drinks
    // Id from 400 to 499 means Deserts

    /// <summary>
    /// virtual means lazy loading http://stackoverflow.com/questions/11469432/entity-framework-code-first-lazy-loading
    /// Order means one-to-many relationships https://msdn.microsoft.com/en-us/data/hh134698.aspx
    /// </summary>
    public class Course
    {
        //PrimaryKey
        [Key]
        public int CourseId { get; set; }
        public String CourseName { get; set; }
        public String TimeForCooking { get; set; } //in minutes
        public String TimeForEating { get; set; } //in minutes
        //lazy loading, foreign key Order_OrderId
        public virtual Order Order { get; set; }
    }
}
