using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestCollectionView
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            SetSpan(4);
            this.BindingContext = new RoomMapViewModel();
        }

        private void SetSpan3(object sender, EventArgs arg)
        {
            SetSpan(3);
        }
        private void SetSpan4(object sender, EventArgs arg)
        {
            SetSpan(4);
        }
        private void SetSpan5(object sender, EventArgs arg)
        {
            SetSpan(5);
        }
        private void SetSpan(int span)
        {
            Cll.ItemsLayout = new GridItemsLayout(span, ItemsLayoutOrientation.Vertical)
            {
                VerticalItemSpacing = 1,
                HorizontalItemSpacing = 1
            };
        }

        private void SetItemSizingStrategy(object sender, EventArgs arg)
        {
            if (Cll.ItemSizingStrategy == ItemSizingStrategy.MeasureAllItems)
            {
                Cll.ItemSizingStrategy = ItemSizingStrategy.MeasureFirstItem;
            }
            else
            {
                Cll.ItemSizingStrategy = ItemSizingStrategy.MeasureAllItems;
            }
        }
    }
}
