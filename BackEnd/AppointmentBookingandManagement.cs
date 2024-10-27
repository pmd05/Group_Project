// Khách hàng: Phát triển giao diện và logic cho phép khách hàng duyệt dịch vụ, chọn stylist và đặt lịch hẹn.
// Nhân viên salon: Xây dựng hệ thống quản lý và theo dõi yêu cầu lịch hẹn, bao gồm việc chấp nhận và từ chối các yêu cầu.
public class Service
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    
    public Service(int id, string name, decimal price)
    {
        Id = id;
        Name = name;
        Price = price;
    }
}

public class Stylist
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Specialty { get; set; }

    public Stylist(int id, string name, string specialty)
    {
        Id = id;
        Name = name;
        Specialty = specialty;
    }
}

using System;

public class Appointment
{
    public int Id { get; set; }
    public Service Service { get; set; }
    public Stylist Stylist { get; set; }
    public DateTime Date { get; set; }
    public bool IsConfirmed { get; set; }

    public Appointment(int id, Service service, Stylist stylist, DateTime date)
    {
        Id = id;
        Service = service;
        Stylist = stylist;
        Date = date;
        IsConfirmed = false;
    }
}










