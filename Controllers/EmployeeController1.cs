using Microsoft.AspNetCore.Mvc;
using Test.Data;
using Test.Models;

namespace Test.Controllers
{
    public class EmployeeController1 : Controller
    {
        private readonly Datacontacts datacontacts;

        public EmployeeController1(Datacontacts datacontacts)
        {
            this.datacontacts = datacontacts;
        }
        [HttpGet]
        public IActionResult Add() 
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(EmployeeViewModel  addEmployeerqst)
        {
            var emp = new Employees() {
                Id=addEmployeerqst.Id,
            Name= addEmployeerqst.Name,
            ParentsId=addEmployeerqst.ParentsId,
            IsActive=addEmployeerqst.IsActive,
            StartDate=addEmployeerqst.StartDate
            };
            await datacontacts.AddAsync(emp);
            await datacontacts.SaveChangesAsync();
            return RedirectToAction("Add");

        }

    }
}
