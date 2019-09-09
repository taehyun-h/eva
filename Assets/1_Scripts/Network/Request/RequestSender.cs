public class RequestSender : Singleton<RequestSender>
{
    public Request SignIn()
    {
        var request = new SignInRequest();
        return request.Send<SignInResponse>();
    }

    public Request StudyWord()
    {
        var request = new StudyWorkRequest();
        return request.Send<StudyWordResponse>();
    }
}
