using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;


// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPPlatform
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class BindingUpdate : Page
    {
        public Phone MyPhone { get; set; } = new Phone { Company = "Apple", Price = 40000, ModelPhone = "IPhone 5" };

        public BindingUpdate()
        {
            this.InitializeComponent();
        }
    }
}
