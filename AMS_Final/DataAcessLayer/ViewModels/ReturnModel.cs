using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAcessLayer.ViewModels
{
    public class ReturnModel
    {           
            public string Data { get; set; }
            public string Error { get; set; }
            public bool HasError { get; set; }
      
    }
}