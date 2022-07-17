using Windows.UI.Xaml.Controls;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace UWPPlatform
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Навигация
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void NavigationView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            var item = args.InvokedItemContainer;
            // Содержимое выбранного элемента
            switch (item.Name)
            {
                case "GridWithProportionalSize":
                    ContentFrame.Navigate(typeof(GridWithProportionalSize));
                    break;
                case "GridLayout":
                    ContentFrame.Navigate(typeof(GridLayout));
                    break;
                case "GridWithAutoSize":
                    ContentFrame.Navigate(typeof(GridWithAutoSize));
                    break;
                case "VariableSizedWrapGrid":
                    ContentFrame.Navigate(typeof(VariableSizedWrapGrid));
                    break;
                case "StackPanelLayout":
                    ContentFrame.Navigate(typeof(StackPanelLayout));
                    break;
                case "CanvasLayout":
                    ContentFrame.Navigate(typeof(CanvasLayout));
                    break;
                case "RelativePanelLayout":
                    ContentFrame.Navigate(typeof(RelativePanelLayout));
                    break;
                case "SplitViewLayout":
                    ContentFrame.Navigate(typeof(SplitViewLayout));
                    break;
                case "Binding":
                    ContentFrame.Navigate(typeof(Binding));
                    break;
                case "BindingWithSource":
                    ContentFrame.Navigate(typeof(BindingWithSource));
                    break;
                case "DataContext":
                    ContentFrame.Navigate(typeof(DataContext));
                    break;
                case "DataContextWithFrameworkElement":
                    ContentFrame.Navigate(typeof(DataContextWithFrameworkElement));
                    break;
                case "DataContextWithINotifyPropertyChanged":
                    ContentFrame.Navigate(typeof(DataContextWithINotifyPropertyChanged));
                    break;
                case "Bind":
                    ContentFrame.Navigate(typeof(Bind));
                    break;
                case "BindingsUpdate":
                    ContentFrame.Navigate(typeof(BindingUpdate));
                    break;
                case "ValueConverter":
                    ContentFrame.Navigate(typeof(ValueConverter));
                    break;
                case "VisualState":
                    ContentFrame.Navigate(typeof(VisualState));
                    break;
            }
        }
    }
}
