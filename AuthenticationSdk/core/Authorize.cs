// Decompiled with JetBrains decompiler
// Type: AuthenticationSdk.core.Authorize
// Assembly: AuthenticationSdk, Version=0.0.0.8, Culture=neutral, PublicKeyToken=null
// MVID: 7CF009B5-7313-471B-83F8-D22556D92815


using AuthenticationSdk.authentication.http;
using AuthenticationSdk.authentication.jwt;
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
        HttpToken token = (HttpToken) new HttpTokenGenerator(this._merchantConfig).GetToken();

        return token;
      }
      catch (Exception ex)
      {
        ExceptionUtility.Exception(ex.Message, ex.StackTrace);
        return (HttpToken) null;
      }
    }

    public JwtToken GetToken()
    {
      try
      {
        if (this._merchantConfig == null)
          return (JwtToken) null;

        Enumerations.ValidateRequestType(this._merchantConfig.RequestType);
        JwtToken token = (JwtToken) new JwtTokenGenerator(this._merchantConfig).GetToken();
        
        return token;
      }
      catch (Exception ex)
      {
        ExceptionUtility.Exception(ex.Message, ex.StackTrace);
        return (JwtToken) null;
      }
    }

  }
}
