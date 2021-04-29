// Decompiled with JetBrains decompiler
// Type: AuthenticationSdk.util.Cache
// Assembly: AuthenticationSdk, Version=0.0.0.9, Culture=neutral, PublicKeyToken=null
// MVID: B31F8FE4-8578-4DB7-AA70-B490E8CCC72C

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Caching;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace AuthenticationSdk.util
{
  public static class Cache
  {
    public static X509Certificate2 FetchCachedCertificate(
      string p12FilePath,
      string keyPassword)
    {
      try
      {
        ObjectCache objectCache = (ObjectCache) MemoryCache.Default;
        if (objectCache["certiFromP12File"] is X509Certificate2 x509Certificate2_4)
          return x509Certificate2_4;
        CacheItemPolicy policy = new CacheItemPolicy();
        policy.ChangeMonitors.Add((ChangeMonitor) new HostFileChangeMonitor((IList<string>) new List<string>()
        {
          Path.GetFullPath(p12FilePath)
        }));
        X509Certificate2 x509Certificate2_2 = new X509Certificate2(p12FilePath, keyPassword);
        objectCache.Set("certiFromP12File", (object) x509Certificate2_2, policy);
        return x509Certificate2_2;
      }
      catch (CryptographicException ex)
      {
        if (ex.Message.Equals("The specified network password is not correct.\r\n"))
          throw new Exception(Constants.ErrorPrefix + " KeyPassword provided:" + keyPassword + " is incorrect");
        return (X509Certificate2) null;
      }
    }
  }
}
