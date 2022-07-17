using Windows.UI.Xaml.Controls;


// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPPlatform
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class DataContextWithINotifyPropertyChanged : Page
    {
        public DataContextWithINotifyPropertyChanged()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Увеличиваем стоимость телефона
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Increase(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Phone phone = this.DataContext as Phone;
            phone.Price += 1000;
        }

        /// <summary>
        /// Уменьшаем стоимость телефона
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Decrease(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Phone phone = this.DataContext as Phone;
            phone.Price -= 1000;
        }
    }
}
