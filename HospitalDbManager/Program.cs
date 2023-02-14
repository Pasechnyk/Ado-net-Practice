using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

// Hospital Database Manager

public class Doctor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public decimal Salary { get; set; }
    public decimal Premium { get; set; }
}

public class Examination
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int DayOfWeek { get; set; }
    public DateTime StartTime { get; set; } // string dates changed to DateTime data
    public DateTime EndTime { get; set; }
}

public class HospitalDbManager
{
    private SqlConnection connection;

    public HospitalDbManager(string? connectionString = null)
    {
        connectionString ??= ConfigurationManager.ConnectionStrings["HospitalDb"].ConnectionString;

        connection = new SqlConnection(connectionString);
        connection.Open();
    }

    // Task 1 - Get amount of places in department by name
    public decimal? GetAmountByName(string name)
    {
        SqlCommand command = connection.CreateCommand();
        command.CommandText = "select count(d.Wards) from Departments as d" +
                              "where d.Name = @name";

        command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;

        var result = command.ExecuteScalar();

        if (result is DBNull) return null;
        return (decimal)result;
    }

    // Task 2 - Get examinations list
    public List<Examination> GetExaminations()
    {
        SqlCommand command = connection.CreateCommand();
        command.CommandText = "select * from Examinations";

        SqlDataReader reader = command.ExecuteReader();

        List<Examination> list = new List<Examination>();

        while (reader.Read())
        {
            list.Add(new Examination()
            {
                Id = (int)reader["Id"],
                Name = (string)reader["Name"],
                DayOfWeek = (int)reader["Day"],
                StartTime = (DateTime)reader["Start"],
                EndTime = (DateTime)reader["End"]
            });
        }
        reader.Close();

        return list;
    }

    // Task 3 - Get examinations past certain date
    public int DeleteExamination(string date)
    {
        SqlCommand command = connection.CreateCommand();
        command.CommandText = "delete * from Examinations as e" +
                              "where e.StartTime < @date";

        command.Parameters.Add("@date", SqlDbType.Date).Value = date;

        return command.ExecuteNonQuery();
    }

    // Task 4 - Get doctors with salary higher than given amount
    public List<Doctor> GetBySalary(int salary)
    {
        SqlCommand command = connection.CreateCommand();
        command.CommandText = "select * from Doctors as d" +
                              "where d.Salary >= @salary";

        command.Parameters.Add("@salary", SqlDbType.Decimal).Value = salary;

        SqlDataReader reader = command.ExecuteReader();

        List<Doctor> list = new List<Doctor>();

        while (reader.Read()) 
        {
            list.Add(new Doctor()
            {
                Id = (int)reader["Id"],
                Name = (string)reader["Name"],
                Surname = (string)reader["Surname"],
                Salary = (decimal)reader["Salary"],
                Premium = (decimal)reader["Premium"]
            });
        }
        reader.Close();

        return list;
    }
    
    // Task 5 - Get the biggest donation
    public decimal? GetBiggestDonation()
    {
        SqlCommand command = connection.CreateCommand();
        command.CommandText = "select Top 1 d.Id from Donations as d " +
                              "order by d.Amount";

        var result = command.ExecuteScalar();

        if (result is DBNull) return null;
        return (decimal)result;
    }

    // Task 6 - Add new examination
    public int AddExamination(int id, string name, int day, string start, string end)
    {
        SqlCommand command = connection.CreateCommand();
        command.CommandText = "insert Sales " +
                             $"values (@id, @name, @day, @start, @end)";

        command.Parameters.Add("@id", SqlDbType.Int).Value = id;
        command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
        command.Parameters.Add("@day", SqlDbType.Int).Value = day;
        command.Parameters.Add("@start", SqlDbType.DateTime).Value = start;
        command.Parameters.Add("@end", SqlDbType.DateTime).Value = end;

        return command.ExecuteNonQuery();
    }

    // Task 7* - Delete sponsors without any donations
    public int DeleteSponsor()
    {
        SqlCommand command = connection.CreateCommand();
        command.CommandText = "delete s.Id from Sponsors as s" +
                              "join Donations as d ON d.SponsorId = s.Id " +
                              "where count(d.Amount) = 0";

        return command.ExecuteNonQuery();
    }

    // Get doctors count
    public int GetDoctorsCount()
    {
        SqlCommand command = connection.CreateCommand();
        command.CommandText = "select count(d.Id) from Doctors as d";

        return (int)command.ExecuteScalar();
    }

    // Get all doctors
    public List<Doctor> GetAllDoctors()
    {
        SqlCommand command = connection.CreateCommand();
        command.CommandText = "select * from Doctors";

        SqlDataReader reader = command.ExecuteReader();

        List<Doctor> list = new List<Doctor>();

        while (reader.Read()) 
        {
            list.Add(new Doctor()
            {
                Id = (int)reader["Id"],
                Name = (string)reader["Name"],
                Surname = (string)reader["Surname"],
                Salary = (decimal)reader["Salary"],
                Premium = (decimal)reader["Premium"]
            });
        }
        reader.Close();

        return list;
    }

    // Get donations amount of some sponsor
    public decimal? GetDonationAmount(string sponsor)
    {
        SqlCommand command = connection.CreateCommand();
        command.CommandText = "select sum(d.Amount) " +
                              "from Donations as d join Sponsors as s on d.SponsorId = s.Id " +
                              "where s.Name = @sponsorName";

        command.Parameters.Add("@sponsorName", SqlDbType.NVarChar).Value = sponsor;

        var result = command.ExecuteScalar();

        if (result is DBNull) return null;
        return (decimal)result;
    }

    // Set doctor premium
    public int SetDoctorPremium(int id, decimal value)
    {
        SqlCommand command = connection.CreateCommand();
        command.CommandText = "update Doctors " +
                             $"set Premium = @value " +
                             $"where Id = @id";

        command.Parameters.Add("@value", SqlDbType.Money).Value = value;
        command.Parameters.Add("@id", SqlDbType.Int).Value = id;

        return command.ExecuteNonQuery();
    }

    // Add a donation
    public int Donate(decimal amount, int departmentId, int sponsorId)
    {
        SqlCommand command = connection.CreateCommand();
        command.CommandText = "insert Donations " +
                             $"values ({amount}, '{DateTime.Now:yyyy/MM/dd}', {departmentId}, {sponsorId})";

        return command.ExecuteNonQuery();
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        // test all functions
        string connStr = ConfigurationManager.ConnectionStrings["HospitalDb"].ConnectionString;
        HospitalDbManager manager = new HospitalDbManager(connStr);

        Console.WriteLine($"Doctors: {manager.GetDoctorsCount()}");

        foreach (var d in manager.GetAllDoctors())
        {
            Console.WriteLine($"[{d.Id}]: {d.Name} {d.Surname} - {d.Salary} + {d.Premium}");
        }

        Console.Write("Enter sponsor name: ");
        string name = Console.ReadLine()!;

        var result = manager.GetDonationAmount(name);

        Console.WriteLine($"{name} donations: {result}$");

        manager.SetDoctorPremium(7, 55);
        manager.GetAmountByName("Edward");

        foreach (var e in manager.GetExaminations())
        {
            Console.WriteLine($"[{e.Id}]: {e.Name}, {e.DayOfWeek}, {e.StartTime} - {e.EndTime}");
        }

        manager.DeleteSponsor();
        manager.DeleteExamination("2010/02/15");
        manager.AddExamination(16, "Surgery", 2, "18:15:50", "19:20:14");
        manager.GetBySalary(20000);
        manager.GetBiggestDonation();

    }
}
