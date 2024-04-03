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
    /// Defines DSWorkflowComparisonOperatorTypes
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum DSWorkflowComparisonOperatorTypes
    {
        
        /// <summary>
        /// Enum Contains for value: Contains
        /// </summary>
        [EnumMember(Value = "Contains")]
        Contains = 1,
        
        /// <summary>
        /// Enum NotContains for value: NotContains
        /// </summary>
        [EnumMember(Value = "NotContains")]
        NotContains = 2,
        
        /// <summary>
        /// Enum Equal for value: Equal
        /// </summary>
        [EnumMember(Value = "Equal")]
        Equal = 3,
        
        /// <summary>
        /// Enum NotEqual for value: NotEqual
        /// </summary>
        [EnumMember(Value = "NotEqual")]
        NotEqual = 4,
        
        /// <summary>
        /// Enum GreaterThan for value: GreaterThan
        /// </summary>
        [EnumMember(Value = "GreaterThan")]
        GreaterThan = 5,
        
        /// <summary>
        /// Enum GreaterThanOrEqual for value: GreaterThanOrEqual
        /// </summary>
        [EnumMember(Value = "GreaterThanOrEqual")]
        GreaterThanOrEqual = 6,
        
        /// <summary>
        /// Enum LessThan for value: LessThan
        /// </summary>
        [EnumMember(Value = "LessThan")]
        LessThan = 7,
        
        /// <summary>
        /// Enum LessThanOrEqual for value: LessThanOrEqual
        /// </summary>
        [EnumMember(Value = "LessThanOrEqual")]
        LessThanOrEqual = 8,
        
        /// <summary>
        /// Enum StartsWith for value: StartsWith
        /// </summary>
        [EnumMember(Value = "StartsWith")]
        StartsWith = 9,
        
        /// <summary>
        /// Enum NotStartsWith for value: NotStartsWith
        /// </summary>
        [EnumMember(Value = "NotStartsWith")]
        NotStartsWith = 10,
        
        /// <summary>
        /// Enum EndsWith for value: EndsWith
        /// </summary>
        [EnumMember(Value = "EndsWith")]
        EndsWith = 11,
        
        /// <summary>
        /// Enum NotEndsWith for value: NotEndsWith
        /// </summary>
        [EnumMember(Value = "NotEndsWith")]
        NotEndsWith = 12
    }

}