/* 
 * Maestro API
 *
 * Maestro authors and executes experiences that allow non-coders the ability to define Simple Business Process without having to write code and to deploy them seamlessly without having to have development expertise
 *
 * OpenAPI spec version: 1.0.0
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace DocuSign.Maestro.Model
{
    /// <summary>
    /// Access Token token Types
    /// </summary>
    /// <value>Access Token token Types</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum AccessTokenTokenTypes
    {
        
        /// <summary>
        /// Enum Bearer for value: Bearer
        /// </summary>
        [EnumMember(Value = "Bearer")]
        Bearer = 1,
        
        /// <summary>
        /// Enum Application for value: Application
        /// </summary>
        [EnumMember(Value = "Application")]
        Application = 2,
        
        /// <summary>
        /// Enum Resource for value: Resource
        /// </summary>
        [EnumMember(Value = "Resource")]
        Resource = 3
    }

}
