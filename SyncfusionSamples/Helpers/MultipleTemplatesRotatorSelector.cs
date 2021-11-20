using SyncfusionSamples.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SyncfusionSamples.Helpers
{
    public class MultipleTemplatesRotatorSelector : DataTemplateSelector
    {
        public DataTemplate StackTemplate { get; set; }
        public DataTemplate ChartTemplate { get; set; }
        public DataTemplate DefaultTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var model = (RotatorItem)item;
            switch (model.TemplateId)
            {
                case 1:
                    return StackTemplate;
                case 2:
                    return ChartTemplate;
                default:
                    return DefaultTemplate;
            }
            throw new Exception($"The template {item.ToString()} isn't implemented");
        }
    }
}
