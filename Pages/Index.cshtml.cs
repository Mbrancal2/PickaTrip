using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.VisualBasic;

namespace test_webapp1.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public string Destination {get; set;}
    SelectListGroup NA = new SelectListGroup { Name="North America" };
    SelectListGroup Asia = new SelectListGroup { Name="Asia" };
    SelectListGroup SA = new SelectListGroup { Name="South America" };
    SelectListGroup Europe = new SelectListGroup { Name="Europe" };
    SelectListGroup Africa = new SelectListGroup { Name="Africa" };
    public List<SelectListItem> Destinations {get; set;}
    

    public void OnGet()
    {
        Destinations = new List<SelectListItem>{
            new SelectListItem(){Text="Buenos Aires", Value="AR", Group= SA},
            new SelectListItem(){Text="Paris", Value="FR", Group= Europe},
            new SelectListItem(){Text="Sao Paulo", Value="BR", Group= SA},
            new SelectListItem(){Text="Berlin", Value="GRE", Group= Europe},
            new SelectListItem(){Text="Beijing", Value="CHI", Group= Asia},
            new SelectListItem(){Text="Chicago", Value="US", Group= NA},
            new SelectListItem(){Text="New York City", Value="US", Group= NA},
            new SelectListItem(){Text="Los Angeles", Value="US", Group= NA},
            new SelectListItem(){Text="San Francisco", Value="US", Group= NA},
            new SelectListItem(){Text="Boston", Value="US", Group= NA},
            new SelectListItem(){Text="Washington D.C.", Value="US", Group= NA},
            new SelectListItem(){Text="Miami", Value="US", Group= NA},
            new SelectListItem(){Text="Austin", Value="US", Group= NA},
            new SelectListItem(){Text="Seattle", Value="US", Group= NA},
        };

    }
}
