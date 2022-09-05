#pragma checksum "E:\Workspace-E\Source code\EmployeeManagementProject\Test\Web\Test\Web\Views\Notification\SendNotificationToSpecificUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9abf6bf53d208864bad54e295b526910e8a5fb23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Notification_SendNotificationToSpecificUser), @"mvc.1.0.view", @"/Views/Notification/SendNotificationToSpecificUser.cshtml")]
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
#line 1 "E:\Workspace-E\Source code\EmployeeManagementProject\Test\Web\Test\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Workspace-E\Source code\EmployeeManagementProject\Test\Web\Test\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9abf6bf53d208864bad54e295b526910e8a5fb23", @"/Views/Notification/SendNotificationToSpecificUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_Notification_SendNotificationToSpecificUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web.Models.Notification>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Workspace-E\Source code\EmployeeManagementProject\Test\Web\Test\Web\Views\Notification\SendNotificationToSpecificUser.cshtml"
  
    ViewData["Title"] = "SendNotificationToSpecificUser";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-xl px-4 mt-4"">

    <hr class=""mt-0 mb-4"">
    <div class=""row"">
        <div class=""col-xl-12"">
        </div>
        <div class=""col-xl-8"">
            <!-- Account details card-->
            <div class=""card mb-4"">
                <div class=""card-header""> Send Notification To Specific User</div>
                <div class=""card-body"">
");
#nullable restore
#line 22 "E:\Workspace-E\Source code\EmployeeManagementProject\Test\Web\Test\Web\Views\Notification\SendNotificationToSpecificUser.cshtml"
                     using (Html.BeginForm("SendNotificationToSpecificUser", "Notification", FormMethod.Post))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <fieldset>
                            <!-- Form Group (username)-->
                            <div class=""mb-3"">
                                <label class=""small mb-1"">Title Notification</label>
                                ");
#nullable restore
#line 28 "E:\Workspace-E\Source code\EmployeeManagementProject\Test\Web\Test\Web\Views\Notification\SendNotificationToSpecificUser.cshtml"
                           Write(Html.TextBoxFor(model => model.Title, new { @class = "form-control", required = "required", placeholder = "Enter Title Of Notification..." }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                            <!-- Form Row-->
                            <div class=""mb-3"">
                                <!-- Form Group (first name)-->
                                <label class=""small mb-1"">Content Notification</label>
                                ");
#nullable restore
#line 34 "E:\Workspace-E\Source code\EmployeeManagementProject\Test\Web\Test\Web\Views\Notification\SendNotificationToSpecificUser.cshtml"
                           Write(Html.TextAreaFor(model => model.Content, new { @class = "form-control", required = "required", placeholder = "Enter Message Content..." }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <!-- Form Group (last name)-->\r\n                            </div>\r\n\r\n");
#nullable restore
#line 38 "E:\Workspace-E\Source code\EmployeeManagementProject\Test\Web\Test\Web\Views\Notification\SendNotificationToSpecificUser.cshtml"
                              
                                var list = ViewBag.listUsername;
                                if (list != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"mb-3\">\r\n                                        <label class=\"small mb-1\">Send To?</label>\r\n                                        ");
#nullable restore
#line 44 "E:\Workspace-E\Source code\EmployeeManagementProject\Test\Web\Test\Web\Views\Notification\SendNotificationToSpecificUser.cshtml"
                                   Write(Html.DropDownListFor(model => model.Reciver, new SelectList(list), "----- Select -----", new { @class = "form-control " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n");
#nullable restore
#line 46 "E:\Workspace-E\Source code\EmployeeManagementProject\Test\Web\Test\Web\Views\Notification\SendNotificationToSpecificUser.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button type=\"submit\" class=\"btn btn-primary btn-user btn-block\">\r\n                                Send\r\n                            </button>\r\n                        </fieldset>\r\n");
#nullable restore
#line 52 "E:\Workspace-E\Source code\EmployeeManagementProject\Test\Web\Test\Web\Views\Notification\SendNotificationToSpecificUser.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web.Models.Notification> Html { get; private set; }
    }
}
#pragma warning restore 1591