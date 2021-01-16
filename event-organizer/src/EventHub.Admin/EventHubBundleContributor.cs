﻿using Volo.Abp.Bundling;

namespace EventHub.Admin
{
    public class EventHubBundleContributor : IBundleContributor
    {
        public void AddScripts(BundleContext context)
        {
        }

        public void AddStyles(BundleContext context)
        {
            context.Add("main.css", true);
        }
    }
}