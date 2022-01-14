// Decompiled with JetBrains decompiler
// Type: AuthenticationSdk.util.LogUtility
// Assembly: AuthenticationSdk, Version=0.0.0.11, Culture=neutral, PublicKeyToken=null
// MVID: E675A5F6-4D13-4E8E-AD27-25529C4D6414

using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AuthenticationSdk.util
{
  public static class LogUtility
  {
    private static Dictionary<string, string> sensitiveTags = new Dictionary<string, string>();
    private static Dictionary<string, string> authenticationTags = new Dictionary<string, string>();

    private static void LoadSensitiveDataConfiguration()
    {
      LogUtility.sensitiveTags.Clear();
      LogUtility.authenticationTags.Clear();
      int length1 = SensitiveDataConfigurationType.sensitiveTags.Length;
      for (int index = 0; index < length1; ++index)
      {
        string tagName = SensitiveDataConfigurationType.sensitiveTags[index].tagName;
        string pattern = SensitiveDataConfigurationType.sensitiveTags[index].pattern;
        string replacement = SensitiveDataConfigurationType.sensitiveTags[index].replacement;
        string key;
        if (!string.IsNullOrEmpty(pattern))
          key = "\\\"" + tagName + "\\\":\\\"" + pattern + "\\\"";
        else
          key = "\\\"" + tagName + "\\\":\\\".+\\\"";
        string str = "\"" + tagName + "\":\"" + replacement + "\"";
        LogUtility.sensitiveTags.Add(key, str);
      }
      int length2 = SensitiveDataConfigurationType.authenticationTags.Length;
      for (int index = 0; index < length2; ++index)
      {
        string tagName = SensitiveDataConfigurationType.authenticationTags[index].tagName;
        string key = SensitiveDataConfigurationType.authenticationTags[index].pattern;
        string replacement = SensitiveDataConfigurationType.authenticationTags[index].replacement;
        if (!string.IsNullOrEmpty(key))
          key = tagName + " : " + key;
        string str = replacement ?? "";
        LogUtility.authenticationTags.Add(key, str);
      }
    }

    public static string MaskSensitiveData(string str)
    {
      LogUtility.LoadSensitiveDataConfiguration();
      foreach (KeyValuePair<string, string> sensitiveTag in LogUtility.sensitiveTags)
        str = Regex.Replace(str, sensitiveTag.Key, sensitiveTag.Value);
      foreach (KeyValuePair<string, string> authenticationTag in LogUtility.authenticationTags)
        str = Regex.Replace(str, authenticationTag.Key, authenticationTag.Value);
      return str;
    }

    public static string ConvertDictionaryToString(Dictionary<string, string> dict)
    {
      StringBuilder stringBuilder = new StringBuilder();
      foreach (KeyValuePair<string, string> keyValuePair in dict)
        stringBuilder.Append(keyValuePair.Key + " = " + keyValuePair.Value + "\n");
      return stringBuilder.ToString();
    }
  }
}
