// Thiết kế và phát triển giao diện web/mobile để người dùng truy cập.
// Đảm bảo tương thích trên các thiết bị khác nhau.
// Tích hợp cơ chế đăng nhập và bảo mật.

// Tạo mô hình người dùng
public class User
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; } // Hash mật khẩu
    public string Role { get; set; } // Vai trò: Admin, Customer, Stylist, etc.
}

// Tạo DTO cho đăng kí/đăng nhập
public class RegisterDto
{
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}

public class LoginDto
{
    public string Email { get; set; }
    public string Password { get; set; }
}
//Tạo API đăng kí/đăng nhập
[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly DatabaseContext _context; // Kết nối database
    private readonly IConfiguration _configuration; // Để cấu hình JWT

    public AuthController(DatabaseContext context, IConfiguration configuration)
    {
        _context = context;
        _configuration = configuration;
    }

    // API Đăng ký
    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterDto request)
    {
        // Kiểm tra nếu email đã tồn tại
        if (_context.Users.Any(u => u.Email == request.Email))
        {
            return BadRequest("Email đã tồn tại.");
        }

        // Hash mật khẩu
        string passwordHash = BCrypt.Net.BCrypt.HashPassword(request.Password);

        // Tạo người dùng mới
        User user = new User
        {
            FullName = request.FullName,
            Email = request.Email,
            PasswordHash = passwordHash,
            Role = "Customer" // Default role là Customer
        };

        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        return Ok("Đăng ký thành công");
    }

    // API Đăng nhập
    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginDto request)
    {
        var user = _context.Users.FirstOrDefault(u => u.Email == request.Email);
        if (user == null || !BCrypt.Net.BCrypt.Verify(request.Password, user.PasswordHash))
        {
            return BadRequest("Email hoặc mật khẩu không đúng.");
        }

        // Tạo JWT token
        var token = CreateToken(user);
        return Ok(new { Token = token });
    }

    // Hàm tạo JWT token
    private string CreateToken(User user)
    {
        List<Claim> claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, user.Email),
            new Claim(ClaimTypes.Role, user.Role)
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Key"]));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);

        var token = new JwtSecurityToken(
            claims: claims,
            expires: DateTime.Now.AddDays(1),
            signingCredentials: creds);

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
