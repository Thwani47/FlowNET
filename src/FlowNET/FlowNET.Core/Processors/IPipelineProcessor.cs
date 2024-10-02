namespace FlowNET.Core.Processors;

public interface IPipelineProcessor
{
    object Process(object data);
}