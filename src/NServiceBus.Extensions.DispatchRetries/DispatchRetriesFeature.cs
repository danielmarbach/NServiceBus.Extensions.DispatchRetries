﻿using NServiceBus.Features;

namespace NServiceBus.Extensions.DispatchRetries
{
    public class DispatchRetriesFeature : Feature
    {
        protected override void Setup(FeatureConfigurationContext context)
        {
            context.Pipeline.Register(new ImmediateDispatchRetriesBehavior(context.Settings), "Immediate dispatch retries behavior based on Polly.");
            context.Pipeline.Register(new BatchDispatchRetriesBehavior(context.Settings), "Batch dispatch retries behavior based on Polly.");
        }
    }
}