using Microsoft.AspNetCore.Mvc;
using OnlineRailwayReservation.Models;
using OnlineRailwayReservation.Repositories;

namespace OnlineRailwayReservation.Controllers
{

    [ApiController]
    [Route("api/payments")]
    public class PaymentController : Controller
    {
        private readonly PaymentRepository _paymentRepository;

        public PaymentController(PaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var payments = _paymentRepository.GetAllPayments();
            return View(payments);
        }
        [HttpGet("{id}")]
        public IActionResult Details(int id)
        {
            var payment = _paymentRepository.GetPaymentById(id);
            if (payment == null)
            {
                return NotFound();
            }
            return View(payment);
        }
        [HttpPost]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("{payment}")]
        public IActionResult Create(Payment payment)
        {
            if (ModelState.IsValid)
            {
                _paymentRepository.AddPayment(payment);
                return RedirectToAction("Index");
            }
            return View(payment);
        }
        [HttpPut("{id}")]
        public IActionResult Edit(int id)
        {
            var payment = _paymentRepository.GetPaymentById(id);
            if (payment == null)
            {
                return NotFound();
            }
            return View(payment);
        }

        [HttpPost("{id}")]
        public IActionResult Edit(int id, Payment payment)
        {
            if (id != payment.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _paymentRepository.UpdatePayment(payment);
                return RedirectToAction("Index");
            }
            return View(payment);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var payment = _paymentRepository.GetPaymentById(id);
            if (payment == null)
            {
                return NotFound();
            }
            return View(payment);
        }

        [HttpPost("{id}"), ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _paymentRepository.DeletePayment(id);
            return RedirectToAction("Index");
        }
    }
}
