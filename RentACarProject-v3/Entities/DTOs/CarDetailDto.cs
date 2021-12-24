using Core.Entities;  // IDto için
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    // Data Transfer Object
    public class CarDetailDto : IDto // IDto imzasıdır. imzası IEntity değil çünkü IEntity sen bir tablosun demekti, dto birden fazla tablo içerir.
    {
        public string CarName { get; set; }  // Car Name
        public string BrandName { get; set; }  // Brand Name
        public string ColorName { get; set; }  // Color Name
        public decimal DailyPrice { get; set; }
    }
}
