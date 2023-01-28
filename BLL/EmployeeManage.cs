namespace BLL;
 using BOL;
 using DAL;

 public class EmployeeManage{
    public static EmployeeManage instance=null;

    public static EmployeeManage GetManage(){
        if(instance==null){
            instance=new EmployeeManage();
        }
        return instance;
    }
    public List<Employee> Getall(){
        EmployeeIoManage Em =new EmployeeIoManage();
        return Em.Getall();
    }
    public bool AddEmp(Employee e){
        EmployeeIoManage Em = new EmployeeIoManage();
        return Em.AddEmp(e);

    }
     public bool Remove(String hod){
        EmployeeIoManage em = new EmployeeIoManage();
        return em.Remove(hod);
    }
     
      public bool EditEmp(String hod,Employee e){
        EmployeeIoManage em = new EmployeeIoManage();
        return em.Edit(hod,e);
    }

    
 }
