using Model;
using System;
using System.Collections.Generic;
using System.Text;

[QueryProperty("Monkey","Monkey")]

namespace MonkeyFinder.ViewModel;
public partial class MonkeyDetailsViewModel : BaseViewModel
{
    public MonkeyDetailsViewModel()
    {
        this.monkey;
    }
    [ObservableObject]
    Monkey monkey;

}

