using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

[AllowAnonymous]
public class MyControllerAnon : ControllerBase
{
}

[Authorize] // Overridden by the [AllowAnonymous] attribute on MyControllerAnon
public class MyControllerInherited : MyControllerAnon
{
}

public class MyControllerInherited2 : MyControllerAnon
{
    [Authorize] // Overridden by the [AllowAnonymous] attribute on MyControllerAnon
    public string Private() => "Privacy Disclaimer";
}