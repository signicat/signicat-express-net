﻿namespace Idfy.Signature
{
    public class Styling
    {
        /// <summary>
        /// The color theme for the application.
        /// </summary>
        public ColorTheme? ColorTheme { get; set; }
    
        /// <summary>
        /// The type of spinner to show in loading screens.
        /// </summary>
        public Spinner? Spinner { get; set; }
    
        /// <summary>
        /// If you want to hide the top bar, set this property to true (can be a good choice in iframe mode)
        /// </summary>
        public bool? HideTopBar { get; set; }
    }
}