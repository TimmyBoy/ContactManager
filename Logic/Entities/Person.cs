using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Logic.Entities;

namespace Logic
{
    public class Person
    {
        public int Id { get; set; }

        [DisplayName("First name")]
        public string Firstname { get; set; }

        [DisplayName("Surname")]
        public string Surname { get; set; }

        [DisplayName("Company")]
        public string Company { get; set; }

        [DisplayName("Postion")]
        public string Position { get; set; }

        [DisplayName("Website")]
        [Required]
        [RegularExpression("^((http[s]?://)?[\\w\\-_ ]+(.[\\w-_]+)+([\\-.,@?^=%&amp;:/~\\+#]*[\\w-@?^=%&amp;/~\\+#])?)?$", ErrorMessage="Die Webseite muss eine gültige Adresse sein.")]
        public string Website { get; set; }

        [DisplayName("E-Mail-Address")]
        [Required]
        //[RegularExpression(@"^[\w_-.%]+@[\w.-]+.\w{2,4}$", ErrorMessage = "Die E-Mail-Adresse muss ein gültiges Format haben!")]
        public string EMail { get; set; }

        [DisplayName("Telefonnummer")]
        [Required]
        [StringLength(40)]
        [RegularExpression(@"^((((([+][1-9]\d{0,3}([\s]*\(0\)){0,1})|(00[1-9]\d{0,3})|0|(\([+][1-9]\d{0,3}\))|(\(00[1-9]\d{0,3}\)))[\s]*(([-/]{0,1}[\s]*[1-9]\d+)|(\([1-9]\d+\))))|([-]{0,1}\(0[1-9]\d+\)))([\s]*[-/]{0,1}[\s]*\d+)+[\s]*)$", ErrorMessage = "Die Telefonnummer stimmt nicht.")]
        public string TelephoneNumber { get; set; }


        public List<Notes> Notes { get; set; }

        public Person()
        {
        }
        public Person(string firstname, string surname, string company, string postion, string website, string email, string telephonenumber, List<Notes> notes)
        {
            this.Firstname = firstname;
            this.Surname = surname;
            this.Company = company;
            this.Position = postion;
            this.Website = website;
            this.EMail = email;
            this.TelephoneNumber = telephonenumber;
            this.Notes = notes;
        }
    }
}
