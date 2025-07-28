using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Casting_Operators_Overloading
{
    // Model : Is a Class that represents a data in the table in the database
    class User
    {

        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public Guid SecurityStmp { get; set; }

    }
}
