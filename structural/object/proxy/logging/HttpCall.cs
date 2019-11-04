namespace practicing_design_patterns.structural.@object.proxy.logging
{
  public sealed class HttpCall : IHttpClient
  {
    public void Post(string url, string content)
    {
      // Actual http call happens.
    }
  }
}
