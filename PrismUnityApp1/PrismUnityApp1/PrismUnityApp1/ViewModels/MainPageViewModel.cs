using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismUnityApp1.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }


        #region entryText
        private string _entryText;
        /// <summary>
        /// entryText
        /// </summary>
        public string entryText
        {
            get { return this._entryText; }
            set { this.SetProperty(ref this._entryText, value); }
        }
        #endregion

        #region labelText
        private string _labelText;
        /// <summary>
        /// labelText
        /// </summary>
        public string labelText
        {
            get { return this._labelText; }
            set { this.SetProperty(ref this._labelText, value); }
        }
        #endregion

        public DelegateCommand OKCommand { get; set; }

        public MainPageViewModel()
        {
            OKCommand = new DelegateCommand(() =>
            {
                labelText = entryText;
            });

            //OKCommand = new DelegateCommand(fooDele);
        }

        //private void fooDele()
        //{
        //    throw new NotImplementedException();
        //}

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
                Title = (string)parameters["title"] + " and Prism";
        }
    }
}
