#if NOESIS
using Noesis;
#else
using System.Windows.Data;
using System.Windows.Markup;
#endif

using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;

namespace MarkupExtensions
{
    [ContentProperty(nameof(Key))]
    public class TranslateExtension : MarkupExtension
    {
        public TranslateExtension()
        {
        }

        public TranslateExtension(string key)
            => Key = key;

#if !NOESIS
        [ConstructorArgument("key")]
#endif
        public string Key { get; set; }

        public BindingBase Arg0 { get; set; } = null;

        public BindingBase Arg1 { get; set; } = null;

        public BindingBase Arg2 { get; set; } = null;

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            var localizedBinding = new Binding(nameof(LocalizedDataSource.LocalizedValue))
            {
                Source = new LocalizedDataSource(Key),
            };

            if (Arg0 == null && Arg1 == null && Arg2 == null)
            {
                return localizedBinding.ProvideValue(serviceProvider);
            }
            else
            {
                var dummyBinding = new Binding() { Source = null };
                var multiBinding = new MultiBinding();
                multiBinding.Mode = BindingMode.OneWay;
                multiBinding.Converter = new FormattedTranslationTextConverter();

                multiBinding.Bindings.Add(localizedBinding);
                multiBinding.Bindings.Add(Arg0 ?? dummyBinding);
                multiBinding.Bindings.Add(Arg1 ?? dummyBinding);
                multiBinding.Bindings.Add(Arg2 ?? dummyBinding);
                return multiBinding.ProvideValue(serviceProvider);
            }
        }
    }

    /// <summary>
    /// Provides language change tracking with weak subscription
    /// and acts as data source for binding with <see cref="TranslateExtension"/>.
    /// </summary>
    internal class LocalizedDataSource : INotifyPropertyChanged, IDisposable
    {
        private static readonly PropertyChangedEventArgs LOCALIZED_VALUE_CHANGED_ARGS
            = new PropertyChangedEventArgs(nameof(LocalizedValue));

        
        private readonly string key;
        private readonly IDisposable subscriptionToken;
        private object localizedValue;

        public LocalizedDataSource(string key)
        {
            
            this.key = key;

            LocalizedValue = key;
        }

        ~LocalizedDataSource()
        {
            Dispose(false);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public object LocalizedValue
        {
            get => localizedValue;
            set
            {
                localizedValue = value;
                PropertyChanged?.Invoke(this, LOCALIZED_VALUE_CHANGED_ARGS);
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                subscriptionToken?.Dispose();
            }
        }
    }

    /// <summary>
    /// Used by <see cref="TranslateExtension"/> to format localized strings.
    /// Accepts localized format string as first argument and other objects as format arguments.
    /// </summary>
    internal class FormattedTranslationTextConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values == null || values.Length == 0)
                return DependencyProperty.UnsetValue;

            var formatString = values[0].ToString();
            //return localizationManager.PluralizedFormat(formatString, values.Skip(1).ToArray());
            return string.Format(formatString, values.Skip(1).ToArray());
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new InvalidOperationException();
        }
    }
}
