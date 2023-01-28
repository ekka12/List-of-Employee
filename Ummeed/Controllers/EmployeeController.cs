using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ummeed.Models;
using SAL;
using BOL;

namespace EmployeeController;

public class EmployeeController : Controller{
    private readonly ILogger<EmployeeController>_Logger;

    public EmployeeController(ILogger<EmployeeController>logger){
         _Logger=logger;
    }

    public IActionResult Index(){
          EmployeeService es=new EmployeeService();
          List<Employee>elist = es.Getall();
          if(elist!=null){
            this.ViewData["Employee"]=elist;
          }  
          return View();
    } 
    public IActionResult Delete(string hod){
        EmployeeService es =new EmployeeService();
        bool status = es.Remove(hod);
        if(status){
            return RedirectToAction("Index","Employee");
        }
        return View();
    }
    [HttpGet]
    public IActionResult Insert(){
          return View();
    }
    [HttpPost]
    public IActionResult Insert(string subname,string hod){
          EmployeeService es = new EmployeeService();
          bool status = es.AddEmp(new Employee{SubName=subname,HOD=hod});
          if(status){
              return RedirectToAction("Index","Employee");
          } 
          return View();
    }
    [HttpGet]
    public IActionResult Edit(){
        return View();
    }
    [HttpPost]
    public IActionResult Edit(string hod1,string subname,string hod){
        EmployeeService es=new EmployeeService();
        bool status=es.EditEmp(hod1,new Employee{SubName=subname,HOD=hod});
        if(status){
            return RedirectToAction("Index","Employee");
        }
        return View();
    }
}