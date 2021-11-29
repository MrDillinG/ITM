using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InternalTradeMarket.Models;

namespace InternalTradeMarket.ViewModels
{
    public class SortViewModel
    {
        public IEnumerable<Load> LoadsList { get; set; }
        public Load SortingList { get; set; }
    }
}