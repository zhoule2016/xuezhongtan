﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Primitives;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace XZTJY.Site.Apply.Helper.Ioc
{
    public class MefDependencySolver : IDependencyResolver
    {
        private readonly ComposablePartCatalog _catalog;
        private readonly string _httpContextKey = Guid.NewGuid().ToString();

        public MefDependencySolver(ComposablePartCatalog catalog)
        {
            _catalog = catalog;
        }

        public CompositionContainer Container
        {
            get
            {
                if (!HttpContext.Current.Items.Contains(_httpContextKey))
                {
                    HttpContext.Current.Items.Add(_httpContextKey, new CompositionContainer(_catalog));
                }
                CompositionContainer container = (CompositionContainer)HttpContext.Current.Items[_httpContextKey];
                HttpContext.Current.Application["Container"] = container;
                return container;
            }
        }

        #region IDependencyResolver Members

        public object GetService(Type serviceType)
        {
            string contractName = AttributedModelServices.GetContractName(serviceType);
            return Container.GetExportedValueOrDefault<object>(contractName);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return Container.GetExportedValues<object>(serviceType.FullName);
        }

        #endregion
    }

}
