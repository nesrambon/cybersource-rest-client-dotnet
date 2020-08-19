// Decompiled with JetBrains decompiler
// Type: AuthenticationSdk.util.Enumerations
// Assembly: AuthenticationSdk, Version=0.0.0.7, Culture=neutral, PublicKeyToken=null
// MVID: 51F37287-3D9C-4D24-9C5B-42A967D1065C


using AuthenticationSdk.core;
using System;

namespace AuthenticationSdk.util
{
  public class Enumerations
  {
    public static bool ValidateAuthenticationType(string authType)
    {
      if (string.IsNullOrEmpty(authType))
        throw new Exception(Constants.ErrorPrefix + " No Authentication type provided in config file");
      if (Enum.IsDefined(typeof (Enumerations.AuthenticationType), (object) authType.ToUpper()))
        return true;
      throw new Exception(Constants.ErrorPrefix + "Invalid Auth type " + authType + " provided in config file");
    }

    public static bool ValidateRequestType(string requestType)
    {
      if (requestType == null)
        throw new Exception(Constants.ErrorPrefix + " RequestType has not been set. Set it to any one of the Valid Values: GET/POST/PUT/DELETE");
      if (requestType.Trim() == string.Empty)
        throw new Exception(Constants.ErrorPrefix + " RequestType has been set as blank. Set it to any one of the Valid Values: GET/POST/PUT/DELETE");
      if (!Enum.IsDefined(typeof (Enumerations.RequestType), (object) requestType.ToUpper()))
        throw new Exception(Constants.ErrorPrefix + " Invalid Request Type:" + requestType + " . Valid Values: GET/POST/PUT/DELETE");
      return true;
    }

    public static void SetRequestType(MerchantConfig merchantConfig)
    {
      if (string.Equals(merchantConfig.RequestType, Enumerations.RequestType.GET.ToString(), StringComparison.OrdinalIgnoreCase))
        merchantConfig.IsGetRequest = true;
      else if (string.Equals(merchantConfig.RequestType, Enumerations.RequestType.POST.ToString(), StringComparison.OrdinalIgnoreCase))
        merchantConfig.IsPostRequest = true;
      else if (string.Equals(merchantConfig.RequestType, Enumerations.RequestType.PUT.ToString(), StringComparison.OrdinalIgnoreCase))
        merchantConfig.IsPutRequest = true;
      else if (string.Equals(merchantConfig.RequestType, Enumerations.RequestType.DELETE.ToString(), StringComparison.OrdinalIgnoreCase))
      {
        merchantConfig.IsDeleteRequest = true;
      }
      else
      {
        if (!string.Equals(merchantConfig.RequestType, Enumerations.RequestType.PATCH.ToString(), StringComparison.OrdinalIgnoreCase))
          return;
        merchantConfig.IsPatchRequest = true;
      }
    }

    public enum AuthenticationType
    {
      HTTP_SIGNATURE,
      JWT,
    }

    public enum RequestType
    {
      GET,
      POST,
      PUT,
      DELETE,
      PATCH,
    }
  }
}
