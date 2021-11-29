using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using PagedList;

namespace InternalTradeMarket.Models
{
    public class Load
    {
        [Required]
        public int Id { get; set; }

        [Display(Name = "Departure City")]
        [Required]
        public string DepartureCity { get; set; }

        [Display(Name = "Departure Zip Code")]
        [Required]
        public string DepartureZipCode { get; set; }

        [Display(Name = "Delivery to")]
        [Required]
        public string ArrivalCity { get; set; }

        [Display(Name  = "Delivery Zip Code")]
        [Required]
        public string ArrivalZipCode { get; set; }

        [Display(Name = "Pickup Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-mm-dd}")]
        [Required]
        public DateTime? PickupDate { get; set; }

        [Display(Name = "Delivery Date")]
        [Required]
        public DateTime? DeliveryDate { get; set; }

        [Required]
        public int Weight { get; set; }

        [Display(Name = "LDM")]
        [Required]
        public string LoadingMeter { get; set; }

        public string UserName { get; set; }

        [Display(Name = "Pickup Country")]
        [Required]
        public string DepartureCountry { get; set; }

        [Display(Name = "Delivery Country")]
        [Required]
        public string ArrivalCountry { get; set; }

        [Display(Name = "Temperature controlled")]
        public bool Frigo { get; set; }

        [Display(Name = "Dangerous goods")]
        public bool Adr { get; set; }

        [Display(Name = "Extra Comments")]
        public string ExtraComments { get; set; }

        public int Lat { get; set; }

        public int Long { get; set; }
    }
}