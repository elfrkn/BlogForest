using Microsoft.AspNetCore.Mvc;

namespace BlogForest.WebUI.ViewComponents.DefaultViewComponents
{
    public class _TopBarComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
