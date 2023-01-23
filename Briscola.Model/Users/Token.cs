using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Briscola.Model.Users;

public class Token
{
    public int Id { get; }

    public int UserId { get; set; }

    public string LoginToken { get; set; }
}

