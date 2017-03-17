using MarcelDigital.Umbraco.Amp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core;
using Umbraco.Web.Mvc;

namespace AmpTest
{
    public class Bootstrapper : IApplicationEventHandler
    {
        public void OnApplicationInitialized(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            
        }

        public void OnApplicationStarted(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            
        }

        public void OnApplicationStarting(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            //DefaultRenderMvcControllerResolver.Current.SetDefaultControllerType(typeof(RenderAmpMvcController));
        }
    }
}