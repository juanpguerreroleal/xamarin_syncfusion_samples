using SyncfusionSamples.Views.Templates;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SyncfusionSamples.ViewModels
{
    public class RotatorItemViewModel
    {
        public StackLayout CreateTemplate(string templateXaml)
        {
            StackLayout stackLayout = new StackLayout();
            stackLayout.LoadFromXaml(templateXaml);
            return stackLayout;
        }
    }
}
