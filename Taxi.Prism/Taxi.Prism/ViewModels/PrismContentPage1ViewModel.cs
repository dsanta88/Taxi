﻿using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Taxi.Prism.ViewModels
{
    public class PrismContentPage1ViewModel : ViewModelBase
    {
        public PrismContentPage1ViewModel(INavigationService navigationService)
         : base(navigationService)
        {

        }
    }
}
