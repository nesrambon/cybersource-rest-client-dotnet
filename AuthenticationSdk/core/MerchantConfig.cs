// Decompiled with JetBrains decompiler
// Type: AuthenticationSdk.core.MerchantConfig
// Assembly: AuthenticationSdk, Version=0.0.0.8, Culture=neutral, PublicKeyToken=null
// MVID: 7CF009B5-7313-471B-83F8-D22556D92815

using AuthenticationSdk.util;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Reflection;

namespace AuthenticationSdk.core
{
  public class MerchantConfig
  {
    public MerchantConfig(
      IReadOnlyDictionary<string, string> merchantConfigDictionary = null)
    {
      string empty = string.Empty;

      if (merchantConfigDictionary != null)
      {
        this.SetValuesUsingDictObj(merchantConfigDictionary);
      }
      else
      {
        NameValueCollection section = (NameValueCollection)ConfigurationManager.GetSection(nameof(MerchantConfig));
        if (section != null)
        {
          this.SetValuesFromAppConfig(section);
        }
        else
        {
          throw new Exception(Constants.ErrorPrefix + " Merchant Configuration Missing in App.Config File");
        }
      }

      this.ValidateProperties();
    }

    public string MerchantId { get; set; }

    public string PortfolioId { get; set; }

    public string MerchantSecretKey { get; set; }

    public string MerchantKeyId { get; set; }

    public string UseMetaKey { get; set; }

    public string EnableClientCert { get; set; }

    public string ClientCertDirectory { get; set; }

    public string ClientCertFile { get; set; }

    public string ClientCertPassword { get; set; }

    public string ClientId { get; set; }

    public string AccessToken { get; set; }

    public string RefreshToken { get; set; }

    public string ClientSecret { get; set; }

    public string AuthenticationType { get; set; }

    public string KeyDirectory { get; set; }

    public string KeyfileName { get; set; }

    public string RunEnvironment { get; set; }

    public string KeyAlias { get; set; }

    public string KeyPass { get; set; }

    public string EnableLog { get; set; } = "TRUE";

    public string LogDirectory { get; set; } = "../../logs";

    public string LogfileMaxSize { get; set; } = "10485760";

    public string LogFileName { get; set; } = "cybs.log";

    public string TimeOut { get; set; }

    public string UseProxy { get; set; }

    public string ProxyAddress { get; set; }

    public string ProxyPort { get; set; }

    public string ProxyUsername { get; set; }

    public string ProxyPassword { get; set; }

    public string HostName { get; set; }

    public string P12Keyfilepath { get; set; }

    public string RequestTarget { get; set; }

    public string HttpSignRequestTarget { get; set; }

    public string RequestJsonData { get; set; }

    public string RequestType { get; set; }

    public bool IsGetRequest { get; set; }

    public bool IsPostRequest { get; set; }

    public bool IsPutRequest { get; set; }

    public bool IsDeleteRequest { get; set; }

    public bool IsPatchRequest { get; set; }

    public bool IsHttpSignAuthType { get; set; }

    public bool IsJwtTokenAuthType { get; set; }

    public bool IsOAuthTokenAuthType { get; set; }

    public void LogMerchantConfigurationProperties()
    {
      string[] array = ((IEnumerable<string>)Constants.HideMerchantConfigProps.Split(',')).Select<string, string>((Func<string, string>)(property => property.Trim())).Where<string>((Func<string, bool>)(property => property != null && property != "")).ToArray<string>();
      string str = string.Empty;
      foreach (PropertyInfo property in typeof(MerchantConfig).GetProperties())
      {
        if (!((IEnumerable<string>)array).Any<string>(new Func<string, bool>(property.Name.Contains)))
        {
          object obj = property.GetValue((object)this);
          if (obj != null && !string.IsNullOrEmpty(obj.ToString()) && !property.Name.StartsWith("Is", StringComparison.OrdinalIgnoreCase))
            str = str + property.Name + " = " + obj + "\n";
        }
      }
    }

