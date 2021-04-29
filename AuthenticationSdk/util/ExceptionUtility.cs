// Decompiled with JetBrains decompiler
// Type: AuthenticationSdk.util.ExceptionUtility
// Assembly: AuthenticationSdk, Version=0.0.0.9, Culture=neutral, PublicKeyToken=null
// MVID: B31F8FE4-8578-4DB7-AA70-B490E8CCC72C


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
