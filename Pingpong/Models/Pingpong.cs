namespace Pingpong
{
  public class Pingpong
  {

    public static string PingpongCheck(int number)
    {
      if (number % 3 == 0 && number % 5 != 0)
      {
        return "ping";
      }else
      if (number % 5 == 0 && number % 3 != 0)
      {
        return "pong";
      }
      else if (number % 3 == 0 && number % 5 == 0)
      {
        return "pingpong";
      }
      else
      {
        return number.ToString();
      }
    }
  }
}
