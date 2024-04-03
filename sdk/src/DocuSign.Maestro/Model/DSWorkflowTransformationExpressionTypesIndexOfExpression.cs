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
    /// Defines DSWorkflowTransformationExpressionTypes.IndexOfExpression
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum DSWorkflowTransformationExpressionTypesIndexOfExpression
    {
        
        /// <summary>
        /// Enum IndexOfExpression for value: IndexOfExpression
        /// </summary>
        [EnumMember(Value = "IndexOfExpression")]
        IndexOfExpression = 1
    }

}
