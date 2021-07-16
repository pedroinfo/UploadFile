using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcUploadFile.Data;
using MvcUploadFile.Extensions;
using MvcUploadFile.Models;

namespace MvcUploadFile.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly AppDataContext _context;

        public EmployeesController(AppDataContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Employee.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee.Include(x=>x.EmployeeAttachments)
                .FirstOrDefaultAsync(m => m.EmployeeId == id);

            //todo: View FileBytes of image types.

            // System.IO.File.WriteAllBytes(@"C:\temp\arquivo\" + employee.EmployeeAttachments[0].AttachmentName, employee.EmployeeAttachments[0].Bytes);

            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }


        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                if(Request.Form.Files.Count > 0)
                {
                    employee.EmployeeAttachments = new List<EmployeeAttachment>();

                    foreach (var item in Request.Form.Files)
                    {
                        employee.EmployeeAttachments.Add(new EmployeeAttachment
                        {
                            AttachmentName = item.FileName,
                            ContentLenght = item.Length,
                            ContentType = item.ContentType,
                            Bytes = await item.GetBytes()
                        });
                    }
                }

                _context.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee
                                         .Include(x => x.EmployeeAttachments)
                                         .Where(x => x.EmployeeId == (int)id)
                                         .FirstOrDefaultAsync();
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Employee employee)
        {
            if (id != employee.EmployeeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.EmployeeId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee
                .FirstOrDefaultAsync(m => m.EmployeeId == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

   
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.Employee.FindAsync(id);
            _context.Employee.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employee.Any(e => e.EmployeeId == id);
        }


        [HttpGet]
        public async Task<IActionResult> DownloadFile(int id)
        {
            var file = await _context.EmployeeAttachment
                .FirstOrDefaultAsync(x => x.EmployeeAttachmentId == id);

            return File(file.Bytes, file.ContentType, file.AttachmentName);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteFile(int id)
        {
            var file = new EmployeeAttachment { EmployeeAttachmentId = id };
          _context.EmployeeAttachment.Remove(file);
            var isDeleted = await _context.SaveChangesAsync();

            if (isDeleted > 0)
                return Ok("File deleted.");
            else
                return Problem("fail...");
        }


        [HttpPost]
        public async Task<IActionResult> SaveFileWithAjax(int employeeId)
        {
            var employeeAttachmentList = new List<EmployeeAttachment>();

            foreach (var item in Request.Form.Files)
            {
                var employeeAttachment = new EmployeeAttachment
                {
                    EmployeeId = employeeId,
                    AttachmentName = item.FileName,
                    ContentLenght = item.Length,
                    ContentType = item.ContentType,
                    Bytes = await item.GetBytes()
                };
                employeeAttachmentList.Add(employeeAttachment);
            }

            _context.EmployeeAttachment.AddRange(employeeAttachmentList);
            var result = await _context.SaveChangesAsync();

            return Ok(result);
        }

    }
}
