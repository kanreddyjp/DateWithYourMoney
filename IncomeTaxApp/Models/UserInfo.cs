using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace IncomeTaxApp.Models
{
    public class UserInfo : Controller
    {
      public string Name { get; set; }

      [Required(ErrorMessage = "Gross annual salary is required")]
      [Range(1, int.MaxValue, ErrorMessage = "Please provide only numeric value, do not append any symbol or special character such as dot, comma.")]
      public int TotalSalary { get; set; }

      [Required(ErrorMessage = "Gross annual salary is required")]
      [Range(1, 100, ErrorMessage = "Sorry we do not have any suggestions for new born's or for above 100yrs age.")]
      public int Age { get; set; }

      public Gender Gender { get; set; }

      public bool IsIndianResident { get; set; }

      public IncomeSource SourceOfIncome { get; set; }
    }

  public enum IncomeSource
  {
    Salary,
    HouseProperty,
    Business,
    CapitalGains,
    Other
  }

  public enum Gender
    {
      Male,
      Female
    }
}
