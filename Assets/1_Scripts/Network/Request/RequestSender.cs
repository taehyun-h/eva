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

    public Request TestWordIKnow()
    {
        var request = new TestWordIKnowRequest();
        return request.Send<TestWordIKnowResponse>();
    }

    public Request TestWordIDontKnow()
    {
        var request = new TestWordIDontKnowRequest();
        return request.Send<TestWordIDontKnowResponse>();
    }
}
