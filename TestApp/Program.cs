using DBT;
using Dep;

using System.Collections.Generic;
using System.Linq;
using System.Data;
using MySql.Data.MySqlClient;


// Department dept = new Department{Id=1,Name="Research",Location="Pune"};
// bool status= DBTManage.Insert(dept);
// Department dept1 = new Department{Id=2,Name="Action",Location="Pune"};
// bool status1= DBTManage.Insert(dept1);

int id = 1;
Department d= DBTManage.GetById(id);
List <Department>dlist=new List<Department>();
    while(dlist!=null){
        if(d.Id==id){
           Console.WriteLine(" "+d.Id+" "+d.Name+" "+d.Location);
            break ; 
        }


            }

