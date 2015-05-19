using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteRabbit2.Models
{/// <summary>
    /// virtual means lazy loading http://stackoverflow.com/questions/11469432/entity-framework-code-first-lazy-loading
    /// ICollection means many-to-many relationships https://msdn.microsoft.com/en-us/data/hh134698.aspx
    /// </summary>
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [DefaultValue("false")]
        public bool IsOpen { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
