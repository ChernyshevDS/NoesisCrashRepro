using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EmptyViewModel : MonoBehaviour, INotifyPropertyChanged
{
    [SerializeField]
    private NoesisView noesisView;
    private int intProp;

    public event PropertyChangedEventHandler PropertyChanged;

    public int IntProp { get => intProp; set => SetProperty(ref intProp, value); }

    void Start()
    {
        noesisView.Content.DataContext = this;
        StartCoroutine(IncrementProperty());
    }

    private IEnumerator IncrementProperty()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            IntProp++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
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
