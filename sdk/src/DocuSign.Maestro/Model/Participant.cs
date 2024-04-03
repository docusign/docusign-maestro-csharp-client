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
    /// A DS Workflow participant
    /// </summary>
    [DataContract]
    public partial class Participant :  IEquatable<Participant>, IValidatableObject
    {
        public Participant()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Participant" /> class.
        /// </summary>
        /// <param name="ParticipantEmail">ParticipantEmail (required).</param>
        /// <param name="ParticipantFirstName">ParticipantFirstName (required).</param>
        /// <param name="ParticipantLastName">ParticipantLastName (required).</param>
        /// <param name="ParticipantRole">ParticipantRole (required).</param>
        public Participant(string ParticipantEmail = default(string), string ParticipantFirstName = default(string), string ParticipantLastName = default(string), string ParticipantRole = default(string))
        {
            // to ensure "ParticipantEmail" is required (not null)
            if (ParticipantEmail == null)
            {
                throw new InvalidDataException("ParticipantEmail is a required property for Participant and cannot be null");
            }
            else
            {
                this.ParticipantEmail = ParticipantEmail;
            }
            // to ensure "ParticipantFirstName" is required (not null)
            if (ParticipantFirstName == null)
            {
                throw new InvalidDataException("ParticipantFirstName is a required property for Participant and cannot be null");
            }
            else
            {
                this.ParticipantFirstName = ParticipantFirstName;
            }
            // to ensure "ParticipantLastName" is required (not null)
            if (ParticipantLastName == null)
            {
                throw new InvalidDataException("ParticipantLastName is a required property for Participant and cannot be null");
            }
            else
            {
                this.ParticipantLastName = ParticipantLastName;
            }
            // to ensure "ParticipantRole" is required (not null)
            if (ParticipantRole == null)
            {
                throw new InvalidDataException("ParticipantRole is a required property for Participant and cannot be null");
            }
            else
            {
                this.ParticipantRole = ParticipantRole;
            }
        }
        
        /// <summary>
        /// Gets or Sets ParticipantEmail
        /// </summary>
        [DataMember(Name="participantEmail", EmitDefaultValue=false)]
        public string ParticipantEmail { get; set; }
        /// <summary>
        /// Gets or Sets ParticipantFirstName
        /// </summary>
        [DataMember(Name="participantFirstName", EmitDefaultValue=false)]
        public string ParticipantFirstName { get; set; }
        /// <summary>
        /// Gets or Sets ParticipantLastName
        /// </summary>
        [DataMember(Name="participantLastName", EmitDefaultValue=false)]
        public string ParticipantLastName { get; set; }
        /// <summary>
        /// Gets or Sets ParticipantRole
        /// </summary>
        [DataMember(Name="participantRole", EmitDefaultValue=false)]
        public string ParticipantRole { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Participant {\n");
            sb.Append("  ParticipantEmail: ").Append(ParticipantEmail).Append("\n");
            sb.Append("  ParticipantFirstName: ").Append(ParticipantFirstName).Append("\n");
            sb.Append("  ParticipantLastName: ").Append(ParticipantLastName).Append("\n");
            sb.Append("  ParticipantRole: ").Append(ParticipantRole).Append("\n");
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
            return this.Equals(obj as Participant);
        }

        /// <summary>
        /// Returns true if Participant instances are equal
        /// </summary>
        /// <param name="other">Instance of Participant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Participant other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ParticipantEmail == other.ParticipantEmail ||
                    this.ParticipantEmail != null &&
                    this.ParticipantEmail.Equals(other.ParticipantEmail)
                ) && 
                (
                    this.ParticipantFirstName == other.ParticipantFirstName ||
                    this.ParticipantFirstName != null &&
                    this.ParticipantFirstName.Equals(other.ParticipantFirstName)
                ) && 
                (
                    this.ParticipantLastName == other.ParticipantLastName ||
                    this.ParticipantLastName != null &&
                    this.ParticipantLastName.Equals(other.ParticipantLastName)
                ) && 
                (
                    this.ParticipantRole == other.ParticipantRole ||
                    this.ParticipantRole != null &&
                    this.ParticipantRole.Equals(other.ParticipantRole)
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
                if (this.ParticipantEmail != null)
                    hash = hash * 59 + this.ParticipantEmail.GetHashCode();
                if (this.ParticipantFirstName != null)
                    hash = hash * 59 + this.ParticipantFirstName.GetHashCode();
                if (this.ParticipantLastName != null)
                    hash = hash * 59 + this.ParticipantLastName.GetHashCode();
                if (this.ParticipantRole != null)
                    hash = hash * 59 + this.ParticipantRole.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
