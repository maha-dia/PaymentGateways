using LibraryApp.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Stripe;
using System.Linq;

namespace LibraryApp.Controllers
{
    public class StripeDashboardController:Controller
    {
        public IActionResult Index() {

            var response = new StrapeDashboardVM();

            var balanceService = new BalanceService();
            var balanceResult = balanceService.Get();
            response.Balance = balanceResult;

            var transactionService = new BalanceTransactionService();
            var transactionsResult = transactionService.List().ToList();
            response.Transaction = transactionsResult;

            //create a references to the service
            var customersService = new CustomerService();
            var customerResult = customersService.List().ToList();
            response.Customers = customerResult;

            //Retrieve Stripe charges
            var chargeService = new ChargeService();    
            var chargeResult = chargeService.List().ToList();   
            response.Charges = chargeResult;  
            
            var disputeService = new DisputeService();  
            var disputeResult = disputeService.List().ToList(); 
            response.Disputes = disputeResult;  
            var refundService = new RefundService();
            var refundResult = refundService.List().ToList();   
            response.Refunds = refundResult;    


            var productService = new ProductService();
            var productResult = productService.List().ToList();

            response.Products = productResult;  

            return View(response); 
        } 

    }
}
