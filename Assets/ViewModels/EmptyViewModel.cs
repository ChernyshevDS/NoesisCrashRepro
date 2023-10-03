using MarkupExtensions;
using Noesis;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using UnityEngine;

namespace ViewModels
{
    public class EmptyViewModel : MonoBehaviour, INotifyPropertyChanged
    {
        [SerializeField]
        private NoesisView noesisView;
        private Coroutine coroutine;

        private int intProp;
        private ICommand updCommand;
        private object childVM;

        public event PropertyChangedEventHandler PropertyChanged;

        public int IntProp { get => intProp; set => SetProperty(ref intProp, value); }

        public object ChildVM { get => childVM; set => SetProperty(ref childVM, value); }

        public ICommand UpdCommand { get => updCommand; set => SetProperty(ref updCommand, value); }

        void Start()
        {
            noesisView.Content.DataContext = this;
            UpdCommand = new DelegateCommand(HandleCommand);
        }

        private void HandleCommand()
        {
            if (coroutine == null)
            { 
                coroutine = StartCoroutine(IncrementProperty());
            }
            else
            {
                StopCoroutine(coroutine);
                coroutine = null;
            }
        }

        private IEnumerator IncrementProperty()
        {
            while (true)
            {
                yield return new WaitForSeconds(0.1f);
                IntProp++;

                var dummyBinding = new Binding() { Source = null };
                var localizedBinding = new Binding(nameof(LocalizedDataSource.LocalizedValue))
                {
                    Source = new LocalizedDataSource("Key"),
                };
                var multiBinding = new MultiBinding();
                multiBinding.Mode = BindingMode.OneWay;
                multiBinding.Converter = new FormattedTranslationTextConverter();

                multiBinding.Bindings.Add(localizedBinding);
                multiBinding.Bindings.Add(dummyBinding);
            }
        }

        protected virtual bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(storage, value))
            {
                return false;
            }

            storage = value;
            RaisePropertyChanged(propertyName);
            return true;
        }

        private void RaisePropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(storage, value))
            {
                return false;
            }

            storage = value;
            RaisePropertyChanged(propertyName);
            return true;
        }

        private void RaisePropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public class FirstVM : ViewModelBase
    {
        private string localizationKey;
        private int value;

        public string LocalizationKey { get => localizationKey; set => SetProperty(ref localizationKey, value); }

        public int Value { get => value; set => SetProperty(ref this.value, value); }
    }

    public class SecondVM : ViewModelBase
    {
        private int value;

        public int Value { get => value; set => SetProperty(ref this.value, value); }
    }


    public class InnerVM : ViewModelBase
    {
        private object inner;

        public object Inner { get => inner; set => SetProperty(ref inner, value); }
    }
}
