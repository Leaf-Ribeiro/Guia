using System;
using System.Collections.Generic;
using System.Text;

namespace Guia.Domain.Companies
{
    public class SocialNetWork
    {
        public SocialNetWork()
        {

        }

        public int Id { get; set; }
        public string Url { get; set; }

        public Company Company { get; set; }
    }
}
