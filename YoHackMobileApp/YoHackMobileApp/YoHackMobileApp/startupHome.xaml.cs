﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace YoHackMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class startupHome : TabbedPage
    {
        public startupHome()
        {
            InitializeComponent();
        }
        async void round(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new StartupRound());
        }
        void OnTextChanged(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
           list = SendToDB.GetInvestors($"SELECT \"{search.Text}\" FROM \"investor\"");
            foreach (string i in list) Console.WriteLine(list);
        }
    }
}
