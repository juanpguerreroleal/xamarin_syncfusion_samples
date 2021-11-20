using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace SyncfusionSamples.Models
{
    public class CustomViewsRotatorItem: INotifyPropertyChanged
    {
        public CustomViewsRotatorItem(View itemTemplate)
        {
            ItemTemplate = itemTemplate;
        }
        private View _itemTemplate;

        public View ItemTemplate
        {
            get { return _itemTemplate; }
            set { _itemTemplate = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ItemTemplate))); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
