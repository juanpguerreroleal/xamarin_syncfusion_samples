using System;
using System.Collections.Generic;
using System.Text;

namespace SyncfusionSamples.ViewModels
{
    public class MainViewModel
    {
        #region ViewModels
        public MultipleTemplatesRotatorViewModel MultipleTemplatesRotator { get; set; }
        #endregion
        #region Constructor
        public MainViewModel()
        {
            MultipleTemplatesRotator = new MultipleTemplatesRotatorViewModel();
        }
        #endregion
    }
}
