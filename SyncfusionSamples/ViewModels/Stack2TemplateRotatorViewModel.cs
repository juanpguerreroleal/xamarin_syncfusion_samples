using SyncfusionSamples.Views.Templates;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SyncfusionSamples.ViewModels
{
    public class Stack2TemplateRotatorViewModel: RotatorItemViewModel
    {
        public string XamlTemplate
        {
            get
            {
                return $@"
                        <StackLayout xmlns='http://xamarin.com/schemas/2014/forms'>
                            <Label Text='Stack 2' Margin='30, 30, 30, 0'/>
                            <BoxView HeightRequest='1' BackgroundColor='DarkGray'/>

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
