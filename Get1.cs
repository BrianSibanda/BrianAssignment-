static string HttpGet(string url) 
{
  HttpWebRequest req = WebRequest.Create(url) as HttpWebRequest;
  string userName = null;
  using (HttpWebResponse resp = req.GetResponse() as HttpWebResponse)
  {
    StreamReader reader = new StreamReader(resp.GetResponseStream());
    userName = reader.ReadToEnd();
  }
  return userName;
}