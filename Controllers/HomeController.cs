using aspdotnet_ef_example.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace aspdotnet_ef_example.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ExpensesDbContext _context;

        public HomeController(ILogger<HomeController> logger, ExpensesDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Expenses() 
        {
            var allExpenses = _context.Expenses.ToList();
            
            
            var totalExpenses = allExpenses.Sum(x => x.value);

            ViewBag.Expenses = totalExpenses;
            
            return View(allExpenses);
        }

        public IActionResult CreateEditExpense(int? id) 
        {

            if (id != null) 
            { 
             var expenseInDB = _context.Expenses.SingleOrDefault(expense => expense.Id == id);
             return View(expenseInDB);

            }

            return View();
         }

        public IActionResult CreateEditExpenseForm(Expense model) 
        {
            if (model.Id == 0)
            {
                _context.Expenses.Add(model);

            }
            else {
            _context.Expenses.Update(model);
            }
            _context.SaveChanges();


            return RedirectToAction("Expenses");
        
        }

        public ActionResult DeleteExpense(int id)
        {
            var expenseInDB = _context.Expenses.SingleOrDefault(expense => expense.Id == id);
            _context.Expenses.Remove(expenseInDB);
            _context.SaveChanges();
            return RedirectToAction("Expenses"); 
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
