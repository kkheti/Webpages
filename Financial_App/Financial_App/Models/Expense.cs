﻿using System.ComponentModel.DataAnnotations;
namespace Financial_App.Models
{
    public class Expense
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; } = null!;
        [Required]
        [Range(0.01, double.MaxValue,ErrorMessage = "Amount needs to be right")]
        public double Amount {  get; set; }
        [Required]
        public string Category { get; set; } = null!;

        public DateTime Date { get; set; } = DateTime.Now;


    }
}
