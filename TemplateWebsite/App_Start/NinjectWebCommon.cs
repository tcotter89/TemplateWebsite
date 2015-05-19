[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(TemplateWebsite.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(TemplateWebsite.App_Start.NinjectWebCommon), "Stop")]

namespace TemplateWebsite.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using TemplateWebsite.ServiceLayer.Services;
    using TemplateWebsite.RepositoryLayer.Repository;
    using TemplateWebsite.Shared.Services;
    using TemplateWebsite.Shared.Repository;

    public static class NinjectWebCommon 
    {
        public static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel) {
            //Repositories
            kernel.Bind<IUpdatesRepository>().To<UpdatesRepository>();
            kernel.Bind<IMediaRepository>().To<MediaRepository>();
            kernel.Bind<IForumsForumRepository>().To<ForumsForumRepository>();
            kernel.Bind<IForumsTopicRepository>().To<ForumsTopicRepository>();
            kernel.Bind<IForumsPostRepository>().To<ForumsPostRepository>();
            //Services
            kernel.Bind<IUpdatesService>().To<UpdatesService>();
            kernel.Bind<IMediaService>().To<MediaService>();
            kernel.Bind<IForumsForumService>().To<ForumsForumService>();
            kernel.Bind<IForumsTopicService>().To<ForumsTopicService>();
            kernel.Bind<IForumsPostService>().To<ForumsPostService>();
        }        
    }
}
