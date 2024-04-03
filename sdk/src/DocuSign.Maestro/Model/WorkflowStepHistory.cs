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
    /// Details (history) of a Workflow Instance Step
    /// </summary>
    [DataContract]
    public partial class WorkflowStepHistory :  IEquatable<WorkflowStepHistory>, IValidatableObject
    {
        public WorkflowStepHistory()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Gets or Sets StepState
        /// </summary>
        [DataMember(Name="stepState", EmitDefaultValue=false)]
        public WorkflowStepHistoryState? StepState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowStepHistory" /> class.
        /// </summary>
        /// <param name="AccountId">AccountId.</param>
        /// <param name="DacId">DacId (required).</param>
        /// <param name="DsStepId">DsStepId.</param>
        /// <param name="EndDate">Track the End time of the Workflow Step.</param>
        /// <param name="Error">Error.</param>
        /// <param name="OutputModuleProperties">OutputModuleProperties.</param>
        /// <param name="StartDate">Track the Start time of the Workflow Step.</param>
        /// <param name="StepId">The Step Id of the workflow step in the workflow instance.</param>
        /// <param name="StepName">Name of the workflow step (DS Scope) (required).</param>
        /// <param name="StepState">StepState (required).</param>
        /// <param name="UserId">UserId (required).</param>
        public WorkflowStepHistory(string AccountId = default(string), string DacId = default(string), string DsStepId = default(string), DateTime? EndDate = default(DateTime?), WorkflowStepError Error = default(WorkflowStepError), Object OutputModuleProperties = default(Object), DateTime? StartDate = default(DateTime?), string StepId = default(string), string StepName = default(string), WorkflowStepHistoryState? StepState = default(WorkflowStepHistoryState?), string UserId = default(string))
        {
            // to ensure "DacId" is required (not null)
            if (DacId == null)
            {
                throw new InvalidDataException("DacId is a required property for WorkflowStepHistory and cannot be null");
            }
            else
            {
                this.DacId = DacId;
            }
            // to ensure "StepName" is required (not null)
            if (StepName == null)
            {
                throw new InvalidDataException("StepName is a required property for WorkflowStepHistory and cannot be null");
            }
            else
            {
                this.StepName = StepName;
            }
            // to ensure "StepState" is required (not null)
            if (StepState == null)
            {
                throw new InvalidDataException("StepState is a required property for WorkflowStepHistory and cannot be null");
            }
            else
            {
                this.StepState = StepState;
            }
            // to ensure "UserId" is required (not null)
            if (UserId == null)
            {
                throw new InvalidDataException("UserId is a required property for WorkflowStepHistory and cannot be null");
            }
            else
            {
                this.UserId = UserId;
            }
            this.AccountId = AccountId;
            this.DsStepId = DsStepId;
            this.EndDate = EndDate;
            this.Error = Error;
            this.OutputModuleProperties = OutputModuleProperties;
            this.StartDate = StartDate;
            this.StepId = StepId;
        }
        
        /// <summary>
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public string AccountId { get; set; }
        /// <summary>
        /// Gets or Sets DacId
        /// </summary>
        [DataMember(Name="dacId", EmitDefaultValue=false)]
        public string DacId { get; set; }
        /// <summary>
        /// Gets or Sets DsStepId
        /// </summary>
        [DataMember(Name="dsStepId", EmitDefaultValue=false)]
        public string DsStepId { get; set; }
        /// <summary>
        /// Track the End time of the Workflow Step
        /// </summary>
        /// <value>Track the End time of the Workflow Step</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public WorkflowStepError Error { get; set; }
        /// <summary>
        /// Gets or Sets OutputModuleProperties
        /// </summary>
        [DataMember(Name="outputModuleProperties", EmitDefaultValue=false)]
        public Object OutputModuleProperties { get; set; }
        /// <summary>
        /// Track the Start time of the Workflow Step
        /// </summary>
        /// <value>Track the Start time of the Workflow Step</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// The Step Id of the workflow step in the workflow instance
        /// </summary>
        /// <value>The Step Id of the workflow step in the workflow instance</value>
        [DataMember(Name="stepId", EmitDefaultValue=false)]
        public string StepId { get; set; }
        /// <summary>
        /// Name of the workflow step (DS Scope)
        /// </summary>
        /// <value>Name of the workflow step (DS Scope)</value>
        [DataMember(Name="stepName", EmitDefaultValue=false)]
        public string StepName { get; set; }
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkflowStepHistory {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  DacId: ").Append(DacId).Append("\n");
            sb.Append("  DsStepId: ").Append(DsStepId).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  OutputModuleProperties: ").Append(OutputModuleProperties).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  StepId: ").Append(StepId).Append("\n");
            sb.Append("  StepName: ").Append(StepName).Append("\n");
            sb.Append("  StepState: ").Append(StepState).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(obj as WorkflowStepHistory);
        }

        /// <summary>
        /// Returns true if WorkflowStepHistory instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkflowStepHistory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkflowStepHistory other)
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
                    this.DacId == other.DacId ||
                    this.DacId != null &&
                    this.DacId.Equals(other.DacId)
                ) && 
                (
                    this.DsStepId == other.DsStepId ||
                    this.DsStepId != null &&
                    this.DsStepId.Equals(other.DsStepId)
                ) && 
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
                ) && 
                (
                    this.Error == other.Error ||
                    this.Error != null &&
                    this.Error.Equals(other.Error)
                ) && 
                (
                    this.OutputModuleProperties == other.OutputModuleProperties ||
                    this.OutputModuleProperties != null &&
                    this.OutputModuleProperties.Equals(other.OutputModuleProperties)
                ) && 
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) && 
                (
                    this.StepId == other.StepId ||
                    this.StepId != null &&
                    this.StepId.Equals(other.StepId)
                ) && 
                (
                    this.StepName == other.StepName ||
                    this.StepName != null &&
                    this.StepName.Equals(other.StepName)
                ) && 
                (
                    this.StepState == other.StepState ||
                    this.StepState != null &&
                    this.StepState.Equals(other.StepState)
                ) && 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
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
                if (this.DacId != null)
                    hash = hash * 59 + this.DacId.GetHashCode();
                if (this.DsStepId != null)
                    hash = hash * 59 + this.DsStepId.GetHashCode();
                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();
                if (this.Error != null)
                    hash = hash * 59 + this.Error.GetHashCode();
                if (this.OutputModuleProperties != null)
                    hash = hash * 59 + this.OutputModuleProperties.GetHashCode();
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                if (this.StepId != null)
                    hash = hash * 59 + this.StepId.GetHashCode();
                if (this.StepName != null)
                    hash = hash * 59 + this.StepName.GetHashCode();
                if (this.StepState != null)
                    hash = hash * 59 + this.StepState.GetHashCode();
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
