// Decompiled with JetBrains decompiler
// Type: AuthenticationSdk.core.MerchantConfig
// Assembly: AuthenticationSdk, Version=0.0.0.7, Culture=neutral, PublicKeyToken=null
// MVID: 51F37287-3D9C-4D24-9C5B-42A967D1065C


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
    private string _propertiesSetUsing = string.Empty;

    public MerchantConfig(
      IReadOnlyDictionary<string, string> merchantConfigDictionary = null)
    {
      NameValueCollection section = (NameValueCollection) ConfigurationManager.GetSection(nameof (MerchantConfig));
      if (merchantConfigDictionary != null)
      {
        this.SetValuesUsingDictObj(merchantConfigDictionary);
      }
      else
      {
        if (section == null)
          throw new Exception(Constants.ErrorPrefix + " Merchant Config Missing in App.Config File!");
        this.SetValuesFromAppConfig(section);
      }

      this.ValidateProperties();
    }

    public string MerchantId { get; set; }

    public string MerchantSecretKey { get; set; }

    public string MerchantKeyId { get; set; }

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

    public static string LogAllproperties(MerchantConfig obj)
    {
      string[] strArray = Constants.HideMerchantConfigProps.Split(',');
      string str = " ";
      foreach (PropertyInfo property in typeof (MerchantConfig).GetProperties())
      {
        if (!((IEnumerable<string>) strArray).Any<string>(new Func<string, bool>(property.Name.Contains)))
          str = str + property.Name + " " + property.GetValue((object) obj) + ", ";
      }
      return str;
    }

    private void SetValuesFromAppConfig(NameValueCollection merchantConfigSection)
    {
      this._propertiesSetUsing = "App.Config File";
      this.MerchantId = merchantConfigSection["merchantID"];
      this.MerchantSecretKey = merchantConfigSection["merchantsecretKey"];
      this.MerchantKeyId = merchantConfigSection["merchantKeyId"];
      this.AuthenticationType = merchantConfigSection["authenticationType"];
      this.KeyDirectory = merchantConfigSection["keysDirectory"];
      this.KeyfileName = merchantConfigSection["keyFilename"];
      this.RunEnvironment = merchantConfigSection["runEnvironment"];
      this.KeyAlias = merchantConfigSection["keyAlias"];
      this.KeyPass = merchantConfigSection["keyPass"];
      this.EnableLog = merchantConfigSection["enableLog"];
      this.LogDirectory = merchantConfigSection["logDirectory"];
      this.LogfileMaxSize = merchantConfigSection["logFileMaxSize"];
      this.LogFileName = merchantConfigSection["logFileName"];
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
      string key = string.Empty;
      try
      {
        if (merchantConfigDictionary == null)
          return;
        this._propertiesSetUsing = "Dictionary Object";
        key = "merchantID";
        this.MerchantId = merchantConfigDictionary[key];
        key = "runEnvironment";
        this.RunEnvironment = merchantConfigDictionary[key];
        key = "authenticationType";
        this.AuthenticationType = merchantConfigDictionary[key];
        Enumerations.AuthenticationType result;
        Enum.TryParse<Enumerations.AuthenticationType>(this.AuthenticationType.ToUpper(), out result);
        if (object.Equals((object) result, (object) Enumerations.AuthenticationType.HTTP_SIGNATURE))
        {
          key = "merchantsecretKey";
          this.MerchantSecretKey = merchantConfigDictionary[key];
          key = "merchantKeyId";
          this.MerchantKeyId = merchantConfigDictionary[key];
        }
        if (object.Equals((object) result, (object) Enumerations.AuthenticationType.JWT))
        {
          if (merchantConfigDictionary.ContainsKey("keyAlias"))
            this.KeyAlias = merchantConfigDictionary["keyAlias"];
          if (merchantConfigDictionary.ContainsKey("keyFilename"))
            this.KeyfileName = merchantConfigDictionary["keyFilename"];
          if (merchantConfigDictionary.ContainsKey("keyPass"))
            this.KeyPass = merchantConfigDictionary["keyPass"];
          if (merchantConfigDictionary.ContainsKey("keysDirectory"))
            this.KeyDirectory = merchantConfigDictionary["keysDirectory"];
        }
        if (merchantConfigDictionary.ContainsKey("enableLog"))
          this.EnableLog = merchantConfigDictionary["enableLog"];
        if (merchantConfigDictionary.ContainsKey("logDirectory"))
          this.LogDirectory = merchantConfigDictionary["logDirectory"];
        if (merchantConfigDictionary.ContainsKey("logFileMaxSize"))
          this.LogfileMaxSize = merchantConfigDictionary["logFileMaxSize"];
        if (merchantConfigDictionary.ContainsKey("logFileName"))
          this.LogFileName = merchantConfigDictionary["logFileName"];
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
      catch (KeyNotFoundException)
      {
        throw new Exception(Constants.ErrorPrefix + " Mandatory Key (" + key + ") Missing in the Configuration Dictionary Object Passed to the instance of MerchantConfig");
      }
    }

    private void ValidateProperties()
    {
      if (string.IsNullOrEmpty(this.MerchantId))
        throw new Exception(Constants.ErrorPrefix + " Merchant Config field - MerchantID is Mandatory");
      Enumerations.ValidateAuthenticationType(this.AuthenticationType);
      string authenticationType1 = this.AuthenticationType;
      Enumerations.AuthenticationType authenticationType2 = Enumerations.AuthenticationType.HTTP_SIGNATURE;
      string b1 = authenticationType2.ToString();
      if (string.Equals(authenticationType1, b1, StringComparison.OrdinalIgnoreCase))
      {
        this.IsHttpSignAuthType = true;
      }
      else
      {
        string authenticationType3 = this.AuthenticationType;
        authenticationType2 = Enumerations.AuthenticationType.JWT;
        string b2 = authenticationType2.ToString();
        if (string.Equals(authenticationType3, b2, StringComparison.OrdinalIgnoreCase))
          this.IsJwtTokenAuthType = true;
      }
      if (string.IsNullOrEmpty(this.TimeOut))
        this.TimeOut = string.Empty;
      string str = !string.IsNullOrEmpty(this.RunEnvironment) ? this.RunEnvironment.ToUpper() : throw new Exception(Constants.ErrorPrefix + " Merchant Config field - RunEnvironment is Mandatory");
      this.HostName = !str.Equals(Constants.CybsSandboxRunEnv.ToUpper()) ? (!str.Equals(Constants.CybsProdRunEnv.ToUpper()) ? (!str.Equals(Constants.BoASandboxRunEnv.ToUpper()) ? (!str.Equals(Constants.BoAProdRunEnv.ToUpper()) ? (!str.Equals(Constants.IDCSandboxRunEnv.ToUpper()) ? (!str.Equals(Constants.IDCProdRunEnv.ToUpper()) ? this.RunEnvironment.ToLower() : Constants.IDCProdHostName) : Constants.IDCSandboxHostName) : Constants.BoAProdHostName) : Constants.BoASandboxHostName) : Constants.CybsProdHostName) : Constants.CybsSandboxHostName;
      if (this.IsHttpSignAuthType)
      {
        if (string.IsNullOrEmpty(this.MerchantKeyId))
          throw new Exception(Constants.ErrorPrefix + " Merchant Config field - MerchantKeyId is Mandatory");
        if (string.IsNullOrEmpty(this.MerchantSecretKey))
          throw new Exception(Constants.ErrorPrefix + " Merchant Config field - MerchantSecretKey is Mandatory");
      }
      else
      {
        if (!this.IsJwtTokenAuthType)
          return;
        if (string.IsNullOrEmpty(this.KeyAlias))
        {
          this.KeyAlias = this.MerchantId;
        }
        if (!string.Equals(this.KeyAlias, this.MerchantId))
        {
          this.KeyAlias = this.MerchantId;
        }
        if (string.IsNullOrEmpty(this.KeyPass))
        {
          this.KeyPass = this.MerchantId;
        }
        if (string.IsNullOrEmpty(this.KeyDirectory))
        {
          this.KeyDirectory = Constants.P12FileDirectory;
        }
        if (string.IsNullOrEmpty(this.KeyfileName))
        {
          this.KeyfileName = this.MerchantId;
        }
        this.P12Keyfilepath = this.KeyDirectory + "\\" + this.KeyfileName + ".p12";
      }
    }
  }
}
