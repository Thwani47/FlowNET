namespace FlowNET.Core.Sources;

public class ExampleSource : IPipelineSource
{
    public object GetData()
    {
        return "Initial Data";
    }
}