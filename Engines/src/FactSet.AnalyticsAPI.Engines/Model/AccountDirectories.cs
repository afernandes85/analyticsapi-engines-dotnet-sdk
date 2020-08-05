/* 
 * Engines API
 *
 * Allow clients to fetch Engines Analytics through APIs.
 *
 * The version of the OpenAPI document: 2
 * Contact: analytics.api.support@factset.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = FactSet.AnalyticsAPI.Engines.Client.OpenAPIDateConverter;

namespace FactSet.AnalyticsAPI.Engines.Model
{
    /// <summary>
    /// AccountDirectories
    /// </summary>
    [DataContract]
    public partial class AccountDirectories :  IEquatable<AccountDirectories>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDirectories" /> class.
        /// </summary>
        /// <param name="accounts">List of account and composite files..</param>
        /// <param name="directories">List of directories..</param>
        public AccountDirectories(List<string> accounts = default(List<string>), List<string> directories = default(List<string>))
        {
            this.Accounts = accounts;
            this.Directories = directories;
        }
        
        /// <summary>
        /// List of account and composite files.
        /// </summary>
        /// <value>List of account and composite files.</value>
        [DataMember(Name="accounts", EmitDefaultValue=false)]
        public List<string> Accounts { get; set; }

        /// <summary>
        /// List of directories.
        /// </summary>
        /// <value>List of directories.</value>
        [DataMember(Name="directories", EmitDefaultValue=false)]
        public List<string> Directories { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountDirectories {\n");
            sb.Append("  Accounts: ").Append(Accounts).Append("\n");
            sb.Append("  Directories: ").Append(Directories).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccountDirectories);
        }

        /// <summary>
        /// Returns true if AccountDirectories instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountDirectories to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountDirectories input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Accounts == input.Accounts ||
                    this.Accounts != null &&
                    input.Accounts != null &&
                    this.Accounts.SequenceEqual(input.Accounts)
                ) && 
                (
                    this.Directories == input.Directories ||
                    this.Directories != null &&
                    input.Directories != null &&
                    this.Directories.SequenceEqual(input.Directories)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Accounts != null)
                    hashCode = hashCode * 59 + this.Accounts.GetHashCode();
                if (this.Directories != null)
                    hashCode = hashCode * 59 + this.Directories.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}