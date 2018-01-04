
using OffBloom.Client.Features;
using Xamarin.Forms;

namespace OffBloom.Client
{
    public partial class MasterView : TabbedPage
    {
        public MasterView()
            : base()
        {
            InitializeComponent();

            SetupHomeView();
            SetupTourView();
        }

        private void SetupHomeView()
        {
            var navigationPage = new NavigationPage(new MainPage()
            {
            });

            // TODO:
            //navigationPage.Icon = "schedule.png";
            navigationPage.Title = "Schedule";
            Children.Add(navigationPage);
        }

        private void SetupTourView()
        {
            var tourView = new TourView();
            tourView.Title = "Tour";
            Children.Add(tourView);
        }
    }
}
