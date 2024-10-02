using FlowNET.Core.Processors;
using FlowNET.Core.Sources;
using FlowNET.Core.Triggers;

namespace FlowNET.Core;

public class Pipeline
{
    public IPipelineSink Sink { get; set; }
    public IPipelineSource Source { get; set; }
    public IPipelineTrigger Trigger { get; set; }
    public List<IPipelineProcessor> Processors { get; set; } = new List<IPipelineProcessor>();
    
}