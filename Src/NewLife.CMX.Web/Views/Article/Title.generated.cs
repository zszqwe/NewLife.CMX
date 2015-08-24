﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
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
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    using NewLife.CMX;
    using NewLife.CMX.Web;
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Article/Title.cshtml")]
    public partial class _Views_Article_Title_cshtml : System.Web.Mvc.WebViewPage<NewLife.CMX.IEntityTitle>
    {
        public _Views_Article_Title_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Article\Title.cshtml"
  
    var Channel = ViewBag.Channel as Channel;
    var Category = ViewBag.Category as IEntityCategory;

    this.PushTitle(Model.Category.Name);
    this.PushTitle(Model.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 11 "..\..\Views\Article\Title.cshtml"
   Write(Html.Partial("_Nav"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        <h2");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 15 "..\..\Views\Article\Title.cshtml"
       Write(Model.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n        </h2>\r\n        <h3");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n            <em");

WriteLiteral(" class=\"e e1\"");

WriteLiteral(">来源：");

            
            #line 18 "..\..\Views\Article\Title.cshtml"
                            Write(Model as IUserInfo);

            
            #line default
            #line hidden
WriteLiteral(".CreateUserName</em>\r\n            <em");

WriteLiteral(" class=\"e e2\"");

WriteLiteral(">发布时间：");

            
            #line 19 "..\..\Views\Article\Title.cshtml"
                             Write(Model.CreateTime.ToFullString());

            
            #line default
            #line hidden
WriteLiteral("</em>\r\n            <em");

WriteLiteral(" class=\"e e3\"");

WriteLiteral(">浏览：");

            
            #line 20 "..\..\Views\Article\Title.cshtml"
                           Write(Model.Views.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("</em>\r\n        </h3>\r\n        <div");

WriteLiteral(" class=\"content\"");

WriteLiteral(">\r\n            <style");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(">\r\n                .TRS_Editor P {\r\n                    margin-top: 0;\r\n         " +
"           margin-bottom: 1em;\r\n                    line-height: 2;\r\n           " +
"     }\r\n\r\n                .TRS_Editor DIV {\r\n                    margin-top: 0;\r" +
"\n                    margin-bottom: 1em;\r\n                    line-height: 2;\r\n " +
"               }\r\n\r\n                .TRS_Editor TD {\r\n                    margin" +
"-top: 0;\r\n                    margin-bottom: 1em;\r\n                    line-heig" +
"ht: 2;\r\n                }\r\n\r\n                .TRS_Editor TH {\r\n                 " +
"   margin-top: 0;\r\n                    margin-bottom: 1em;\r\n                    " +
"line-height: 2;\r\n                }\r\n\r\n                .TRS_Editor SPAN {\r\n      " +
"              margin-top: 0;\r\n                    margin-bottom: 1em;\r\n         " +
"           line-height: 2;\r\n                }\r\n\r\n                .TRS_Editor FON" +
"T {\r\n                    margin-top: 0;\r\n                    margin-bottom: 1em;" +
"\r\n                    line-height: 2;\r\n                }\r\n\r\n                .TRS" +
"_Editor UL {\r\n                    margin-top: 0;\r\n                    margin-bot" +
"tom: 1em;\r\n                    line-height: 2;\r\n                }\r\n\r\n           " +
"     .TRS_Editor LI {\r\n                    margin-top: 0;\r\n                    m" +
"argin-bottom: 1em;\r\n                    line-height: 2;\r\n                }\r\n\r\n  " +
"              .TRS_Editor A {\r\n                    margin-top: 0;\r\n             " +
"       margin-bottom: 1em;\r\n                    line-height: 2;\r\n               " +
" }\r\n            </style>\r\n            <div");

WriteLiteral(" class=\"TRS_Editor\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 79 "..\..\Views\Article\Title.cshtml"
           Write(Html.Raw(Model.ContentText));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
