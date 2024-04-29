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
    /// The workflow deployment status
    /// </summary>
    /// <value>The workflow deployment status</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum DeploymentStatus
    {
        
        /// <summary>
        /// Enum DeploymentInProgress for value: Deployment In Progress
        /// </summary>
        [EnumMember(Value = "Deployment In Progress")]
        DeploymentInProgress = 1,
        
        /// <summary>
        /// Enum Deployed for value: Deployed
        /// </summary>
        [EnumMember(Value = "Deployed")]
        Deployed = 2,
        
        /// <summary>
        /// Enum Failed for value: Failed
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed = 3,
        
        /// <summary>
        /// Enum DeleteinProgress for value: Delete in Progress
        /// </summary>
        [EnumMember(Value = "Delete in Progress")]
        DeleteinProgress = 4,
        
        /// <summary>
        /// Enum Deleted for value: Deleted
        /// </summary>
        [EnumMember(Value = "Deleted")]
        Deleted = 5,
        
        /// <summary>
        /// Enum NotDeployed for value: Not Deployed
        /// </summary>
        [EnumMember(Value = "Not Deployed")]
        NotDeployed = 6,
        
        /// <summary>
        /// Enum UnpublishinProgress for value: Unpublish in Progress
        /// </summary>
        [EnumMember(Value = "Unpublish in Progress")]
        UnpublishinProgress = 7,
        
        /// <summary>
        /// Enum Unpublished for value: Unpublished
        /// </summary>
        [EnumMember(Value = "Unpublished")]
        Unpublished = 8
    }

}
