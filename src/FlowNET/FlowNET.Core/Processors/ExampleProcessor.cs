namespace FlowNET.Core.Processors;

public class ExampleProcessor : IPipelineProcessor
{
    public object Process(object data)
    {
        return data.ToString().ToUpper();
    }
}