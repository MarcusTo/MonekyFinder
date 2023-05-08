using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MonkeyFinder.ViewModel;
public class BaseViewModel : INotifyPropertyChanged
{
    bool isBusy;
    string title;

    public bool IsBusy
    {
        get => isBusy;
        set
        {
            if (isBusy == value)
                return;

            isBusy = value;
            OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public void OnPropertyChanged([CallerMemberName] string name = null)
    {
        PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
