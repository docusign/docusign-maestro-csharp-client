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
    /// The workflow replication status
    /// </summary>
    /// <value>The workflow replication status</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ReplicationStatus
    {
        
        /// <summary>
        /// Enum DeployReplicationInProgress for value: Deploy Replication In Progress
        /// </summary>
        [EnumMember(Value = "Deploy Replication In Progress")]
        DeployReplicationInProgress = 1,
        
        /// <summary>
        /// Enum DeployReplicated for value: Deploy Replicated
        /// </summary>
        [EnumMember(Value = "Deploy Replicated")]
        DeployReplicated = 2,
        
        /// <summary>
        /// Enum DeployReplicationFailed for value: Deploy Replication Failed
        /// </summary>
        [EnumMember(Value = "Deploy Replication Failed")]
        DeployReplicationFailed = 3,
        
        /// <summary>
        /// Enum NotReplicated for value: Not Replicated
        /// </summary>
        [EnumMember(Value = "Not Replicated")]
        NotReplicated = 4,
        
        /// <summary>
        /// Enum DeleteReplicationinProgress for value: Delete Replication in Progress
        /// </summary>
        [EnumMember(Value = "Delete Replication in Progress")]
        DeleteReplicationinProgress = 5,
        
        /// <summary>
        /// Enum DeleteReplicated for value: Delete Replicated
        /// </summary>
        [EnumMember(Value = "Delete Replicated")]
        DeleteReplicated = 6,
        
        /// <summary>
        /// Enum DeleteReplicationFailed for value: Delete Replication Failed
        /// </summary>
        [EnumMember(Value = "Delete Replication Failed")]
        DeleteReplicationFailed = 7,
        
        /// <summary>
        /// Enum UnpublishreplicationinProgress for value: Unpublish replication in Progress
        /// </summary>
        [EnumMember(Value = "Unpublish replication in Progress")]
        UnpublishreplicationinProgress = 8,
        
        /// <summary>
        /// Enum UnpublishReplicated for value: Unpublish Replicated
        /// </summary>
        [EnumMember(Value = "Unpublish Replicated")]
        UnpublishReplicated = 9,
        
        /// <summary>
        /// Enum UnpublishReplicationFailed for value: Unpublish Replication Failed
        /// </summary>
        [EnumMember(Value = "Unpublish Replication Failed")]
        UnpublishReplicationFailed = 10
    }

}
