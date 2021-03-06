﻿namespace Dawoe.OEmbedPickerPropertyEditor.Configuration
{
    using Umbraco.Core.PropertyEditors;

    /// <summary>
    /// Represents the configuration for the OEmbed picker
    /// </summary>
    public class OEmbedPickerConfiguration
    {
        /// <summary>
        /// Gets or sets a value indicating whether multiple items are allowed to be picked
        /// </summary>
        [ConfigurationField("allowmultiple", "Allow picking of multiple items", "boolean")]
        public bool AllowMultiple { get; set; }
    }
}
