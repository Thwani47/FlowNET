using FlowNET.Core.Processors;
using FlowNET.Core.Sources;
using FlowNET.Core.Triggers;

namespace FlowNET.Core.Builder;

public class PipelineBuilder
{
    private readonly Pipeline _pipeline = new Pipeline();
    public PipelineBuilder AddTrigger(IPipelineTrigger trigger)
    {
        _pipeline.Trigger = trigger;
        return this;
    }

    public PipelineBuilder AddSource(IPipelineSource source)
    {
        _pipeline.Source = source;
        return this;
    }
    
    public PipelineBuilder AddProcessor(IPipelineProcessor processor)
    {
        _pipeline.Processors.Add(processor);
        return this;
    }

    public PipelineBuilder AddSink(IPipelineSink sink)
    {
        _pipeline.Sink = sink;
        return this;
    }
    
    public Pipeline Build()
    {
        return new Pipeline();
    }
}