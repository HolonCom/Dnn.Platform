﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace DotNetNuke.Web.Mvc.Skins
{
    using System;
    using System.Web;
    using System.Web.Mvc;

    using DotNetNuke.Common;
    using DotNetNuke.Entities.Host;

    public static partial class SkinExtensions
    {
        public static IHtmlString HostName(this HtmlHelper<DotNetNuke.Framework.Models.PageModel> helper, string cssClass = "")
        {
            var link = new TagBuilder("a");
            link.Attributes.Add("href", Globals.AddHTTP(Host.HostURL));
            link.Attributes.Add("class", cssClass);
            link.SetInnerText(Host.HostTitle);

            return new MvcHtmlString(link.ToString());
        }
    }
}