using System.ComponentModel.DataAnnotations;

namespace BlazorCRUDApp.Data.Models;

public class Person
{
    public int Id { get; set; }

    [Required, MaxLength(50)]
    public string FirstName { get; set; }

    [MaxLength(50)]
    public string LastName { get; set; } = string.Empty;

    [Required, MaxLength(100)]
    public string Email { get; set; }

    public string Address { get; set; }

    [MaxLength(50)]
    public string City { get; set; }

    [MaxLength(50)]
    public string Region { get; set; }

    [MaxLength(15)]
    public string PostalCode { get; set; }

    [Required, MaxLength(100)]
    public string Country { get; set; }

    [MaxLength(20)]
    public string Phone { get; set; }

    [MaxLength(50)]
    public string Fax { get; set; }

    [MaxLength(100)]
    public string HomePage { get; set; }
}

