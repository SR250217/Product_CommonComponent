using System;
using System.ComponentModel.DataAnnotations;
namespace Dodos.UI.Models {
    public class Common_ConnectionModel {
         [Key]
        public int ProductID { get; set; }

        [Required]

        public string ProductCode { get; set; }

        [Required]
        public string ProductName { get; set; }

        
        [Required]
        public string ConnectionString { get; set; }

        public bool ProductStatus { get; set; }
        public DateTime Createdon { get; set; }
    }
}