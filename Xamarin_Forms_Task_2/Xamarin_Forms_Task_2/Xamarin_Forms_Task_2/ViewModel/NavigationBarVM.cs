using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Xamarin_Forms_Task_2.ViewModel
{
    public class NavigationBarVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop = "")
          => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        public INavigation Navigation { get; set; }
        public ICommand NavBarButtonCommand { get; set; }

        public string _navBarButton1, _navBarButton2, _navBarButton3;
        public NavigationBarVM(INavigation navigation)
        {
            NavBarButton1 = "CatalogViewButton1.png";
            NavBarButton2 = "CatalogViewButton2.png";
            NavBarButton3 = "CatalogSelectedButton3.png";
            NavBarButtonCommand = new Command<string>(NavBarButtonClicked);
            Navigation = navigation;
        }     
        public string NavBarButton1
        {
            get => _navBarButton1;
            set
            {
                _navBarButton1 = value;
                OnPropertyChanged("NavBarButton1");
            }
        }
        public string NavBarButton2
        {
            get => _navBarButton2;
            set
            {
                _navBarButton2 = value;
                OnPropertyChanged("NavBarButton2");
            }
        }
        public string NavBarButton3
        {
            get => _navBarButton3;
            set
            {
                _navBarButton3 = value;
                OnPropertyChanged("NavBarButton3");
            }
        }
        private void NavBarButtonClicked(object sender)
        {
            int temp = Convert.ToInt32(sender as string);
            switch (temp)
            {
                case 1:
                    NavBarButton1 = "CatalogSelectedButton1.png";
                    NavBarButton2 = "CatalogViewButton2.png";
                    NavBarButton3 = "CatalogViewButton3.png";
                    break;
                case 2:
                    NavBarButton1 = "CatalogViewButton1.png";
                    NavBarButton2 = "CatalogSelectedButton2.png";
                    NavBarButton3 = "CatalogViewButton3.png";
                    break;
                case 3:
                    NavBarButton1 = "CatalogViewButton1.png";
                    NavBarButton2 = "CatalogViewButton2.png";
                    NavBarButton3 = "CatalogSelectedButton3.png";
                    break;
            }         
        }
    }
}
