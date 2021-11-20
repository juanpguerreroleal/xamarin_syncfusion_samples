using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace SyncfusionSamples.Models
{
    public class RotatorItem: INotifyPropertyChanged
    {
        public int TemplateId { get; set; }
        private ObservableCollection<ItemDataPoint> _highTemperature;

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<ItemDataPoint> HighTemperature
        {
            get 
            { 
                return _highTemperature; 
            }
            set 
            {
                if (value != _highTemperature)
                {
                    _highTemperature = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(HighTemperature)));
                }
            }
        }

    }
}
