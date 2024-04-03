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
    /// DeployResponse
    /// </summary>
    [DataContract]
    public partial class DeployResponse :  IEquatable<DeployResponse>, IValidatableObject
    {
        public DeployResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployResponse" /> class.
        /// </summary>
        /// <param name="Message">Message (required).</param>
        /// <param name="Method">Method.</param>
        /// <param name="PollUrl">PollUrl (required).</param>
        /// <param name="ReceivedTime">ReceivedTime.</param>
        public DeployResponse(string Message = default(string), string Method = default(string), string PollUrl = default(string), DateTime? ReceivedTime = default(DateTime?))
        {
            // to ensure "Message" is required (not null)
            if (Message == null)
            {
                throw new InvalidDataException("Message is a required property for DeployResponse and cannot be null");
            }
            else
            {
                this.Message = Message;
            }
            // to ensure "PollUrl" is required (not null)
            if (PollUrl == null)
            {
                throw new InvalidDataException("PollUrl is a required property for DeployResponse and cannot be null");
            }
            else
            {
                this.PollUrl = PollUrl;
            }
            this.Method = Method;
            this.ReceivedTime = ReceivedTime;
        }
        
        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }
        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name="method", EmitDefaultValue=false)]
        public string Method { get; set; }
        /// <summary>
        /// Gets or Sets PollUrl
        /// </summary>
        [DataMember(Name="pollUrl", EmitDefaultValue=false)]
        public string PollUrl { get; set; }
        /// <summary>
        /// Gets or Sets ReceivedTime
        /// </summary>
        [DataMember(Name="receivedTime", EmitDefaultValue=false)]
        public DateTime? ReceivedTime { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeployResponse {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  PollUrl: ").Append(PollUrl).Append("\n");
            sb.Append("  ReceivedTime: ").Append(ReceivedTime).Append("\n");
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
            return this.Equals(obj as DeployResponse);
        }

        /// <summary>
        /// Returns true if DeployResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of DeployResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeployResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.Method == other.Method ||
                    this.Method != null &&
                    this.Method.Equals(other.Method)
                ) && 
                (
                    this.PollUrl == other.PollUrl ||
                    this.PollUrl != null &&
                    this.PollUrl.Equals(other.PollUrl)
                ) && 
                (
                    this.ReceivedTime == other.ReceivedTime ||
                    this.ReceivedTime != null &&
                    this.ReceivedTime.Equals(other.ReceivedTime)
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
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.Method != null)
                    hash = hash * 59 + this.Method.GetHashCode();
                if (this.PollUrl != null)
                    hash = hash * 59 + this.PollUrl.GetHashCode();
                if (this.ReceivedTime != null)
                    hash = hash * 59 + this.ReceivedTime.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
