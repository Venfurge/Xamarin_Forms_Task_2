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
        public ObservableCollection<Item> Items { get; set; }
        public Item Item { get; set; }
        public INavigation Navigation { get; set; }
        public ICommand LockClickCommand { get; set; }
        public MainPageVM(INavigation navigation)
        {
            Navigation = navigation;
            Items = new ObservableCollection<Item>();
            Items.Add(new Item("Image1.jpg", "Something Cleaver", "EmptyLock.png", "$125", "$98"));
            Items.Add(new Item("Image2.jpg", "Something Stupid", "FullLock.png", "$125", "$98"));
            Items.Add(new Item("Image3.jpg", "Text more Text", "EmptyLock.png", "$25", "$120"));
            Items.Add(new Item("Image4.jpg", "Hello World", "FullLock.png", "$35", "$78"));
            LockClickCommand = new Command(LockClick);
        }
        public string Image 
        {
            get => Item.Image;
            set
            {
                Item.Image = value;
                OnPropertyChanged("Image");
            }
        }
        public string Name
        {
            get => Item.Name;
            set
            {
                Item.Name = value;
                OnPropertyChanged("Name");
            }
        }
        public string LockImage
        {
            get => Item.LockImage;
            set
            {
                Item.Name = value;
                OnPropertyChanged("LockImage");
            }
        }
        public string OldPrice
        {
            get => Item.OldPrice;
            set
            {
                Item.OldPrice = value;
                OnPropertyChanged("OldPrice");
            }
        }
        public string Price
        {
            get => Item.Price;
            set
            {
                Item.Price = value;
                OnPropertyChanged("Price");
            }
        }
        private void LockClick()
        {
            if (LockImage == "FullLock")
                LockImage = "EmptyLock";
            else
                LockImage = "FullLock";
        }
    }
}
