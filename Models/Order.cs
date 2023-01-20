using Microsoft.EntityFrameworkCore;

namespace VerstaTestWeb.Models
{
    //Модель базы данных для заказа
    public class Order
    {
        public int id { get; set; }

        //Отправитель
        public string sender_city { get; set; }
        public string sender_country { get; set;}

        //Получатель
        public string recipient_city { get; set; }
        public string recipient_country { get; set; }

        //Дополнительная информация
        public float cargo_weight { get; set;}
        public DateTime pickupDate { get; set; }
    }

    //Сервис работы с БД
    public class DbOrders : DbContext
    {
        public DbSet<Order> orders { get; set; }

		//подключения к SqlServer
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
			//server=(localdb)\\mssqllocaldb; Database=Versta24
			//Строка подключения к БД (поменять перед включением)
			optionsBuilder.UseSqlServer("server=(localdb)\\mssqllocaldb; Database=Versta24; Trusted_Connection=true");
        }
    }
}
