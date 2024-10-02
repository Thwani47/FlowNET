namespace FlowNET.Core.Triggers;

public interface IPipelineTrigger
{
    void Execute(Action<object> onDataReceived);
}