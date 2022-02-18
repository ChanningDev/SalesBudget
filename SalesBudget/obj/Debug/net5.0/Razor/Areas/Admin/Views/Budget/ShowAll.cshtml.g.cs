#pragma checksum "C:\Users\cmo\Desktop\SalesBudget\SalesBudget\SalesBudget\SalesBudget\Areas\Admin\Views\Budget\ShowAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3908e6be1053b1228a5d19e901d31683679df2eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Budget_ShowAll), @"mvc.1.0.view", @"/Areas/Admin/Views/Budget/ShowAll.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3908e6be1053b1228a5d19e901d31683679df2eb", @"/Areas/Admin/Views/Budget/ShowAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07739f0a75adec7c5596496b396fcf72bf19dcb8", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Budget_ShowAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SalesBudget.Models.ViewModels.BudgetViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Upsert", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MonthlyDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("hiddenBudgetId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\cmo\Desktop\SalesBudget\SalesBudget\SalesBudget\SalesBudget\Areas\Admin\Views\Budget\ShowAll.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <h2 class=\"text-primary\">All Rows</h2>\r\n    </div>\r\n</div>\r\n\r\n\r\n<br />\r\n<table class=\"table table-striped table-bordered\"");
            BeginWriteAttribute("id", " id=\"", 293, "\"", 298, 0);
            EndWriteAttribute();
            WriteLiteral(@">
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
            <th>
                Price
            </th>
            <th>
                Quantity
            </th>
            <th>
                Total amount
            </th>
            <th>
                Action
            </th>
        </tr>
    </thead>

    <tbody>

");
#nullable restore
#line 51 "C:\Users\cmo\Desktop\SalesBudget\SalesBudget\SalesBudget\SalesBudget\Areas\Admin\Views\Budget\ShowAll.cshtml"
         foreach (var item in Model.RecordsList)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "C:\Users\cmo\Desktop\SalesBudget\SalesBudget\SalesBudget\SalesBudget\Areas\Admin\Views\Budget\ShowAll.cshtml"
               Write(Html.DisplayFor(modelItem => item.Customer.CustomerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 59 "C:\Users\cmo\Desktop\SalesBudget\SalesBudget\SalesBudget\SalesBudget\Areas\Admin\Views\Budget\ShowAll.cshtml"
               Write(Html.DisplayFor(modelItem => item.ItemMaster.ItemDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 62 "C:\Users\cmo\Desktop\SalesBudget\SalesBudget\SalesBudget\SalesBudget\Areas\Admin\Views\Budget\ShowAll.cshtml"
               Write(Html.DisplayFor(modelItem => item.Currency));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 65 "C:\Users\cmo\Desktop\SalesBudget\SalesBudget\SalesBudget\SalesBudget\Areas\Admin\Views\Budget\ShowAll.cshtml"
               Write(Html.DisplayFor(modelItem => item.FreeOfCharge));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 68 "C:\Users\cmo\Desktop\SalesBudget\SalesBudget\SalesBudget\SalesBudget\Areas\Admin\Views\Budget\ShowAll.cshtml"
               Write(Html.DisplayFor(modelItem => item.UnitOfMeasure));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 71 "C:\Users\cmo\Desktop\SalesBudget\SalesBudget\SalesBudget\SalesBudget\Areas\Admin\Views\Budget\ShowAll.cshtml"
               Write(Html.DisplayFor(modelItem => item.UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 74 "C:\Users\cmo\Desktop\SalesBudget\SalesBudget\SalesBudget\SalesBudget\Areas\Admin\Views\Budget\ShowAll.cshtml"
               Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 77 "C:\Users\cmo\Desktop\SalesBudget\SalesBudget\SalesBudget\SalesBudget\Areas\Admin\Views\Budget\ShowAll.cshtml"
               Write(Html.DisplayFor(modelItem => item.TotalAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n\r\n");
            WriteLiteral("                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3908e6be1053b1228a5d19e901d31683679df2eb9979", async() => {
                WriteLiteral("<i class=\"fa fa-pencil-square-o\" aria-hidden=\"true\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 83 "C:\Users\cmo\Desktop\SalesBudget\SalesBudget\SalesBudget\SalesBudget\Areas\Admin\Views\Budget\ShowAll.cshtml"
                                             WriteLiteral(item.BudgetId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2201, "\"", 2240, 3);
            WriteAttributeValue("", 2211, "ConfirmDelete(", 2211, 14, true);
#nullable restore
#line 84 "C:\Users\cmo\Desktop\SalesBudget\SalesBudget\SalesBudget\SalesBudget\Areas\Admin\Views\Budget\ShowAll.cshtml"
WriteAttributeValue("", 2225, item.BudgetId, 2225, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2239, ")", 2239, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\"><i class=\"fa fa-trash-o\" aria-hidden=\"true\"></i></a>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3908e6be1053b1228a5d19e901d31683679df2eb12987", async() => {
                WriteLiteral("<i class=\"fa fa-calendar\" aria-hidden=\"true\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 85 "C:\Users\cmo\Desktop\SalesBudget\SalesBudget\SalesBudget\SalesBudget\Areas\Admin\Views\Budget\ShowAll.cshtml"
                                                     WriteLiteral(item.BudgetId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 89 "C:\Users\cmo\Desktop\SalesBudget\SalesBudget\SalesBudget\SalesBudget\Areas\Admin\Views\Budget\ShowAll.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n\r\n</table>\r\n\r\n");
            WriteLiteral(@"
<div class=""modal fade"" id=""myModal"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <a href=""#"" class=""close"" data-dismiss=""modal"">&times;</a>
                <h3 class=""modal-title"">Delete Budget</h3>
            </div>
            <div class=""modal-body"">
                <h4>Are you sure you want to Remove this Budget?</h4>
            </div>
            <div class=""modal-footer"">
                <a href=""#"" class=""btn btn-default"" data-dismiss=""modal"">Cancel</a>
                <a href=""#"" class=""btn btn-success"" onclick=""DeleteBudget()"">Confirm</a>
            </div>
        </div>
    </div>
</div>


");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3908e6be1053b1228a5d19e901d31683679df2eb16441", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 117 "C:\Users\cmo\Desktop\SalesBudget\SalesBudget\SalesBudget\SalesBudget\Areas\Admin\Views\Budget\ShowAll.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FBudget.BudgetId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        var ConfirmDelete = function (BudgetId) {

            $(""#hiddenBudgetId"").val(BudgetId);
            $(""#myModal"").modal('show');

        }

        var DeleteBudget = function () {

            var bdgId = $(""#hiddenBudgetId"").val();

            $.ajax
                ({
                    type: ""POST"",
                    url: ""/Admin/budget/Delete/"",
                    data: { Id: bdgId },
                    success: function (result) {
                        $(""#myModal"").modal(""hide"");
                        $(""#row_"" + bdgId).remove();
                        window.location.reload();
                    }
                })
        }

    </script>
");
            }
            );
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