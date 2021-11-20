using SyncfusionSamples.Views.Templates;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SyncfusionSamples.ViewModels
{
    public class StackTemplateRotatorViewModel: RotatorItemViewModel
    {
        public string XamlTemplate
        {
            get
            {
                return $@"
                        <StackLayout xmlns='http://xamarin.com/schemas/2014/forms'>
                            <Label Text='Entersome text:' Margin='30, 30, 30, 0'/>
                            <Entry Margin='30, 0, 30, 0'/>
                        </StackLayout>";
            }
        }
        public StackLayout Template
        {
            get
            {
                return CreateTemplate(XamlTemplate);
            }

        }
    }
}
