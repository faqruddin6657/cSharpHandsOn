using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private List<Employee>? employees= new List<Employee>();

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        //[HttpGet(Name = "GetWeatherForecast")]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}

        //[HttpGet]
        //public ActionResult Get()
        //{
        //    employees = new List<Employee>();
        //    employees.Add(new Employee { Id = 1, Name = "faqruddin", Address = "hyderabad" });
        //    employees.Add(new Employee { Id = 2, Name = "aman", Address = "utter pradesh" });
        //    employees.Add(new Employee { Id = 3, Name = "balaram", Address = "vishakapatnam" });

        //    return Ok(employees);
        //}



        [HttpGet]
        public ActionResult GetEmployees()
        {
            employees.Add(new Employee { Id = 1, Name = "faqruddin", Address = "hyderabad" });
            employees.Add(new Employee { Id = 2, Name = "aman", Address = "utter pradesh" });
            employees.Add(new Employee { Id = 3, Name = "balaram", Address = "vishakapatnam" });


            return Ok(employees);
        }

        [HttpPost]
        
        public ActionResult AddEmployee()
        {
            
            employees.Add(new Employee { Id = 1, Name = "faqruddin", Address = "hyderabad" });
            employees.Add(new Employee { Id = 2, Name = "aman", Address = "utter pradesh" });
            employees.Add(new Employee { Id = 3, Name = "balaram", Address = "vishakapatnam" });
            return Ok("added");
        }
        [HttpGet]
        public ActionResult GetEmployeeById()
        {
            employees.Add(new Employee { Id = 1, Name = "faqruddin", Address = "hyderabad" });
            employees.Add(new Employee { Id = 2, Name = "aman", Address = "utter pradesh" });
            employees.Add(new Employee { Id = 3, Name = "balaram", Address = "vishakapatnam" });

            var employee = from emp in employees
                      where emp.Id == 1
                      select emp;   

            
            return Ok(employee);
        }

        [HttpPut]
        public ActionResult UpdateEmpAddress()
        {
            employees.Add(new Employee { Id = 1, Name = "faqruddin", Address = "hyderabad" });
            employees.Add(new Employee { Id = 2, Name = "aman", Address = "utter pradesh" });
            employees.Add(new Employee { Id = 3, Name = "balaram", Address = "vishakapatnam" });
            var updateemp = from emp in employees
                            where emp.Id == 1
                            select emp;

            foreach (var emp in updateemp)
            {
                if (emp.Id == 1)
                {
                    emp.Address = "telangana";
                }
            }

            return Ok(employees);

        }

        [HttpDelete]
        public ActionResult DeleteEmployee()
        {
            
            employees.Add(new Employee { Id = 1, Name = "faqruddin", Address = "hyderabad" });
            employees.Add(new Employee { Id = 2, Name = "aman", Address = "utter pradesh" });
            employees.Add(new Employee { Id = 3, Name = "balaram", Address = "vishakapatnam" });
            
           foreach(Employee emp in employees)
            {
                if(emp.Name == "faqruddin")
                {
                    employees.Remove(emp);
                }
            }

            return Ok(employees);
        }
    }
}