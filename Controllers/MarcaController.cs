using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SegundoParcial.Models;

namespace SegundoParcial.Controllers;

public class MarcaController : Controller
{
    private readonly ApplicationDbContext _context;
    public MarcaController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult MarcaList()
    {
        List<ToyModel> list = _context.juguete.Select(m => new ToyModel
            {
                Id = m.Id,
                codigo = m.codigo,
                nombre = m.nombre,
                Activo =m.Activo

            }).ToList();

            return View(list);
        
    }
    public IActionResult MarcaAdd()
    {
        return View();
    }

    public IActionResult MarcaSave(ToyModel model)
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

            return RedirectToAction("MarcaList", "Marca");
        }

        return RedirectToAction("MarcaAdd", "Marca");
    }
}