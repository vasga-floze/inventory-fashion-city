#pragma checksum "C:\Users\gabri\source\repos\inventory-fashion-city\inventory-fashion-city\Pages\Products.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "959dd71ef7f149aebea40d3496f713a75be3e752"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(inventory_fashion_city.Pages.Pages_Products), @"mvc.1.0.razor-page", @"/Pages/Products.cshtml")]
namespace inventory_fashion_city.Pages
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
#line 1 "C:\Users\gabri\source\repos\inventory-fashion-city\inventory-fashion-city\Pages\_ViewImports.cshtml"
using inventory_fashion_city;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"959dd71ef7f149aebea40d3496f713a75be3e752", @"/Pages/Products.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0512090f8eeb3653d4f94dd0ea5f174a5ec33d8f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Products : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("disabled", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\gabri\source\repos\inventory-fashion-city\inventory-fashion-city\Pages\Products.cshtml"
  
    Layout = "~/Pages/Shared/_LayoutNav.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- pageContent -->
<section class=""full-width pageContent"">
    <section class=""full-width header-well"">
        <div class=""full-width header-well-icon"">
            <i class=""zmdi zmdi-washing-machine""></i>
        </div>
        <div class=""full-width header-well-text"">
            <p class=""text-condensedLight"">
                Lorem ipsum dolor sit amet, consectetur adipisicing elit. Unde aut nulla accusantium minus corporis accusamus fuga harum natus molestias necessitatibus.
            </p>
        </div>
    </section>
    <div class=""mdl-tabs mdl-js-tabs mdl-js-ripple-effect"">
        <div class=""mdl-tabs__tab-bar"">
            <a href=""#tabNewProduct"" class=""mdl-tabs__tab is-active"">NEW</a>
            <a href=""#tabListProducts"" class=""mdl-tabs__tab"">LIST</a>
        </div>
        <div class=""mdl-tabs__panel is-active"" id=""tabNewProduct"">
            <div class=""mdl-grid"">
                <div class=""mdl-cell mdl-cell--4-col-phone mdl-cell--8-col-tablet mdl-cell--12-col-desk");
            WriteLiteral(@"top"">
                    <div class=""full-width panel mdl-shadow--2dp"">
                        <div class=""full-width panel-tittle bg-primary text-center tittles"">
                            New Product
                        </div>
                        <div class=""full-width panel-content"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "959dd71ef7f149aebea40d3496f713a75be3e7526205", async() => {
                WriteLiteral(@"
                                <div class=""mdl-grid"">
                                    <div class=""mdl-cell mdl-cell--4-col-phone mdl-cell--8-col-tablet mdl-cell--6-col-desktop"">
                                        <h5 class=""text-condensedLight"">Basic Information</h5>
                                        <div class=""mdl-textfield mdl-js-textfield mdl-textfield--floating-label"">
                                            <input class=""mdl-textfield__input"" type=""number"" pattern=""-?[0-9- ]*(\.[0-9]+)?"" id=""BarCode"">
                                            <label class=""mdl-textfield__label"" for=""BarCode"">Barcode</label>
                                            <span class=""mdl-textfield__error"">Invalid barcode</span>
                                        </div>
                                        <div class=""mdl-textfield mdl-js-textfield mdl-textfield--floating-label"">
                                            <input class=""mdl-textfield__input"" type=""text"" pattern=""-?[A-");
                WriteLiteral(@"Za-z0-9áéíóúÁÉÍÓÚ ]*(\.[0-9]+)?"" id=""NameProduct"">
                                            <label class=""mdl-textfield__label"" for=""NameProduct"">Name</label>
                                            <span class=""mdl-textfield__error"">Invalid name</span>
                                        </div>
                                        <div class=""mdl-textfield mdl-js-textfield"">
                                            <select class=""mdl-textfield__input"">
                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "959dd71ef7f149aebea40d3496f713a75be3e7528091", async() => {
                    WriteLiteral("Select category");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "959dd71ef7f149aebea40d3496f713a75be3e7529545", async() => {
                    WriteLiteral("Category 1");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "959dd71ef7f149aebea40d3496f713a75be3e75210820", async() => {
                    WriteLiteral("Category 2");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                            </select>
                                        </div>
                                        <h5 class=""text-condensedLight"">Units and Price</h5>
                                        <div class=""mdl-textfield mdl-js-textfield mdl-textfield--floating-label"">
                                            <input class=""mdl-textfield__input"" type=""number"" pattern=""-?[0-9]*(\.[0-9]+)?"" id=""StrockProduct"">
                                            <label class=""mdl-textfield__label"" for=""StrockProduct"">Units</label>
                                            <span class=""mdl-textfield__error"">Invalid number</span>
                                        </div>
                                        <div class=""mdl-textfield mdl-js-textfield mdl-textfield--floating-label"">
                                            <input class=""mdl-textfield__input"" type=""text"" pattern=""-?[0-9.]*(\.[0-9]+)?"" id=""PriceProduct"">
                                        ");
                WriteLiteral(@"    <label class=""mdl-textfield__label"" for=""PriceProduct"">Price</label>
                                            <span class=""mdl-textfield__error"">Invalid price</span>
                                        </div>
                                        <div class=""mdl-textfield mdl-js-textfield mdl-textfield--floating-label"">
                                            <input class=""mdl-textfield__input"" type=""number"" pattern=""-?[0-9]*(\.[0-9]+)?"" id=""discountProduct"">
                                            <label class=""mdl-textfield__label"" for=""discountProduct"">% Discount</label>
                                            <span class=""mdl-textfield__error"">Invalid discount</span>
                                        </div>
                                    </div>
                                    <div class=""mdl-cell mdl-cell--4-col-phone mdl-cell--8-col-tablet mdl-cell--6-col-desktop"">
                                        <h5 class=""text-condensedLight"">Supplier data and m");
                WriteLiteral("odel</h5>\r\n                                        <div class=\"mdl-textfield mdl-js-textfield\">\r\n                                            <select class=\"mdl-textfield__input\">\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "959dd71ef7f149aebea40d3496f713a75be3e75214456", async() => {
                    WriteLiteral("Select provider");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "959dd71ef7f149aebea40d3496f713a75be3e75215911", async() => {
                    WriteLiteral("Provider 1");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "959dd71ef7f149aebea40d3496f713a75be3e75217187", async() => {
                    WriteLiteral("Provider 2");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                            </select>
                                        </div>
                                        <div class=""mdl-textfield mdl-js-textfield mdl-textfield--floating-label"">
                                            <input class=""mdl-textfield__input"" type=""text"" id=""modelProduct"">
                                            <label class=""mdl-textfield__label"" for=""modelProduct"">Model</label>
                                            <span class=""mdl-textfield__error"">Invalid model</span>
                                        </div>
                                        <div class=""mdl-textfield mdl-js-textfield mdl-textfield--floating-label"">
                                            <input class=""mdl-textfield__input"" type=""text"" id=""markProduct"">
                                            <label class=""mdl-textfield__label"" for=""markProduct"">Mark</label>
                                            <span class=""mdl-textfield__error"">Invalid Ma");
                WriteLiteral(@"rk</span>
                                        </div>
                                        <h5 class=""text-condensedLight"">Other Data</h5>
                                        <div class=""mdl-textfield mdl-js-textfield"">
                                            <input type=""date"" class=""mdl-textfield__input"">
                                        </div>
                                        <div class=""mdl-textfield mdl-js-textfield"">
                                            <select class=""mdl-textfield__input"">
                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "959dd71ef7f149aebea40d3496f713a75be3e75220105", async() => {
                    WriteLiteral("Select status");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "959dd71ef7f149aebea40d3496f713a75be3e75221558", async() => {
                    WriteLiteral("Active");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "959dd71ef7f149aebea40d3496f713a75be3e75222830", async() => {
                    WriteLiteral("deactivated");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                            </select>
                                        </div>
                                        <div class=""mdl-textfield mdl-js-textfield"">
                                            <input type=""file"">
                                        </div>
                                    </div>
                                </div>
                                <p class=""text-center"">
                                    <button class=""mdl-button mdl-js-button mdl-button--fab mdl-js-ripple-effect mdl-button--colored bg-primary"" id=""btn-addProduct"">
                                        <i class=""zmdi zmdi-plus""></i>
                                    </button>
                                    <div class=""mdl-tooltip"" for=""btn-addProduct"">Add Product</div>
                                </p>
                            ");
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
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""mdl-tabs__panel"" id=""tabListProducts"">
            <div class=""mdl-grid"">
                <div class=""mdl-cell mdl-cell--4-col-phone mdl-cell--8-col-tablet mdl-cell--12-col-desktop"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "959dd71ef7f149aebea40d3496f713a75be3e75226296", async() => {
                WriteLiteral(@"
                        <div class=""mdl-textfield mdl-js-textfield mdl-textfield--expandable"">
                            <label class=""mdl-button mdl-js-button mdl-button--icon"" for=""searchProduct"">
                                <i class=""zmdi zmdi-search""></i>
                            </label>
                            <div class=""mdl-textfield__expandable-holder"">
                                <input class=""mdl-textfield__input"" type=""text"" id=""searchProduct"">
                                <label class=""mdl-textfield__label""></label>
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <nav class=""full-width menu-categories"">
                        <ul class=""list-unstyle text-center"">
                            <li><a href=""#!"">Category 1</a></li>
                            <li><a href=""#!"">Category 2</a></li>
                            <li><a href=""#!"">Category 3</a></li>
                            <li><a href=""#!"">Category 4</a></li>
                        </ul>
                    </nav>
                    <div class=""full-width text-center"" style=""padding: 30px 0;"">
                        <div class=""mdl-card mdl-shadow--2dp full-width product-card"">
                            <div class=""mdl-card__title"">
                                <img src=""assets/img/fontLogin.jpg"" alt=""product"" class=""img-responsive"">
                            </div>
                            <div class=""mdl-card__supporting-text"">
                                <small>Stock</small><br>
                                <small>Category</small>
                 ");
            WriteLiteral(@"           </div>
                            <div class=""mdl-card__actions mdl-card--border"">
                                Product name
                                <button class=""mdl-button mdl-button--icon mdl-js-button mdl-js-ripple-effect"">
                                    <i class=""zmdi zmdi-more""></i>
                                </button>
                            </div>
                        </div>
                        <div class=""mdl-card mdl-shadow--2dp full-width product-card"">
                            <div class=""mdl-card__title"">
                                <img src=""assets/img/fontLogin.jpg"" alt=""product"" class=""img-responsive"">
                            </div>
                            <div class=""mdl-card__supporting-text"">
                                <small>Stock</small><br>
                                <small>Category</small>
                            </div>
                            <div class=""mdl-card__actions mdl-card--border"">
 ");
            WriteLiteral(@"                               Product name
                                <button class=""mdl-button mdl-button--icon mdl-js-button mdl-js-ripple-effect"">
                                    <i class=""zmdi zmdi-more""></i>
                                </button>
                            </div>
                        </div>
                        <div class=""mdl-card mdl-shadow--2dp full-width product-card"">
                            <div class=""mdl-card__title"">
                                <img src=""assets/img/fontLogin.jpg"" alt=""product"" class=""img-responsive"">
                            </div>
                            <div class=""mdl-card__supporting-text"">
                                <small>Stock</small><br>
                                <small>Category</small>
                            </div>
                            <div class=""mdl-card__actions mdl-card--border"">
                                Product name
                                <button class=""mdl-bu");
            WriteLiteral(@"tton mdl-button--icon mdl-js-button mdl-js-ripple-effect"">
                                    <i class=""zmdi zmdi-more""></i>
                                </button>
                            </div>
                        </div>
                        <div class=""mdl-card mdl-shadow--2dp full-width product-card"">
                            <div class=""mdl-card__title"">
                                <img src=""assets/img/fontLogin.jpg"" alt=""product"" class=""img-responsive"">
                            </div>
                            <div class=""mdl-card__supporting-text"">
                                <small>Stock</small><br>
                                <small>Category</small>
                            </div>
                            <div class=""mdl-card__actions mdl-card--border"">
                                Product name
                                <button class=""mdl-button mdl-button--icon mdl-js-button mdl-js-ripple-effect"">
                                    <i");
            WriteLiteral(" class=\"zmdi zmdi-more\"></i>\r\n                                </button>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<inventory_fashion_city.Pages.ProductsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<inventory_fashion_city.Pages.ProductsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<inventory_fashion_city.Pages.ProductsModel>)PageContext?.ViewData;
        public inventory_fashion_city.Pages.ProductsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591