using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cliente1 = new Cliente(1, "João da Silva", "123.456.789-00", "Gwv9K@example.com", "Lobinho");
        Cliente cliente2 = new Cliente(2, "Maria Souza", "987.654.321-00", "pCvJy@example.com", "Cachorro");
        Cliente cliente3 = new Cliente(3, "Pedro Souza", "321.987.654-00", "pCvJy@example.com", "bob");
        Cliente cliente4 = new Cliente(4, "Andre", "321.987.653-00", "pAvJy@example.com", "daddy");
        Cliente cliente5 = new Cliente(5, "Lucas", "321.987.652-00", "pCvJy@example.com", "rodolfo");
        
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.Clientes = listaClientes;
        
        Fornecedor fornecedor1 = new Fornecedor(1, "Fornecedor1", "123.456.789-00", "Gwv9K@example.com");
        Fornecedor fornecedor2 = new Fornecedor(2, "Fornecedor2", "987.654.321-00", "pCvJy@example.com");
        Fornecedor fornecedor3 = new Fornecedor(3, "Fornecedor3", "321.987.654-00", "pCvJy@example.com");
        Fornecedor fornecedor4 = new Fornecedor(4, "Fornecedor4", "321.987.653-00", "pAvJy@example.com");
        Fornecedor fornecedor5 = new Fornecedor(5, "Fornecedor5", "321.987.652-00", "pCvJy@example.com");

        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.Fornecedores = listaFornecedores;

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
