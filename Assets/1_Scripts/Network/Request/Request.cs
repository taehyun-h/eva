using System;

public abstract class Request
{
    public abstract string Url { get; }

    private Action _onCompleteAction;
    private Action _onFailAction;

    public void SetOnCompleteAction(Action onCompleteAction)
    {
        _onCompleteAction = onCompleteAction;
    }

    public void SetOnFailAction(Action onFailAction)
    {
        _onFailAction = onFailAction;
    }

    public virtual void Complete(string content)
    {
        _onCompleteAction?.Invoke();
    }

    public virtual void Fail()
    {
        _onFailAction.Invoke();
    }
}
