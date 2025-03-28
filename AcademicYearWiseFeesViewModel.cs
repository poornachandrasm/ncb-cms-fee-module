using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using NCB_CMS.Entities;

namespace NCB_CMS.UI.Web.ViewModel
{
    public class AcademicYearWiseFeesViewModel
    {
        public IEnumerable<AcademicYearWiseFeesEntity> AcademicYearWiseFees { get; set; }

        public AcademicYearWiseFeesEntity AcademicYearWiseFee { get; set; }
    }
}