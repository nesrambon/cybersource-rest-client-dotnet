// Decompiled with JetBrains decompiler
// Type: AuthenticationSdk.core.Authorize
// Assembly: AuthenticationSdk, Version=0.0.0.9, Culture=neutral, PublicKeyToken=null
// MVID: B31F8FE4-8578-4DB7-AA70-B490E8CCC72C

using AuthenticationSdk.authentication.http;
using AuthenticationSdk.authentication.jwt;
using AuthenticationSdk.authentication.oauth;
using AuthenticationSdk.util;
using System;

namespace AuthenticationSdk.core
{
  public class Authorize
  {
    private readonly MerchantConfig _merchantConfig;

    public Authorize(MerchantConfig merchantConfig)
    {
      this._merchantConfig = merchantConfig;
      Enumerations.ValidateRequestType(this._merchantConfig.RequestType);
      Enumerations.SetRequestType(this._merchantConfig);
    }

    public HttpToken GetSignature()
    {
      try
      {
        if (this._merchantConfig == null)
          return (HttpToken) null;

        Enumerations.ValidateRequestType(this._merchantConfig.RequestType);
        if (string.IsNullOrEmpty(this._merchantConfig.MerchantId) || string.IsNullOrEmpty(this._merchantConfig.MerchantKeyId) || string.IsNullOrEmpty(this._merchantConfig.MerchantSecretKey))
          throw new Exception("Missing or Empty Credentials : MerchantID or MerchantKeyID or MerchantSecretKey");
        HttpToken token = (HttpToken) new HttpTokenGenerator(this._merchantConfig).GetToken();

        return token;
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    public JwtToken GetToken()
    {
      try
      {
        if (this._merchantConfig == null)
          return (JwtToken) null;

        Enumerations.ValidateRequestType(this._merchantConfig.RequestType);
        if (string.IsNullOrEmpty(this._merchantConfig.MerchantId) || string.IsNullOrEmpty(this._merchantConfig.KeyAlias) || string.IsNullOrEmpty(this._merchantConfig.KeyPass))
          throw new Exception("Missing or Empty Credentials : MerchantID or KeyAlias or KeyPassphrase");
        JwtToken token = (JwtToken) new JwtTokenGenerator(this._merchantConfig).GetToken();
        
        return token;
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    public OAuthToken GetOAuthToken()
    {
      try
      {
        if (this._merchantConfig == null)
          return (OAuthToken) null;
        Enumerations.ValidateRequestType(this._merchantConfig.RequestType);
        if (string.IsNullOrEmpty(this._merchantConfig.AccessToken) || string.IsNullOrEmpty(this._merchantConfig.RefreshToken))
          throw new Exception("Missing or Empty Credentials : AccessToken or RefreshToken");
        OAuthToken token = (OAuthToken) new OAuthTokenGenerator(this._merchantConfig).GetToken();
        return token;
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
  }
}
