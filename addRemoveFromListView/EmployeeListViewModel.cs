using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;


namespace addRemoveFromListView
{
    class EmployeeListViewModel
    {
        public ICommand AddEmployeeCommand => new Command(AddEmployee);

        public ICommand RemoveEmployeeCommand => new Command(RemoveEmployee);

        public ICommand UpdateEmployeeCommand => new Command(UpdateEmployee);
        public ObservableCollection<string> Employees { get; set; }

        public string EmployeeName { get; set; }

        public string SelectedEmployee { get; set; }
        public EmployeeListViewModel()
        {


            Employees = new ObservableCollection<string>();

            Employees.Add("Bent");
            Employees.Add("John");
            Employees.Add("Finn");
            Employees.Add("Kurt");
            Employees.Add("Knud");
            Employees.Add("Sille");



            //string[] arrEmployees = new string[] { "Bent", "John", "Finn", "Kurt", "Knud" };
            //Employees = arrEmployees;

        }

        public void AddEmployee()
        {

            Employees.Add(EmployeeName);

        }
        
        public void RemoveEmployee()
        {

            Employees.Remove(SelectedEmployee);

        }

        public void UpdateEmployee()
        {
            int newIndex = Employees.IndexOf(SelectedEmployee);

            Employees.Remove(SelectedEmployee);
            Employees.Add(EmployeeName);

            int oldIndex = Employees.IndexOf(EmployeeName);

            Employees.Move(oldIndex, newIndex);

        }
    }
}
