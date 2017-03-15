using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismNavi.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }


        #region entry
        private string _entry;
        /// <summary>
        /// entry
        /// </summary>
        public string entry
        {
            get { return this._entry; }
            set { this.SetProperty(ref this._entry, value); }
        }
        #endregion

        public DelegateCommand NextPageCommand { get; set; }

        private readonly INavigationService _navigationService;
        public MainPageViewModel(INavigationService navigationService)
        {

            _navigationService = navigationService;
            NextPageCommand = new DelegateCommand(async() =>
            {
                await _navigationService.NavigateAsync($"NextPage?echo={entry}");
            });
        }

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
