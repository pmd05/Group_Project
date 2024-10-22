// Xây dựng hệ thống đánh giá dịch vụ.
// Thiết kế hệ thống tính điểm thưởng cho khách hàng dựa trên độ thường xuyên sử dụng dịch vụ và chất lượng phản hồi.

// Tạo mô hình feedback and rewards
public class Feedback
{
    public int Id { get; set; }
    public int UserId { get; set; } // Người gửi phản hồi
    public int AppointmentId { get; set; } // Lịch hẹn liên quan đến phản hồi
    public string Comment { get; set; } // Nội dung phản hồi
    public int Rating { get; set; } // Đánh giá (1 đến 5 sao)
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}

public class Reward
{
    public int Id { get; set; }
    public int UserId { get; set; } // Người được thưởng
    public int Points { get; set; } // Số điểm thưởng
    public DateTime LastUpdated { get; set; } = DateTime.Now;
}

// Tạo DTO cho feedback
public class FeedbackDto
{
    public int AppointmentId { get; set; }
    public string Comment { get; set; }
    public int Rating { get; set; }
}

// Tạo API để gửi feedback and rewards
[Route("api/[controller]")]
[ApiController]
public class FeedbackController : ControllerBase
{
    private readonly DatabaseContext _context;

    public FeedbackController(DatabaseContext context)
    {
        _context = context;
    }

    // API gửi phản hồi
    [HttpPost("submit")]
    public async Task<IActionResult> SubmitFeedback(FeedbackDto feedbackDto)
    {
        var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)); // Lấy ID người dùng từ token

        // Tạo phản hồi mới
        Feedback feedback = new Feedback
        {
            UserId = userId,
            AppointmentId = feedbackDto.AppointmentId,
            Comment = feedbackDto.Comment,
            Rating = feedbackDto.Rating
        };

        _context.Feedbacks.Add(feedback);
        await _context.SaveChangesAsync();

        // Cập nhật điểm thưởng
        var reward = _context.Rewards.FirstOrDefault(r => r.UserId == userId);
        if (reward == null)
        {
            reward = new Reward
            {
                UserId = userId,
                Points = CalculatePoints(feedbackDto.Rating)
            };
            _context.Rewards.Add(reward);
        }
        else
        {
            reward.Points += CalculatePoints(feedbackDto.Rating);
            reward.LastUpdated = DateTime.Now;
        }

        await _context.SaveChangesAsync();

        return Ok(new { message = "Phản hồi đã được ghi nhận và điểm thưởng đã được cập nhật." });
    }

    // Hàm tính điểm thưởng dựa trên đánh giá
    private int CalculatePoints(int rating)
    {
        // Ví dụ: đánh giá 5 sao thì được 10 điểm, 4 sao thì 7 điểm, v.v.
        return rating switch
        {
            5 => 10,
            4 => 7,
            3 => 5,
            2 => 2,
            _ => 1,
        };
    }

    // API để lấy điểm thưởng của người dùng
    [HttpGet("rewards")]
    public async Task<IActionResult> GetRewards()
    {
        var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
        var reward = await _context.Rewards.FirstOrDefaultAsync(r => r.UserId == userId);

        if (reward == null)
        {
            return Ok(new { Points = 0 });
        }

        return Ok(new { Points = reward.Points });
    }
}

// cập nhật mô hình
dotnet ef migrations add AddFeedbackAndReward
dotnet ef database update
