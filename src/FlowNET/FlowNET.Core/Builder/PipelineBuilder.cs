using FlowNET.Core.Processors;
using FlowNET.Core.Sources;
using FlowNET.Core.Triggers;

namespace FlowNET.Core.Builder;

public class PipelineBuilder
{
    private IPipelineSink _sink;
    private IPipelineSource _source;
    private IPipelineTrigger _trigger;
    private readonly List<IPipelineProcessor> _processors = new();

    public PipelineBuilder AddTrigger(IPipelineTrigger trigger)
    {
        _trigger = trigger;
        return this;
    }

    public PipelineBuilder AddSource(IPipelineSource source)
    {
        _source = source;
        return this;
    }

    public PipelineBuilder AddProcessor(IPipelineProcessor processor)
    {
        _processors.Add(processor);
        return this;
    }

    public PipelineBuilder AddSink(IPipelineSink sink)
    {
        _sink = sink;
        return this;
    }

    public Pipeline Build()
    {
        return new Pipeline(_trigger, _source, _processors, _sink);
    }
}