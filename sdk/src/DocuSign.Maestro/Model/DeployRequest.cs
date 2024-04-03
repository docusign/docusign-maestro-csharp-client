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
    /// DeployRequest
    /// </summary>
    [DataContract]
    public partial class DeployRequest :  IEquatable<DeployRequest>, IValidatableObject
    {
        public DeployRequest()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Gets or Sets DeploymentStatus
        /// </summary>
        [DataMember(Name="deploymentStatus", EmitDefaultValue=false)]
        public DeployStatus? DeploymentStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeployRequest" /> class.
        /// </summary>
        /// <param name="DeploymentStatus">DeploymentStatus (required).</param>
        public DeployRequest(DeployStatus? DeploymentStatus = default(DeployStatus?))
        {
            // to ensure "DeploymentStatus" is required (not null)
            if (DeploymentStatus == null)
            {
                throw new InvalidDataException("DeploymentStatus is a required property for DeployRequest and cannot be null");
            }
            else
            {
                this.DeploymentStatus = DeploymentStatus;
            }
        }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeployRequest {\n");
            sb.Append("  DeploymentStatus: ").Append(DeploymentStatus).Append("\n");
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
            return this.Equals(obj as DeployRequest);
        }

        /// <summary>
        /// Returns true if DeployRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of DeployRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeployRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DeploymentStatus == other.DeploymentStatus ||
                    this.DeploymentStatus != null &&
                    this.DeploymentStatus.Equals(other.DeploymentStatus)
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
                if (this.DeploymentStatus != null)
                    hash = hash * 59 + this.DeploymentStatus.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}