﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace DotNetNuke.Web.Mvc.Skins
{
    using System;
    using System.Web;
    using System.Web.Mvc;

    public static partial class SkinExtensions
    {
        public static IHtmlString DnnJsInclude(this HtmlHelper<DotNetNuke.Framework.Models.PageModel> helper, string filePath, string pathNameAlias = "", int priority = 100, bool addTag = false, string name = "", string version = "", bool forceVersion = false, string forceProvider = "", bool forceBundle = false)
        {
            var jsInclude = new TagBuilder("dnn:DnnJsInclude");
            jsInclude.Attributes.Add("ID", "ctlInclude");
            jsInclude.Attributes.Add("runat", "server");
            jsInclude.Attributes.Add("FilePath", filePath);
            jsInclude.Attributes.Add("PathNameAlias", pathNameAlias);
            jsInclude.Attributes.Add("Priority", priority.ToString());
            jsInclude.Attributes.Add("AddTag", addTag.ToString());
            jsInclude.Attributes.Add("Name", name);
            jsInclude.Attributes.Add("Version", version);
            jsInclude.Attributes.Add("ForceVersion", forceVersion.ToString());
            jsInclude.Attributes.Add("ForceProvider", forceProvider);
            jsInclude.Attributes.Add("ForceBundle", forceBundle.ToString());

            return new MvcHtmlString(jsInclude.ToString());
        }
    }
}