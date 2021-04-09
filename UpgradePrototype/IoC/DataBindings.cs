using Autofac;
using Data;

namespace UpgradePrototype.IoC
{
    public class DataBindings : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<ModelService>()
                .As<IModelService>();
        }
    }
}