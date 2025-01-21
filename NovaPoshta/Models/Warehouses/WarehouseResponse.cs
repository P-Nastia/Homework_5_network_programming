﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPoshta.Models.Warehouses;

public class WarehouseResponse
{
    public bool Success { get; set; }
    public List<WarehouseItemResponse>? Data { get; set; }
    public List<object> Errors { get; set; }
    public List<object> Warnings { get; set; }

    
    public object Info { get; set; }
    public List<object> MessageCodes { get; set; }
    public List<object> ErrorCodes { get; set; }
    public List<object> WarningCodes { get; set; }
    public List<object> InfoCodes { get; set; }
}
