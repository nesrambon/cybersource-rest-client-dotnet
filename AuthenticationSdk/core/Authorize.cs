// Decompiled with JetBrains decompiler
// Type: AuthenticationSdk.core.Authorize
// Assembly: AuthenticationSdk, Version=0.0.0.7, Culture=neutral, PublicKeyToken=null
// MVID: 51F37287-3D9C-4D24-9C5B-42A967D1065C


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
