using Microsoft.AspNetCore.Mvc;

namespace TechCareerWebApiTutorial.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : Controller
    {
        [HttpGet]
        public string[] Get()
        {
            string[] products = new string[] { "table", "chair", "laptop", "phone", "mouse" };
            return products;

        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            string[] products = new string[] { "table", "chair", "laptop", "phone", "mouse" };

            string result = "";

            if (id <= 0 || id > products.Length) {

                return "Invalid ID";
            }
            else
            {
                for (int i = 0; i < id; i++)
                {
                    result += products[i] + "\n";
                }

                return result;
            }
        }
    }
}
