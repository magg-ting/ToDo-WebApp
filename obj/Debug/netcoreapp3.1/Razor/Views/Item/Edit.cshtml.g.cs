#pragma checksum "C:\Users\User\Source\Repos\ToDo-WebApp\Views\Item\Edit.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1b0dcc78dcdc2eb67404f41be3f0a2e99b5a64dfdaeff200b3d6b612dbe4d3c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Item_Edit), @"mvc.1.0.view", @"/Views/Item/Edit.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\User\Source\Repos\ToDo-WebApp\Views\_ViewImports.cshtml"
using todo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Source\Repos\ToDo-WebApp\Views\_ViewImports.cshtml"
using todo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"1b0dcc78dcdc2eb67404f41be3f0a2e99b5a64dfdaeff200b3d6b612dbe4d3c6", @"/Views/Item/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"513e911f5fabdabe1b11b8f0a18c77264e75c54fb2bbc175d66c619324c9b84f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Item_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<todo.Models.Item>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/bundles/jqueryval"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2 class=\"text-center well\">Edit a To-Do Item</h2>\r\n\r\n");
#nullable restore
#line 5 "C:\Users\User\Source\Repos\ToDo-WebApp\Views\Item\Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Source\Repos\ToDo-WebApp\Views\Item\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <hr />\r\n        ");
#nullable restore
#line 11 "C:\Users\User\Source\Repos\ToDo-WebApp\Views\Item\Edit.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 12 "C:\Users\User\Source\Repos\ToDo-WebApp\Views\Item\Edit.cshtml"
   Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 15 "C:\Users\User\Source\Repos\ToDo-WebApp\Views\Item\Edit.cshtml"
       Write(Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 17 "C:\Users\User\Source\Repos\ToDo-WebApp\Views\Item\Edit.cshtml"
           Write(Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 18 "C:\Users\User\Source\Repos\ToDo-WebApp\Views\Item\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 23 "C:\Users\User\Source\Repos\ToDo-WebApp\Views\Item\Edit.cshtml"
       Write(Html.LabelFor(model => model.Description, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 25 "C:\Users\User\Source\Repos\ToDo-WebApp\Views\Item\Edit.cshtml"
           Write(Html.EditorFor(model => model.Description, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 26 "C:\Users\User\Source\Repos\ToDo-WebApp\Views\Item\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Description, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 31 "C:\Users\User\Source\Repos\ToDo-WebApp\Views\Item\Edit.cshtml"
       Write(Html.LabelFor(model => model.Completed, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                <div class=\"checkbox\">\r\n                    ");
#nullable restore
#line 34 "C:\Users\User\Source\Repos\ToDo-WebApp\Views\Item\Edit.cshtml"
               Write(Html.EditorFor(model => model.Completed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 35 "C:\Users\User\Source\Repos\ToDo-WebApp\Views\Item\Edit.cshtml"
               Write(Html.ValidationMessageFor(model => model.Completed, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
        </div>

        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-10"">
                <input type=""submit"" value=""Save"" class=""btn btn-warning"" />
            </div>
        </div>
    </div>
");
#nullable restore
#line 46 "C:\Users\User\Source\Repos\ToDo-WebApp\Views\Item\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"btn-container\">\r\n    <button class=\"btn btn-default\">\r\n        ");
#nullable restore
#line 50 "C:\Users\User\Source\Repos\ToDo-WebApp\Views\Item\Edit.cshtml"
   Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </button>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b0dcc78dcdc2eb67404f41be3f0a2e99b5a64dfdaeff200b3d6b612dbe4d3c68458", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<todo.Models.Item> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
