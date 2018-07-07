using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MasterDetailExample.Views
{
    public partial class MasterDetail : MasterDetailPage
    {
        public MasterDetail()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        public void MenuClick(object sender, EventArgs e){
            
            Button btn = (Button)sender;

            /* Navigation.PushAsync(new NavigationPage(new Contacts())); Was correctly navigating
             * however, we were losing the main menu button.  I assume that is because I must
             * have not hooked up the contacts page to correctly be a child?  
             * 
             * Either way manipulating the current detail setting seems to have worked well.
             */
            switch(btn.CommandParameter.ToString()){
                case "1":
                    this.Detail = new NavigationPage(new MainLanding());
                    this.IsPresented = false;
                    break;
                case "2":
                    this.Detail = new NavigationPage(new Contacts());
                    this.IsPresented = false;
                    break;
                case "3":
                    this.Detail = new NavigationPage(new About());
                    this.IsPresented = false;
                    break;
                default:
                    break;
            }

        }
    }
}
