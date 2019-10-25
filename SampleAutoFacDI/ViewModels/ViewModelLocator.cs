using System;
using CommonServiceLocator;
namespace SampleAutoFacDI.ViewModels
{
    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            AutoFacContainer.Initialize();
        }

        public MainPageViewModel MainPageViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainPageViewModel>();
            }
        }
    }
}
