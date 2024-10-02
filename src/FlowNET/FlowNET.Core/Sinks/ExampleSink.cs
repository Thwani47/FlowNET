namespace FlowNET.Core;

public class ExampleSink : IPipelineSink
{
    public void Write(object data)
    {
        Console.WriteLine($"Example Sink Received: {data}");
    }
}