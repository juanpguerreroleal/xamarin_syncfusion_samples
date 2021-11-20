using Syncfusion.SfChart.XForms;
using SyncfusionSamples.Models;
using SyncfusionSamples.Views.Templates;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace SyncfusionSamples.ViewModels
{
    public class MultipleTemplatesRotatorViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        #region Properties
        private ObservableCollection<RotatorItem> _rotatorlist;
        public ObservableCollection<RotatorItem> RotatorList
        {
            get { return _rotatorlist; }
            set 
            {
                if (value != _rotatorlist)
                {
                    _rotatorlist = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(RotatorList)));
                } 
            }
        }
        public List<ItemDataPoint> Data { get; set; }

        private ObservableCollection<ItemDataPoint> _dataPoints;

        public ObservableCollection<ItemDataPoint> DataPoints
        {
            get { return _dataPoints; }
            set 
            {
                if (value != _dataPoints)
                {
                    _dataPoints = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DataPoints)));
                }
            }
        }




        private ObservableCollection<RotatorItemViewModel> _customTemplateRotatorlist;
        public ObservableCollection<RotatorItemViewModel> CustomTemplateRotatorList
        {
            get { return _customTemplateRotatorlist; }
            set
            {
                if (value != _customTemplateRotatorlist)
                {
                    _customTemplateRotatorlist = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CustomTemplateRotatorList)));
                }
            }
        }


        private ObservableCollection<CustomViewsRotatorItem> _viewsRotatorlist;
        public ObservableCollection<CustomViewsRotatorItem> ViewsRotatorList
        {
            get { return _viewsRotatorlist; }
            set
            {
                if (value != _viewsRotatorlist)
                {
                    _viewsRotatorlist = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ViewsRotatorList)));
                }
            }
        }
        #endregion

        #region Constructor
        public MultipleTemplatesRotatorViewModel()
        {
            Data = new List<ItemDataPoint>();
            Data.Add(new ItemDataPoint() { Month = "January", Value = 15 });
            Data.Add(new ItemDataPoint() { Month = "February", Value = 12 });
            Data.Add(new ItemDataPoint() { Month = "March", Value = 18 });

            //First Method
            RotatorList = new ObservableCollection<RotatorItem>();
            RotatorList.Add(new RotatorItem {
                TemplateId = 1,
                HighTemperature = new ObservableCollection<ItemDataPoint>(Data)
            });
            RotatorList.Add(new RotatorItem
            {
                TemplateId = 2,
                HighTemperature = new ObservableCollection<ItemDataPoint>(Data)
            });
            RotatorList.Add(new RotatorItem
            {
                TemplateId = 3,
                HighTemperature = new ObservableCollection<ItemDataPoint>(Data)
            });

            //Second Method
            CustomTemplateRotatorList = new ObservableCollection<RotatorItemViewModel>();
            CustomTemplateRotatorList.Add(new StackTemplateRotatorViewModel());
            CustomTemplateRotatorList.Add(new Stack2TemplateRotatorViewModel());

            //Third Method
            DataPoints = new ObservableCollection<ItemDataPoint>();
            DataPoints = new ObservableCollection<ItemDataPoint>(Data);
            ViewsRotatorList = new ObservableCollection<CustomViewsRotatorItem>();
            //  Building the view
            var view1 = BuildView1();
            var view1Item = new CustomViewsRotatorItem(view1);
            ViewsRotatorList.Add(view1Item);
            var view2 = BuildView2();
            var view2Item = new CustomViewsRotatorItem(view2);
            ViewsRotatorList.Add(view2Item);
        }
        public View BuildView1()
        {
            var view1BaseLayout = new StackLayout();
            view1BaseLayout.HorizontalOptions = LayoutOptions.FillAndExpand;
            view1BaseLayout.VerticalOptions = LayoutOptions.FillAndExpand;
            var view1CollectionView = new CollectionView();
            view1CollectionView.HorizontalOptions = LayoutOptions.FillAndExpand;
            view1CollectionView.VerticalOptions = LayoutOptions.FillAndExpand;
            view1CollectionView.ItemsSource = DataPoints;
            view1CollectionView.EmptyView = new Label() { Text = "There's no data available" };
            var dataTemplate = new DataTemplate(() => {
                var template = new Grid();
                template.VerticalOptions = LayoutOptions.FillAndExpand;
                template.HorizontalOptions = LayoutOptions.FillAndExpand;
                template.ColumnDefinitions = new ColumnDefinitionCollection();
                var colDef1 = new ColumnDefinition();
                colDef1.Width = new GridLength(30, GridUnitType.Star);
                var colDef2 = new ColumnDefinition();
                colDef2.Width = new GridLength(70, GridUnitType.Star);
                template.ColumnDefinitions.Add(colDef1);
                template.ColumnDefinitions.Add(colDef2);
                var label1 = new Label();
                label1.SetBinding(Label.TextProperty, "Month");
                Grid.SetColumn(label1, 0);
                var label2 = new Label();
                label2.SetBinding(Label.TextProperty, "Value");
                Grid.SetColumn(label1, 1);
                template.Children.Add(label1);
                template.Children.Add(label2);
                return template;
            });
            view1CollectionView.ItemTemplate = dataTemplate;
            view1BaseLayout.Children.Add(view1CollectionView);
            return view1BaseLayout;
        }
        public View BuildView2()
        {
            var view1BaseLayout = new StackLayout();
            view1BaseLayout.HorizontalOptions = LayoutOptions.FillAndExpand;
            view1BaseLayout.VerticalOptions = LayoutOptions.FillAndExpand;
            var chart = new SfChart();
            chart.HeightRequest = 150;
            chart.WidthRequest = 100;
            chart.PrimaryAxis = new CategoryAxis();
            chart.SecondaryAxis = new NumericalAxis();
            var series = new ChartSeriesCollection();
            series.Add(new ColumnSeries() { ItemsSource = DataPoints, XBindingPath = "Month", YBindingPath = "Value" });
            chart.Series = series;
            view1BaseLayout.Children.Add(chart);
            return view1BaseLayout;
        }
        #endregion
    }
}
