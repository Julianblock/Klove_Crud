using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Klove_Crud.Models
{
    public class EmployeesController : Controller
    {
        private Klove_CrudContext db = new Klove_CrudContext();

        // GET: Employees
        public ActionResult Index()
        {

            List<Employees> employeelist = db.Employees.ToList();

            List<EmployeeViewModel> employeeVMList = employeelist.Select(e=> new EmployeeViewModel
            {
                firstName = e.firstName,
                lastName = e.lastName,
                Position = e.Position,
                Salary = e.Salary,
                Email = e.Email,
                Phone = e.Phone,
                departmentID = e.departmentID,
                departmentName = e.Departments.Department }).ToList();

            return View(employeeVMList);
        }

        // GET: Employees/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employees employees = await db.Employees.FindAsync(id);
            if (employees == null)
            {
                return HttpNotFound();
            }
            return View(employees);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID,firstName,lastName,startDate,Position,Salary,Email,Phone,departmentID")] Employees employees)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(employees);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(employees);
        }

        // GET: Employees/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employees employees = await db.Employees.FindAsync(id);
            if (employees == null)
            {
                return HttpNotFound();
            }
            return View(employees);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,firstName,lastName,startDate,Position,Salary,Email,Phone,departmentID")] Employees employees)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employees).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(employees);
        }

        // GET: Employees/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employees employees = await db.Employees.FindAsync(id);
            if (employees == null)
            {
                return HttpNotFound();
            }
            return View(employees);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Employees employees = await db.Employees.FindAsync(id);
            db.Employees.Remove(employees);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
