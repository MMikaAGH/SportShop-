//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod zosta� wygenerowany przez narz�dzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mog� spowodowa� nieprawid�owe zachowanie i zostan� utracone, je�li
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP {
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Security;
using System.Web.UI;
using System.Web.WebPages;
using System.Web.WebPages.Html;

public class _Page_Index_cshtml : System.Web.WebPages.WebPage {
private static object @__o;
#line hidden
public _Page_Index_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
public override void Execute() {

#line 1 "C:\Users\Sornat\AppData\Local\Temp\984817A185891CE73CB27B277F5D9DCDD03B\3\SportShop\SportShop\Views\Customer\Index.cshtml"
__o = model;


#line default
#line hidden

#line 2 "C:\Users\Sornat\AppData\Local\Temp\984817A185891CE73CB27B277F5D9DCDD03B\3\SportShop\SportShop\Views\Customer\Index.cshtml"
  
    ViewBag.Title = "Index";


#line default
#line hidden

#line 3 "C:\Users\Sornat\AppData\Local\Temp\984817A185891CE73CB27B277F5D9DCDD03B\3\SportShop\SportShop\Views\Customer\Index.cshtml"
__o = Html.ActionLink("Create New", "Create");


#line default
#line hidden

#line 4 "C:\Users\Sornat\AppData\Local\Temp\984817A185891CE73CB27B277F5D9DCDD03B\3\SportShop\SportShop\Views\Customer\Index.cshtml"
       __o = Html.DisplayNameFor(model => model.FirstName);


#line default
#line hidden

#line 5 "C:\Users\Sornat\AppData\Local\Temp\984817A185891CE73CB27B277F5D9DCDD03B\3\SportShop\SportShop\Views\Customer\Index.cshtml"
       __o = Html.DisplayNameFor(model => model.LastName);


#line default
#line hidden

#line 6 "C:\Users\Sornat\AppData\Local\Temp\984817A185891CE73CB27B277F5D9DCDD03B\3\SportShop\SportShop\Views\Customer\Index.cshtml"
       __o = Html.DisplayNameFor(model => model.Email);


#line default
#line hidden

#line 7 "C:\Users\Sornat\AppData\Local\Temp\984817A185891CE73CB27B277F5D9DCDD03B\3\SportShop\SportShop\Views\Customer\Index.cshtml"
       __o = Html.DisplayNameFor(model => model.PhoneNumber);


#line default
#line hidden

#line 8 "C:\Users\Sornat\AppData\Local\Temp\984817A185891CE73CB27B277F5D9DCDD03B\3\SportShop\SportShop\Views\Customer\Index.cshtml"
       __o = Html.DisplayNameFor(model => model.Adress);


#line default
#line hidden

#line 9 "C:\Users\Sornat\AppData\Local\Temp\984817A185891CE73CB27B277F5D9DCDD03B\3\SportShop\SportShop\Views\Customer\Index.cshtml"
foreach (var item in Model) {
    

#line default
#line hidden

#line 10 "C:\Users\Sornat\AppData\Local\Temp\984817A185891CE73CB27B277F5D9DCDD03B\3\SportShop\SportShop\Views\Customer\Index.cshtml"
       __o = Html.DisplayFor(modelItem => item.FirstName);


#line default
#line hidden

#line 11 "C:\Users\Sornat\AppData\Local\Temp\984817A185891CE73CB27B277F5D9DCDD03B\3\SportShop\SportShop\Views\Customer\Index.cshtml"
       __o = Html.DisplayFor(modelItem => item.LastName);


#line default
#line hidden

#line 12 "C:\Users\Sornat\AppData\Local\Temp\984817A185891CE73CB27B277F5D9DCDD03B\3\SportShop\SportShop\Views\Customer\Index.cshtml"
       __o = Html.DisplayFor(modelItem => item.Email);


#line default
#line hidden

#line 13 "C:\Users\Sornat\AppData\Local\Temp\984817A185891CE73CB27B277F5D9DCDD03B\3\SportShop\SportShop\Views\Customer\Index.cshtml"
       __o = Html.DisplayFor(modelItem => item.PhoneNumber);


#line default
#line hidden

#line 14 "C:\Users\Sornat\AppData\Local\Temp\984817A185891CE73CB27B277F5D9DCDD03B\3\SportShop\SportShop\Views\Customer\Index.cshtml"
       __o = Html.DisplayFor(modelItem => item.Adress);


#line default
#line hidden

#line 15 "C:\Users\Sornat\AppData\Local\Temp\984817A185891CE73CB27B277F5D9DCDD03B\3\SportShop\SportShop\Views\Customer\Index.cshtml"
       __o = Html.ActionLink("Edit", "Edit", new { id=item.CustomerID });


#line default
#line hidden

#line 16 "C:\Users\Sornat\AppData\Local\Temp\984817A185891CE73CB27B277F5D9DCDD03B\3\SportShop\SportShop\Views\Customer\Index.cshtml"
       __o = Html.ActionLink("View", "View", new { id=item.CustomerID });


#line default
#line hidden

#line 17 "C:\Users\Sornat\AppData\Local\Temp\984817A185891CE73CB27B277F5D9DCDD03B\3\SportShop\SportShop\Views\Customer\Index.cshtml"
       __o = Html.ActionLink("Delete", "Delete", new { id=item.CustomerID });


#line default
#line hidden

#line 18 "C:\Users\Sornat\AppData\Local\Temp\984817A185891CE73CB27B277F5D9DCDD03B\3\SportShop\SportShop\Views\Customer\Index.cshtml"
         
}

#line default
#line hidden
}
}
}
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod zosta� wygenerowany przez narz�dzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mog� spowodowa� nieprawid�owe zachowanie i zostan� utracone, je�li
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP {
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Security;
using System.Web.UI;
using System.Web.WebPages;
using System.Web.WebPages.Html;

public class _Page_Index_cshtml : System.Web.WebPages.WebPage {
private static object @__o;
#line hidden
public _Page_Index_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
public override void Execute() {

#line 1 "C:\Users\Sornat\AppData\Local\Temp\984817A185891CE73CB27B277F5D9DCDD03B\2\SportShop\SportShop\Views\Customer\Index.cshtml"
__o = model;


#line default
#line hidden

#line 2 "C:\Users\Sornat\AppData\Local\Temp\984817A185891CE73CB27B277F5D9DCDD03B\2\SportShop\SportShop\Views\Customer\Index.cshtml"
  
    ViewBag.Title = "Index";


#line default
#line hidden

#line 3 "C:\Users\Sornat\AppData\Local\Temp\984817A185891CE73CB27B277F5D9DCDD03B\2\SportShop\SportShop\Views\Customer\Index.cshtml"
__o = Html.ActionLink("Create New", "Create");


#line default
#line hidden

#line 4 "C:\Users\Sornat\AppData\Local\Temp\984817A185891CE73CB27B277F5D9DCDD03B\2\SportShop\SportShop\Views\Customer\Index.cshtml"
       __o = Html.DisplayNameFor(model => model.FirstName);


#line default
#line hidden

#line 5 "C:\Users\Sornat\AppData\Local\Temp\984817A185891CE73CB27B277F5D9DCDD03B\2\SportShop\SportShop\Views\Customer\Index.cshtml"
       __o = Html.DisplayNameFor(model => model.LastName);


#line default
#line hidden

#line 6 "C:\Users\Sornat\AppData\Local\Temp\984817A185891CE73CB27B277F5D9DCDD03B\2\SportShop\SportShop\Views\Customer\Index.cshtml"
       __o = Html.DisplayNameFor(model => model.Email);


#line default
#line hidden

#line 7 "C:\Users\Sornat\AppData\Local\Temp\984817A185891CE73CB27B277F5D9DCDD03B\2\SportShop\SportShop\Views\Customer\Index.cshtml"
       __o = Html.DisplayNameFor(model => model.PhoneNumber);


#line default
#line hidden

#line 8 "C:\Users\Sornat\AppData\Local\Temp\984817A185891CE73CB27B277F5D9DCDD03B\2\SportShop\SportShop\Views\Customer\Index.cshtml"
       __o = Html.DisplayNameFor(model => model.Adress);


#line default
#line hidden

#line 9 "C:\Users\Sornat\AppData\Local\Temp\984817A185891CE73CB27B277F5D9DCDD03B\2\SportShop\SportShop\Views\Customer\Index.cshtml"
foreach (var item in Model) {
    

#line default
#line hidden

#line 10 "C:\Users\Sornat\AppData\Local\Temp\984817A185891CE73CB27B277F5D9DCDD03B\2\SportShop\SportShop\Views\Customer\Index.cshtml"
       __o = Html.DisplayFor(modelItem => item.FirstName);


#line default
#line hidden

#line 11 "C:\Users\Sornat\AppData\Local\Temp\984817A185891CE73CB27B277F5D9DCDD03B\2\SportShop\SportShop\Views\Customer\Index.cshtml"
       __o = Html.DisplayFor(modelItem => item.LastName);


#line default
#line hidden

#line 12 "C:\Users\Sornat\AppData\Local\Temp\984817A185891CE73CB27B277F5D9DCDD03B\2\SportShop\SportShop\Views\Customer\Index.cshtml"
       __o = Html.DisplayFor(modelItem => item.Email);


#line default
#line hidden

#line 13 "C:\Users\Sornat\AppData\Local\Temp\984817A185891CE73CB27B277F5D9DCDD03B\2\SportShop\SportShop\Views\Customer\Index.cshtml"
       __o = Html.DisplayFor(modelItem => item.PhoneNumber);


#line default
#line hidden

#line 14 "C:\Users\Sornat\AppData\Local\Temp\984817A185891CE73CB27B277F5D9DCDD03B\2\SportShop\SportShop\Views\Customer\Index.cshtml"
       __o = Html.DisplayFor(modelItem => item.Adress);


#line default
#line hidden

#line 15 "C:\Users\Sornat\AppData\Local\Temp\984817A185891CE73CB27B277F5D9DCDD03B\2\SportShop\SportShop\Views\Customer\Index.cshtml"
       __o = Html.ActionLink("Edit", "Edit", new { id=item.CustomerID });


#line default
#line hidden

#line 16 "C:\Users\Sornat\AppData\Local\Temp\984817A185891CE73CB27B277F5D9DCDD03B\2\SportShop\SportShop\Views\Customer\Index.cshtml"
       __o = Html.ActionLink("Details", "Details", new { id=item.CustomerID });


#line default
#line hidden

#line 17 "C:\Users\Sornat\AppData\Local\Temp\984817A185891CE73CB27B277F5D9DCDD03B\2\SportShop\SportShop\Views\Customer\Index.cshtml"
       __o = Html.ActionLink("Delete", "Delete", new { id=item.CustomerID });


#line default
#line hidden

#line 18 "C:\Users\Sornat\AppData\Local\Temp\984817A185891CE73CB27B277F5D9DCDD03B\2\SportShop\SportShop\Views\Customer\Index.cshtml"
         
}

#line default
#line hidden
}
}
}
