using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sieve.HR.Areas.Admin.Models;
using Sieve.HR.Infrastructure;
using Sieve.HR.Services.Db;

namespace Sieve.HR.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AttendanceSheetController : Controller
    {      
        private readonly IUnitOfWork unitOfWork;
        public AttendanceSheetController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            IEnumerable<HR_ATTENDANCE_SHEET> objList = unitOfWork.AttendanceSheet.SelectAll(orderBy: x => x.OrderBy(o => o.EMP_ID));
            return View(objList);
        }        
    }
}
