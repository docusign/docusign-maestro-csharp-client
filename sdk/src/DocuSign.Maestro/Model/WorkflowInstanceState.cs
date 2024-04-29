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
    /// Current Workflow Instance state (completed, failed, In-progress)
    /// </summary>
    /// <value>Current Workflow Instance state (completed, failed, In-progress)</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum WorkflowInstanceState
    {
        
        /// <summary>
        /// Enum Created for value: Created
        /// </summary>
        [EnumMember(Value = "Created")]
        Created = 1,
        
        /// <summary>
        /// Enum InProgress for value: In Progress
        /// </summary>
        [EnumMember(Value = "In Progress")]
        InProgress = 2,
        
        /// <summary>
        /// Enum Completed for value: Completed
        /// </summary>
        [EnumMember(Value = "Completed")]
        Completed = 3,
        
        /// <summary>
        /// Enum Failed for value: Failed
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed = 4,
        
        /// <summary>
        /// Enum Canceled for value: Canceled
        /// </summary>
        [EnumMember(Value = "Canceled")]
        Canceled = 5
    }

}
