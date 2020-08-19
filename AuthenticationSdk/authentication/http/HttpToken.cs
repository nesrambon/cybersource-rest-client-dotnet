// Decompiled with JetBrains decompiler
// Type: AuthenticationSdk.authentication.http.HttpToken
// Assembly: AuthenticationSdk, Version=0.0.0.7, Culture=neutral, PublicKeyToken=null
// MVID: 51F37287-3D9C-4D24-9C5B-42A967D1065C


using AuthenticationSdk.core;
using AuthenticationSdk.util;
using System;

namespace AuthenticationSdk.authentication.http
{
  public class HttpToken : Token
  {
    public HttpToken(MerchantConfig merchantConfig)
    {
      this.SignatureAlgorithm = Constants.SignatureAlgorithm;
      DateTime dateTime = DateTime.Now;
      dateTime = dateTime.ToUniversalTime();
      this.GmtDateTime = dateTime.ToString("r");
      this.RequestJsonData = merchantConfig.RequestJsonData;
      this.HostName = merchantConfig.HostName;
      this.MerchantId = merchantConfig.MerchantId;
      this.MerchantSecretKey = merchantConfig.MerchantSecretKey;
      this.MerchantKeyId = merchantConfig.MerchantKeyId;
      this.HttpSignRequestTarget = merchantConfig.RequestType.ToLower() + " " + merchantConfig.RequestTarget;
    }

    public string SignatureAlgorithm { get; set; }

    public string GmtDateTime { get; set; }

    public string MerchantId { get; set; }

    public string MerchantSecretKey { get; set; }

    public string RequestJsonData { get; }

    public string HostName { get; }

    public string HttpSignRequestTarget { get; set; }

    public string MerchantKeyId { get; set; }

    public string Digest { get; set; }

    public string SignatureParam { get; set; }
  }
}
