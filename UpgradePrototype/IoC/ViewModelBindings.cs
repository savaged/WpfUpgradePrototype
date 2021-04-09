using Autofac;
using ViewModels;

namespace UpgradePrototype.IoC
{
    public class ViewModelBindings : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<MainWindowViewModel>()
                .As<IMainWindowViewModel>();
        }
    }
}