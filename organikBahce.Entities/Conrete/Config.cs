using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace organikBahce.Entities.Conrete
{
    public class Config
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyOfficialName { get; set; }
        public string WebSite { get; set; }
        public string AuthorizedPerson { get; set; }
        public string Phone { get; set; }
        public string Phone2 { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string OrderEmail { get; set; }
        public string Adress { get; set; }
        public int ContryId { get; set; }
        public int CityId { get; set; }
        public int DistrictId { get; set; }
        public int PostCode { get; set; }
        public string TaxAdministrator { get; set; }
        public string TaxNumber { get; set; }
        public string KepNumber { get; set; }
        public string MersisNumber { get; set; }
        public string Favicon { get; set; }
        public string Logo { get; set; }
        public string MailLogo { get; set; }
        public bool isActive { get; set; }
        public string RobotUrl { get; set; }
        public string SitemapUrl { get; set; }
        public string GoogleAnaliyticCode { get; set; }
        public string YandexAnaliyticCode { get; set; }
        public string SMTPName { get; set; }
        public string SMTPHostName { get; set; }
        public string SMTPPort { get; set; }
        public string SMTPPassword { get; set; }
        public bool isSSL { get; set; }

    }
}
