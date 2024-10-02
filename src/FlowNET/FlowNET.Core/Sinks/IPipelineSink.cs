namespace FlowNET.Core;

public interface IPipelineSink
{
    void Write(Object data);
}