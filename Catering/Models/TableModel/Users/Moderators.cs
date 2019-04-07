using System;
using System.Collections.Generic;

namespace Catering.Models
{
    public partial class Moderators
    {
        public int ModeratorId { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
    }
}
