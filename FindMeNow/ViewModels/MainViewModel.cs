using FindMeNow.Repositories;
using FindMeNow.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace FindMeNow.ViewModels
{
    public class MainViewModel : ViewModel
    {
        private readonly ILocationRepository locationRepository;
        private readonly ILocationTrackingService locationTrackingService;
        public MainViewModel(ILocationTrackingService
        locationTrackingService,
        ILocationRepository locationRepository)
        {
            this.locationTrackingService =
            locationTrackingService;
            this.locationRepository = locationRepository;
           
            
           


        }
    }
}
