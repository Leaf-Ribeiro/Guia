using Guia.Domain.Globals;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Guia.Domain.Companies
{
    public class Company
    {
        public Company()
        {
            CreatedOn = DateTimeOffset.Now;
            SocialNetWorks = new List<SocialNetWork>();
            Pictures = new List<Picture>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string FantasyName { get; set; }

        private string _cnpj;
        // [StringLengthValidator(14, ErrorMessage = "Limite máximo de 14 caracteres para CNPJ")]
        public string CNPJ
        {
            get
            {
                return _cnpj;
            }

            set
            {
                _cnpj = value;
                if (_cnpj != null)
                {
                    Regex regularExpression = new Regex(@"[^0-9]");
                    _cnpj = regularExpression.Replace(value, "");
                }
            }
        }

        private string cpf;
        //[StringLengthValidator(11, ErrorMessage = "Limite máximo de 11 caracteres para CPF")]
        public string CPF
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
                if (cpf != null)
                {
                    Regex regularExpression = new Regex(@"[^0-9]");
                    cpf = regularExpression.Replace(value, "");
                }
            }
        }

        public string Email { get; set; }
        public string Description { get; set; }

        private string _phone;
        //[StringLengthValidator(12, ErrorMessage = "Limite máximo de 12 caracteres para Telefone")]
        public string Phone
        {
            get
            {
                return _phone;
            }

            set
            {
                _phone = value;
                if (_phone != null)
                {
                    Regex regularExpression = new Regex(@"[^0-9]");
                    _phone = regularExpression.Replace(value, "");
                }
            }
        }

        public string Address { get; set; }
        //[StringLengthValidator(10, ErrorMessage = "Limite máximo de 10 caracteres para Número")]
        public string Number { get; set; }

        //[StringLengthValidator(250, ErrorMessage = "Limite máximo de 250 caracteres para Complemento")]
        public string Complement { get; set; }

        private string _zipcode;
        //[StringLengthValidator(8, ErrorMessage = "Limite máximo de 8 caracteres para Cep")]
        public string ZipCode
        {
            get
            {
                return _zipcode;
            }

            set
            {
                _zipcode = value;
                if (_zipcode != null)
                {
                    Regex regularExpression = new Regex(@"[^0-9]");
                    _zipcode = regularExpression.Replace(value, "");
                }
            }
        }

        //[StringLengthValidator(100, ErrorMessage = "Limite máximo de 100 caracteres para Bairro")]
        public string Neighborhood { get; set; }

        public string Latitude { get; set; }
        public string Longitude { get; set; }

        public string GoogleMapsUrl { get; set; }

        public DateTimeOffset CreatedOn { get; set; }
        public bool Active { get; set; }
        public string Token { get; set; }

        public CompanyType Type { get; set; }
        public City City { get; set; }

        public IList<SocialNetWork> SocialNetWorks { get; set; }
        public IList<Picture> Pictures { get; set; }
    }
}
