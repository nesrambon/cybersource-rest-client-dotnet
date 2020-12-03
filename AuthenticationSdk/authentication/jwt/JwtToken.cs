// Decompiled with JetBrains decompiler
// Type: AuthenticationSdk.authentication.jwt.JwtToken
// Assembly: AuthenticationSdk, Version=0.0.0.8, Culture=neutral, PublicKeyToken=null
// MVID: 7CF009B5-7313-471B-83F8-D22556D92815


using AuthenticationSdk.core;
using AuthenticationSdk.util;
using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace AuthenticationSdk.authentication.jwt
{
  public class JwtToken : Token
  {
    public JwtToken(MerchantConfig merchantConfig)
    {
      this.RequestJsonData = merchantConfig.RequestJsonData;
      this.HostName = merchantConfig.HostName;
      this.P12FilePath = merchantConfig.P12Keyfilepath;
      if (!File.Exists(this.P12FilePath))
        throw new Exception(Constants.ErrorPrefix + " File not found at the given path: " + Path.GetFullPath(this.P12FilePath));
      this.KeyAlias = merchantConfig.KeyAlias;
      this.KeyPass = merchantConfig.KeyPass;
      this.Certificate = Cache.FetchCachedCertificate(this.P12FilePath, this.KeyPass);
    }

    public string BearerToken { get; set; }

    public string RequestJsonData { get; set; }

    public string HostName { get; set; }

    public string P12FilePath { get; set; }

    public string KeyAlias { get; set; }

    public string KeyPass { get; }

    public X509Certificate2 Certificate { get; }
  }
}
