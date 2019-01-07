using System;
using System.Collections.Generic;
using System.Text;

namespace Guia.Domain.Globals
{
    public class Country
    {
        public const int Brazil = 1;

        public Country()
        {
            States = new List<State>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual IList<State> States { get; set; }
    }
}
