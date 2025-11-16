using ETUPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace ETUPortal.Components;

public class FacultyViewComponent : ViewComponent
{
    public FacultyViewComponent(){}
    
    public IViewComponentResult Invoke(Faculty faculty)
    {
        return View(faculty);
    }
}