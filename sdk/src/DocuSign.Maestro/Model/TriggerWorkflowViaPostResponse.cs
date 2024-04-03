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
    /// Trigger workflow via POST response details
    /// </summary>
    [DataContract]
    public partial class TriggerWorkflowViaPostResponse :  IEquatable<TriggerWorkflowViaPostResponse>, IValidatableObject
    {
        public TriggerWorkflowViaPostResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerWorkflowViaPostResponse" /> class.
        /// </summary>
        /// <param name="InstanceId">InstanceId.</param>
        /// <param name="WorkflowInstanceUrl">Instance specific url that can be used to be redirected to a workflow instance.</param>
        public TriggerWorkflowViaPostResponse(string InstanceId = default(string), string WorkflowInstanceUrl = default(string))
        {
            this.InstanceId = InstanceId;
            this.WorkflowInstanceUrl = WorkflowInstanceUrl;
        }
        
        /// <summary>
        /// Gets or Sets InstanceId
        /// </summary>
        [DataMember(Name="instanceId", EmitDefaultValue=false)]
        public string InstanceId { get; set; }
        /// <summary>
        /// Instance specific url that can be used to be redirected to a workflow instance
        /// </summary>
        /// <value>Instance specific url that can be used to be redirected to a workflow instance</value>
        [DataMember(Name="workflowInstanceUrl", EmitDefaultValue=false)]
        public string WorkflowInstanceUrl { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TriggerWorkflowViaPostResponse {\n");
            sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  WorkflowInstanceUrl: ").Append(WorkflowInstanceUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as TriggerWorkflowViaPostResponse);
        }

        /// <summary>
        /// Returns true if TriggerWorkflowViaPostResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TriggerWorkflowViaPostResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TriggerWorkflowViaPostResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.InstanceId == other.InstanceId ||
                    this.InstanceId != null &&
                    this.InstanceId.Equals(other.InstanceId)
                ) && 
                (
                    this.WorkflowInstanceUrl == other.WorkflowInstanceUrl ||
                    this.WorkflowInstanceUrl != null &&
                    this.WorkflowInstanceUrl.Equals(other.WorkflowInstanceUrl)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.InstanceId != null)
                    hash = hash * 59 + this.InstanceId.GetHashCode();
                if (this.WorkflowInstanceUrl != null)
                    hash = hash * 59 + this.WorkflowInstanceUrl.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