    private void SetValuesFromAppConfig(NameValueCollection merchantConfigSection)
    {
      this.MerchantId = merchantConfigSection["merchantID"];
      this.PortfolioId = merchantConfigSection["portfolioID"];
      this.MerchantSecretKey = merchantConfigSection["merchantsecretKey"];
      this.MerchantKeyId = merchantConfigSection["merchantKeyId"];
      this.UseMetaKey = merchantConfigSection["useMetaKey"];
      this.AuthenticationType = merchantConfigSection["authenticationType"];
      this.KeyDirectory = merchantConfigSection["keysDirectory"];
      this.KeyfileName = merchantConfigSection["keyFilename"];
      this.RunEnvironment = merchantConfigSection["runEnvironment"];
      this.EnableClientCert = merchantConfigSection["enableClientCert"];
      this.ClientCertDirectory = merchantConfigSection["clientCertDirectory"];
      this.ClientCertFile = merchantConfigSection["clientCertFile"];
      this.ClientCertPassword = merchantConfigSection["clientCertPassword"];
      this.ClientId = merchantConfigSection["clientId"];
      this.ClientSecret = merchantConfigSection["clientSecret"];
      this.KeyAlias = merchantConfigSection["keyAlias"];
      this.KeyPass = merchantConfigSection["keyPass"];
      this.TimeOut = merchantConfigSection["timeout"];
      this.UseProxy = merchantConfigSection["useProxy"];
      this.ProxyAddress = merchantConfigSection["proxyAddress"];
      this.ProxyPort = merchantConfigSection["proxyPort"];
      this.ProxyUsername = merchantConfigSection["proxyUsername"];
      this.ProxyPassword = merchantConfigSection["proxyPassword"];
    }

