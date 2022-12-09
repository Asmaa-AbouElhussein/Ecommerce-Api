﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerice.Core.Specification
{
    public class ProductSpecParam
    {
        private const int MaxPageSize = 50;
        public int PageIndex { get; set; } = 1;
        private int _pageSize = 6;
        private string _search;

        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = (value > MaxPageSize ? MaxPageSize : value);
        }

        public string Search
        {
            get => _search;
            set => _search = value.ToLower();
        }

        public int? CategoryId { get; set; }
        public string Sort { get; set; }
    }
}
