using System;
using System.Collections.Generic;
using System.Text;

namespace Guia.Domain.Companies
{
    public class Picture
    {
        public Picture()
        {

        }

        public int Id { get; set; }
        public string Url { get; set; }
        public DateTimeOffset UploadedOn { get; set; }

        public Company Company { get; set; }
    }
}
