using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NCB_CMS.Entities;

namespace NCB_CMS.Data
{
    public class AcademicYearWiseFeesData
    {
        public IEnumerable<AcademicYearWiseFeesEntity> Read(bool isActive)
        {
            List<AcademicYearWiseFeesEntity> AcademicYearWiseFeesList = new List<AcademicYearWiseFeesEntity>();
            var context = new NcbCmsEntities();
            foreach (var item in context.AcademicYearWiseFees)
            {
                if (item.IsActive == isActive)
                    AcademicYearWiseFeesList.Add(new AcademicYearWiseFeesEntity
                    {
                        Id = item.Id,
                        AcademicFeesId = item.AcademicFeesId,
                        Year = item.Year,
                        Amount = item.Amount,
                        Discount = item.Discount,
                        ExtraFees= item.ExtraFees,
                        PaymentId = item.PaymentId,
                        ReciptNo = item.ReciptNo,
                        ReciptDate = item.ReciptDate,
                        ChallanNo = item.ChallanNo,
                        Description = item.Description,
                        IsActive = item.IsActive
                    });
            }
            return AcademicYearWiseFeesList;
        }

        public void Create(AcademicYearWiseFeesEntity academicYear)
        {
            using (var context = new NcbCmsEntities())
            {
                AcademicYearWiseFee AcademicYearWiseFeesInfo = new AcademicYearWiseFee
                {
                    AcademicFeesId = academicYear.AcademicFeesId,
                    Year = academicYear.Year,
                    Amount = academicYear.Amount,
                    Discount = academicYear.Discount,
                    ExtraFees = academicYear.ExtraFees,
                    PaymentId = academicYear.PaymentId,
                    ReciptNo=academicYear.ReciptNo,
                    ReciptDate=academicYear.ReciptDate,
                    ChallanNo=academicYear.ChallanNo,
                    Description=academicYear.Description,
                    IsActive = true,
                    CreatedBy = "Created Person",
                    CreatedDate = DateTime.Now
                };
                context.AcademicYearWiseFees.Add(AcademicYearWiseFeesInfo);
                context.SaveChanges();
            }
        }

        public void Update(AcademicYearWiseFeesEntity academicYear)
        {
            using (var context = new NcbCmsEntities())
            {
                var AcademicYearWiseFeesInfo = context.AcademicYearWiseFees.Single(x => x.Id == academicYear.Id);

                AcademicYearWiseFeesInfo.AcademicFeesId = academicYear.AcademicFeesId;
                    AcademicYearWiseFeesInfo.Year = academicYear.Year;
                    AcademicYearWiseFeesInfo.Amount = academicYear.Amount;
                    AcademicYearWiseFeesInfo.Discount = academicYear.Discount;
                    AcademicYearWiseFeesInfo.ExtraFees = academicYear.ExtraFees;
                    AcademicYearWiseFeesInfo.PaymentId = academicYear.PaymentId;
                    AcademicYearWiseFeesInfo.ReciptNo = academicYear.ReciptNo;
                    AcademicYearWiseFeesInfo.ReciptDate = academicYear.ReciptDate;
                    AcademicYearWiseFeesInfo.ChallanNo = academicYear.ChallanNo;
                    AcademicYearWiseFeesInfo.Description = academicYear.Description;
                    AcademicYearWiseFeesInfo.IsActive = true;
                    AcademicYearWiseFeesInfo.UpdatedBy = "Updated Person";
                    AcademicYearWiseFeesInfo.UpdatedDate = DateTime.Now;
                context.SaveChanges();
            }
        }

        public void Delete(AcademicYearWiseFeesEntity academicYear)
        {
            using (var context = new NcbCmsEntities())
            {
                var AcademicYearWiseFeesInfo = context.AcademicYearWiseFees.Single(x => x.Id == academicYear.Id);                
                AcademicYearWiseFeesInfo.IsActive = false;
                AcademicYearWiseFeesInfo.UpdatedBy = "Updated Person";
                AcademicYearWiseFeesInfo.UpdatedDate = DateTime.Now;
                context.SaveChanges();
            }
        }
    }
}
