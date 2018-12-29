using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dodos.UI.Models {
    public class LoginModel {
        [Key]
       public long AppUserId { get; set; }
        public string AppUserName { get; set; }
        public string AppUserPassword { get; set; }
        public bool? AppUserStatus { get; set; }
        public int? PrimaryCompanyId { get; set; }
        public string ProfilePhoto { get; set; }
        public string Prefix { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public bool? IsActivated { get; set; }
        public DateTime? ActivatedOn { get; set; }
        public int? ReportingToId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? FailedAttempts { get; set; }
        public DateTime? CurrentSigninAt { get; set; }
        public string CurrentSigninIp { get; set; }
        public DateTime? LastSigninAt { get; set; }
        public string LastSigninIp { get; set; }
        public int UserRoleId { get; set; }
        public int? EmpId { get; set; }
        public bool? IsAttendance { get; set; }
        public string PrimaryEmail { get; set; }
        public string SecondaryEmail { get; set; }
        public string ContactPhone { get; set; }
    }
}