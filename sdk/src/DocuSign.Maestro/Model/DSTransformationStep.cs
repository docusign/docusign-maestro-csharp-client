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
    /// DSTransformationStep
    /// </summary>
    [DataContract]
    public partial class DSTransformationStep :  IEquatable<DSTransformationStep>, IValidatableObject
    {
        public DSTransformationStep()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DSTransformationStep" /> class.
        /// </summary>
        /// <param name="Config">Config (required).</param>
        /// <param name="Expression">Reference of #/definitions/DSWorkflowTransformationExpression. Transformation Expression object. This object should be any of the following object models: [#/definitions/DSWorkflowReplaceExpression, #/definitions/DSWorkflowToLowerExpression, #/definitions/DSWorkflowToUpperExpression, #/components/schemas/DSWorkflowLastIndexOfExpression, #/components/schemas/DSWorkflowIndexOfExpression, #/components/schemas/DSWorkflowSubstringExpression, #/components/schemas/DSWorkflowConcatExpression] (required).</param>
        /// <param name="Id">Id (required).</param>
        /// <param name="Input">A Record of strings to Strings, Variables, or Transformation Expressions (required).</param>
        /// <param name="Name">Name (required).</param>
        /// <param name="Output">A Record of strings to Strings, Variables, or Transformation Expressions (required).</param>
        /// <param name="Type">Type (required).</param>
        public DSTransformationStep(RecordToNever Config = default(RecordToNever), Object Expression = default(Object), string Id = default(string), Dictionary<string, Object> Input = default(Dictionary<string, Object>), string Name = default(string), Dictionary<string, Object> Output = default(Dictionary<string, Object>), DSWorkflowStepTypesDSTransformation Type = default(DSWorkflowStepTypesDSTransformation))
        {
            // to ensure "Config" is required (not null)
            if (Config == null)
            {
                throw new InvalidDataException("Config is a required property for DSTransformationStep and cannot be null");
            }
            else
            {
                this.Config = Config;
            }
            // to ensure "Expression" is required (not null)
            if (Expression == null)
            {
                throw new InvalidDataException("Expression is a required property for DSTransformationStep and cannot be null");
            }
            else
            {
                this.Expression = Expression;
            }
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for DSTransformationStep and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Input" is required (not null)
            if (Input == null)
            {
                throw new InvalidDataException("Input is a required property for DSTransformationStep and cannot be null");
            }
            else
            {
                this.Input = Input;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for DSTransformationStep and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Output" is required (not null)
            if (Output == null)
            {
                throw new InvalidDataException("Output is a required property for DSTransformationStep and cannot be null");
            }
            else
            {
                this.Output = Output;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for DSTransformationStep and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
        }
        
        /// <summary>
        /// Gets or Sets Config
        /// </summary>
        [DataMember(Name="config", EmitDefaultValue=false)]
        public RecordToNever Config { get; set; }
        /// <summary>
        /// Reference of #/definitions/DSWorkflowTransformationExpression. Transformation Expression object. This object should be any of the following object models: [#/definitions/DSWorkflowReplaceExpression, #/definitions/DSWorkflowToLowerExpression, #/definitions/DSWorkflowToUpperExpression, #/components/schemas/DSWorkflowLastIndexOfExpression, #/components/schemas/DSWorkflowIndexOfExpression, #/components/schemas/DSWorkflowSubstringExpression, #/components/schemas/DSWorkflowConcatExpression]
        /// </summary>
        /// <value>Reference of #/definitions/DSWorkflowTransformationExpression. Transformation Expression object. This object should be any of the following object models: [#/definitions/DSWorkflowReplaceExpression, #/definitions/DSWorkflowToLowerExpression, #/definitions/DSWorkflowToUpperExpression, #/components/schemas/DSWorkflowLastIndexOfExpression, #/components/schemas/DSWorkflowIndexOfExpression, #/components/schemas/DSWorkflowSubstringExpression, #/components/schemas/DSWorkflowConcatExpression]</value>
        [DataMember(Name="expression", EmitDefaultValue=false)]
        public Object Expression { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// A Record of strings to Strings, Variables, or Transformation Expressions
        /// </summary>
        /// <value>A Record of strings to Strings, Variables, or Transformation Expressions</value>
        [DataMember(Name="input", EmitDefaultValue=false)]
        public Dictionary<string, Object> Input { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// A Record of strings to Strings, Variables, or Transformation Expressions
        /// </summary>
        /// <value>A Record of strings to Strings, Variables, or Transformation Expressions</value>
        [DataMember(Name="output", EmitDefaultValue=false)]
        public Dictionary<string, Object> Output { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public DSWorkflowStepTypesDSTransformation Type { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DSTransformationStep {\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  Expression: ").Append(Expression).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Input: ").Append(Input).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Output: ").Append(Output).Append("\n");
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
            return this.Equals(obj as DSTransformationStep);
        }

        /// <summary>
        /// Returns true if DSTransformationStep instances are equal
        /// </summary>
        /// <param name="other">Instance of DSTransformationStep to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DSTransformationStep other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Config == other.Config ||
                    this.Config != null &&
                    this.Config.Equals(other.Config)
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
                    this.Input == other.Input ||
                    this.Input != null &&
                    this.Input.SequenceEqual(other.Input)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Output == other.Output ||
                    this.Output != null &&
                    this.Output.SequenceEqual(other.Output)
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
                if (this.Config != null)
                    hash = hash * 59 + this.Config.GetHashCode();
                if (this.Expression != null)
                    hash = hash * 59 + this.Expression.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Input != null)
                    hash = hash * 59 + this.Input.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Output != null)
                    hash = hash * 59 + this.Output.GetHashCode();
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
