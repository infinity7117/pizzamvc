﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Pizza.Mvc;
    using Pizza.Mvc.HtmlHelpers;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Index.cshtml")]
    public partial class _Views_Shared_Index_cshtml : System.Web.Mvc.WebViewPage<Pizza.Mvc.Grid.Metamodel.GridMetamodel>
    {
        public _Views_Shared_Index_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<h2>");

            
            #line 1 "..\..\Views\Shared\Index.cshtml"
Write(ViewBag.PageTitle);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n");

            
            #line 4 "..\..\Views\Shared\Index.cshtml"
Write(Html.DisplayFor(x => Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591