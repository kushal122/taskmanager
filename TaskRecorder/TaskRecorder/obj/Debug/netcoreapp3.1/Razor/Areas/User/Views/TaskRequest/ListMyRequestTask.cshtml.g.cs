#pragma checksum "D:\Projects\Activity Tracking Module\TaskRecordingModule\TaskRecorder\TaskRecorder\Areas\User\Views\TaskRequest\ListMyRequestTask.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9ef8b906de6a5c86f519f2cd003d511229848a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_TaskRequest_ListMyRequestTask), @"mvc.1.0.view", @"/Areas/User/Views/TaskRequest/ListMyRequestTask.cshtml")]
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
#line 1 "D:\Projects\Activity Tracking Module\TaskRecordingModule\TaskRecorder\TaskRecorder\Areas\User\Views\_ViewImports.cshtml"
using TaskRecorder;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9ef8b906de6a5c86f519f2cd003d511229848a8", @"/Areas/User/Views/TaskRequest/ListMyRequestTask.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"131a1ef35d3e6b5b42f90d5e0bbad8085bd072fa", @"/Areas/User/Views/_ViewImports.cshtml")]
    public class Areas_User_Views_TaskRequest_ListMyRequestTask : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TaskRecorder_DataModels.Models.TaskRequest>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "TaskRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Projects\Activity Tracking Module\TaskRecordingModule\TaskRecorder\TaskRecorder\Areas\User\Views\TaskRequest\ListMyRequestTask.cshtml"
  
    ViewData["Title"] = "ListMyRequestTask";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\" style=\"padding:50px\">\r\n    <div class=\"row\">\r\n        <div class=\"col-6\">\r\n            <h2 class=\"text-info\">Task List</h2>\r\n        </div>\r\n    </div>\r\n    <br />\r\n");
#nullable restore
#line 14 "D:\Projects\Activity Tracking Module\TaskRecordingModule\TaskRecorder\TaskRecorder\Areas\User\Views\TaskRequest\ListMyRequestTask.cshtml"
     if (Model.Any())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1 class=\"text-center text-danger\"> ");
#nullable restore
#line 16 "D:\Projects\Activity Tracking Module\TaskRecordingModule\TaskRecorder\TaskRecorder\Areas\User\Views\TaskRequest\ListMyRequestTask.cshtml"
                                        Write(ViewBag.Error);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
        <div>
            <table class=""table table-striped border"">
                <tr class=""table-info"">
                    <th>
                        RequestId
                    </th>
                    <th>
                        TaskId
                    </th>
                    <th>
                        RequestDate
                    </th>
                    <th>
                        DeadLine
                    </th>
                    <th>
                        Status
                    </th>
                    <th>
                        UserId
                    </th>
                    <th>
                        Description
                    </th>
                    <th>Action</th>
                </tr>
");
#nullable restore
#line 43 "D:\Projects\Activity Tracking Module\TaskRecordingModule\TaskRecorder\TaskRecorder\Areas\User\Views\TaskRequest\ListMyRequestTask.cshtml"
                 foreach (var task in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 46 "D:\Projects\Activity Tracking Module\TaskRecordingModule\TaskRecorder\TaskRecorder\Areas\User\Views\TaskRequest\ListMyRequestTask.cshtml"
                       Write(task.RequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 47 "D:\Projects\Activity Tracking Module\TaskRecordingModule\TaskRecorder\TaskRecorder\Areas\User\Views\TaskRequest\ListMyRequestTask.cshtml"
                       Write(task.TaskId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 48 "D:\Projects\Activity Tracking Module\TaskRecordingModule\TaskRecorder\TaskRecorder\Areas\User\Views\TaskRequest\ListMyRequestTask.cshtml"
                       Write(task.RequestDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 49 "D:\Projects\Activity Tracking Module\TaskRecordingModule\TaskRecorder\TaskRecorder\Areas\User\Views\TaskRequest\ListMyRequestTask.cshtml"
                       Write(task.DeadLine);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 50 "D:\Projects\Activity Tracking Module\TaskRecordingModule\TaskRecorder\TaskRecorder\Areas\User\Views\TaskRequest\ListMyRequestTask.cshtml"
                       Write(task.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 51 "D:\Projects\Activity Tracking Module\TaskRecordingModule\TaskRecorder\TaskRecorder\Areas\User\Views\TaskRequest\ListMyRequestTask.cshtml"
                       Write(task.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 52 "D:\Projects\Activity Tracking Module\TaskRecordingModule\TaskRecorder\TaskRecorder\Areas\User\Views\TaskRequest\ListMyRequestTask.cshtml"
                       Write(task.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        <td>\r\n                            <div class=\"btn-group\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9ef8b906de6a5c86f519f2cd003d511229848a88872", async() => {
                WriteLiteral("\r\n                                    Detail\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-taskId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "D:\Projects\Activity Tracking Module\TaskRecordingModule\TaskRecorder\TaskRecorder\Areas\User\Views\TaskRequest\ListMyRequestTask.cshtml"
                                                                                           WriteLiteral(task.TaskId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["taskId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-taskId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["taskId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 62 "D:\Projects\Activity Tracking Module\TaskRecordingModule\TaskRecorder\TaskRecorder\Areas\User\Views\TaskRequest\ListMyRequestTask.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n        </div>\r\n");
#nullable restore
#line 65 "D:\Projects\Activity Tracking Module\TaskRecordingModule\TaskRecorder\TaskRecorder\Areas\User\Views\TaskRequest\ListMyRequestTask.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\">\r\n            <div class=\"card-header\">\r\n                No Task created yet\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 73 "D:\Projects\Activity Tracking Module\TaskRecordingModule\TaskRecorder\TaskRecorder\Areas\User\Views\TaskRequest\ListMyRequestTask.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TaskRecorder_DataModels.Models.TaskRequest>> Html { get; private set; }
    }
}
#pragma warning restore 1591
