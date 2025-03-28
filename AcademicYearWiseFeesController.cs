using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using NCB_CMS.Business;
using NCB_CMS.Entities;
using NCB_CMS.UI.Web.ViewModel;

namespace NCB_CMS.UI.Web.Controllers
{
    public class AcademicYearWiseFeesController : Controller
    {
        AcademicYearWiseFeesComponent academicYearWiseFeesComponent = new AcademicYearWiseFeesComponent();
        AcademicYearWiseFeesViewModel academicYearWiseFeesViewModel = new AcademicYearWiseFeesViewModel();
        
        // GET: AcademicYearWiseFees
        public ActionResult Index(int id = 0)
        {
            ViewBag.IsEdit = false;
            academicYearWiseFeesViewModel = ViewModel(true);
            if (id != 0)
            {
                ModelState.Clear();
                academicYearWiseFeesViewModel.AcademicYearWiseFee = academicYearWiseFeesViewModel.AcademicYearWiseFees.Single(x => x.Id == id);
                ViewBag.IsEdit = true;
            }
            return View(academicYearWiseFeesViewModel);
        }

        [HttpPost]
        public ActionResult Index(AcademicYearWiseFeesEntity academic, int id = 0)
        {
            if (id == 0)
                academicYearWiseFeesComponent.AddAcademicYearWiseFeesDetails(academic);
            else
            {
                academic.Id = id;
                academicYearWiseFeesComponent.UpdateAcademicYearWiseFeesDetails(academic);
            }
            return RedirectToAction("Index", new { id = 0 });
        }

        public ActionResult Delete(int Id)
        {
            academicYearWiseFeesViewModel = ViewModel(true);
            AcademicYearWiseFeesEntity academic = academicYearWiseFeesViewModel.AcademicYearWiseFees.Single(x => x.Id == Id);
            academicYearWiseFeesComponent.DeleteAcademicYearWiseFeesDetails(academic);
            return RedirectToAction("Index");
        }

        private AcademicYearWiseFeesViewModel ViewModel(bool isActive)
        {
            academicYearWiseFeesViewModel.AcademicYearWiseFees = academicYearWiseFeesComponent.GetAcademicYearWiseFeesDetails(isActive);            
            return academicYearWiseFeesViewModel;
        }
    }
}