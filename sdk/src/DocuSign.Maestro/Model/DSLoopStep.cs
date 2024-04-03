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
    /// DSLoopStep
    /// </summary>
    [DataContract]
    public partial class DSLoopStep :  IEquatable<DSLoopStep>, IValidatableObject
    {
        public DSLoopStep()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DSLoopStep" /> class.
        /// </summary>
        /// <param name="Expression">Expression (required).</param>
        /// <param name="Id">Id (required).</param>
        /// <param name="LoopSteps">A list of #/definitions/DSWorkflowStep. Each element is: A DS Workflow Step. This object should be any of the following object models: [#/definitions/DSServiceStep, #/definitions/DSTransformationStep, #/definitions/DSDocGenStep, #/definitions/DSSignStep] (required).</param>
        /// <param name="Name">Name (required).</param>
        /// <param name="Type">Type (required).</param>
        public DSLoopStep(DSWorkflowComparisonExpression Expression = default(DSWorkflowComparisonExpression), string Id = default(string), List<Object> LoopSteps = default(List<Object>), string Name = default(string), DSWorkflowStepTypesLoop Type = default(DSWorkflowStepTypesLoop))
        {
            // to ensure "Expression" is required (not null)
            if (Expression == null)
            {
                throw new InvalidDataException("Expression is a required property for DSLoopStep and cannot be null");
            }
            else
            {
                this.Expression = Expression;
            }
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for DSLoopStep and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "LoopSteps" is required (not null)
            if (LoopSteps == null)
            {
                throw new InvalidDataException("LoopSteps is a required property for DSLoopStep and cannot be null");
            }
            else
            {
                this.LoopSteps = LoopSteps;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for DSLoopStep and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for DSLoopStep and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
        }
        
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
        /// A list of #/definitions/DSWorkflowStep. Each element is: A DS Workflow Step. This object should be any of the following object models: [#/definitions/DSServiceStep, #/definitions/DSTransformationStep, #/definitions/DSDocGenStep, #/definitions/DSSignStep]
        /// </summary>
        /// <value>A list of #/definitions/DSWorkflowStep. Each element is: A DS Workflow Step. This object should be any of the following object models: [#/definitions/DSServiceStep, #/definitions/DSTransformationStep, #/definitions/DSDocGenStep, #/definitions/DSSignStep]</value>
        [DataMember(Name="loopSteps", EmitDefaultValue=false)]
        public List<Object> LoopSteps { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public DSWorkflowStepTypesLoop Type { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DSLoopStep {\n");
            sb.Append("  Expression: ").Append(Expression).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LoopSteps: ").Append(LoopSteps).Append("\n");
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
            return this.Equals(obj as DSLoopStep);
        }

        /// <summary>
        /// Returns true if DSLoopStep instances are equal
        /// </summary>
        /// <param name="other">Instance of DSLoopStep to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DSLoopStep other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
                    this.LoopSteps == other.LoopSteps ||
                    this.LoopSteps != null &&
                    this.LoopSteps.SequenceEqual(other.LoopSteps)
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
                if (this.Expression != null)
                    hash = hash * 59 + this.Expression.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.LoopSteps != null)
                    hash = hash * 59 + this.LoopSteps.GetHashCode();
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