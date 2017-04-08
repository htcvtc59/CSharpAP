using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace New
{
    /*
     * In the above code, 
     * the class Employees declares a method called Display(). 
     * This method is inherited in the derived class 
     * Department and is preceded by the new keyword. 
     * The new keyword hides the inherited method Display () 
     * that was defined in the base class, thereby executing the
     * Display () method of the derived class when a call is made 
     * to it. However, the base keyword allows you to access the 
     * base class members. Therefore, the statements in the 
     * Display () method of the derived class and the base class
     * are executed, and. finally, the employee ID, employee name, 
     * department ID and department name are displayed in the 
     * console window.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Department objDepartment = new Department();
            objDepartment.Display();
        }
    }
}
