﻿using Microsoft.Practices.Unity;
using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace Sleemon.Portal.Factories
{
    public class UnityControllerFactory : DefaultControllerFactory
    {
        private readonly UnityContainer Container;

        [InjectionConstructor]
        public UnityControllerFactory([Dependency]UnityContainer container)
            : this()
        {
            this.Container = container;
        }

        public UnityControllerFactory()
        {
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            if (controllerType != null)
            {
                return this.Container.Resolve(controllerType) as IController;
            }

            return base.GetControllerInstance(requestContext, null);
        }
    }
}
