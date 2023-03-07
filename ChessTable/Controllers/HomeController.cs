using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ChessTable.Models;

namespace ChessTable.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var model = new ChessTableModel
        {
            ["a8"] = "♜",
            ["b8"] = "♞",
            ["c8"] = "♝",
            ["d8"] = "♛",
            ["e8"] = "♚",
            ["f8"] = "♝",
            ["g8"] = "♞",
            ["h8"] = "♜",
            ["a7"] = "♟",
            ["b7"] = "♟",
            ["c7"] = "♟",
            ["d7"] = "♟",
            ["e7"] = "♟",
            ["f7"] = "♟",
            ["g7"] = "♟",
            ["h7"] = "♟",
            
            ["a2"] = "♙",
            ["b2"] = "♙",
            ["c2"] = "♙",
            ["d2"] = "♙",
            ["e2"] = "♙",
            ["f2"] = "♙",
            ["g2"] = "♙",
            ["h2"] = "♙",
            ["a1"] = "♖",
            ["b1"] = "♘",
            ["c1"] = "♗",
            ["d1"] = "♕",
            ["e1"] = "♔",
            ["f1"] = "♗",
            ["g1"] = "♘",
            ["h1"] = "♖",
        };
        return View(model);
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