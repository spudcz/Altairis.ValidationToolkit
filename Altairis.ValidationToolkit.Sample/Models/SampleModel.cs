﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Altairis.ValidationToolkit.Sample.Models {
    public class SampleModel {

        public static readonly SampleModel SampleData = new SampleModel {
            DateOfBirth = DateTime.Today.AddDays(10),
            NextMonthDate = DateTime.Today.AddDays(-1),
            YearOfBirth = DateTime.Today.Year + 1,
            MinValue = 10,
            MaxValue = 10,
            MaxOrEqualValue = 9,
            Ico = "27560911"
        };

        [DataType(DataType.Date), Display(Name = "Date of birth (must be between 100 years ago and now)")]
        [DateOffset(-100, 0)]
        public DateTime DateOfBirth { get; set; }

        [DataType(DataType.Date), Display(Name = "Date in next 30 days:")]
        [DateOffset(null, "30.00:00:00")]
        public DateTime NextMonthDate { get; set; }

        [Display(Name = "Year of birth (must be between 100 years ago and now)")]
        [YearOffset(-100, 0)]
        public int YearOfBirth { get; set; }

        [Display(Name = "Some minimum value")]
        public int MinValue { get; set; }

        [Display(Name = "Some value greater than minimum")]
        [GreaterThan("MinValue")]
        public int MaxValue { get; set; }

        [Display(Name = "Some value greater or equal to minimum")]
        [GreaterThan("MinValue", AllowEqual = true)]
        public int MaxOrEqualValue { get; set; }

        [Ico]
        public string Ico { get; set; }

    }
}