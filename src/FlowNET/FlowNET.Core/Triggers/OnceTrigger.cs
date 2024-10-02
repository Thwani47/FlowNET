namespace FlowNET.Core.Triggers;

public class OnceTrigger : IPipelineTrigger
{
    public void Execute(Action<object> onDataReceived)
    {
        onDataReceived(null);
    }
}