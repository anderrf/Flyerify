using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Flyerify.Models;
using Flyerify.Repositories;

namespace Flyerify.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ITemplateRepository templateRepository;

    public HomeController(
        ILogger<HomeController> logger,
        ITemplateRepository templateRepository
    )
    {
        _logger = logger;
        this.templateRepository = templateRepository;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Templates()
    {
        List<TemplateModel> templates = this.templateRepository.getTemplates();
        return View(templates);
    }

    public IActionResult Template(int id)
    {
        if(id <= 0)
        {
            return Redirect("/Home/NotFound");
        }
        TemplateModel? template = this.templateRepository.getTemplateById(id);
        if(template == null)
        {
            return Redirect("/Home/NotFound");
        }
        return View(template);
    }

    public IActionResult NotFound()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
