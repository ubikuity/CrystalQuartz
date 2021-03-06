﻿using System.Reflection;
using System.Web;

namespace CrystalQuartz.WebFramework.Request
{
    public class SingleFileRequestHandler : AbstractFileRequestHandler
    {
        private readonly string _path;

        public SingleFileRequestHandler(Assembly resourcesAssembly, string resourcePrefix, string path) : base(resourcesAssembly, resourcePrefix)
        {
            _path = path;
        }

        protected override string GetPath(HttpContextBase context)
        {
            return _path;
        }
    }
}