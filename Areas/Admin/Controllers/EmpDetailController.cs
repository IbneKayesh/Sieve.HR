using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Services.Db;

namespace Sieve.HR.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EmpDetailController : Controller
    {
        private readonly HRDbContext _context;
        public EmpDetailController(HRDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<HR_EMP_DETAIL> objList = _context.HR_EMP_DETAIL;
            return View(objList);
        }

        public IActionResult Create(int? id)
        {
            DropDownListFor_Create();
            HR_EMP_DETAIL objDb = new HR_EMP_DETAIL();
            if (id == null || id == 0)
            {
                return View(objDb);
            }
            else
            {
                objDb = _context.HR_EMP_DETAIL.Find(id);
                return View(objDb);
            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HR_EMP_DETAIL obj)
        {
            DropDownListFor_Create();
            if (ModelState.IsValid)
            {
                if (obj.ID <= 0)
                {
                    _context.HR_EMP_DETAIL.Add(obj);
                }
                else
                {
                    _context.Entry(obj).State = EntityState.Modified;
                }
                _context.SaveChanges();
                TempData["ResultOk"] = "Record Added/Updated Successfully !";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult Delete(int? id)
        {
            var Deleterecord = _context.HR_EMP_DETAIL.Find(id);

            if (id == null || id == 0)
            {
                return NotFound();
            }
            else
            {
                _context.HR_EMP_DETAIL.Remove(Deleterecord);
                _context.SaveChanges();
                TempData["ResultOk"] = "Data Deleted Successfully !";
                return RedirectToAction("Index");
            }

        }

        private void DropDownListFor_Create()
        {
            ViewBag.GENDER_ID = new List<SelectListItem>() { new SelectListItem { Text = "Male", Value = "Male" },
                                                             new SelectListItem { Text = "Female", Value = "Female"},
                                                             new SelectListItem { Text = "Third Gender", Value = "Third Gender"}
                                                            };

            ViewBag.MARITAIL_STATUS = new List<SelectListItem>() { new SelectListItem { Text = "Married", Value = "Married" },
                                                             new SelectListItem { Text = "Unmarried", Value = "Unmarried"},
                                                             new SelectListItem { Text = "Divorce", Value = "Divorce"}
                                                            };
        }

    }
}
