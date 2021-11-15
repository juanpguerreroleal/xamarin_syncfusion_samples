using SyncfusionSamples.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SyncfusionSamples.Services
{
    public class Locator
    {
        #region ViewModels
        public MainViewModel Main { get; set; }
        #endregion
        #region Constructor
        public Locator()
        {
            Main = new MainViewModel();
        }
        #endregion

    }
}
