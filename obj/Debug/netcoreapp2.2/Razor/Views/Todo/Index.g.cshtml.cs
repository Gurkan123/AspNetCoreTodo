#pragma checksum "C:\Users\Asus\spam\AspNetCoreTodo\Views\Todo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac4269918961dd4aa1ef8cab037182e47401495f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Todo_Index), @"mvc.1.0.view", @"/Views/Todo/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Todo/Index.cshtml", typeof(AspNetCore.Views_Todo_Index))]
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
#line 1 "C:\Users\Asus\spam\AspNetCoreTodo\Views\_ViewImports.cshtml"
using AspNetCoreTodo;

#line default
#line hidden
#line 2 "C:\Users\Asus\spam\AspNetCoreTodo\Views\_ViewImports.cshtml"
using AspNetCoreTodo.Models;

#line default
#line hidden
#line 2 "C:\Users\Asus\spam\AspNetCoreTodo\Views\Todo\Index.cshtml"
using Humanizer;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac4269918961dd4aa1ef8cab037182e47401495f", @"/Views/Todo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63823eaa5b73e495aebe7447edc96790f50c299d", @"/Views/_ViewImports.cshtml")]
    public class Views_Todo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TodoViewModel>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Asus\spam\AspNetCoreTodo\Views\Todo\Index.cshtml"
  
    ViewData["Title"] = "Yapılacaklar Listesini Yönet";

#line default
#line hidden
            BeginContext(108, 77, true);
            WriteLiteral("\r\n<div class=\"panel panel-default todo-panel\">\r\n  <div class=\"panel-heading\">");
            EndContext();
            BeginContext(186, 17, false);
#line 9 "C:\Users\Asus\spam\AspNetCoreTodo\Views\Todo\Index.cshtml"
                        Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(203, 203, true);
            WriteLiteral("</div>\r\n\r\n  <table class=\"table table-hover\">\r\n      <thead>\r\n          <tr>\r\n              <td>&#x2714;</td>\r\n              <td>Item</td>\r\n              <td>Due</td>\r\n          </tr>\r\n      </thead>\r\n\r\n");
            EndContext();
#line 20 "C:\Users\Asus\spam\AspNetCoreTodo\Views\Todo\Index.cshtml"
       foreach (var item in Model.Items)
      {

#line default
#line hidden
            BeginContext(457, 74, true);
            WriteLiteral("          <tr>\r\n              <td>\r\n                <input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 531, "\"", 546, 1);
#line 24 "C:\Users\Asus\spam\AspNetCoreTodo\Views\Todo\Index.cshtml"
WriteAttributeValue("", 538, item.Id, 538, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(547, 77, true);
            WriteLiteral(" value=\"true\" class=\"done-checkbox\">\r\n              </td>\r\n              <td>");
            EndContext();
            BeginContext(625, 10, false);
#line 26 "C:\Users\Asus\spam\AspNetCoreTodo\Views\Todo\Index.cshtml"
             Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(635, 25, true);
            WriteLiteral("</td>\r\n              <td>");
            EndContext();
            BeginContext(661, 21, false);
#line 27 "C:\Users\Asus\spam\AspNetCoreTodo\Views\Todo\Index.cshtml"
             Write(item.DueAt.Humanize());

#line default
#line hidden
            EndContext();
            BeginContext(682, 24, true);
            WriteLiteral("</td>\r\n          </tr>\r\n");
            EndContext();
#line 29 "C:\Users\Asus\spam\AspNetCoreTodo\Views\Todo\Index.cshtml"
      }

#line default
#line hidden
            BeginContext(715, 49, true);
            WriteLiteral("  </table>\r\n\r\n  <div class=\"add-item-form\">\r\n    ");
            EndContext();
            BeginContext(764, 292, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac4269918961dd4aa1ef8cab037182e47401495f6006", async() => {
                BeginContext(770, 279, true);
                WriteLiteral(@"
        <div id=""add-item-error"" class=""text-danger""></div>
        <label for=""add-item-title"">Add a new item:</label>
        <input id=""add-item-title"">
        <button type=""button"" id=""add-item-button"">Add</button>
        <input type=""date"" id=""datepicker""></p>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1056, 18, true);
            WriteLiteral("\r\n</div>\r\n\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TodoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
