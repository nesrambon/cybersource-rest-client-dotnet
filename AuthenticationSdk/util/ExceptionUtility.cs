// Decompiled with JetBrains decompiler
// Type: AuthenticationSdk.util.ExceptionUtility
// Assembly: AuthenticationSdk, Version=0.0.0.7, Culture=neutral, PublicKeyToken=null
// MVID: 51F37287-3D9C-4D24-9C5B-42A967D1065C


namespace AuthenticationSdk.util
{
  public class ExceptionUtility
  {
    private static bool _exceptionIsCaughtAlready;

    public static void Exception(string exceptionMessage, string stackTrace)
    {
      if (ExceptionUtility._exceptionIsCaughtAlready)
        return;

      ExceptionUtility._exceptionIsCaughtAlready = true;
    }
  }
}
