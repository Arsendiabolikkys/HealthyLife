using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Web;

namespace HealthyLife
{
    public class ResourceAccessor
    {
        static ResourceAccessor _Instance;

        public static ResourceAccessor Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new ResourceAccessor();
                return _Instance;
            }
        }

        ResourceManager manager;

        public ResourceAccessor()
        {
            manager = HealthyLife.Texts.ResourceManager;
        }

        public string Get(string key)
        {
            return manager.GetString(key);
        }
    }
}