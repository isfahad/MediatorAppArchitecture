using Autofac;
using MediatR;
using StandardAppDesign.Core.Domain.Posts;
using StandardAppDesign.Core.Interfaces.Services;
using StandardAppDesign.Infrastructure.Services;
using StandardAppDesign.Interactor.ViewModels;
using StandardAppDesign.Services;
using StandardAppDesign.Views.Posts;
using System.Reflection;
using Xamarin.Forms;

namespace StandardAppDesign
{
    public partial class App : Application
    {
        public static IContainer Container { get; set; }

        public App()
        {
            InitializeComponent();
            RegisterDependency();
            MainPage = Container.Resolve<PostsPage>();
        }

        private void RegisterDependency()
        {
            var builder = new ContainerBuilder();

            #region Mediator_Config

            builder
                .RegisterType<Mediator>()
                .As<IMediator>()
                .InstancePerLifetimeScope();
            builder.Register<ServiceFactory>(context =>
            {
                var c = context.Resolve<IComponentContext>();
                return t => c.Resolve(t);
            });

            builder.RegisterAssemblyTypes(typeof(AddPostHandler).GetTypeInfo().Assembly).AsImplementedInterfaces();

            #endregion Mediator_Config

            builder.RegisterType<DialogService>().As<IDialogService>().InstancePerDependency();
            //builder.RegisterType<NavigationService>().As<INavigationService>();
            builder.RegisterType<HttpApiService>().As<IHttpApiService>();
            builder.RegisterType<PostViewModel>();
            builder.RegisterType<PostsPage>();
            Container = builder.Build();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}