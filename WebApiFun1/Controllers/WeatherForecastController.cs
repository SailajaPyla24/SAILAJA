//using Microsoft.AspNetCore.Mvc;

//namespace WebApiFun1.Controllers
//{
//    [ApiController]
//    [Route("[controller]")]
//    public class WeatherForecastController : ControllerBase
//    {
//        //public static List<Employee> employees = new List<Employee>(); [HttpPost]
//        public static List<Student> students = new List<Student>();
       
//        public static List<Department> departments = new List<Department>(); 


//        public IActionResult Post(int studentNo, string studentName)

//        {

//            //Add new record

//            students.Add(new Student
//            {

//                StudentNo = studentNo,

//                StudentName = studentName

//            });

//            return Ok("created");

//        }
//        [HttpPost]

//        [Route("AddStudent")]

//        public IActionResult Post([FromBody] Student std)

//        {

//            //Add new record

//            students.Add(std);

//            return Ok("Added");

//        }
//        [HttpPut]

//        public IActionResult Put(int studentNo, string studentName)

//        {
//            try
//            {
//                if (students.Contains(students.Find(std => std.StudentNo.Equals(studentNo))))
//                {
//                    students.Find(std => std.StudentNo.Equals(studentNo)).StudentName = studentName;
//                    return Ok("Modified");
//                }
//                else
//                {
//                    return Ok("No data found for perticular record");
//                }
//            }
//            catch (Exception ex)
//            {
//                return BadRequest("student number is not found");
//            }
//        }
//        [HttpGet]

//        public IEnumerable<Student> Get()

//        {

//            return students;

//        }


//        //public IActionResult Post(int empNo, string empName)

//        //{

//        //    Add new record

//        //    employees.Add(new Employee
//        //    {

//        //        EmpNo = empNo,

//        //        EmpName = empName

//        //    });

//        //    return Ok("created");

//        //}
//        //[HttpPost]

//        //[Route("AddEmp")]

//        //public IActionResult Post([FromBody] Employee emp)

//        //{

//        //    Add new record

//        //    employees.Add(emp);

//        //    return Ok("Added");

//        //}
//        //[HttpPut]

//        //public IActionResult Put(int empNo, string empName)

//        //{
//        //    try
//        //    {
//        //        if (employees.Contains(employees.Find(emp => emp.EmpNo.Equals(empNo))))
//        //        {
//        //            employees.Find(emp => emp.EmpNo.Equals(empNo)).EmpName = empName;
//        //            return Ok("Modified");
//        //        }
//        //        else
//        //        {
//        //            return Ok("No data found for perticular record");
//        //        }
//        //    }
//        //    catch (Exception ex)
//        //    {
//        //        return BadRequest("employee number is not found");
//        //    }
//        //}
//        //[HttpDelete]

//        //public IActionResult Delete(int empNo, string empName)

//        //{

//        //    employees.Remove(employees.Find(emp => emp.EmpNo.Equals(empNo)));
//        //    return Ok("Removed");

//        //}

//        //[HttpGet]

//        //public IEnumerable<Employee> Get()

//        //{

//        //    return employees;

//        //}
//        #region
//        //private static readonly string[] Summaries = new[]
//        //{
//        //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
//        //};

//        //private readonly ILogger<WeatherForecastController> _logger;

//        //public WeatherForecastController(ILogger<WeatherForecastController> logger)
//        //{
//        //    _logger = logger;
//        //}

//        //[HttpGet(Name = "GetWeatherForecast")]
//        //public IEnumerable<WeatherForecast> Get()
//        //{
//        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
//        //    {
//        //        Date = DateTime.Now.AddDays(index),
//        //        TemperatureC = Random.Shared.Next(-20, 55),
//        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
//        //    })
//        //    .ToArray();
//        //}
//        #endregion

//        //[HttpGet]
//        //public string GetTime()
//        //{
//        //    return DateTime.Now.ToString();
//        //}


//        [HttpGet()]

//        [Route("AddNumbers")]

//        public string Add(int a, int b)

//        {

//            return (a + b).ToString();

//        }
//        [HttpGet()]

//        [Route("MulNumbers")]

//        public string Mul(int a, int b)

//        {

//            return (a * b).ToString();

//        }
//        [HttpGet()]

//        [Route("DivNumbers")]

//        public string Div(int a, int b)

//        {

//            return (a / b).ToString();

//        }

//    }



//}





