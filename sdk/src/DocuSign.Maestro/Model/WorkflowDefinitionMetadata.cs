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
    /// A DS workflow definition&#39;s metadata.
    /// </summary>
    [DataContract]
    public partial class WorkflowDefinitionMetadata :  IEquatable<WorkflowDefinitionMetadata>, IValidatableObject
    {
        public WorkflowDefinitionMetadata()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public WorkflowMetadataStatus? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowDefinitionMetadata" /> class.
        /// </summary>
        /// <param name="AccountId">AccountId.</param>
        /// <param name="CreatedDate">The date the workflow was created.</param>
        /// <param name="Id">Id (required).</param>
        /// <param name="IsDraft">IsDraft.</param>
        /// <param name="LastDeployedId">LastDeployedId.</param>
        /// <param name="LastDeployedVersion">LastDeployedVersion.</param>
        /// <param name="LastUpdatedDate">The date the workflow was last updated.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Status">Status.</param>
        /// <param name="TriggerUrl">TriggerUrl.</param>
        public WorkflowDefinitionMetadata(string AccountId = default(string), DateTime? CreatedDate = default(DateTime?), string Id = default(string), bool? IsDraft = default(bool?), string LastDeployedId = default(string), string LastDeployedVersion = default(string), DateTime? LastUpdatedDate = default(DateTime?), string Name = default(string), WorkflowMetadataStatus? Status = default(WorkflowMetadataStatus?), string TriggerUrl = default(string))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for WorkflowDefinitionMetadata and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            this.AccountId = AccountId;
            this.CreatedDate = CreatedDate;
            this.IsDraft = IsDraft;
            this.LastDeployedId = LastDeployedId;
            this.LastDeployedVersion = LastDeployedVersion;
            this.LastUpdatedDate = LastUpdatedDate;
            this.Name = Name;
            this.Status = Status;
            this.TriggerUrl = TriggerUrl;
        }
        
        /// <summary>
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public string AccountId { get; set; }
        /// <summary>
        /// The date the workflow was created
        /// </summary>
        /// <value>The date the workflow was created</value>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets IsDraft
        /// </summary>
        [DataMember(Name="isDraft", EmitDefaultValue=false)]
        public bool? IsDraft { get; set; }
        /// <summary>
        /// Gets or Sets LastDeployedId
        /// </summary>
        [DataMember(Name="lastDeployedId", EmitDefaultValue=false)]
        public string LastDeployedId { get; set; }
        /// <summary>
        /// Gets or Sets LastDeployedVersion
        /// </summary>
        [DataMember(Name="lastDeployedVersion", EmitDefaultValue=false)]
        public string LastDeployedVersion { get; set; }
        /// <summary>
        /// The date the workflow was last updated
        /// </summary>
        /// <value>The date the workflow was last updated</value>
        [DataMember(Name="lastUpdatedDate", EmitDefaultValue=false)]
        public DateTime? LastUpdatedDate { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets TriggerUrl
        /// </summary>
        [DataMember(Name="triggerUrl", EmitDefaultValue=false)]
        public string TriggerUrl { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkflowDefinitionMetadata {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsDraft: ").Append(IsDraft).Append("\n");
            sb.Append("  LastDeployedId: ").Append(LastDeployedId).Append("\n");
            sb.Append("  LastDeployedVersion: ").Append(LastDeployedVersion).Append("\n");
            sb.Append("  LastUpdatedDate: ").Append(LastUpdatedDate).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TriggerUrl: ").Append(TriggerUrl).Append("\n");
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
            return this.Equals(obj as WorkflowDefinitionMetadata);
        }

        /// <summary>
        /// Returns true if WorkflowDefinitionMetadata instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkflowDefinitionMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkflowDefinitionMetadata other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccountId == other.AccountId ||
                    this.AccountId != null &&
                    this.AccountId.Equals(other.AccountId)
                ) && 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.IsDraft == other.IsDraft ||
                    this.IsDraft != null &&
                    this.IsDraft.Equals(other.IsDraft)
                ) && 
                (
                    this.LastDeployedId == other.LastDeployedId ||
                    this.LastDeployedId != null &&
                    this.LastDeployedId.Equals(other.LastDeployedId)
                ) && 
                (
                    this.LastDeployedVersion == other.LastDeployedVersion ||
                    this.LastDeployedVersion != null &&
                    this.LastDeployedVersion.Equals(other.LastDeployedVersion)
                ) && 
                (
                    this.LastUpdatedDate == other.LastUpdatedDate ||
                    this.LastUpdatedDate != null &&
                    this.LastUpdatedDate.Equals(other.LastUpdatedDate)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.TriggerUrl == other.TriggerUrl ||
                    this.TriggerUrl != null &&
                    this.TriggerUrl.Equals(other.TriggerUrl)
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
                if (this.AccountId != null)
                    hash = hash * 59 + this.AccountId.GetHashCode();
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.IsDraft != null)
                    hash = hash * 59 + this.IsDraft.GetHashCode();
                if (this.LastDeployedId != null)
                    hash = hash * 59 + this.LastDeployedId.GetHashCode();
                if (this.LastDeployedVersion != null)
                    hash = hash * 59 + this.LastDeployedVersion.GetHashCode();
                if (this.LastUpdatedDate != null)
                    hash = hash * 59 + this.LastUpdatedDate.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.TriggerUrl != null)
                    hash = hash * 59 + this.TriggerUrl.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
