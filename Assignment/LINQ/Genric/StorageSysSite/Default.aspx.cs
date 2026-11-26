using StorageSysLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//1. Generic Storage System

//Scenario:
//A company needs a reusable storage class. Today it needs to store int values, 
//but tomorrow it may need to store string, Employee, or Product objects.

//Create a generic class Storage<T> with:

//A private field of type T
//SetValue(T value) method
//GetValue() method
//Questions:

//How will you define the generic class?
//How will you create objects for int, string, and Employee?
//Why is Storage<T> better than creating separate IntStorage, StringStorage, and EmployeeStorage classes?
//Expected usage:

//Storage<int> intStorage = new Storage<int>();

//Storage<string> stringStorage = new Storage<string>();

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnDisplay_Click(object sender, EventArgs e)
    {
        Storage<int> intStorage = new Storage<int>();
        intStorage.SetValue(123);
        lblDisplay.Text += "int value: " + intStorage.GetValue() + "<br>";

        Storage<string> stringStorage = new Storage<string>();
        stringStorage.SetValue("abc");
        lblDisplay.Text += "string value: " + stringStorage.GetValue() + "<br>";

        Storage<Employee> empStorage = new Storage<Employee>();
        Employee emp = new Employee() { Id = 101, Name = "Bob" };
        empStorage.SetValue(emp);
        Employee data = empStorage.GetValue();

        lblDisplay.Text += "<br>employee value: " + "<br>" + "id: " + data.Id + "<br>" + "name: " + data.Name;
    }
}