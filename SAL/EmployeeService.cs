namespace SAL;

using BOL;
using BLL;

public class EmployeeService {
    public List<Employee> Getall(){
        EmployeeManage em = new EmployeeManage();
        return em.Getall();
    }
    
    public bool AddEmp(Employee e){
        EmployeeManage em = new EmployeeManage();
        return em.AddEmp(e);
    }
     public bool Remove(String hod){
        EmployeeManage em = new EmployeeManage();
        return em.Remove(hod);
    }

      public bool EditEmp(String hod,Employee e){
        EmployeeManage em = new EmployeeManage();
        return em.EditEmp(hod,e);
    }
 
}