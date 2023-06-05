﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersionalProject.Application.Dtos
{
    public class PageResult<T>
    {
        List<T> Items { get; set; }
        public int TotalRecord { get; set; }

    }
}
