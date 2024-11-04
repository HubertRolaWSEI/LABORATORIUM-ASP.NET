using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Models.Services;

namespace WebApplication1.Controllers;

public class ContactController : Controller
{
    private readonly IContactService _contactService;

    public ContactController()
    {
        _contactService = new MemoryContactService();
    }

    public IActionResult Index()
    {
        return View("Index", _contactService.GetAll());
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(ContactModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }
        _contactService.Add(model);
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Delete(int id)
    {
        _contactService.Delete(id);
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Edit(int id)
    {
        return View(_contactService.GetById(id));
    }

    [HttpPost]
    public IActionResult Edit(ContactModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }
        _contactService.Update(model);
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Details(int id)
    {
        return View(_contactService.GetById(id));
    }
}