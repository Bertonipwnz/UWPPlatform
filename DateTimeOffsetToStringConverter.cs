using System;
using Windows.UI.Xaml.Data;

namespace UWPPlatform
{
    public class DateTimeOffsetToStringConverter : IValueConverter
    {
        /// <summary>
        /// Конвертируем строку в тип даты
        /// </summary>
        /// <param name="value">значение, которое надо преобразовать</param>
        /// <param name="targetType">тип, к которому надо преобразовать значение value</param>
        /// <param name="parameter">вспомогательный параметр привязки</param>
        /// <param name="language">языковой код en-US ru-RU</param>
        /// <returns>Возвращает преобразованную строку в тип даты</returns>
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            DateTimeOffset sourceTime = (DateTimeOffset)value;
            DateTime targetTime = sourceTime.DateTime;
            string result = targetTime.ToString("dd.MM.yyyy");
            if (language == "en-US")
                result = targetTime.ToString("MM-dd-yyyy");
            // проверяем переданный параметр
            if (parameter != null && parameter.ToString() == "full")
                result = "Сегодня: " + result;
            return result;
        }

        /// <summary>
        /// Конвертируем дату в тип строки
        /// </summary>
        /// <param name="value">значение, которое надо преобразовать</param>
        /// <param name="targetType">тип, к которому надо преобразовать значение value</param>
        /// <param name="parameter">вспомогательный параметр привязки</param>
        /// <param name="language">языковой код en-US ru-RU</param>
        /// <returns>Возвращает преобразованную дату в тип строки</returns>
        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            DateTimeOffset resultTime = DateTime.Parse(value.ToString());
            return resultTime;
        }
    }
}
