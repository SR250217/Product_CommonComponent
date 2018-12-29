using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dodos.UI.Models {
    public class CitiesModel {
         [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int stateid { get; set; }
        public bool cstatus { get; set; }  
        
    }
}