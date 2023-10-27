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
        Cliente cliente1 = new Cliente(01, "Cliente 1 Eu Mesmo", "11208312381239", "1lucas@email.com", "1Cachorro");
        Cliente cliente2 = new Cliente(02, "Cliente 2 Eu Mesmo", "21208312381239", "2lucas@email.com", "2Cachorro");
        Cliente cliente3 = new Cliente(03, "Cliente 3 Eu Mesmo", "31208312381239", "3lucas@email.com", "3Cachorro");
        Cliente cliente4 = new Cliente(04, "Cliente 4 Eu Mesmo", "41208312381239", "4lucas@email.com", "4Cachorro");
        Cliente cliente5 = new Cliente(05, "Cliente 5 Eu Mesmo", "51208312381239", "5lucas@email.com", "5Cachorro");

        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        Fornecedor fornecedor1 = new Fornecedor(01, "ForneLucas 1", "cnpj1111111", "email1@email.com");
        Fornecedor fornecedor2 = new Fornecedor(02, "ForneLucas 2", "cnpj2222222", "email2@email.com");
        Fornecedor fornecedor3 = new Fornecedor(03, "ForneLucas 3", "cnpj3333333", "email3@email.com");
        Fornecedor fornecedor4 = new Fornecedor(04, "ForneLucas 4", "cnpj4444444", "email4@email.com");
        Fornecedor fornecedor5 = new Fornecedor(05, "ForneLucas 5", "cnpj5555555", "email5@email.com");

        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;

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
