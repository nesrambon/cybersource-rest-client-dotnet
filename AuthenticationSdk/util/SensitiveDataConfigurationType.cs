// Decompiled with JetBrains decompiler
// Type: AuthenticationSdk.util.SensitiveDataConfigurationType
// Assembly: AuthenticationSdk, Version=0.0.0.11, Culture=neutral, PublicKeyToken=null
// MVID: E675A5F6-4D13-4E8E-AD27-25529C4D6414

namespace AuthenticationSdk.util
{
  public class SensitiveDataConfigurationType
  {
    public static SensitiveTag[] sensitiveTags = new SensitiveTag[14]
    {
      new SensitiveTag("securityCode", "[0-9]{3,4}", "xxxxx"),
      new SensitiveTag("number", "(\\p{N}+)(\\p{N}{4})", "xxxxx$2"),
      new SensitiveTag("cardNumber", "(\\p{N}+)(\\p{N}{4})", "xxxxx$2"),
      new SensitiveTag("expirationMonth", "[0-1][0-9]", "xxxx"),
      new SensitiveTag("expirationYear", "2[0-9][0-9][0-9]", "xxxx"),
      new SensitiveTag("account", "(\\p{N}+)(\\p{N}{4})", "xxxxx$2"),
      new SensitiveTag("routingNumber", "[0-9]+", "xxxxx"),
      new SensitiveTag("email", "[a-z0-9!#$%&'*+\\/=?^_`{|}~-]+(?:.[a-z0-9!#$%&'*+\\/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?", "xxxxx"),
      new SensitiveTag("firstName", "([a-zA-Z]+( )?[a-zA-Z]*'?-?[a-zA-Z]*( )?([a-zA-Z]*)?)", "xxxxx"),
      new SensitiveTag("lastName", "([a-zA-Z]+( )?[a-zA-Z]*'?-?[a-zA-Z]*( )?([a-zA-Z]*)?)", "xxxxx"),
      new SensitiveTag("phoneNumber", "(\\+[0-9]{1,2} )?\\(?[0-9]{3}\\)?[ .-]?[0-9]{3}[ .-]?[0-9]{4}", "xxxxx"),
      new SensitiveTag("type", "[-A-Za-z0-9 ]+", "xxxxx"),
      new SensitiveTag("token", "[-.A-Za-z0-9 ]+", "xxxxx"),
      new SensitiveTag("signature", "[-.A-Za-z0-9 ]+", "xxxxx")
    };
    public static AuthenticationSchemeTag[] authenticationTags = new AuthenticationSchemeTag[1]
    {
      new AuthenticationSchemeTag("Signature", "(keyid=\\\"([\\w-]*)\\\"),([\\w\\\"\\-\\(\\),= ]*), (signature=\\\"([\\w\\/=\\+]*)\\\")", "Signature : keyid=\"XXXXX\",$3, signature=\"$5\"")
    };
  }
}
