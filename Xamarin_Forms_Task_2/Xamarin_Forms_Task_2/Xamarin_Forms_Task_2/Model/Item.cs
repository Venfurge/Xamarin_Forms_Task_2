﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin_Forms_Task_2.Model
{
    public class Item
    {
        private string _image, _name, _lockImage;
        private int _price;
        private string _oldPrice;
        public Item(string Image, string Name, string LockImage, int Price, string OldPrice)
        {
            this.Image = Image;
            this.Name = Name;
            this.LockImage = LockImage;
            this.Price = Price;
            this.OldPrice = OldPrice;
        }
        public Item()
            : this("", "", "", 0, null)
        { }
        public string Image
        {
            get => _image;
            set
            {
                _image = value;
            }
        }
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }
        public string LockImage
        {
            get => _lockImage;
            set
            {
                _lockImage = value;
            }
        }
        public int Price
        {
            get => _price;
            set
            {
                _price = value;
            }
        }
        public string OldPrice
        {
            get => _oldPrice;
            set
            {
                _oldPrice = value;
            }
        }
    }
}
