using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wixisoftware.Entities.Concrete
{
    public class Writer
    {

        [Key]
        public int WriterID { get; set; }

        public string? WriterFirstName { get; set; }
        public string? WriterLastName { get; set; }
        public string? WriterImage { get; set; }
        public string? WriterMail { get; set; }
        public string? WriterPassword { get; set; }

        public bool WriterStatus { get; set; }

        public DateTime CretedDateTime { get; set; }



        //todo MD5 ile Şifreleme yap

        // MD5 ile Crypte ve Encrypte Konularına bakıcağız burda işin Salt konusu giricek 
        //public string Salt { get; set; }
        //public string Hash { get; set; }








    }
}
