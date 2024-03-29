﻿using System.Collections.Generic;

namespace Signicat.Express.Signature
{    
    public class ExtraInfoSignerRequest 
    {
        /// <summary>
        /// A list of the extra information you want to order. Certain types require special properties, see documentation for more information. Additional cost will incur (with the exception of Difi company info).
        /// </summary>
        public List<ExtraInfoSignerType> Types { get; set; }
    
        /// <summary>
        /// A set of key-value pairs with special properties, see documentation for more information.
        /// </summary>
        public SpecialProperties SpecialProperties { get; set; }
    }
}