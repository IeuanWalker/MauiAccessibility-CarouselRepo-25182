using System.Collections;

namespace CarouselRepo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CarouselView_PositionChanged(object sender, PositionChangedEventArgs e)
        {
            if(carousel.ItemsSource is not IList items)
            {
                return;
            }

            btnLeft.IsVisible = carousel.Position != 0;
            btnRight.IsVisible = carousel.Position != items.Count - 1;
        }

        private void BtnLeft_Clicked(object sender, EventArgs e)
        {
            carousel.Position--;
        }

        private void BtnRight_Clicked(object sender, EventArgs e)
        {
            carousel.Position++;
        }
    }

}
