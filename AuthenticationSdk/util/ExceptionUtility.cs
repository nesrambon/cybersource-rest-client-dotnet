// Decompiled with JetBrains decompiler
// Type: AuthenticationSdk.util.ExceptionUtility
// Assembly: AuthenticationSdk, Version=0.0.0.8, Culture=neutral, PublicKeyToken=null
// MVID: 7CF009B5-7313-471B-83F8-D22556D92815



namespace AuthenticationSdk.util
{
  public static class ExceptionUtility
  {
    private static bool _exceptionIsCaughtAlready;

    public static void Exception(string exceptionMessage, string stackTrace)
    {
      if (_exceptionIsCaughtAlready)
        return;

      _exceptionIsCaughtAlready = true;
    }
  }
}
