#pragma checksum "C:\Users\cmo\Desktop\SalesBudget\SalesBudget\SalesBudget\SalesBudget\Areas\Admin\Views\Budget\MonthlyDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38de00d3bfe6510b9d491fd0ae7cdd8255bf7b43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Budget_MonthlyDetails), @"mvc.1.0.view", @"/Areas/Admin/Views/Budget/MonthlyDetails.cshtml")]
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
#line 1 "C:\Users\cmo\Desktop\SalesBudget\SalesBudget\SalesBudget\SalesBudget\Areas\Admin\Views\_ViewImports.cshtml"
using SalesBudget;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cmo\Desktop\SalesBudget\SalesBudget\SalesBudget\SalesBudget\Areas\Admin\Views\_ViewImports.cshtml"
using SalesBudget.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38de00d3bfe6510b9d491fd0ae7cdd8255bf7b43", @"/Areas/Admin/Views/Budget/MonthlyDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07739f0a75adec7c5596496b396fcf72bf19dcb8", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Budget_MonthlyDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SalesBudget.Models.ViewModels.BudgetViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditMonthDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\cmo\Desktop\SalesBudget\SalesBudget\SalesBudget\SalesBudget\Areas\Admin\Views\Budget\MonthlyDetails.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "38de00d3bfe6510b9d491fd0ae7cdd8255bf7b435062", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 5 "C:\Users\cmo\Desktop\SalesBudget\SalesBudget\SalesBudget\SalesBudget\Areas\Admin\Views\Budget\MonthlyDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FBudget.BudgetId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral(@"

<br />
<h1 class=""text-primary"">Monthly Details</h1>


<br />
<table class=""table table-striped table-bordered"">
    <thead>
        <tr>
            <th>
                Customer
            </th>
            <th>
                Decription
            </th>
            <th>
                Curr
            </th>
            <th>
                FoC
            </th>
            <th>
                UM
            </th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>
                ");
#nullable restore
#line 37 "C:\Users\cmo\Desktop\SalesBudget\SalesBudget\SalesBudget\SalesBudget\Areas\Admin\Views\Budget\MonthlyDetails.cshtml"
           Write(Html.DisplayFor(Model => Model.FBudget.Customer.CustomerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\cmo\Desktop\SalesBudget\SalesBudget\SalesBudget\SalesBudget\Areas\Admin\Views\Budget\MonthlyDetails.cshtml"
           Write(Html.DisplayFor(Model => Model.FBudget.ItemMaster.ItemDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\cmo\Desktop\SalesBudget\SalesBudget\SalesBudget\SalesBudget\Areas\Admin\Views\Budget\MonthlyDetails.cshtml"
           Write(Html.DisplayFor(Model => Model.FBudget.Currency));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\cmo\Desktop\SalesBudget\SalesBudget\SalesBudget\SalesBudget\Areas\Admin\Views\Budget\MonthlyDetails.cshtml"
           Write(Html.DisplayFor(Model => Model.FBudget.FreeOfCharge));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\cmo\Desktop\SalesBudget\SalesBudget\SalesBudget\SalesBudget\Areas\Admin\Views\Budget\MonthlyDetails.cshtml"
           Write(Html.DisplayFor(Model => Model.FBudget.UnitOfMeasure));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </td>
        </tr>
    </tbody>
</table>


<br />
<table class=""table table-striped table-bordered"">
    <thead>
        <tr>
            <th>
                Jan
            </th>
            <th>
                Feb
            </th>
            <th>
                Mar
            </th>
            <th>
                Apr
            </th>
            <th>
                May
            </th>
            <th>
                Jun
            </th>
            <th>
                Jul
            </th>
            <th>
                Ago
            </th>
            <th>
                Sept
            </th>
            <th>
                Oct
            </th>
            <th>
                Nov
            </th>
            <th>
                Dec
            </th>
            <th>
                Total Amount
            </th>
            <th>
                Total by Months
            </th>
        </tr>
    </thead>
");
            WriteLiteral("    <tbody>\r\n        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 108 "C:\Users\cmo\Desktop\SalesBudget\SalesBudget\SalesBudget\SalesBudget\Areas\Admin\Views\Budget\MonthlyDetails.cshtml"
           Write(Html.DisplayFor(Model => Model.FBudget.Jan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 111 "C:\Users\cmo\Desktop\SalesBudget\SalesBudget\SalesBudget\SalesBudget\Areas\Admin\Views\Budget\MonthlyDetails.cshtml"
           Write(Html.DisplayFor(Model => Model.FBudget.Feb));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 114 "C:\Users\cmo\Desktop\SalesBudget\SalesBudget\SalesBudget\SalesBudget\Areas\Admin\Views\Budget\MonthlyDetails.cshtml"
           Write(Html.DisplayFor(Model => Model.FBudget.Mar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 117 "C:\Users\cmo\Desktop\SalesBudget\SalesBudget\SalesBudget\SalesBudget\Areas\Admin\Views\Budget\MonthlyDetails.cshtml"
           Write(Html.DisplayFor(Model => Model.FBudget.Apr));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 120 "C:\Users\cmo\Desktop\SalesBudget\SalesBudget\SalesBudget\SalesBudget\Areas\Admin\Views\Budget\MonthlyDetails.cshtml"
           Write(Html.DisplayFor(Model => Model.FBudget.May));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 123 "C:\Users\cmo\Desktop\SalesBudget\SalesBudget\SalesBudget\SalesBudget\Areas\Admin\Views\Budget\MonthlyDetails.cshtml"
           Write(Html.DisplayFor(Model => Model.FBudget.Jun));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 126 "C:\Users\cmo\Desktop\SalesBudget\SalesBudget\SalesBudget\SalesBudget\Areas\Admin\Views\Budget\MonthlyDetails.cshtml"
           Write(Html.DisplayFor(Model => Model.FBudget.Jul));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 129 "C:\Users\cmo\Desktop\SalesBudget\SalesBudget\SalesBudget\SalesBudget\Areas\Admin\Views\Budget\MonthlyDetails.cshtml"
           Write(Html.DisplayFor(Model => Model.FBudget.Ago));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 132 "C:\Users\cmo\Desktop\SalesBudget\SalesBudget\SalesBudget\SalesBudget\Areas\Admin\Views\Budget\MonthlyDetails.cshtml"
           Write(Html.DisplayFor(Model => Model.FBudget.Sept));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 135 "C:\Users\cmo\Desktop\SalesBudget\SalesBudget\SalesBudget\SalesBudget\Areas\Admin\Views\Budget\MonthlyDetails.cshtml"
           Write(Html.DisplayFor(Model => Model.FBudget.Oct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 138 "C:\Users\cmo\Desktop\SalesBudget\SalesBudget\SalesBudget\SalesBudget\Areas\Admin\Views\Budget\MonthlyDetails.cshtml"
           Write(Html.DisplayFor(Model => Model.FBudget.Nov));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 141 "C:\Users\cmo\Desktop\SalesBudget\SalesBudget\SalesBudget\SalesBudget\Areas\Admin\Views\Budget\MonthlyDetails.cshtml"
           Write(Html.DisplayFor(Model => Model.FBudget.Dec));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 144 "C:\Users\cmo\Desktop\SalesBudget\SalesBudget\SalesBudget\SalesBudget\Areas\Admin\Views\Budget\MonthlyDetails.cshtml"
           Write(Html.DisplayFor(Model => Model.FBudget.TotalAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 147 "C:\Users\cmo\Desktop\SalesBudget\SalesBudget\SalesBudget\SalesBudget\Areas\Admin\Views\Budget\MonthlyDetails.cshtml"
           Write(Html.DisplayFor(Model => Model.FBudget.TotalMonths));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38de00d3bfe6510b9d491fd0ae7cdd8255bf7b4315209", async() => {
                WriteLiteral("<i class=\"fas fa-edit\"></i> Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 155 "C:\Users\cmo\Desktop\SalesBudget\SalesBudget\SalesBudget\SalesBudget\Areas\Admin\Views\Budget\MonthlyDetails.cshtml"
                                      WriteLiteral(Model.FBudget.BudgetId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n<br />\r\n\r\n");
            WriteLiteral(@"<a class=""btn btn-danger"" onClick=""window.close()""><i class=""fas fa-times""></i> Close page</a>
<a class=""btn btn-success float-end"" onClick=""document.location.reload(true)""><i class=""fas fa-sync-alt""></i> &nbsp; Refresh page</a>


<br />
<br />




");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SalesBudget.Models.ViewModels.BudgetViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
