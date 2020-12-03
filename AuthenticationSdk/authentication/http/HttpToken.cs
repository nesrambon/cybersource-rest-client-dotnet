﻿// Decompiled with JetBrains decompiler
// Type: AuthenticationSdk.authentication.http.HttpToken
// Assembly: AuthenticationSdk, Version=0.0.0.8, Culture=neutral, PublicKeyToken=null
// MVID: 7CF009B5-7313-471B-83F8-D22556D92815


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
      bool result;
      bool.TryParse(merchantConfig.UseMetaKey, out result);
      this.UseMetaKey = result;
      if (!this.UseMetaKey)
        return;
      this.PortfolioId = merchantConfig.PortfolioId;
    }

    public string SignatureAlgorithm { get; set; }

    public string GmtDateTime { get; set; }

    public string MerchantId { get; set; }

    public string PortfolioId { get; set; }

    public bool UseMetaKey { get; set; }

    public string MerchantSecretKey { get; set; }

    public string RequestJsonData { get; }

    public string HostName { get; }

    public string HttpSignRequestTarget { get; set; }

    public string MerchantKeyId { get; set; }

    public string Digest { get; set; }

    public string SignatureParam { get; set; }
  }
}
