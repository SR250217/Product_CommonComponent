using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dodos.UI.Models {
    public class StatesModel {
          [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int countryid { get; set; }
        public bool cstatus { get; set; }
    }
}