public abstract class Request
{
    public Request Send<TResponse>()
        where TResponse : Response
    {
        var response = GetResponse<TResponse>();
        if (response == null)
        {
            D.Error($"{GetType().Name} failed.");
        }
        else
        {
            ResponseUpdater.Instance.OnUpdate(response);
        }

        return this;
    }

    protected abstract TResponse GetResponse<TResponse>()
        where TResponse : Response;
}
