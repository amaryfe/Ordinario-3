using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using Ordinario_3.Models;

namespace Ordinario_3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropietariosController : Controller
{
    private readonly ApplicationDbContext _context;

    public PropietariosController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var propietarios = _context.Propietarios.ToList();
        return View(propietarios);
    }

    public IActionResult Details(int id)
    {
        var propietario = _context.Propietarios.Find(id);
        return View(propietario);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Propietario propietario)
    {
        _context.Propietarios.Add(propietario);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Edit(int id)
    {
        var propietario = _context.Propietarios.Find(id);
        return View(propietario);
    }

    [HttpPost]
    public IActionResult Edit(int id, Propietario propietario)
    {
        if (id != propietario.Id)
        {
            return NotFound();
        }

        _context.Entry(propietario).State = EntityState.Modified;
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Delete(int id)
    {
        var propietario = _context.Propietarios.Find(id);
        return View(propietario);
    }

    [HttpPost, ActionName("Delete")]
    public IActionResult DeleteConfirmed(int id)
    {
        var propietario = _context.Propietarios.Find(id);
        _context.Propietarios.Remove(propietario);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
}
}