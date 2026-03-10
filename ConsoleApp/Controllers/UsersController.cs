[ApiController]
[Route("api/users")]
public class UsersController : ControllerBase
{
    [HttpGet]
    public IActionResult GetUsers() { }

    [HttpGet("{id}")]
    public IActionResult GetUser(int id) { }

    [HttpPost]
    public IActionResult CreateUser(User user) { }

    [HttpPut("{id}")]
    public IActionResult UpdateUser(int id, User user) { }

    [HttpDelete("{id}")]
    public IActionResult DeleteUser(int id) { }
}