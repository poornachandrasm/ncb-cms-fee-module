using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NCB_CMS.Entities;

namespace NCB_CMS.Business
{
    public class AcademicYearWiseFeesComponent
    {
        NCB_CMS.Data.AcademicYearWiseFeesData academicYearWiseFeesData = new Data.AcademicYearWiseFeesData();

        public IEnumerable<AcademicYearWiseFeesEntity> GetAcademicYearWiseFeesDetails(bool isActive)
        {
            return academicYearWiseFeesData.Read(isActive);
        }
        public void AddAcademicYearWiseFeesDetails(AcademicYearWiseFeesEntity academicYear)
        {
            academicYearWiseFeesData.Create(academicYear);
        }

        public void UpdateAcademicYearWiseFeesDetails(AcademicYearWiseFeesEntity academicYear)
        {
            academicYearWiseFeesData.Update(academicYear);
        }

        public void DeleteAcademicYearWiseFeesDetails(AcademicYearWiseFeesEntity academicYear)
        {
            academicYearWiseFeesData.Delete(academicYear);
        }
    }
}
