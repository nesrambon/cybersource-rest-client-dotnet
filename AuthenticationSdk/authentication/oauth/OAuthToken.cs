// Decompiled with JetBrains decompiler
// Type: AuthenticationSdk.authentication.oauth.OAuthToken
// Assembly: AuthenticationSdk, Version=0.0.0.9, Culture=neutral, PublicKeyToken=null
// MVID: B31F8FE4-8578-4DB7-AA70-B490E8CCC72C

using AuthenticationSdk.core;

namespace AuthenticationSdk.authentication.oauth
{
  public class OAuthToken : Token
  {
    public OAuthToken(MerchantConfig merchantConfig)
    {
      this.AccessToken = merchantConfig.AccessToken;
      this.RefreshToken = merchantConfig.RefreshToken;
    }

    public string AccessToken { get; set; }

    public string RefreshToken { get; set; }
  }
}
