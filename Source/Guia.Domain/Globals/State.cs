using System;
using System.Collections.Generic;
using System.Text;

namespace Guia.Domain.Globals
{
    public class State
    {
        public State()
        {

        }

        public int? Id { get; set; }
        public string Name { get; set; }
        public string Acronym { get; set; }

        public virtual Country Country { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}
