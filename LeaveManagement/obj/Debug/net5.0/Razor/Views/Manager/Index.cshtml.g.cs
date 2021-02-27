#pragma checksum "C:\Users\Naruto\source\repos\LeaveManagement\LeaveManagement\Views\Manager\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50f9679741c90656ffcb3b1bdf07ab9c61f78cc7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manager_Index), @"mvc.1.0.view", @"/Views/Manager/Index.cshtml")]
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
#line 1 "C:\Users\Naruto\source\repos\LeaveManagement\LeaveManagement\Views\_ViewImports.cshtml"
using LeaveManagement.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Naruto\source\repos\LeaveManagement\LeaveManagement\Views\_ViewImports.cshtml"
using LeaveManagement.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Naruto\source\repos\LeaveManagement\LeaveManagement\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50f9679741c90656ffcb3b1bdf07ab9c61f78cc7", @"/Views/Manager/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f59be95cc6341fe6c4c1d4f1e9d5d50fa8b0364a", @"/Views/_ViewImports.cshtml")]
    public class Views_Manager_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ManagerViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AcceptRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-block bg-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RejectRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Naruto\source\repos\LeaveManagement\LeaveManagement\Views\Manager\Index.cshtml"
  
    ViewBag.Title = "Manager Homepage";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-center\">Current Employees</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Naruto\source\repos\LeaveManagement\LeaveManagement\Views\Manager\Index.cshtml"
 if (Model.Employees.Count > 0)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 14 "C:\Users\Naruto\source\repos\LeaveManagement\LeaveManagement\Views\Manager\Index.cshtml"
             foreach (var employee in Model.Employees)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card m-0 col-sm-3 p-0 text-center border-0\">\r\n                    <div class=\"m-2\">\r\n\r\n");
#nullable restore
#line 19 "C:\Users\Naruto\source\repos\LeaveManagement\LeaveManagement\Views\Manager\Index.cshtml"
                         if (employee.LeaveRequest == "unTouched")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"card-header font-weight-bold text-center bg-info\">\r\n                                <h1 class=\"card-title font-weight-bold\">");
#nullable restore
#line 22 "C:\Users\Naruto\source\repos\LeaveManagement\LeaveManagement\Views\Manager\Index.cshtml"
                                                                   Write(employee.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                            </div>\r\n");
            WriteLiteral("                            <div class=\"card-footer text-center font-weight-bold\">\r\n                                <h5>Working..</h5>\r\n                            </div>\r\n");
#nullable restore
#line 28 "C:\Users\Naruto\source\repos\LeaveManagement\LeaveManagement\Views\Manager\Index.cshtml"
                        }

                        else if (employee.LeaveRequest == "Submitted")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"card-header font-weight-bold text-center bg-warning\">\r\n                                <h2 class=\"card-title\">");
#nullable restore
#line 33 "C:\Users\Naruto\source\repos\LeaveManagement\LeaveManagement\Views\Manager\Index.cshtml"
                                                  Write(employee.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            </div>\r\n");
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50f9679741c90656ffcb3b1bdf07ab9c61f78cc78483", async() => {
                WriteLiteral("\r\n                                <div class=\"card-footer \">\r\n                                    <div class=\"row\">\r\n                                        <div class=\"col-sm-6\">\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50f9679741c90656ffcb3b1bdf07ab9c61f78cc78976", async() => {
                    WriteLiteral("\r\n                                                Accept\r\n                                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "C:\Users\Naruto\source\repos\LeaveManagement\LeaveManagement\Views\Manager\Index.cshtml"
                                                                                 WriteLiteral(employee.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"col-sm-6\">\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50f9679741c90656ffcb3b1bdf07ab9c61f78cc711661", async() => {
                    WriteLiteral("\r\n                                                Reject\r\n                                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "C:\Users\Naruto\source\repos\LeaveManagement\LeaveManagement\Views\Manager\Index.cshtml"
                                                                                               WriteLiteral(employee.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2153, "return", 2153, 6, true);
                AddHtmlAttributeValue(" ", 2159, "confirm(\'Reject", 2160, 16, true);
#nullable restore
#line 48 "C:\Users\Naruto\source\repos\LeaveManagement\LeaveManagement\Views\Manager\Index.cshtml"
AddHtmlAttributeValue(" ", 2175, employee.UserName, 2176, 18, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue(" ", 2194, "request", 2195, 8, true);
                AddHtmlAttributeValue(" ", 2202, "?\')", 2203, 4, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 55 "C:\Users\Naruto\source\repos\LeaveManagement\LeaveManagement\Views\Manager\Index.cshtml"
                        }

                        else if (employee.LeaveRequest == "Accepted")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"card-header font-weight-bold text-center bg-success\">\r\n                                <h1 class=\"card-title font-weight-bold\">");
#nullable restore
#line 60 "C:\Users\Naruto\source\repos\LeaveManagement\LeaveManagement\Views\Manager\Index.cshtml"
                                                                   Write(employee.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                            </div>\r\n");
            WriteLiteral("                            <div class=\"card-footer text-center font-weight-bold\">\r\n                                <h5>Left!</h5>\r\n                            </div>\r\n");
#nullable restore
#line 66 "C:\Users\Naruto\source\repos\LeaveManagement\LeaveManagement\Views\Manager\Index.cshtml"
                        }

                        else if (employee.LeaveRequest == "Rejected")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"card-header font-weight-bold text-center bg-danger\">\r\n                                <h1 class=\"card-title font-weight-bold\">");
#nullable restore
#line 71 "C:\Users\Naruto\source\repos\LeaveManagement\LeaveManagement\Views\Manager\Index.cshtml"
                                                                   Write(employee.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                            </div>\r\n");
            WriteLiteral("                            <div class=\"card-footer text-center font-weight-bold\">\r\n                                <h5>Rejected</h5>\r\n                            </div>\r\n");
#nullable restore
#line 77 "C:\Users\Naruto\source\repos\LeaveManagement\LeaveManagement\Views\Manager\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 81 "C:\Users\Naruto\source\repos\LeaveManagement\LeaveManagement\Views\Manager\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n");
#nullable restore
#line 84 "C:\Users\Naruto\source\repos\LeaveManagement\LeaveManagement\Views\Manager\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1 class=\"text-center\">No Requests Available Yet!</h1>\r\n");
#nullable restore
#line 88 "C:\Users\Naruto\source\repos\LeaveManagement\LeaveManagement\Views\Manager\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ManagerViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
