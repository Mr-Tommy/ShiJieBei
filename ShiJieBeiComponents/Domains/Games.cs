﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiJieBeiComponents.Domains
{
    public class Games
    {
        public int Id { get; set; }
        public string ZhuChang { get; set; }
        public string KeChang { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime StartTime { get; set; }
        public virtual List<GameOrders> GameOrders { get; set; }
    }

}
