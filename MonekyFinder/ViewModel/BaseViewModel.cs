using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MonkeyFinder.ViewModel;

[INotifyPropertyChanged]
public partial class BaseViewModel : ObservableObject
{
    public BaseViewModel()
    {
        
    }
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsNotBusy))]
    bool isBusy;
    [ObservableProperty]
    string title;

    public bool IsNotBusy => !IsBusy;
    

    
    

   
}
