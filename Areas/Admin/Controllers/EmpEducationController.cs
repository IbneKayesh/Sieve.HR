﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Infrastructure;
using Sieve.HR.Services.Db;
using Sieve.HR.Utilities;

namespace Sieve.HR.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EmpEducationController : Controller
    {

        private readonly IUnitOfWork unitOfWork;
        public EmpEducationController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }


        //private readonly HRDbContext _context;
        //public EmpEducationController(HRDbContext context)
        //{
        //    _context = context;
        //}
        public IActionResult Index()
        {
            //IEnumerable<HR_EMP_EDU> objList = _context.HR_EMP_EDU;

            IEnumerable<HR_EMP_EDU> objList = unitOfWork.EmpEducation.SelectAll(orderBy: x => x.OrderBy(o => o.ID));

            return View(objList);
        }
        public IActionResult Create(int? id)
        {
            DropDownListFor_Create();
            HR_EMP_EDU objDb = new HR_EMP_EDU();
            if (id == null || id == 0)
            {
                return View(objDb);
            }            
            objDb = unitOfWork.EmpEducation.SelectById(id.Value);
            return View(objDb);
        }
        public IActionResult CreateByEmpID(int? EMP_ID)
        {
            DropDownListFor_Create();
            IEnumerable<HR_EMP_EDU> objDbList = unitOfWork.EmpEducation.SelectAll(filter: x => x.EMP_ID == EMP_ID);
            if (objDbList != null && objDbList.Count() > 0)
            {
                return View("Index", objDbList);
            }
            else
            {
                return View("Index", objDbList);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HR_EMP_EDU obj)
        {
            DropDownListFor_Create();
            if (ModelState.IsValid)
            {
                if (obj.ID <= 0)
                {
                    unitOfWork.EmpEducation.Insert(obj);
                }
                else
                {
                    unitOfWork.EmpEducation.Update(obj);
                }
                EQResult eQ = unitOfWork.Commit();
                if (eQ.SUCCESS && eQ.ROWS > 0)
                {
                    TempData["msg"] = SweetMessages.SaveSuccessOK();
                }
                else
                {
                    TempData["msg"] = SweetMessages.ShowError(eQ.MESSAGES);
                }
                return RedirectToAction(nameof(Create));
            }
            return View(obj);
        }

        private void DropDownListFor_Create()
        {
            ViewBag.EDU_TYPE_ID = unitOfWork.EduType.SelectAll().Select(s => new SelectListItem() { Text = s.TYPE_NAME, Value = s.ID.ToString() }).ToList();
        }
    }
}
