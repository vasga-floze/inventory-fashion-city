#pragma checksum "C:\Users\gabri\source\repos\inventory-fashion-city\inventory-fashion-city\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "835166ef3e7ca70d76ade9299656b939bd559252"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(inventory_fashion_city.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"835166ef3e7ca70d76ade9299656b939bd559252", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0512090f8eeb3653d4f94dd0ea5f174a5ec33d8f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\gabri\source\repos\inventory-fashion-city\inventory-fashion-city\Pages\Index.cshtml"
  
    ViewData["Title"] = "Inicio";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Notifications area -->
<section class=""full-width container-notifications"">
    <div class=""full-width container-notifications-bg btn-Notification""></div>
    <section class=""NotificationArea"">
        <div class=""full-width text-center NotificationArea-title tittles"">Notifications <i class=""zmdi zmdi-close btn-Notification""></i></div>
        <a href=""#"" class=""Notification"" id=""notifation-unread-1"">
            <div class=""Notification-icon""><i class=""zmdi zmdi-accounts-alt bg-info""></i></div>
            <div class=""Notification-text"">
                <p>
                    <i class=""zmdi zmdi-circle""></i>
                    <strong>New User Registration</strong>
                    <br>
                    <small>Just Now</small>
                </p>
            </div>
            <div class=""mdl-tooltip mdl-tooltip--left"" for=""notifation-unread-1"">Notification as UnRead</div>
        </a>
        <a href=""#"" class=""Notification"" id=""notifation-read-1"">
            <div class=""N");
            WriteLiteral(@"otification-icon""><i class=""zmdi zmdi-cloud-download bg-primary""></i></div>
            <div class=""Notification-text"">
                <p>
                    <i class=""zmdi zmdi-circle-o""></i>
                    <strong>New Updates</strong>
                    <br>
                    <small>30 Mins Ago</small>
                </p>
            </div>
            <div class=""mdl-tooltip mdl-tooltip--left"" for=""notifation-read-1"">Notification as Read</div>
        </a>
        <a href=""#"" class=""Notification"" id=""notifation-unread-2"">
            <div class=""Notification-icon""><i class=""zmdi zmdi-upload bg-success""></i></div>
            <div class=""Notification-text"">
                <p>
                    <i class=""zmdi zmdi-circle""></i>
                    <strong>Archive uploaded</strong>
                    <br>
                    <small>31 Mins Ago</small>
                </p>
            </div>
            <div class=""mdl-tooltip mdl-tooltip--left"" for=""notifation-unread-2"">Noti");
            WriteLiteral(@"fication as UnRead</div>
        </a>
        <a href=""#"" class=""Notification"" id=""notifation-read-2"">
            <div class=""Notification-icon""><i class=""zmdi zmdi-mail-send bg-danger""></i></div>
            <div class=""Notification-text"">
                <p>
                    <i class=""zmdi zmdi-circle-o""></i>
                    <strong>New Mail</strong>
                    <br>
                    <small>37 Mins Ago</small>
                </p>
            </div>
            <div class=""mdl-tooltip mdl-tooltip--left"" for=""notifation-read-2"">Notification as Read</div>
        </a>
        <a href=""#"" class=""Notification"" id=""notifation-read-3"">
            <div class=""Notification-icon""><i class=""zmdi zmdi-folder bg-primary""></i></div>
            <div class=""Notification-text"">
                <p>
                    <i class=""zmdi zmdi-circle-o""></i>
                    <strong>Folder delete</strong>
                    <br>
                    <small>1 hours Ago</small>
        ");
            WriteLiteral(@"        </p>
            </div>
            <div class=""mdl-tooltip mdl-tooltip--left"" for=""notifation-read-3"">Notification as Read</div>
        </a>
    </section>
</section>
<!-- navBar -->
<div class=""full-width navBar"">
    <div class=""full-width navBar-options"">
        <i class=""zmdi zmdi-more-vert btn-menu"" id=""btn-menu""></i>
        <div class=""mdl-tooltip"" for=""btn-menu"">Menu</div>
        <nav class=""navBar-options-list"">
            <ul class=""list-unstyle"">
                <li class=""btn-Notification"" id=""notifications"">
                    <i class=""zmdi zmdi-notifications""></i>
                    <!-- <i class=""zmdi zmdi-notifications-active btn-Notification"" id=""notifications""></i> -->
                    <div class=""mdl-tooltip"" for=""notifications"">Notificationes</div>
                </li>
                <li class=""btn-exit"" id=""btn-exit"">
                    <i class=""zmdi zmdi-power""></i>
                    <div class=""mdl-tooltip"" for=""btn-exit"">Salir</div>
       ");
            WriteLiteral(@"         </li>
                <li class=""text-condensedLight noLink""><small>Vasti Flores</small></li>
                <li class=""noLink"">
                    <figure>
                        <img src=""assets/img/avatar-female.png"" alt=""Avatar"" class=""img-responsive"">
                    </figure>
                </li>
            </ul>
        </nav>
    </div>
</div>
<!-- navLateral -->
<section class=""full-width navLateral"">
    <div class=""full-width navLateral-bg btn-menu""></div>
    <div class=""full-width navLateral-body"">
        <div class=""full-width navLateral-body-logo text-center tittles"">
            <i class=""zmdi zmdi-close btn-menu""></i> Inicio
        </div>
        <figure class=""full-width"" style=""height: 77px;"">
            <div class=""navLateral-body-cl"">
                <img src=""assets/img/avatar-female.png"" alt=""Avatar"" class=""img-responsive"">
            </div>
            <figcaption class=""navLateral-body-cr hide-on-tablet"">
                <span>
           ");
            WriteLiteral(@"         Vasti Gabriela Flores<br>
                    <small>Administradora</small>
                </span>
            </figcaption>
        </figure>
        <div class=""full-width tittles navLateral-body-tittle-menu"">
            <i class=""zmdi zmdi-desktop-mac""></i><span class=""hide-on-tablet"">&nbsp; DASHBOARD</span>
        </div>
        <nav class=""full-width"">
            <ul class=""full-width list-unstyle menu-principal"">
                <li class=""full-width"">
                    <a href=""Index"" class=""full-width"">
                        <div class=""navLateral-body-cl"">
                            <i class=""zmdi zmdi-view-dashboard""></i>
                        </div>
                        <div class=""navLateral-body-cr hide-on-tablet"">
                            INICIO
                        </div>
                    </a>
                </li>
                <li class=""full-width divider-menu-h""></li>
                <li class=""full-width"">
                    <a href=");
            WriteLiteral(@"""#!"" class=""full-width btn-subMenu"">
                        <div class=""navLateral-body-cl"">
                            <i class=""zmdi zmdi-case""></i>
                        </div>
                        <div class=""navLateral-body-cr hide-on-tablet"">
                            ADMINISTRACION
                        </div>
                        <span class=""zmdi zmdi-chevron-left""></span>
                    </a>
                    <ul class=""full-width menu-principal sub-menu-options"">
                        <li class=""full-width"">
                            <a href=""Company"" class=""full-width"">
                                <div class=""navLateral-body-cl"">
                                    <i class=""zmdi zmdi-balance""></i>
                                </div>
                                <div class=""navLateral-body-cr hide-on-tablet"">
                                    COMPAÑIA
                                </div>
                            </a>
                    ");
            WriteLiteral(@"    </li>
                        <li class=""full-width"">
                            <a href=""Providers"" class=""full-width"">
                                <div class=""navLateral-body-cl"">
                                    <i class=""zmdi zmdi-truck""></i>
                                </div>
                                <div class=""navLateral-body-cr hide-on-tablet"">
                                    PROVEEDORES
                                </div>
                            </a>
                        </li>
                        <li class=""full-width"">
                            <a href=""#!"" class=""full-width"">
                                <div class=""navLateral-body-cl"">
                                    <i class=""zmdi zmdi-card""></i>
                                </div>
                                <div class=""navLateral-body-cr hide-on-tablet"">
                                    PAGOS
                                </div>
                            </a>
  ");
            WriteLiteral(@"                      </li>
                        <li class=""full-width"">
                            <a href=""Categories"" class=""full-width"">
                                <div class=""navLateral-body-cl"">
                                    <i class=""zmdi zmdi-label""></i>
                                </div>
                                <div class=""navLateral-body-cr hide-on-tablet"">
                                    CATEGORIAS
                                </div>
                            </a>
                        </li>
                    </ul>
                </li>
                <li class=""full-width divider-menu-h""></li>
                <li class=""full-width"">
                    <a href=""#!"" class=""full-width btn-subMenu"">
                        <div class=""navLateral-body-cl"">
                            <i class=""zmdi zmdi-face""></i>
                        </div>
                        <div class=""navLateral-body-cr hide-on-tablet"">
                          ");
            WriteLiteral(@"  USUARIOS
                        </div>
                        <span class=""zmdi zmdi-chevron-left""></span>
                    </a>
                    <ul class=""full-width menu-principal sub-menu-options"">
                        <li class=""full-width"">
                            <a href=""Admin"" class=""full-width"">
                                <div class=""navLateral-body-cl"">
                                    <i class=""zmdi zmdi-account""></i>
                                </div>
                                <div class=""navLateral-body-cr hide-on-tablet"">
                                    ADMINISTRADORES
                                </div>
                            </a>
                        </li>
                        <li class=""full-width"">
                            <a href=""Client"" class=""full-width"">
                                <div class=""navLateral-body-cl"">
                                    <i class=""zmdi zmdi-accounts""></i>
                        ");
            WriteLiteral(@"        </div>
                                <div class=""navLateral-body-cr hide-on-tablet"">
                                    CLIENTES
                                </div>
                            </a>
                        </li>
                    </ul>
                </li>
                <li class=""full-width divider-menu-h""></li>
                <li class=""full-width"">
                    <a href=""Products"" class=""full-width"">
                        <div class=""navLateral-body-cl"">
                            <i class=""zmdi zmdi-washing-machine""></i>
                        </div>
                        <div class=""navLateral-body-cr hide-on-tablet"">
                            PRODUCTOS
                        </div>
                    </a>
                </li>
                <li class=""full-width divider-menu-h""></li>
                <li class=""full-width"">
                    <a href=""Sales"" class=""full-width"">
                        <div class=""navLateral-body");
            WriteLiteral(@"-cl"">
                            <i class=""zmdi zmdi-shopping-cart""></i>
                        </div>
                        <div class=""navLateral-body-cr hide-on-tablet"">
                            VENTAS
                        </div>
                    </a>
                </li>
                <li class=""full-width divider-menu-h""></li>
                <li class=""full-width"">
                    <a href=""Inventory"" class=""full-width"">
                        <div class=""navLateral-body-cl"">
                            <i class=""zmdi zmdi-store""></i>
                        </div>
                        <div class=""navLateral-body-cr hide-on-tablet"">
                            INVENTARIO
                        </div>
                    </a>
                </li>
                <li class=""full-width divider-menu-h""></li>
                <li class=""full-width"">
                    <a href=""#!"" class=""full-width btn-subMenu"">
                        <div class=""navLateral-bod");
            WriteLiteral(@"y-cl"">
                            <i class=""zmdi zmdi-wrench""></i>
                        </div>
                        <div class=""navLateral-body-cr hide-on-tablet"">
                            CONFIGURACIONES
                        </div>
                        <span class=""zmdi zmdi-chevron-left""></span>
                    </a>
                    <ul class=""full-width menu-principal sub-menu-options"">
                        <li class=""full-width"">
                            <a href=""#!"" class=""full-width"">
                                <div class=""navLateral-body-cl"">
                                    <i class=""zmdi zmdi-widgets""></i>
                                </div>
                                <div class=""navLateral-body-cr hide-on-tablet"">
                                    OPTION
                                </div>
                            </a>
                        </li>
                        <li class=""full-width"">
                            <a h");
            WriteLiteral(@"ref=""#!"" class=""full-width"">
                                <div class=""navLateral-body-cl"">
                                    <i class=""zmdi zmdi-widgets""></i>
                                </div>
                                <div class=""navLateral-body-cr hide-on-tablet"">
                                    OPTION
                                </div>
                            </a>
                        </li>
                    </ul>
                </li>
            </ul>
        </nav>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
