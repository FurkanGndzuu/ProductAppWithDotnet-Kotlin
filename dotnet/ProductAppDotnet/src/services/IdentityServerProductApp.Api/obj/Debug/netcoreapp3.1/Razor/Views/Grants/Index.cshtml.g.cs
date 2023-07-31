#pragma checksum "C:\Users\furka\OneDrive\Masaüstü\ProductAppWithDotnet&Kotlin\dotnet\ProductAppDotnet\src\services\IdentityServerProductApp.Api\Views\Grants\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0913be272805ec5bd89e6458e77d6f52e8b0ec5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Grants_Index), @"mvc.1.0.view", @"/Views/Grants/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\furka\OneDrive\Masaüstü\ProductAppWithDotnet&Kotlin\dotnet\ProductAppDotnet\src\services\IdentityServerProductApp.Api\Views\_ViewImports.cshtml"
using IdentityServerHost.Quickstart.UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0913be272805ec5bd89e6458e77d6f52e8b0ec5d", @"/Views/Grants/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a00496e1714fb62801584a343cc1019e13a800a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Grants_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GrantsViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Revoke", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"grants-page\">\r\n    <div class=\"lead\">\r\n        <h1>Client Application Permissions</h1>\r\n        <p>Below is the list of applications you have given permission to and the resources they have access to.</p>\r\n    </div>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\furka\OneDrive\Masaüstü\ProductAppWithDotnet&Kotlin\dotnet\ProductAppDotnet\src\services\IdentityServerProductApp.Api\Views\Grants\Index.cshtml"
     if (Model.Grants.Any() == false)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-sm-8\">\r\n                <div class=\"alert alert-info\">\r\n                    You have not given access to any applications\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 18 "C:\Users\furka\OneDrive\Masaüstü\ProductAppWithDotnet&Kotlin\dotnet\ProductAppDotnet\src\services\IdentityServerProductApp.Api\Views\Grants\Index.cshtml"
    }
    else
    {
        foreach (var grant in Model.Grants)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card\">\r\n                <div class=\"card-header\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-sm-8 card-title\">\r\n");
