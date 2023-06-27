﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wixisoftware.Entities.Concrete
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        public string? ContactUserName { get; set; }
        public string? ContactMail { get; set; }
        public string? ContactSubject { get; set; }
        public string? ContactMessage { get; set; }
        public bool ContactStatus { get; set; }
        public DateTime CreatedDateTime { get; set; }
     


    }
}