    private void SetValuesUsingDictObj(
      IReadOnlyDictionary<string, string> merchantConfigDictionary)
    {
      string empty = string.Empty;
      try
      {
        if (merchantConfigDictionary == null)
          return;
        string key1 = "runEnvironment";
        this.RunEnvironment = merchantConfigDictionary[key1];
        string key2 = "authenticationType";
        this.AuthenticationType = merchantConfigDictionary[key2];
        string key3 = "useMetaKey";
        this.UseMetaKey = "false";
        if (merchantConfigDictionary.ContainsKey(key3))
        {
          this.UseMetaKey = merchantConfigDictionary[key3];
          if (string.IsNullOrEmpty(this.UseMetaKey))
            this.UseMetaKey = "false";
        }
        Enumerations.AuthenticationType result;
        Enum.TryParse<Enumerations.AuthenticationType>(this.AuthenticationType.ToUpper(), out result);
        if (object.Equals((object)result, (object)Enumerations.AuthenticationType.HTTP_SIGNATURE))
        {
          string key4 = "merchantID";
          this.MerchantId = merchantConfigDictionary[key4];
          string key5 = "merchantsecretKey";
          this.MerchantSecretKey = merchantConfigDictionary[key5];
          string key6 = "merchantKeyId";
          this.MerchantKeyId = merchantConfigDictionary[key6];
        }
        if (object.Equals((object)bool.Parse(this.UseMetaKey.ToString()), (object)true))
        {
          string key7 = "portfolioID";
          this.PortfolioId = merchantConfigDictionary[key7];
          if (object.Equals((object)this.PortfolioId, (object)string.Empty))
            throw new KeyNotFoundException("KeyNotFoundException : Key 'portfolioID' not found in configuration. Portfolio ID is mandatory when useMetaKey is true");
        }
        if (object.Equals((object)result, (object)Enumerations.AuthenticationType.JWT))
        {
          string key8 = "merchantID";
          this.MerchantId = merchantConfigDictionary[key8];
          if (merchantConfigDictionary.ContainsKey("keyAlias"))
            this.KeyAlias = merchantConfigDictionary["keyAlias"];
          if (merchantConfigDictionary.ContainsKey("keyFilename"))
            this.KeyfileName = merchantConfigDictionary["keyFilename"];
          if (merchantConfigDictionary.ContainsKey("keyPass"))
            this.KeyPass = merchantConfigDictionary["keyPass"];
          if (merchantConfigDictionary.ContainsKey("keysDirectory"))
            this.KeyDirectory = merchantConfigDictionary["keysDirectory"];
        }
        if (object.Equals((object)result, (object)Enumerations.AuthenticationType.OAUTH))
        {
          this.IsOAuthTokenAuthType = true;
          string key9 = "accessToken";
          this.AccessToken = merchantConfigDictionary.ContainsKey(key9) && !string.IsNullOrEmpty(merchantConfigDictionary[key9]) ? merchantConfigDictionary[key9] : throw new KeyNotFoundException("KeyNotFoundException : Key 'accessToken' not found in configuration. Access Token is mandatory when Authentication Type is set to OAuth");
          string key10 = "refreshToken";
          this.RefreshToken = merchantConfigDictionary.ContainsKey(key10) && !string.IsNullOrEmpty(merchantConfigDictionary[key10]) ? merchantConfigDictionary[key10] : throw new KeyNotFoundException("KeyNotFoundException : Key 'refreshToken' not found in configuration. Refresh Token is mandatory when Authentication Type is set to OAuth");
        }
        if (object.Equals((object)result, (object)Enumerations.AuthenticationType.MUTUAL_AUTH))
        {
          string key11 = "clientId";
          this.ClientId = merchantConfigDictionary.ContainsKey(key11) && !string.IsNullOrEmpty(merchantConfigDictionary[key11]) ? merchantConfigDictionary[key11] : throw new KeyNotFoundException("KeyNotFoundException : Key 'clientId' not found in configuration. Client ID is mandatory when Authentication Type is set to Mutual Auth");
          string key12 = "clientSecret";
          this.ClientSecret = merchantConfigDictionary.ContainsKey(key12) && !string.IsNullOrEmpty(merchantConfigDictionary[key12]) ? merchantConfigDictionary[key12] : throw new KeyNotFoundException("KeyNotFoundException : Key 'clientSecret' not found in configuration. Client Secret is mandatory when Authentication Type is set to Mutual Auth");
        }
        string key13 = "enableClientCert";
        this.EnableClientCert = !merchantConfigDictionary.ContainsKey(key13) || string.IsNullOrEmpty(merchantConfigDictionary[key13]) ? "false" : merchantConfigDictionary[key13];
        if (object.Equals((object)bool.Parse(this.EnableClientCert.ToString()), (object)true))
        {
          string key14 = "clientCertFile";
          this.ClientCertFile = merchantConfigDictionary.ContainsKey(key14) && !string.IsNullOrEmpty(merchantConfigDictionary[key14]) ? merchantConfigDictionary[key14] : throw new KeyNotFoundException("KeyNotFoundException : Key 'clientCertFile' not found in configuration. Client Certificate File is mandatory when enableClientCert is true");
          string key15 = "clientCertPassword";
          this.ClientCertPassword = merchantConfigDictionary.ContainsKey(key15) && !string.IsNullOrEmpty(merchantConfigDictionary[key15]) ? merchantConfigDictionary[key15] : throw new KeyNotFoundException("KeyNotFoundException : Key 'clientCertPassword' not found in configuration. Client Certificate Password is mandatory when enableClientCert is true");
          string key16 = "clientCertDirectory";
          this.ClientCertDirectory = merchantConfigDictionary.ContainsKey(key16) && !string.IsNullOrEmpty(merchantConfigDictionary[key16]) ? merchantConfigDictionary[key16] : throw new KeyNotFoundException("KeyNotFoundException : Key 'clientCertDirectory' not found in configuration. Client Certificate Directory is mandatory when enableClientCert is true");
        }
        if (merchantConfigDictionary.ContainsKey("timeout"))
          this.TimeOut = merchantConfigDictionary["timeout"];
        if (merchantConfigDictionary.ContainsKey("useProxy"))
          this.UseProxy = merchantConfigDictionary["useProxy"];
        if (merchantConfigDictionary.ContainsKey("proxyAddress"))
          this.ProxyAddress = merchantConfigDictionary["proxyAddress"];
        if (merchantConfigDictionary.ContainsKey("proxyPort"))
          this.ProxyPort = merchantConfigDictionary["proxyPort"];
        if (merchantConfigDictionary.ContainsKey("proxyUsername"))
          this.ProxyUsername = merchantConfigDictionary["proxyUsername"];
        if (!merchantConfigDictionary.ContainsKey("proxyPassword"))
          return;
        this.ProxyPassword = merchantConfigDictionary["proxyPassword"];
      }
      catch (KeyNotFoundException ex)
      {
        throw new Exception(Constants.ErrorPrefix + " " + ex.Message);
      }
    }

