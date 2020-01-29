using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin_Forms_Task_2.Model;

namespace Xamarin_Forms_Task_2.ViewModel
{
    public class ItemVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop = "")
           => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        private Item Item { get; set; }
        public ItemVM(string Image, string Name, string LockImage, int Price, int? OldPrice)
        {
            Item = new Item();
            this.Image = Image;
            this.Name = Name;
            this.LockImage = LockImage;
            this.Price = Price;
            this.OldPrice = OldPrice.ToString() ?? "";
        }
        public ItemVM()
            : this("", "", "", 0, 0)
        { }
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
                Item.LockImage = value;
                OnPropertyChanged("LockImage");
            }
        }
        public string OldPrice
        {
            get
            {
                if (Item.OldPrice == "")
                    return "";
                else
                    return "$" + Item.OldPrice;
            }
            set
            {
                Item.OldPrice = value;
                OnPropertyChanged("OldPrice");
            }
        }
        public int Price
        {
            get => Item.Price;
            set
            {
                Item.Price = value;
                OnPropertyChanged("Price");
            }
        }
    }
}
