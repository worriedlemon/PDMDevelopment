using ETUPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace ETUPortal.Components;

public class BuildingViewComponent : ViewComponent
{
    public BuildingViewComponent(){}
    
    public IViewComponentResult Invoke(Building building)
    {
        return View(building);
    }
}