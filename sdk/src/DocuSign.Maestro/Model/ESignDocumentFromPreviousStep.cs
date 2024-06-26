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
    /// ESignDocumentFromPreviousStep
    /// </summary>
    [DataContract]
    public partial class ESignDocumentFromPreviousStep :  IEquatable<ESignDocumentFromPreviousStep>, IValidatableObject
    {
        public ESignDocumentFromPreviousStep()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Gets or Sets FileExtension
        /// </summary>
        [DataMember(Name="fileExtension", EmitDefaultValue=false)]
        public DSWorkflowDocGenDocOutputFormat? FileExtension { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ESignDocumentFromPreviousStep" /> class.
        /// </summary>
        /// <param name="DocumentFromPreviousStep">Reference of #/definitions/DSWorkflowVariable. DS Workflow Variables (required).</param>
        /// <param name="FileExtension">FileExtension (required).</param>
        /// <param name="Name">Reference of #/definitions/StringOrVariableOrTransformation. Object stands for a String or a Variable or a Transformation. This object should be any of the following object models or types: [string, #/definitions/DSWorkflowVariable, #/definitions/DSWorkflowTransformationExpression] (required).</param>
        /// <param name="Type">Type (required).</param>
        public ESignDocumentFromPreviousStep(Object DocumentFromPreviousStep = default(Object), DSWorkflowDocGenDocOutputFormat? FileExtension = default(DSWorkflowDocGenDocOutputFormat?), Object Name = default(Object), ESignDocumentTypesFromPreviousStep Type = default(ESignDocumentTypesFromPreviousStep))
        {
            // to ensure "DocumentFromPreviousStep" is required (not null)
            if (DocumentFromPreviousStep == null)
            {
                throw new InvalidDataException("DocumentFromPreviousStep is a required property for ESignDocumentFromPreviousStep and cannot be null");
            }
            else
            {
                this.DocumentFromPreviousStep = DocumentFromPreviousStep;
            }
            // to ensure "FileExtension" is required (not null)
            if (FileExtension == null)
            {
                throw new InvalidDataException("FileExtension is a required property for ESignDocumentFromPreviousStep and cannot be null");
            }
            else
            {
                this.FileExtension = FileExtension;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for ESignDocumentFromPreviousStep and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for ESignDocumentFromPreviousStep and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
        }
        
        /// <summary>
        /// Reference of #/definitions/DSWorkflowVariable. DS Workflow Variables
        /// </summary>
        /// <value>Reference of #/definitions/DSWorkflowVariable. DS Workflow Variables</value>
        [DataMember(Name="documentFromPreviousStep", EmitDefaultValue=false)]
        public Object DocumentFromPreviousStep { get; set; }
        /// <summary>
        /// Reference of #/definitions/StringOrVariableOrTransformation. Object stands for a String or a Variable or a Transformation. This object should be any of the following object models or types: [string, #/definitions/DSWorkflowVariable, #/definitions/DSWorkflowTransformationExpression]
        /// </summary>
        /// <value>Reference of #/definitions/StringOrVariableOrTransformation. Object stands for a String or a Variable or a Transformation. This object should be any of the following object models or types: [string, #/definitions/DSWorkflowVariable, #/definitions/DSWorkflowTransformationExpression]</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public Object Name { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public ESignDocumentTypesFromPreviousStep Type { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ESignDocumentFromPreviousStep {\n");
            sb.Append("  DocumentFromPreviousStep: ").Append(DocumentFromPreviousStep).Append("\n");
            sb.Append("  FileExtension: ").Append(FileExtension).Append("\n");
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
            return this.Equals(obj as ESignDocumentFromPreviousStep);
        }

        /// <summary>
        /// Returns true if ESignDocumentFromPreviousStep instances are equal
        /// </summary>
        /// <param name="other">Instance of ESignDocumentFromPreviousStep to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ESignDocumentFromPreviousStep other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DocumentFromPreviousStep == other.DocumentFromPreviousStep ||
                    this.DocumentFromPreviousStep != null &&
                    this.DocumentFromPreviousStep.Equals(other.DocumentFromPreviousStep)
                ) && 
                (
                    this.FileExtension == other.FileExtension ||
                    this.FileExtension != null &&
                    this.FileExtension.Equals(other.FileExtension)
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
                if (this.DocumentFromPreviousStep != null)
                    hash = hash * 59 + this.DocumentFromPreviousStep.GetHashCode();
                if (this.FileExtension != null)
                    hash = hash * 59 + this.FileExtension.GetHashCode();
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
