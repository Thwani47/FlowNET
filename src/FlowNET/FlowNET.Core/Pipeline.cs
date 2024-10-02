using FlowNET.Core.Processors;
using FlowNET.Core.Sources;
using FlowNET.Core.Triggers;

namespace FlowNET.Core;

public class Pipeline
{
    private readonly IPipelineSink _sink;
    private readonly IPipelineSource _source;
    private readonly IPipelineTrigger _trigger;
    private readonly List<IPipelineProcessor> _processors;

    public Pipeline(IPipelineTrigger trigger, IPipelineSource source, List<IPipelineProcessor> processors,
        IPipelineSink sink)
    {
        _sink = sink;
        _source = source;
        _trigger = trigger;
        _processors = processors;
    }


    public void Start()
    {
        _trigger.Execute(data =>
        {
            var sourceData = _source.GetData();
            foreach (var processor in _processors)
            {
                sourceData = processor.Process(sourceData);
            }

            _sink.Write(sourceData);
        });
    }
}