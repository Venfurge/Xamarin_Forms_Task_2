using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Linq;
using Xamarin.Forms;
using Xamarin_Forms_Task_2.Model;
using System.Windows.Input;

namespace Xamarin_Forms_Task_2.ViewModel
{
    public class MainPageVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        public INavigation Navigation { get; set; }
        public ObservableCollection<ItemVM> Items { get; set; }
        public ItemVM Item { get; set; }
        public ICommand LockClickCommand { get; set; }
        public MainPageVM(INavigation navigation)
        {
            Navigation = navigation;    
            Items = new ObservableCollection<ItemVM>();
            Items.Add(new ItemVM("Image1.jpg", "Something asdgasdg asdg asdg asdg ag ads asdgsadgasdg", "EmptyLock.png", 125, null));
            Items.Add(new ItemVM("Image2.jpg", "Something Stupid", "EmptyLock.png", 125, 98));
            Items.Add(new ItemVM("Image3.jpg", "Text more Text", "EmptyLock.png", 25, 120));
            Items.Add(new ItemVM("Image4.jpg", "Hello World", "EmptyLock.png", 35, 78));
            LockClickCommand = new Command<ItemVM>(LockClick);
        }      
        private void LockClick(object sender)
        {
            Item = sender as ItemVM;
            if (Item.LockImage == "FullLock.png")
                Item.LockImage = "EmptyLock.png";
            else
                Item.LockImage = "FullLock.png";
        }
    }
}
