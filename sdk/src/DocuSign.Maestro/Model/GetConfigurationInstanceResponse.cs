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
    /// GetConfigurationInstanceResponse
    /// </summary>
    [DataContract]
    public partial class GetConfigurationInstanceResponse :  IEquatable<GetConfigurationInstanceResponse>, IValidatableObject
    {
        public GetConfigurationInstanceResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigurationInstanceResponse" /> class.
        /// </summary>
        /// <param name="SavedValues">SavedValues.</param>
        /// <param name="StepId">StepId.</param>
        /// <param name="WorkflowDefinitionId">WorkflowDefinitionId.</param>
        public GetConfigurationInstanceResponse(Object SavedValues = default(Object), string StepId = default(string), string WorkflowDefinitionId = default(string))
        {
            this.SavedValues = SavedValues;
            this.StepId = StepId;
            this.WorkflowDefinitionId = WorkflowDefinitionId;
        }
        
        /// <summary>
        /// Gets or Sets SavedValues
        /// </summary>
        [DataMember(Name="savedValues", EmitDefaultValue=false)]
        public Object SavedValues { get; set; }
        /// <summary>
        /// Gets or Sets StepId
        /// </summary>
        [DataMember(Name="stepId", EmitDefaultValue=false)]
        public string StepId { get; set; }
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
            sb.Append("class GetConfigurationInstanceResponse {\n");
            sb.Append("  SavedValues: ").Append(SavedValues).Append("\n");
            sb.Append("  StepId: ").Append(StepId).Append("\n");
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
            return this.Equals(obj as GetConfigurationInstanceResponse);
        }

        /// <summary>
        /// Returns true if GetConfigurationInstanceResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of GetConfigurationInstanceResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetConfigurationInstanceResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SavedValues == other.SavedValues ||
                    this.SavedValues != null &&
                    this.SavedValues.Equals(other.SavedValues)
                ) && 
                (
                    this.StepId == other.StepId ||
                    this.StepId != null &&
                    this.StepId.Equals(other.StepId)
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
                if (this.SavedValues != null)
                    hash = hash * 59 + this.SavedValues.GetHashCode();
                if (this.StepId != null)
                    hash = hash * 59 + this.StepId.GetHashCode();
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
