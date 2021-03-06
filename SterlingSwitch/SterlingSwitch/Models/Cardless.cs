﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SterlingSwitch.Models
{
   public class Cardless
    {
        public string Referenceid { get; set; }
        public string RequestType { get; set; }
        public string Translocation { get; set; }
        public string appid { get; set; }
        public string ttid { get; set; }
        public string amount { get; set; }
        public string codeGenerationChannel { get; set; }
        public string accountNo { get; set; }
        public string transactionRef { get; set; }
        public string subscriber { get; set; }
        public string oneTimePin { get; set; }
    }
}
