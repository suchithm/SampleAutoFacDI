using System;
using System.Collections.ObjectModel;
using ServiceManager;

namespace SampleAutoFacDI.ViewModels
{
    public class MainPageViewModel
    { 
        private readonly ObservableCollection<string> _employeeCollection = new ObservableCollection<string>();
        public ObservableCollection<string> EmployeeCollection
        {
            get
            {
                return _employeeCollection;
            } 
        }

        public MainPageViewModel(IEmployeeService employeeService)
        {
           employeeService.GetEmployeeNameList().ForEach(emp => _employeeCollection.Add(emp));

        }
    }
}
