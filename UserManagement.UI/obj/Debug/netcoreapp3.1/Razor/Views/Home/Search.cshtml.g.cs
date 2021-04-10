#pragma checksum "E:\Projects\Rest Api Project\UserManagement\UserManagement.UI\Views\Home\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f44ba7668e9304c39c1c4a20ec4a78ec935bcbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Search), @"mvc.1.0.view", @"/Views/Home/Search.cshtml")]
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
#line 1 "E:\Projects\Rest Api Project\UserManagement\UserManagement.UI\Views\_ViewImports.cshtml"
using UserManagement.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projects\Rest Api Project\UserManagement\UserManagement.UI\Views\_ViewImports.cshtml"
using UserManagement.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f44ba7668e9304c39c1c4a20ec4a78ec935bcbb", @"/Views/Home/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8ed8c65978368617405084e3aa71aff885f877c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/jquery-ui/jquery-ui.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/jquery-ui/jquery-ui.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\Projects\Rest Api Project\UserManagement\UserManagement.UI\Views\Home\Search.cshtml"
  
    ViewData["Title"] = "Search";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-12"">
        <div class=""card "">
            <div class=""card-body "">
                <h4 class=""card-title"">Search User</h4>
                <div class=""row"">
                    <div class=""col-md-12 mb-4"">
                        <div class=""form-group row"">
                            <label class=""col-md-2 col-form-label"">Username</label>
                            <div class=""col-md-10"">
                                <input class=""form-control"" id=""txtUsername"" />
                                <span class=""text-danger hide"" id=""nogamemsg"">No user found.</span>
                            </div>
                        </div>
                    </div>

                    <div class=""col-md-12 mt-4"">
                        <table id=""tblUsers"" class=""table table-bordered"">
                            <thead>
                                <tr>
                                    <th>Id</th>
                                    <th>First");
            WriteLiteral(@" Name</th>
                                    <th>Last Name</th>
                                    <th>Address</th>
                                    <th>Age</th>
                                    <th>Interests</th>
                                </tr>
                            </thead>
                            <tbody></tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2f44ba7668e9304c39c1c4a20ec4a78ec935bcbb6126", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f44ba7668e9304c39c1c4a20ec4a78ec935bcbb7304", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(""#txtUsername"").autocomplete({
            destroy: true,
            minLength: 1,
            source: function (request, response) {
                var _uri = ""https://localhost:44320/api/v1/Users/Search/"" + request.term + """";
                $.ajax({
                    url: _uri,
                    type: ""GET"",
                    dataType: ""json"",
                    data: {},
                    success: function (data) {
                        debugger
                        response($.map(data, function (item) {
                            return { label: (item.firstName + "" "" + item.lastName), value: item.id };
                        }))
                    }
                })
            },
            select: function (event, ui) {
                debugger
                $(""#txtUsername"").val(ui.item.label);
                var _geturi = ""https://localhost:44320/api/v1/Users/Find/"" + ui.item.value + """";
                $.");
                WriteLiteral(@"ajax({
                    url: _geturi,
                    type: ""GET"",
                    dataType: ""json"",
                    data: {},
                    async: false,
                    success: function (data) {
                        if (data != null) {
                            $(""#txtUsername"").val(data.firstName + "" "" + data.lastName);
                            var str = ""<tr><td>"" + 1 + ""</td><td>"" + data.firstName + ""</td><td>"" + data.lastName + ""</td><td>"" + data.address + '</td><td>' + data.age + '</td ><td>' + data.interests + '</td ></tr>';
                            $('#tblUsers').find(""tbody"").html(str);
                        }

                    }
                });
                $(""#txtUsername"").val(ui.item.label);
                return false;
            },
            focus: function (event, ui) {
                $(""#txtUsername"").val(ui.item.label);
                return false;
            },
            search: function (event, ui) {
        ");
                WriteLiteral(@"        $(""#txtUsername"").addClass(""loading"");
            },
            response: function (event, ui) {
                $(""#txtUsername"").removeClass(""loading"");
                if (ui.content.length === 0) {
                    $(""#nogamemsg"").removeClass(""hide"");
                } else {
                    $(""#nogamemsg"").addClass(""hide"");
                }
            },
        });
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591