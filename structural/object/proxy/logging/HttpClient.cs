namespace practicing_design_patterns.structural.@object.proxy.logging
{
  public sealed class HttpClient : IHttpClient
  {
    private readonly HttpCall httpCall = new HttpCall();

    public void Post(string url, string content)
    {
      this.LogRequest();
      this.httpCall.Post(url, content);
    }

    private void LogRequest()
    {
      System.Console.WriteLine("Logging request...");
    }
  }
}
