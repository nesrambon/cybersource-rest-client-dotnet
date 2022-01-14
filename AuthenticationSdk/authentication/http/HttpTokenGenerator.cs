// Decompiled with JetBrains decompiler
// Type: AuthenticationSdk.authentication.http.HttpTokenGenerator
// Assembly: AuthenticationSdk, Version=0.0.0.11, Culture=neutral, PublicKeyToken=null
// MVID: E675A5F6-4D13-4E8E-AD27-25529C4D6414

using AuthenticationSdk.core;
using System;
using System.Security.Cryptography;
using System.Text;

namespace AuthenticationSdk.authentication.http
{
  public class HttpTokenGenerator : ITokenGenerator
  {
    private readonly MerchantConfig _merchantConfig;
    private readonly HttpToken _httpToken;

    public HttpTokenGenerator(MerchantConfig merchantConfig)
    {
      this._merchantConfig = merchantConfig;
      this._httpToken = new HttpToken(this._merchantConfig);
    }

    public Token GetToken()
    {
      this._httpToken.SignatureParam = this.SetSignatureParam();
      return (Token) this._httpToken;
    }

    private string SetSignatureParam()
    {
      string str = string.Empty;
      if (this._merchantConfig.IsGetRequest || this._merchantConfig.IsDeleteRequest)
        str = this.SignatureForCategory1();
      else if (this._merchantConfig.IsPostRequest || this._merchantConfig.IsPutRequest || this._merchantConfig.IsPatchRequest)
        str = this.SignatureForCategory2();
      return str;
    }

    private string SignatureForCategory1()
    {
      StringBuilder stringBuilder1 = new StringBuilder();
      StringBuilder stringBuilder2 = new StringBuilder();
      stringBuilder1.Append("\nhost: " + this._httpToken.HostName).Append("\ndate: " + this._httpToken.GmtDateTime).Append("\n(request-target): " + this._httpToken.HttpSignRequestTarget).Append("\nv-c-merchant-id: ");
      if (this._httpToken.UseMetaKey)
        stringBuilder1.Append(this._httpToken.PortfolioId);
      else
        stringBuilder1.Append(this._httpToken.MerchantId);
      stringBuilder1.Remove(0, 1);
      byte[] bytes = Encoding.UTF8.GetBytes(stringBuilder1.ToString());
      string base64String = Convert.ToBase64String(new HMACSHA256(Convert.FromBase64String(this._httpToken.MerchantSecretKey)).ComputeHash(bytes));
      stringBuilder2.Append("keyid=\"" + this._httpToken.MerchantKeyId + "\"").Append(", algorithm=\"" + this._httpToken.SignatureAlgorithm + "\"").Append(", headers=\"host date (request-target) v-c-merchant-id\"").Append(", signature=\"" + base64String + "\"");
      return stringBuilder2.ToString();
    }

    private string SignatureForCategory2()
    {
      StringBuilder stringBuilder1 = new StringBuilder();
      StringBuilder stringBuilder2 = new StringBuilder();
      this._httpToken.Digest = this.GenerateDigest();
      stringBuilder1.Append("\nhost: " + this._httpToken.HostName).Append("\ndate: " + this._httpToken.GmtDateTime).Append("\n(request-target): " + this._httpToken.HttpSignRequestTarget).Append("\ndigest: " + this._httpToken.Digest).Append("\nv-c-merchant-id: ");
      if (this._httpToken.UseMetaKey)
        stringBuilder1.Append(this._httpToken.PortfolioId);
      else
        stringBuilder1.Append(this._httpToken.MerchantId);
      stringBuilder1.Remove(0, 1);
      byte[] bytes = Encoding.UTF8.GetBytes(stringBuilder1.ToString());
      string base64String = Convert.ToBase64String(new HMACSHA256(Convert.FromBase64String(this._httpToken.MerchantSecretKey)).ComputeHash(bytes));
      stringBuilder2.Append("keyid=\"" + this._httpToken.MerchantKeyId + "\"").Append(", algorithm=\"" + this._httpToken.SignatureAlgorithm + "\"").Append(", headers=\"host date (request-target) digest v-c-merchant-id\"").Append(", signature=\"" + base64String + "\"");
      return stringBuilder2.ToString();
    }

    private string GenerateDigest()
    {
      using (SHA256 shA256 = SHA256.Create())
        return "SHA-256=" + Convert.ToBase64String(shA256.ComputeHash(Encoding.UTF8.GetBytes(this._httpToken.RequestJsonData)));
    }
  }
}
