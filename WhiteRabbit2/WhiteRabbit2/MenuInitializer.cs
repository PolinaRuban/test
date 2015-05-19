using System.Data.Entity;
using System.Data.Entity.Migrations;
using WhiteRabbit2.Models;

namespace WhiteRabbit2
{
    //Set it before first usage of context
    // This method should be used if migrations don't used. 
    //It's not possible to use migration AND "DropCreateDatabaseAlways" as the initializer at the same time.
    public class MenuInitializer : DropCreateDatabaseAlways<OrderContext>
    {

    }
}
