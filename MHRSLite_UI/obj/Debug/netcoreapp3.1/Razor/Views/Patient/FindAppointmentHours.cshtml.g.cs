#pragma checksum "C:\Users\ŞeydaZenler\source\repos\MerkeziHekimRandevuSistemi\MHRSLite_UI\Views\Patient\FindAppointmentHours.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "046df8dd2122e3559853b8dc3a4ce4ca2df02e29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patient_FindAppointmentHours), @"mvc.1.0.view", @"/Views/Patient/FindAppointmentHours.cshtml")]
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
#line 1 "C:\Users\ŞeydaZenler\source\repos\MerkeziHekimRandevuSistemi\MHRSLite_UI\Views\_ViewImports.cshtml"
using MHRSLite_UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ŞeydaZenler\source\repos\MerkeziHekimRandevuSistemi\MHRSLite_UI\Views\_ViewImports.cshtml"
using MHRSLite_UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ŞeydaZenler\source\repos\MerkeziHekimRandevuSistemi\MHRSLite_UI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ŞeydaZenler\source\repos\MerkeziHekimRandevuSistemi\MHRSLite_UI\Views\_ViewImports.cshtml"
using MHRSLite_EL.IdentityModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ŞeydaZenler\source\repos\MerkeziHekimRandevuSistemi\MHRSLite_UI\Views\_ViewImports.cshtml"
using MHRSLite_EL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ŞeydaZenler\source\repos\MerkeziHekimRandevuSistemi\MHRSLite_UI\Views\_ViewImports.cshtml"
using MHRSLite_EL.PagingListModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"046df8dd2122e3559853b8dc3a4ce4ca2df02e29", @"/Views/Patient/FindAppointmentHours.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb3b1d17880c65c59eb0f7ffd39a17efce364c76", @"/Views/_ViewImports.cshtml")]
    public class Views_Patient_FindAppointmentHours : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AvailableDoctorAppointmentHoursViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Patient", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FindAppointment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\ŞeydaZenler\source\repos\MerkeziHekimRandevuSistemi\MHRSLite_UI\Views\Patient\FindAppointmentHours.cshtml"
  
    ViewData["Title"] = "FindAppointmentHours";
    Layout = "~/Views/Shared/_LayoutMHRS.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div style=""background-color:#ffffff; border-radius: 18px;"">
    <div class=""container-fluid"">
        <div class=""row"" style="" border-radius: 12px; padding: 30px; min-height: calc(100vh - 300px);"">
            <div class=""row col-md-12"" style=""font-size:20px"">
                <span>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "046df8dd2122e3559853b8dc3a4ce4ca2df02e295307", async() => {
                WriteLiteral("<i class=\"fa fa-arrow-left\" style=\"color:black\"></i>");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-cid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 10 "C:\Users\ŞeydaZenler\source\repos\MerkeziHekimRandevuSistemi\MHRSLite_UI\Views\Patient\FindAppointmentHours.cshtml"
                                                                                  WriteLiteral(TempData["ClinicId"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-cid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 10 "C:\Users\ŞeydaZenler\source\repos\MerkeziHekimRandevuSistemi\MHRSLite_UI\Views\Patient\FindAppointmentHours.cshtml"
                                                                                                                        WriteLiteral(TempData["HospitalId"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["hid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-hid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["hid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("&emsp;Randevu Al</span>\n");
            WriteLiteral("            </div>\n            <div class=\"row col-md-12\" style=\"font-size:20px\">\n                <span>&ensp;</span>\n                <span><b>Hekim:</b> ");
#nullable restore
#line 15 "C:\Users\ŞeydaZenler\source\repos\MerkeziHekimRandevuSistemi\MHRSLite_UI\Views\Patient\FindAppointmentHours.cshtml"
                               Write(ViewBag.Doctor);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>

            </div>

            <div class=""m-4"">
                <ul class=""nav nav-tabs"" id=""myTab"">

                    <li class=""nav-item"">
                        <a href=""#day"" class=""nav-link active"" data-bs-toggle=""tab"" style=""border-bottom: 2px solid blue;"">
                            ");
#nullable restore
#line 24 "C:\Users\ŞeydaZenler\source\repos\MerkeziHekimRandevuSistemi\MHRSLite_UI\Views\Patient\FindAppointmentHours.cshtml"
                       Write(DateTime.Now.AddDays(1).ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 24 "C:\Users\ŞeydaZenler\source\repos\MerkeziHekimRandevuSistemi\MHRSLite_UI\Views\Patient\FindAppointmentHours.cshtml"
                                                                      Write(DateTime.Now.AddDays(1).ToString("dddd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </a>\n                    </li>\n                </ul>\n                <div class=\"tab-content\">\n                    <div class=\"accordion\" id=\"myAccordion\">\n");
#nullable restore
#line 30 "C:\Users\ŞeydaZenler\source\repos\MerkeziHekimRandevuSistemi\MHRSLite_UI\Views\Patient\FindAppointmentHours.cshtml"
                          
                            byte sayac = 1;
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\ŞeydaZenler\source\repos\MerkeziHekimRandevuSistemi\MHRSLite_UI\Views\Patient\FindAppointmentHours.cshtml"
                         foreach (var item in Model)
                        {
                            if (item.Hours.Count == 0)
                            {
                                continue;
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"accordion-item\">\n\n                                <h2 class=\"accordion-header\"");
            BeginWriteAttribute("id", " id=\"", 1900, "\"", 1920, 2);
            WriteAttributeValue("", 1905, "heading", 1905, 7, true);
#nullable restore
#line 41 "C:\Users\ŞeydaZenler\source\repos\MerkeziHekimRandevuSistemi\MHRSLite_UI\Views\Patient\FindAppointmentHours.cshtml"
WriteAttributeValue("", 1912, sayac, 1912, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                    <button type=\"button\" class=\"accordion-button collapsed\" data-bs-toggle=\"collapse\"\n                                            data-bs-target=\"#collapse");
#nullable restore
#line 43 "C:\Users\ŞeydaZenler\source\repos\MerkeziHekimRandevuSistemi\MHRSLite_UI\Views\Patient\FindAppointmentHours.cshtml"
                                                                 Write(sayac);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" style=\"height:50px\">\n                                        ");
#nullable restore
#line 44 "C:\Users\ŞeydaZenler\source\repos\MerkeziHekimRandevuSistemi\MHRSLite_UI\Views\Patient\FindAppointmentHours.cshtml"
                                   Write(item.HourBase);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </button>\n                                </h2>\n                                <div");
            BeginWriteAttribute("id", " id=\"", 2317, "\"", 2338, 2);
            WriteAttributeValue("", 2322, "collapse", 2322, 8, true);
#nullable restore
#line 47 "C:\Users\ŞeydaZenler\source\repos\MerkeziHekimRandevuSistemi\MHRSLite_UI\Views\Patient\FindAppointmentHours.cshtml"
WriteAttributeValue("", 2330, sayac, 2330, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"accordion-collapse collapse\" data-bs-parent=\"#myAccordion\">\n                                    <div class=\"card-body\">\n");
#nullable restore
#line 49 "C:\Users\ŞeydaZenler\source\repos\MerkeziHekimRandevuSistemi\MHRSLite_UI\Views\Patient\FindAppointmentHours.cshtml"
                                         foreach (var subitem in item.Hours)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <button type=\"submit\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2651, "\"", 2807, 9);
            WriteAttributeValue("", 2661, "SaveAppointment(", 2661, 16, true);
#nullable restore
#line 51 "C:\Users\ŞeydaZenler\source\repos\MerkeziHekimRandevuSistemi\MHRSLite_UI\Views\Patient\FindAppointmentHours.cshtml"
WriteAttributeValue("", 2677, item.HospitalClinicId, 2677, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2699, ",", 2699, 1, true);
            WriteAttributeValue("\n                                               ", 2700, "\'", 2748, 49, true);
#nullable restore
#line 52 "C:\Users\ŞeydaZenler\source\repos\MerkeziHekimRandevuSistemi\MHRSLite_UI\Views\Patient\FindAppointmentHours.cshtml"
WriteAttributeValue("", 2749, DateTime.Now.AddDays(1).ToShortDateString(), 2749, 44, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2793, "\',", 2793, 2, true);
            WriteAttributeValue(" ", 2795, "\'", 2796, 2, true);
#nullable restore
#line 52 "C:\Users\ŞeydaZenler\source\repos\MerkeziHekimRandevuSistemi\MHRSLite_UI\Views\Patient\FindAppointmentHours.cshtml"
WriteAttributeValue("", 2797, subitem, 2797, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2805, "\')", 2805, 2, true);
            EndWriteAttribute();
            WriteLiteral("\n                                               class=\"btn btn-primary\" style=\"width:100px; color:white;\">\n                                                ");
#nullable restore
#line 54 "C:\Users\ŞeydaZenler\source\repos\MerkeziHekimRandevuSistemi\MHRSLite_UI\Views\Patient\FindAppointmentHours.cshtml"
                                           Write(subitem);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            </button>\n");
#nullable restore
#line 56 "C:\Users\ŞeydaZenler\source\repos\MerkeziHekimRandevuSistemi\MHRSLite_UI\Views\Patient\FindAppointmentHours.cshtml"

                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\n                                </div>\n                            </div>\n");
#nullable restore
#line 61 "C:\Users\ŞeydaZenler\source\repos\MerkeziHekimRandevuSistemi\MHRSLite_UI\Views\Patient\FindAppointmentHours.cshtml"
                            sayac++;
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        function SaveAppointment(hcid, date, hour) {
            Swal.fire({
                title: 'Randevu talebinizi onaylıyor musunuz?',
                showDenyButton: false,
                showCancelButton: true,
                confirmButtonText: 'Onayla',
                cancelButtonText: 'İptal Et',
            }).then((result) => {
                /* Read more about isConfirmed, isDenied below */
                if (result.isConfirmed) {
                    $.ajax({
                        type: 'GET',
                        url: '/Patient/SaveAppointment?hcid=' + hcid + '&date=' + date + '&hour=' + hour,
                        success: function (res) {
                            Swal.fire({
                                title: res.message,
                                showDenyButton: false,
                                showCancelButton: false,
                            }).then((result) => {
                                window.open(""/Patient/Index"", ""_self"")
          ");
                WriteLiteral(@"                  });
                        },
                        error: function (err) {
                            console.log(err, '', 'danger')
                        },
                    });
                }
            })
        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AvailableDoctorAppointmentHoursViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
