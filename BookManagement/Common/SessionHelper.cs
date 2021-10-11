
using BookManagement.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace BookManagement.Common
{
    public static class SessionHelper
    {
        //public static void setSession(Admin us)
        //{
        //    HttpContext.Request.Session["GET_USER"] = us;
        //}
        //public static Admin getSession()
        //{
        //    if (HttpContext.Session["GET_USER"] == null) return null;
        //    return HttpContext.Session["GET_USER"] as Admin;
        //}

        public static void Set<T>(this ISession session, string key, T value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static T Get<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) : JsonSerializer.Deserialize<T>(value);
        }
    }
}
