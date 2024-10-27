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

using System;
using System.Collections.Generic;

public class Salon
{
    private List<Service> services;
    private List<Stylist> stylists;
    private List<Appointment> appointments;

    public Salon()
    {
        services = new List<Service>();
        stylists = new List<Stylist>();
        appointments = new List<Appointment>();
    }

    public void AddService(Service service)
    {
        services.Add(service);
    }

    public void AddStylist(Stylist stylist)
    {
        stylists.Add(stylist);
    }

    public List<Service> GetServices()
    {
        return services;
    }

    public List<Stylist> GetStylists()
    {
        return stylists;
    }

    public bool CreateAppointment(Service service, Stylist stylist, DateTime date)
    {
         // Xác thực nếu dịch vụ và thợ làm tóc tồn tại  
    var service = services.FirstOrDefault(s => s.Id == serviceId);  
    var stylist = stylists.FirstOrDefault(s => s.Id == stylistId);  

    if (service == null || stylist == null)  
    {  
        Console.WriteLine("Dịch vụ hoặc thợ làm tóc không tồn tại.");  
        return false;  
    }  

    // Kiểm tra để đảm bảo ngày hẹn là trong tương lai  
    if (date <= DateTime.Now)  
    {  
        Console.WriteLine("Ngày hẹn phải là ngày trong tương lai.");  
        return false;  
    }  

    // Kiểm tra các lịch hẹn đang xung đột  
    if (appointments.Any(a => a.Stylist.Id == stylistId && a.Date == date))  
    {  
        Console.WriteLine("Thợ làm tóc đã có lịch hẹn vào thời gian này.");  
        return false;  
    }  

    var appointment = new Appointment(appointments.Count + 1, service, stylist, date);  
    appointments.Add(appointment);  
    return true; // Trả về true nếu lịch hẹn được tạo thành công 
    }

    public List<Appointment> GetAppointments()
    {
        return appointments;
    }

    // Xác nhận lịch hẹn
    public void ConfirmAppointment(int appointmentId)
    {
        var appointment = appointments.FirstOrDefault(a => a.Id == appointmentId);
        if (appointment != null)
        {
            appointment.IsConfirmed = true;
            Console.WriteLine($"Lịch hẹn {appointmentId} đã được xác nhận.");
        }
        else
        {
            Console.WriteLine("Lịch hẹn không tồn tại.");
        }
    }

    // Từ chối lịch hẹn
    public void RejectAppointment(int appointmentId)
    {
        var appointment = appointments.FirstOrDefault(a => a.Id == appointmentId);
        if (appointment != null)
        {
            appointments.Remove(appointment);
            Console.WriteLine($"Lịch hẹn {appointmentId} đã bị từ chối.");
        }
        else
        {
            Console.WriteLine("Lịch hẹn không tồn tại.");
        }
    }
}