#nullable restore
#line 27 "C:\Users\furka\OneDrive\Masaüstü\ProductAppWithDotnet&Kotlin\dotnet\ProductAppDotnet\src\services\IdentityServerProductApp.Api\Views\Grants\Index.cshtml"
                             if (grant.ClientLogoUrl != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <img");
            BeginWriteAttribute("src", " src=\"", 925, "\"", 951, 1);
#nullable restore
#line 29 "C:\Users\furka\OneDrive\Masaüstü\ProductAppWithDotnet&Kotlin\dotnet\ProductAppDotnet\src\services\IdentityServerProductApp.Api\Views\Grants\Index.cshtml"
WriteAttributeValue("", 931, grant.ClientLogoUrl, 931, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 30 "C:\Users\furka\OneDrive\Masaüstü\ProductAppWithDotnet&Kotlin\dotnet\ProductAppDotnet\src\services\IdentityServerProductApp.Api\Views\Grants\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <strong>");
#nullable restore
#line 31 "C:\Users\furka\OneDrive\Masaüstü\ProductAppWithDotnet&Kotlin\dotnet\ProductAppDotnet\src\services\IdentityServerProductApp.Api\Views\Grants\Index.cshtml"
                               Write(grant.ClientName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                        </div>\r\n\r\n                        <div class=\"col-sm-2\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0913be272805ec5bd89e6458e77d6f52e8b0ec5d6531", async() => {
                WriteLiteral("\r\n                                <input type=\"hidden\" name=\"clientId\"");
                BeginWriteAttribute("value", " value=\"", 1256, "\"", 1279, 1);
#nullable restore
#line 36 "C:\Users\furka\OneDrive\Masaüstü\ProductAppWithDotnet&Kotlin\dotnet\ProductAppDotnet\src\services\IdentityServerProductApp.Api\Views\Grants\Index.cshtml"
WriteAttributeValue("", 1264, grant.ClientId, 1264, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <button class=\"btn btn-danger\">Revoke Access</button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                \r\n                <ul class=\"list-group list-group-flush\">\r\n");
#nullable restore
#line 44 "C:\Users\furka\OneDrive\Masaüstü\ProductAppWithDotnet&Kotlin\dotnet\ProductAppDotnet\src\services\IdentityServerProductApp.Api\Views\Grants\Index.cshtml"
                     if (grant.Description != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"list-group-item\">\r\n                            <label>Description:</label> ");
#nullable restore
#line 47 "C:\Users\furka\OneDrive\Masaüstü\ProductAppWithDotnet&Kotlin\dotnet\ProductAppDotnet\src\services\IdentityServerProductApp.Api\Views\Grants\Index.cshtml"
                                                   Write(grant.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </li>   \r\n");
#nullable restore
#line 49 "C:\Users\furka\OneDrive\Masaüstü\ProductAppWithDotnet&Kotlin\dotnet\ProductAppDotnet\src\services\IdentityServerProductApp.Api\Views\Grants\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"list-group-item\">\r\n                        <label>Created:</label> ");
#nullable restore
#line 51 "C:\Users\furka\OneDrive\Masaüstü\ProductAppWithDotnet&Kotlin\dotnet\ProductAppDotnet\src\services\IdentityServerProductApp.Api\Views\Grants\Index.cshtml"
                                           Write(grant.Created.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </li>\r\n");
#nullable restore
#line 53 "C:\Users\furka\OneDrive\Masaüstü\ProductAppWithDotnet&Kotlin\dotnet\ProductAppDotnet\src\services\IdentityServerProductApp.Api\Views\Grants\Index.cshtml"
                     if (grant.Expires.HasValue)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"list-group-item\">\r\n                            <label>Expires:</label> ");
#nullable restore
#line 56 "C:\Users\furka\OneDrive\Masaüstü\ProductAppWithDotnet&Kotlin\dotnet\ProductAppDotnet\src\services\IdentityServerProductApp.Api\Views\Grants\Index.cshtml"
                                               Write(grant.Expires.Value.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </li>\r\n");
#nullable restore
#line 58 "C:\Users\furka\OneDrive\Masaüstü\ProductAppWithDotnet&Kotlin\dotnet\ProductAppDotnet\src\services\IdentityServerProductApp.Api\Views\Grants\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\furka\OneDrive\Masaüstü\ProductAppWithDotnet&Kotlin\dotnet\ProductAppDotnet\src\services\IdentityServerProductApp.Api\Views\Grants\Index.cshtml"
                     if (grant.IdentityGrantNames.Any())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"list-group-item\">\r\n                            <label>Identity Grants</label>\r\n                            <ul>\r\n");
#nullable restore
#line 64 "C:\Users\furka\OneDrive\Masaüstü\ProductAppWithDotnet&Kotlin\dotnet\ProductAppDotnet\src\services\IdentityServerProductApp.Api\Views\Grants\Index.cshtml"
                                 foreach (var name in grant.IdentityGrantNames)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li>");
#nullable restore
#line 66 "C:\Users\furka\OneDrive\Masaüstü\ProductAppWithDotnet&Kotlin\dotnet\ProductAppDotnet\src\services\IdentityServerProductApp.Api\Views\Grants\Index.cshtml"
                                   Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 67 "C:\Users\furka\OneDrive\Masaüstü\ProductAppWithDotnet&Kotlin\dotnet\ProductAppDotnet\src\services\IdentityServerProductApp.Api\Views\Grants\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n                        </li>\r\n");
#nullable restore
#line 70 "C:\Users\furka\OneDrive\Masaüstü\ProductAppWithDotnet&Kotlin\dotnet\ProductAppDotnet\src\services\IdentityServerProductApp.Api\Views\Grants\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\furka\OneDrive\Masaüstü\ProductAppWithDotnet&Kotlin\dotnet\ProductAppDotnet\src\services\IdentityServerProductApp.Api\Views\Grants\Index.cshtml"
                     if (grant.ApiGrantNames.Any())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"list-group-item\">\r\n                            <label>API Grants</label>\r\n                            <ul>\r\n");
#nullable restore
#line 76 "C:\Users\furka\OneDrive\Masaüstü\ProductAppWithDotnet&Kotlin\dotnet\ProductAppDotnet\src\services\IdentityServerProductApp.Api\Views\Grants\Index.cshtml"
                                 foreach (var name in grant.ApiGrantNames)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li>");
#nullable restore
#line 78 "C:\Users\furka\OneDrive\Masaüstü\ProductAppWithDotnet&Kotlin\dotnet\ProductAppDotnet\src\services\IdentityServerProductApp.Api\Views\Grants\Index.cshtml"
                                   Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 79 "C:\Users\furka\OneDrive\Masaüstü\ProductAppWithDotnet&Kotlin\dotnet\ProductAppDotnet\src\services\IdentityServerProductApp.Api\Views\Grants\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n                        </li>\r\n");
#nullable restore
#line 82 "C:\Users\furka\OneDrive\Masaüstü\ProductAppWithDotnet&Kotlin\dotnet\ProductAppDotnet\src\services\IdentityServerProductApp.Api\Views\Grants\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </div>\r\n");
#nullable restore
#line 85 "C:\Users\furka\OneDrive\Masaüstü\ProductAppWithDotnet&Kotlin\dotnet\ProductAppDotnet\src\services\IdentityServerProductApp.Api\Views\Grants\Index.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GrantsViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
