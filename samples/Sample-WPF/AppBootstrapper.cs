﻿using System.ComponentModel;
using System.Reflection;
using System.Windows;
using Autofac;
using Caliburn.Micro.Autofac;

namespace Sample_WPF
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Caliburn.Micro;

    public class AppBootstrapper : AutofacBootstrapper<ShellViewModel>
    {
        public AppBootstrapper()
        {
            Initialize();
        }

        protected override void ConfigureContainer(ContainerBuilder builder)
        {
            
        }

        protected override void ConfigureBootstrapper()
        {
            base.ConfigureBootstrapper();
            EnforceNamespaceConvention = false;
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}
