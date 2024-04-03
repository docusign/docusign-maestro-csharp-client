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
    /// WorkflowDeleteResponse
    /// </summary>
    [DataContract]
    public partial class WorkflowDeleteResponse :  IEquatable<WorkflowDeleteResponse>, IValidatableObject
    {
        public WorkflowDeleteResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowDeleteResponse" /> class.
        /// </summary>
        /// <param name="PollUrl">PollUrl (required).</param>
        /// <param name="WorkflowDefinitionId">WorkflowDefinitionId (required).</param>
        public WorkflowDeleteResponse(string PollUrl = default(string), string WorkflowDefinitionId = default(string))
        {
            // to ensure "PollUrl" is required (not null)
            if (PollUrl == null)
            {
                throw new InvalidDataException("PollUrl is a required property for WorkflowDeleteResponse and cannot be null");
            }
            else
            {
                this.PollUrl = PollUrl;
            }
            // to ensure "WorkflowDefinitionId" is required (not null)
            if (WorkflowDefinitionId == null)
            {
                throw new InvalidDataException("WorkflowDefinitionId is a required property for WorkflowDeleteResponse and cannot be null");
            }
            else
            {
                this.WorkflowDefinitionId = WorkflowDefinitionId;
            }
        }
        
        /// <summary>
        /// Gets or Sets PollUrl
        /// </summary>
        [DataMember(Name="pollUrl", EmitDefaultValue=false)]
        public string PollUrl { get; set; }
        /// <summary>
        /// Gets or Sets WorkflowDefinitionId
        /// </summary>
        [DataMember(Name="workflowDefinitionId", EmitDefaultValue=false)]
        public string WorkflowDefinitionId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkflowDeleteResponse {\n");
            sb.Append("  PollUrl: ").Append(PollUrl).Append("\n");
            sb.Append("  WorkflowDefinitionId: ").Append(WorkflowDefinitionId).Append("\n");
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
            return this.Equals(obj as WorkflowDeleteResponse);
        }

        /// <summary>
        /// Returns true if WorkflowDeleteResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkflowDeleteResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkflowDeleteResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PollUrl == other.PollUrl ||
                    this.PollUrl != null &&
                    this.PollUrl.Equals(other.PollUrl)
                ) && 
                (
                    this.WorkflowDefinitionId == other.WorkflowDefinitionId ||
                    this.WorkflowDefinitionId != null &&
                    this.WorkflowDefinitionId.Equals(other.WorkflowDefinitionId)
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
                if (this.PollUrl != null)
                    hash = hash * 59 + this.PollUrl.GetHashCode();
                if (this.WorkflowDefinitionId != null)
                    hash = hash * 59 + this.WorkflowDefinitionId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
