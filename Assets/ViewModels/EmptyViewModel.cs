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

        private ICommand crashBindingCommand;

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand CrashBindingCommand { get => crashBindingCommand; set => SetProperty(ref crashBindingCommand, value); }

        void Start()
        {
            noesisView.Content.DataContext = this;
            CrashBindingCommand = new DelegateCommand(HandleCommand);
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

                var dummyBinding = new Binding() { Source = null };
                var multiBinding = new MultiBinding();
                multiBinding.Mode = BindingMode.OneWay;
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
}
