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
    /// DSDoUntilStep
    /// </summary>
    [DataContract]
    public partial class DSDoUntilStep :  IEquatable<DSDoUntilStep>, IValidatableObject
    {
        public DSDoUntilStep()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DSDoUntilStep" /> class.
        /// </summary>
        /// <param name="DoSteps">A list of #/definitions/DSWorkflowStep. Each element is: A DS Workflow Step. This object should be any of the following object models: [#/definitions/DSServiceStep, #/definitions/DSTransformationStep, #/definitions/DSDocGenStep, #/definitions/DSSignStep] (required).</param>
        /// <param name="Expression">Expression (required).</param>
        /// <param name="Id">Id (required).</param>
        /// <param name="Name">Name (required).</param>
        /// <param name="Type">Type (required).</param>
        public DSDoUntilStep(List<Object> DoSteps = default(List<Object>), DSWorkflowComparisonExpression Expression = default(DSWorkflowComparisonExpression), string Id = default(string), string Name = default(string), DSWorkflowStepTypesDoUntil Type = default(DSWorkflowStepTypesDoUntil))
        {
            // to ensure "DoSteps" is required (not null)
            if (DoSteps == null)
            {
                throw new InvalidDataException("DoSteps is a required property for DSDoUntilStep and cannot be null");
            }
            else
            {
                this.DoSteps = DoSteps;
            }
            // to ensure "Expression" is required (not null)
            if (Expression == null)
            {
                throw new InvalidDataException("Expression is a required property for DSDoUntilStep and cannot be null");
            }
            else
            {
                this.Expression = Expression;
            }
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for DSDoUntilStep and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for DSDoUntilStep and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for DSDoUntilStep and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
        }
        
        /// <summary>
        /// A list of #/definitions/DSWorkflowStep. Each element is: A DS Workflow Step. This object should be any of the following object models: [#/definitions/DSServiceStep, #/definitions/DSTransformationStep, #/definitions/DSDocGenStep, #/definitions/DSSignStep]
        /// </summary>
        /// <value>A list of #/definitions/DSWorkflowStep. Each element is: A DS Workflow Step. This object should be any of the following object models: [#/definitions/DSServiceStep, #/definitions/DSTransformationStep, #/definitions/DSDocGenStep, #/definitions/DSSignStep]</value>
        [DataMember(Name="doSteps", EmitDefaultValue=false)]
        public List<Object> DoSteps { get; set; }
        /// <summary>
        /// Gets or Sets Expression
        /// </summary>
        [DataMember(Name="expression", EmitDefaultValue=false)]
        public DSWorkflowComparisonExpression Expression { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public DSWorkflowStepTypesDoUntil Type { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DSDoUntilStep {\n");
            sb.Append("  DoSteps: ").Append(DoSteps).Append("\n");
            sb.Append("  Expression: ").Append(Expression).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as DSDoUntilStep);
        }

        /// <summary>
        /// Returns true if DSDoUntilStep instances are equal
        /// </summary>
        /// <param name="other">Instance of DSDoUntilStep to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DSDoUntilStep other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DoSteps == other.DoSteps ||
                    this.DoSteps != null &&
                    this.DoSteps.SequenceEqual(other.DoSteps)
                ) && 
                (
                    this.Expression == other.Expression ||
                    this.Expression != null &&
                    this.Expression.Equals(other.Expression)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.DoSteps != null)
                    hash = hash * 59 + this.DoSteps.GetHashCode();
                if (this.Expression != null)
                    hash = hash * 59 + this.Expression.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}