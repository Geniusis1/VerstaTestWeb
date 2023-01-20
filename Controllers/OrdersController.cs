using Microsoft.AspNetCore.Mvc;
using VerstaTestWeb.Models;

namespace VerstaTestWeb.Controllers
{
	[Route("orders")]
	public class OrdersController : Controller
	{
		//Сервис БД
		private readonly DbOrders _context;

		//Конструктор
		public OrdersController(DbOrders context) => _context = context;

		//Логика показа заказов
		[HttpGet]
		public IActionResult Index()
		{
			return View(_context.orders);
		}

		/// <summary>
		/// Get-запрос, добавляющий заказ в БД
		/// </summary>
		/// <param name="sender_city">Город отправителя</param>
		/// <param name="sender_country">Адрес отправителя</param>
		/// <param name="recipient_city">Город получателя</param>
		/// <param name="recipient_country">Адрес получателя</param>
		/// <param name="cargo_weight">Вес груза</param>
		/// <param name="pickupDate">Дата забора груза</param>
		[Route("new")]
		[HttpGet]
		public IActionResult NewOrderSave(
			string sender_city,
			string sender_country,
			string recipient_city,
			string recipient_country,
			float cargo_weight,
			DateTime pickupDate)
		{
			if (sender_city == null ||
				sender_country == null ||
				recipient_city == null ||
				recipient_country == null)
			{
				return View("Orders");
			}
			//Создание и добавление в БД заказа
			_context.Add(new Order()
			{
				sender_city = sender_city,
				sender_country = sender_country,
				recipient_city = recipient_city,
				recipient_country = recipient_country,
				cargo_weight = cargo_weight,
				pickupDate = pickupDate
			});

			try
			{
				//Обновление БД
				_context.SaveChanges();
			}catch(Exception)
			{
				Response.StatusCode = 400;
				return Content("Naughty");
			}

			return View("Orders");
		}
	}
}
