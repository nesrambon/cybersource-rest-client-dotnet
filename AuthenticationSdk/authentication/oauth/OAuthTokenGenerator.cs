// Decompiled with JetBrains decompiler
// Type: AuthenticationSdk.authentication.oauth.OAuthTokenGenerator
// Assembly: AuthenticationSdk, Version=0.0.0.9, Culture=neutral, PublicKeyToken=null
// MVID: B31F8FE4-8578-4DB7-AA70-B490E8CCC72C

using AuthenticationSdk.core;

namespace AuthenticationSdk.authentication.oauth
{
  public class OAuthTokenGenerator : ITokenGenerator
  {
    private readonly MerchantConfig _merchantConfig;
    private readonly OAuthToken _oauthtoken;

    public OAuthTokenGenerator(MerchantConfig merchantConfig)
    {
      this._merchantConfig = merchantConfig;
      this._oauthtoken = new OAuthToken(this._merchantConfig);
    }

    public Token GetToken() => (Token) this._oauthtoken;
  }
}
