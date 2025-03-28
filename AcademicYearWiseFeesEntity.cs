using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB_CMS.Entities
{
    public class AcademicYearWiseFeesEntity
    {

        public int Id { get; set; }
        public int AcademicFeesId { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> ExtraFees { get; set; }
        public int PaymentId { get; set; }
        public string ReciptNo { get; set; }
        public Nullable<System.DateTime> ReciptDate { get; set; }
        public string ChallanNo { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}
