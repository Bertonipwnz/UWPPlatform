using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace UWPPlatform
{
    /// <summary>
    /// Класс телефона
    /// </summary>
    public class Phone : INotifyPropertyChanged
    {
        private string modelPhone;
        private string company;
        private int price;

        ///<summary>
        /// Модель телефона
        /// </summary>
        public string ModelPhone
        {
            get { return modelPhone; }
            set
            {
                if (modelPhone != value)
                {
                    modelPhone = value;
                    OnPropertyChanged("ModelPhone");
                }
            }
        }

        ///<summary>
        /// Компания производитель
        /// </summary>
        public string Company
        {
            get { return company; }
            set
            {
                if (company != value)
                {
                    company = value;
                    OnPropertyChanged("Company");
                }
            }
        }

        ///<summary>
        /// Цена телефона
        /// </summary>
        public int Price
        {
            get { return price; }
            set
            {
                if (price != value)
                {
                    price = value;
                    OnPropertyChanged("Price");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
