#pragma checksum "C:\Vikas\Development\eAM-Medical-Amit\eAM-Medical\Views\Shared\ActionView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92f80adce58725608cf593c2367c7cf27fd9fa9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ActionView), @"mvc.1.0.view", @"/Views/Shared/ActionView.cshtml")]
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
#line 1 "C:\Vikas\Development\eAM-Medical-Amit\eAM-Medical\Views\_ViewImports.cshtml"
using eAM_Medical;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Vikas\Development\eAM-Medical-Amit\eAM-Medical\Views\_ViewImports.cshtml"
using eAM_Medical.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92f80adce58725608cf593c2367c7cf27fd9fa9a", @"/Views/Shared/ActionView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15b21051a1f233d4a2f8423c7208264cba2ddbb3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ActionView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
 <div class=""col-xl-4 col-md-6 col-12"">

  <button  class=""btn btn-primary waves-effect waves-float waves-light"" type=""submit"">Save</button>

  <button class=""btn btn-success waves-effect waves-float waves-light"" type=""submit"">Search</button>

  <button class=""btn btn-danger waves-effect waves-float waves-light"" type=""submit"">Delete</button>

  <button class=""btn btn-warning waves-effect waves-float waves-light"" id=""position-bottom-end"" type=""submit"">Clear</button>

 </div>
</div>
");
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
