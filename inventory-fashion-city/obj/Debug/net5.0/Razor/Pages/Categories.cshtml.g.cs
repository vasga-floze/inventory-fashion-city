#pragma checksum "C:\Users\gabri\source\repos\inventory-fashion-city\inventory-fashion-city\Pages\Categories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a7daecf00aab77738357e873ba65cb726bd1223"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(inventory_fashion_city.Pages.Pages_Categories), @"mvc.1.0.razor-page", @"/Pages/Categories.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a7daecf00aab77738357e873ba65cb726bd1223", @"/Pages/Categories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0512090f8eeb3653d4f94dd0ea5f174a5ec33d8f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Categories : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\gabri\source\repos\inventory-fashion-city\inventory-fashion-city\Pages\Categories.cshtml"
  
    Layout = "~/Pages/Shared/_LayoutNav.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- pageContent -->
<section class=""full-width pageContent"">
    <section class=""full-width header-well"">
        <div class=""full-width header-well-icon"">
            <i class=""zmdi zmdi-label""></i>
        </div>
        <div class=""full-width header-well-text"">
            <p class=""text-condensedLight"">
                Lorem ipsum dolor sit amet, consectetur adipisicing elit. Unde aut nulla accusantium minus corporis accusamus fuga harum natus molestias necessitatibus.
            </p>
        </div>
    </section>
    <div class=""mdl-tabs mdl-js-tabs mdl-js-ripple-effect"">
        <div class=""mdl-tabs__tab-bar"">
            <a href=""#tabNewCategory"" class=""mdl-tabs__tab is-active"">NEW</a>
            <a href=""#tabListCategory"" class=""mdl-tabs__tab"">LIST</a>
        </div>
        <div class=""mdl-tabs__panel is-active"" id=""tabNewCategory"">
            <div class=""mdl-grid"">
                <div class=""mdl-cell mdl-cell--4-col-phone mdl-cell--8-col-tablet mdl-cell--8-col-desktop mdl-c");
            WriteLiteral(@"ell--2-offset-desktop"">
                    <div class=""full-width panel mdl-shadow--2dp"">
                        <div class=""full-width panel-tittle bg-primary text-center tittles"">
                            New category
                        </div>
                        <div class=""full-width panel-content"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a7daecf00aab77738357e873ba65cb726bd12235128", async() => {
                WriteLiteral(@"
                                <h5 class=""text-condensedLight"">Data category</h5>
                                <div class=""mdl-textfield mdl-js-textfield mdl-textfield--floating-label"">
                                    <input class=""mdl-textfield__input"" type=""text"" pattern=""-?[A-Za-z0-9???????????????????? ]*(\.[0-9]+)?"" id=""NameCategory"">
                                    <label class=""mdl-textfield__label"" for=""NameCategory"">Name</label>
                                    <span class=""mdl-textfield__error"">Invalid name</span>
                                </div>
                                <div class=""mdl-textfield mdl-js-textfield mdl-textfield--floating-label"">
                                    <input class=""mdl-textfield__input"" type=""text"" pattern=""-?[A-Za-z???????????????????? ]*(\.[0-9]+)?"" id=""descriptionCategory"">
                                    <label class=""mdl-textfield__label"" for=""descriptionCategory"">Description</label>
                                    <span class=""mdl-textfie");
                WriteLiteral(@"ld__error"">Invalid description</span>
                                </div>
                                <p class=""text-center"">
                                    <button class=""mdl-button mdl-js-button mdl-button--fab mdl-js-ripple-effect mdl-button--colored bg-primary"" id=""btn-addCategory"">
                                        <i class=""zmdi zmdi-plus""></i>
                                    </button>
                                    <div class=""mdl-tooltip"" for=""btn-addCategory"">Add category</div>
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
        <div class=""mdl-tabs__panel"" id=""tabListCategory"">
            <div class=""mdl-grid"">
                <div class=""mdl-cell mdl-cell--4-col-phone mdl-cell--8-col-tablet mdl-cell--8-col-desktop mdl-cell--2-offset-desktop"">
                    <div class=""full-width panel mdl-shadow--2dp"">
                        <div class=""full-width panel-tittle bg-success text-center tittles"">
                            List categories
                        </div>
                        <div class=""full-width panel-content"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a7daecf00aab77738357e873ba65cb726bd12238750", async() => {
                WriteLiteral(@"
                                <div class=""mdl-textfield mdl-js-textfield mdl-textfield--expandable"">
                                    <label class=""mdl-button mdl-js-button mdl-button--icon"" for=""searchCategory"">
                                        <i class=""zmdi zmdi-search""></i>
                                    </label>
                                    <div class=""mdl-textfield__expandable-holder"">
                                        <input class=""mdl-textfield__input"" type=""text"" id=""searchCategory"">
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            <div class=""mdl-list"">
                                <div class=""mdl-list__item mdl-list__item--two-line"">
                                    <span class=""mdl-list__item-primary-content"">
                                        <i class=""zmdi zmdi-label mdl-list__item-avatar""></i>
                                        <span>1. Category Name</span>
                                        <span class=""mdl-list__item-sub-title"">Sub tittle</span>
                                    </span>
                                    <a class=""mdl-list__item-secondary-action"" href=""#!""><i class=""zmdi zmdi-more""></i></a>
                                </div>
                                <li class=""full-width divider-menu-h""></li>
                                <div class=""mdl-list__item mdl-list__item--two-line"">
                                    <span class=""mdl-list__item-primary-content"">
                                        <i class=""zmdi zmdi-label mdl-list__ite");
            WriteLiteral(@"m-avatar""></i>
                                        <span>2. Category Name</span>
                                        <span class=""mdl-list__item-sub-title"">Sub tittle</span>
                                    </span>
                                    <a class=""mdl-list__item-secondary-action"" href=""#!""><i class=""zmdi zmdi-more""></i></a>
                                </div>
                                <li class=""full-width divider-menu-h""></li>
                                <div class=""mdl-list__item mdl-list__item--two-line"">
                                    <span class=""mdl-list__item-primary-content"">
                                        <i class=""zmdi zmdi-label mdl-list__item-avatar""></i>
                                        <span>3. Category Name</span>
                                        <span class=""mdl-list__item-sub-title"">Sub tittle</span>
                                    </span>
                                    <a class=""mdl-list__item-secondary-ac");
            WriteLiteral(@"tion"" href=""#!""><i class=""zmdi zmdi-more""></i></a>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<inventory_fashion_city.Pages.CategoriesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<inventory_fashion_city.Pages.CategoriesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<inventory_fashion_city.Pages.CategoriesModel>)PageContext?.ViewData;
        public inventory_fashion_city.Pages.CategoriesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
