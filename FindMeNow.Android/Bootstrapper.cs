using Autofac;
using FindMeNow.Droid.Services;
using FindMeNow.Services;

namespace FindMeNow.Droid
{
    public class Bootstrapper : FindMeNow.Bootstrapper
    {
        public static void Init()
        {
            var instance = new Bootstrapper();
        }
        protected override void Initialize()
        {
            base.Initialize();
            ContainerBuilder.RegisterType<LocationTrackingService>().As<ILocationTrackingService>().SingleInstance();
        }
    }
}