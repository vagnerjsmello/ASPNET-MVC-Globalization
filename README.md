# ASP.NET MVC Globalization

Simple project for educational purposes and uses:

- ASP.NET MVC
- Resources files in folder: App_GLobalResources
- Add in Web.Config `<globalization enableClientBasedCulture="true" uiCulture="auto"/>`

#### HomeController

```aspnetmvc
public ActionResult Index(string culture)
{
    if (!string.IsNullOrEmpty(culture))
    {
        HttpContext.Session["culture"] = culture;
        Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
        return View();
    }

    culture = string.IsNullOrEmpty((string)Session["culture"]) ? "pt-br" : Session["culture"].ToString();
    Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);

    return View();
}
```

See a demo at [https://aspnetmvc-globalization.azurewebsites.net](https://aspnetmvc-globalization.azurewebsites.net)
