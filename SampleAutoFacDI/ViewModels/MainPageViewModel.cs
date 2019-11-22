using System;
using System.Collections.ObjectModel;
using ServiceManager;

namespace SampleAutoFacDI.ViewModels
{
    public class MainPageViewModel
    { 
        private readonly IEmployeeService _employeeService;
        private ObservableCollection<string> _employeeCollection;
        public ObservableCollection<string> EmployeeCollection
        {
            get
            {
                return _employeeCollection;
            }
        }

        public MainPageViewModel(IEmployeeService employeeService)//Injected service data here
        {
            _employeeService = employeeService;
            InitializeData();
        }

        private void InitializeData()
        { 
            var empList = _employeeService.GetEmployeeNameList();
            _employeeCollection = new ObservableCollection<string>();
            empList.ForEach(emp => _employeeCollection.Add(emp));
        }
    }
}
