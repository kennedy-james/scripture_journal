#pragma checksum "D:\Documents\GitHub\Repositories\scripture_journal\ScriptureJournal\ScriptureJournal\Pages\JournalEntries\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67c85ba4665e8a905319903717c5ca3d95eec06b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ScriptureJournal.Pages.JournalEntries.Pages_JournalEntries_Details), @"mvc.1.0.razor-page", @"/Pages/JournalEntries/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/JournalEntries/Details.cshtml", typeof(ScriptureJournal.Pages.JournalEntries.Pages_JournalEntries_Details), null)]
namespace ScriptureJournal.Pages.JournalEntries
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Documents\GitHub\Repositories\scripture_journal\ScriptureJournal\ScriptureJournal\Pages\_ViewImports.cshtml"
using ScriptureJournal;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67c85ba4665e8a905319903717c5ca3d95eec06b", @"/Pages/JournalEntries/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b573786b2bad9084fc74df0bab3e17f9201a3a22", @"/Pages/_ViewImports.cshtml")]
    public class Pages_JournalEntries_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(66, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\Documents\GitHub\Repositories\scripture_journal\ScriptureJournal\ScriptureJournal\Pages\JournalEntries\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(111, 126, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>JournalEntry</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(238, 53, false);
#line 15 "D:\Documents\GitHub\Repositories\scripture_journal\ScriptureJournal\ScriptureJournal\Pages\JournalEntries\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.JournalEntry.Book));

#line default
#line hidden
            EndContext();
            BeginContext(291, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(335, 49, false);
#line 18 "D:\Documents\GitHub\Repositories\scripture_journal\ScriptureJournal\ScriptureJournal\Pages\JournalEntries\Details.cshtml"
       Write(Html.DisplayFor(model => model.JournalEntry.Book));

#line default
#line hidden
            EndContext();
            BeginContext(384, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(428, 56, false);
#line 21 "D:\Documents\GitHub\Repositories\scripture_journal\ScriptureJournal\ScriptureJournal\Pages\JournalEntries\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.JournalEntry.Chapter));

#line default
#line hidden
            EndContext();
            BeginContext(484, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(528, 52, false);
#line 24 "D:\Documents\GitHub\Repositories\scripture_journal\ScriptureJournal\ScriptureJournal\Pages\JournalEntries\Details.cshtml"
       Write(Html.DisplayFor(model => model.JournalEntry.Chapter));

#line default
#line hidden
            EndContext();
            BeginContext(580, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(624, 54, false);
#line 27 "D:\Documents\GitHub\Repositories\scripture_journal\ScriptureJournal\ScriptureJournal\Pages\JournalEntries\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.JournalEntry.Verse));

#line default
#line hidden
            EndContext();
            BeginContext(678, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(722, 50, false);
#line 30 "D:\Documents\GitHub\Repositories\scripture_journal\ScriptureJournal\ScriptureJournal\Pages\JournalEntries\Details.cshtml"
       Write(Html.DisplayFor(model => model.JournalEntry.Verse));

#line default
#line hidden
            EndContext();
            BeginContext(772, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(816, 54, false);
#line 33 "D:\Documents\GitHub\Repositories\scripture_journal\ScriptureJournal\ScriptureJournal\Pages\JournalEntries\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.JournalEntry.Notes));

#line default
#line hidden
            EndContext();
            BeginContext(870, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(914, 50, false);
#line 36 "D:\Documents\GitHub\Repositories\scripture_journal\ScriptureJournal\ScriptureJournal\Pages\JournalEntries\Details.cshtml"
       Write(Html.DisplayFor(model => model.JournalEntry.Notes));

#line default
#line hidden
            EndContext();
            BeginContext(964, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1008, 58, false);
#line 39 "D:\Documents\GitHub\Repositories\scripture_journal\ScriptureJournal\ScriptureJournal\Pages\JournalEntries\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.JournalEntry.DateAdded));

#line default
#line hidden
            EndContext();
            BeginContext(1066, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1110, 54, false);
#line 42 "D:\Documents\GitHub\Repositories\scripture_journal\ScriptureJournal\ScriptureJournal\Pages\JournalEntries\Details.cshtml"
       Write(Html.DisplayFor(model => model.JournalEntry.DateAdded));

#line default
#line hidden
            EndContext();
            BeginContext(1164, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1211, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c66918c22804087bc2e0057474697bd", async() => {
                BeginContext(1270, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 47 "D:\Documents\GitHub\Repositories\scripture_journal\ScriptureJournal\ScriptureJournal\Pages\JournalEntries\Details.cshtml"
                           WriteLiteral(Model.JournalEntry.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1278, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1286, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f726ffaf404140aca772f02069bb7135", async() => {
                BeginContext(1308, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1324, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ScriptureJournal.Pages.JournalEntries.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ScriptureJournal.Pages.JournalEntries.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ScriptureJournal.Pages.JournalEntries.DetailsModel>)PageContext?.ViewData;
        public ScriptureJournal.Pages.JournalEntries.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
