using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SegundoParcial.Models;

namespace SegundoParcial.Controllers;

public class ToysController : Controller
{
    private readonly ApplicationDbContext _context;
    public ToysController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult JuguetesList()
    {
        List<ToyModel> list = _context.juguete.Select(t => new ToyModel
            {
                Id = t.Id,
                codigo = t.codigo,
                nombre = t.nombre,
                precio = t.precio,
                Vigencia = t.Vigencia,
                Activo =t.Activo

            }).ToList();

            return View(list);
        
    }
    public IActionResult JuguetesAdd()
    {
        return View();
    }

    public IActionResult ToySave(ToyModel model)
    {
        if(ModelState.IsValid)
        {
           var toys = new Entities.Juguete();
            toys.Id = Guid.NewGuid();
            toys.codigo = model.codigo;
            toys.nombre = model.nombre;
            toys.precio = model.precio;
            toys.Vigencia = model.Vigencia;
            toys.Activo = model.Activo;
        
            this._context.juguete.Add(toys);
            this._context.SaveChanges();

            return RedirectToAction("JuguetesList", "Toys");
        }

        return RedirectToAction("JuguetesAdd", "Toys");
    }

}