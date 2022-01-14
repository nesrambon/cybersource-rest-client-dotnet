// Decompiled with JetBrains decompiler
// Type: AuthenticationSdk.util.SensitiveTag
// Assembly: AuthenticationSdk, Version=0.0.0.11, Culture=neutral, PublicKeyToken=null
// MVID: E675A5F6-4D13-4E8E-AD27-25529C4D6414
namespace AuthenticationSdk.util
{
  public class SensitiveTag
  {
    public string tagName { get; set; }

    public string pattern { get; set; }

    public string replacement { get; set; }

    public bool disableMask { get; set; }

    public SensitiveTag(string tagName, string pattern, string replacement, bool disableMask = false)
    {
      this.tagName = tagName;
      this.pattern = pattern;
      this.replacement = replacement;
      this.disableMask = disableMask;
    }
  }
}