    private void ValidateProperties()
    {
      Enumerations.ValidateAuthenticationType(this.AuthenticationType);
      if (string.Equals(this.AuthenticationType, Enumerations.AuthenticationType.HTTP_SIGNATURE.ToString(), StringComparison.OrdinalIgnoreCase))
        this.IsHttpSignAuthType = true;
      else if (string.Equals(this.AuthenticationType, Enumerations.AuthenticationType.JWT.ToString(), StringComparison.OrdinalIgnoreCase))
        this.IsJwtTokenAuthType = true;
      if (string.IsNullOrEmpty(this.TimeOut))
        this.TimeOut = string.Empty;
      if (string.IsNullOrEmpty(this.RunEnvironment))
      {
        throw new Exception(Constants.ErrorPrefix + " Merchant Config field - RunEnvironment is Mandatory");
      }
      this.HostName = !Constants.OldRunEnvironmentConstants.Contains(this.RunEnvironment.ToUpper()) ? this.RunEnvironment.ToLower() : throw new Exception(Constants.DeprecationPrefix + " The value \"" + this.RunEnvironment + "\" for this field `RunEnvironment` has been deprecated and will not be used anymore.\n\nPlease refer to the README file [ https://github.com/CyberSource/cybersource-rest-samples-csharp/blob/master/README.md ] for information about the new values that are accepted.");
      if (this.IsHttpSignAuthType)
      {
        if (string.IsNullOrEmpty(this.MerchantId))
        {
          throw new Exception(Constants.ErrorPrefix + " Merchant Config field - MerchantID is Mandatory");
        }
        if (string.IsNullOrEmpty(this.MerchantKeyId))
        {
          throw new Exception(Constants.ErrorPrefix + " Merchant Config field - MerchantKeyId is Mandatory");
        }
        if (string.IsNullOrEmpty(this.MerchantSecretKey))
        {
          throw new Exception(Constants.ErrorPrefix + " Merchant Config field - MerchantSecretKey is Mandatory");
        }
      }
      else
      {
        if (!this.IsJwtTokenAuthType)
          return;
        if (string.IsNullOrEmpty(this.MerchantId))
        {
          throw new Exception(Constants.ErrorPrefix + " Merchant Config field - MerchantID is Mandatory");
        }
        if (string.IsNullOrEmpty(this.KeyAlias))
        {
          this.KeyAlias = this.MerchantId;
          throw new Exception(Constants.WarningPrefix + " KeyAlias not provided. Assigning the value of: [MerchantID]");
        }
        if (!string.Equals(this.KeyAlias, this.MerchantId))
        {
          this.KeyAlias = this.MerchantId;
          throw new Exception(Constants.WarningPrefix + " Incorrect value of KeyAlias provided. Assigning the value of: [MerchantID]");
        }
        if (string.IsNullOrEmpty(this.KeyPass))
        {
          this.KeyPass = this.MerchantId;
          throw new Exception(Constants.WarningPrefix + " KeyPassword not provided. Assigning the value of: [MerchantID]");
        }
        if (string.IsNullOrEmpty(this.KeyDirectory))
        {
          this.KeyDirectory = Constants.P12FileDirectory;
          throw new Exception(Constants.WarningPrefix + " KeysDirectory not provided. Using Default Path: " + this.KeyDirectory);
        }
        if (string.IsNullOrEmpty(this.KeyfileName))
        {
          this.KeyfileName = this.MerchantId;
          throw new Exception(Constants.WarningPrefix + " KeyfileName not provided. Assigning the value of: [MerchantId]");
        }
        this.P12Keyfilepath = this.KeyDirectory + "\\" + this.KeyfileName + ".p12";
      }
    }
  }
}
