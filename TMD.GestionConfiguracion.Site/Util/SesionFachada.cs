using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TMD.CF.Entidades;

namespace TMD.CF.Site.Util
{
    static class SesionFachada
    {
        private static void Set(string key, Object value)
        {
            if (HttpContext.Current.Session[key] != null)
            {
                HttpContext.Current.Session.Add(key, value);
            }
            else
            {
                HttpContext.Current.Session[key] = value;
            }
        }

        private static T Get<T>(string key)
        {
            return (T)HttpContext.Current.Session[key];
        }

        public static Usuario Usuario
        {
            set
            {
                Set("_Usuario_", value);
            }
            get { return Get<Usuario>("_Usuario_"); }
        }

    }
}