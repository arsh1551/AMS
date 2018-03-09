using DataAcessLayer.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using DataAcessLayer.ViewModels;
using System.Collections.Generic;
using System;
using ServiceLayer.Interfaces;

namespace TestUI.Controllers
{
    public class AssociateController : Controller
    {
        #region initialize
        IAssociateService _associateService = null;
        public AssociateController(IAssociateService objAssociateService)
        {
            _associateService = objAssociateService;
        }
        #endregion

        #region CRUD

        /// <summary>
        /// Display Associate listing along with specializations.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Index()
        {
            List<AssociateViewModel> listAssociateViewModel = _associateService.GetAssociates();
            CreateSummaryOfNames(listAssociateViewModel);
            return View(listAssociateViewModel);
        }

        /// <summary>
        ///  Save Associate form 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Create()
        {
            AssociateViewModel objAssociateViewModel = new AssociateViewModel();
            objAssociateViewModel.Specializations = _associateService.GetSpecializationsAll();
            return View(objAssociateViewModel);
        }

        /// <summary>
        /// Save new associate.
        /// </summary>
        /// <param name="associateViewModel"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AssociateId,AssociateName,AssociatePhone,AssociateAddress,specializationIds")] AssociateViewModel associateViewModel)
        {
            if (associateViewModel.specializationIds == null)
            {
                ModelState.AddModelError("Specializations", "Please select specialization");
            }
            if (ModelState.IsValid)
            {
                _associateService.SaveAssociate(associateViewModel);
                return RedirectToAction("Index");
            }
            else
            {
                associateViewModel.Specializations = _associateService.GetSpecializationsAll();
                return View(associateViewModel);
            }
        }

        /// <summary>
        /// Edit associate form
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return View("BadRequest");
            }
            else
            {
                try
                {
                    AssociateViewModel associateViewModel = _associateService.GetAssociateById(id.Value);
                    CreateSummaryOfIds(associateViewModel);
                    return View(associateViewModel);
                }
                catch
                {
                    throw;
                }

            }

        }

        /// <summary>
        /// Update associate alongwith specializations.
        /// </summary>
        /// <param name="associateViewModel"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AssociateId,AssociateName,AssociatePhone,AssociateAddress,specializationIds")] AssociateViewModel associateViewModel)
        {
            if (associateViewModel.specializationIds == null)
            {
                ModelState.AddModelError("Specializations", "Please select specialization");
            }

            if (ModelState.IsValid)
            {
                _associateService.SaveAssociate(associateViewModel);
                return RedirectToAction("Index");
            }
            else
            {
                associateViewModel.Specializations = _associateService.GetSpecializationsAll();
                return View(associateViewModel);
            }
        }

        /// <summary>
        /// Delete an associate
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult DeleteConfirmed(int id)
        {

            try
            {
                _associateService.DeleteAssociate(id);
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            catch
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }


        }
        #endregion

        #region Common

        public void CreateSummaryOfNames(List<AssociateViewModel> listAssociateViewModel)
        {
            foreach (AssociateViewModel objAssociateViewModel in listAssociateViewModel)
            {
                objAssociateViewModel.SpecializationSummary = (objAssociateViewModel.Specializations.Count > 0) ? string.Join(",", objAssociateViewModel.Specializations.Select(sp => sp.SpecializationName).ToList()) : "Not specified";

            }
        }
        public void CreateSummaryOfIds(AssociateViewModel associateViewModel)
        {
            associateViewModel.SpecializationSummary = (associateViewModel.Specializations.Count > 0) ? string.Join(",", associateViewModel.specializationIds) : "Not specified";
        }
        #endregion

    }
}
