// Decompiled with JetBrains decompiler
// Type: AuthenticationSdk.util.Cache
// Assembly: AuthenticationSdk, Version=0.0.0.7, Culture=neutral, PublicKeyToken=null
// MVID: 51F37287-3D9C-4D24-9C5B-42A967D1065C


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
        if (objectCache["certiFromP12File"] is X509Certificate2 x509Certificate2)
          return x509Certificate2;
        CacheItemPolicy policy = new CacheItemPolicy();
        policy.ChangeMonitors.Add((ChangeMonitor) new HostFileChangeMonitor((IList<string>) new List<string>()
        {
          Path.GetFullPath(p12FilePath)
        }));
        X509Certificate2 x509Certificate2_1 = new X509Certificate2(p12FilePath, keyPassword);
        objectCache.Set("certiFromP12File", (object) x509Certificate2_1, policy);
        return x509Certificate2_1;
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
