// Tạo hệ thống quản lý lương cố định và hoa hồng cho stylist dựa trên mức doanh thu từ dịch vụ.
// Xây dựng cơ chế tính toán hoa hồng và quản lý thanh toán hàng tháng.
//
public decimal CalculateEarningsForStylist(int stylistId)  
{  
    // Tính tổng doanh thu từ các lịch hẹn của stylist  
    var totalRevenue = appointments  
        .Where(a => a.Stylist.Id == stylistId)  
        .Sum(a => a.Service.Price);  

    // Tìm stylist theo ID  
    var stylist = stylists.FirstOrDefault(s => s.Id == stylistId);  
    if (stylist == null)  
    {  
        Console.WriteLine("Thợ làm tóc không tồn tại.");  
        return 0;  
    }  

    // Tính hoa hồng  
    decimal commission = totalRevenue * stylist.CommissionRate;  

    // Tổng lương = lương cố định + hoa hồng  
    decimal totalEarnings = stylist.BaseSalary + commission;  

    return totalEarnings;  
}
