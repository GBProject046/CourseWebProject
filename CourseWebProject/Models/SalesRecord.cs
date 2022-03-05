﻿using System;
using CourseWebProject.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace CourseWebProject.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [DisplayFormat(DataFormatString = "{0:N}")]
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
