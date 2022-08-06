using System;

#nullable disable

namespace eAM_Medical.Data.Models
{
    public partial class TblClinicMaster
    {
        public int Id { get; set; }
        public string ClinicName { get; set; }
        public string Address { get; set; }
        public string TagLine { get; set; }
        public string Registration { get; set; }
        public string OwnerName { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public int CreatedOn { get; set; }
        public DateTime CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
