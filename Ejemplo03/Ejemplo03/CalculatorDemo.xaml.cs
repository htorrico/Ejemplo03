﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejemplo03
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculatorDemo : ContentPage
    {
        public CalculatorDemo()
        {
            InitializeComponent();
        }
    }
}