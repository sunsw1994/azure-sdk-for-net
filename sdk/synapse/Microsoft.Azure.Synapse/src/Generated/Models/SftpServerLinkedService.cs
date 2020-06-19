// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Synapse.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A linked service for an SSH File Transfer Protocol (SFTP) server.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Sftp")]
    [Rest.Serialization.JsonTransformation]
    public partial class SftpServerLinkedService : LinkedService
    {
        /// <summary>
        /// Initializes a new instance of the SftpServerLinkedService class.
        /// </summary>
        public SftpServerLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SftpServerLinkedService class.
        /// </summary>
        /// <param name="host">The SFTP server host name. Type: string (or
        /// Expression with resultType string).</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="connectVia">The integration runtime reference.</param>
        /// <param name="description">Linked service description.</param>
        /// <param name="parameters">Parameters for linked service.</param>
        /// <param name="annotations">List of tags that can be used for
        /// describing the linked service.</param>
        /// <param name="port">The TCP port number that the SFTP server uses to
        /// listen for client connections. Default value is 22. Type: integer
        /// (or Expression with resultType integer), minimum: 0.</param>
        /// <param name="authenticationType">The authentication type to be used
        /// to connect to the FTP server. Possible values include: 'Basic',
        /// 'SshPublicKey'</param>
        /// <param name="userName">The username used to log on to the SFTP
        /// server. Type: string (or Expression with resultType
        /// string).</param>
        /// <param name="password">Password to logon the SFTP server for Basic
        /// authentication.</param>
        /// <param name="encryptedCredential">The encrypted credential used for
        /// authentication. Credentials are encrypted using the integration
        /// runtime credential manager. Type: string (or Expression with
        /// resultType string).</param>
        /// <param name="privateKeyPath">The SSH private key file path for
        /// SshPublicKey authentication. Only valid for on-premises copy. For
        /// on-premises copy with SshPublicKey authentication, either
        /// PrivateKeyPath or PrivateKeyContent should be specified. SSH
        /// private key should be OpenSSH format. Type: string (or Expression
        /// with resultType string).</param>
        /// <param name="privateKeyContent">Base64 encoded SSH private key
        /// content for SshPublicKey authentication. For on-premises copy with
        /// SshPublicKey authentication, either PrivateKeyPath or
        /// PrivateKeyContent should be specified. SSH private key should be
        /// OpenSSH format.</param>
        /// <param name="passPhrase">The password to decrypt the SSH private
        /// key if the SSH private key is encrypted.</param>
        /// <param name="skipHostKeyValidation">If true, skip the SSH host key
        /// validation. Default value is false. Type: boolean (or Expression
        /// with resultType boolean).</param>
        /// <param name="hostKeyFingerprint">The host key finger-print of the
        /// SFTP server. When SkipHostKeyValidation is false,
        /// HostKeyFingerprint should be specified. Type: string (or Expression
        /// with resultType string).</param>
        public SftpServerLinkedService(object host, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), IntegrationRuntimeReference connectVia = default(IntegrationRuntimeReference), string description = default(string), IDictionary<string, ParameterSpecification> parameters = default(IDictionary<string, ParameterSpecification>), IList<object> annotations = default(IList<object>), object port = default(object), string authenticationType = default(string), object userName = default(object), SecretBase password = default(SecretBase), object encryptedCredential = default(object), object privateKeyPath = default(object), SecretBase privateKeyContent = default(SecretBase), SecretBase passPhrase = default(SecretBase), object skipHostKeyValidation = default(object), object hostKeyFingerprint = default(object))
            : base(additionalProperties, connectVia, description, parameters, annotations)
        {
            Host = host;
            Port = port;
            AuthenticationType = authenticationType;
            UserName = userName;
            Password = password;
            EncryptedCredential = encryptedCredential;
            PrivateKeyPath = privateKeyPath;
            PrivateKeyContent = privateKeyContent;
            PassPhrase = passPhrase;
            SkipHostKeyValidation = skipHostKeyValidation;
            HostKeyFingerprint = hostKeyFingerprint;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the SFTP server host name. Type: string (or Expression
        /// with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.host")]
        public object Host { get; set; }

        /// <summary>
        /// Gets or sets the TCP port number that the SFTP server uses to
        /// listen for client connections. Default value is 22. Type: integer
        /// (or Expression with resultType integer), minimum: 0.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.port")]
        public object Port { get; set; }

        /// <summary>
        /// Gets or sets the authentication type to be used to connect to the
        /// FTP server. Possible values include: 'Basic', 'SshPublicKey'
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.authenticationType")]
        public string AuthenticationType { get; set; }

        /// <summary>
        /// Gets or sets the username used to log on to the SFTP server. Type:
        /// string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.userName")]
        public object UserName { get; set; }

        /// <summary>
        /// Gets or sets password to logon the SFTP server for Basic
        /// authentication.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.password")]
        public SecretBase Password { get; set; }

        /// <summary>
        /// Gets or sets the encrypted credential used for authentication.
        /// Credentials are encrypted using the integration runtime credential
        /// manager. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.encryptedCredential")]
        public object EncryptedCredential { get; set; }

        /// <summary>
        /// Gets or sets the SSH private key file path for SshPublicKey
        /// authentication. Only valid for on-premises copy. For on-premises
        /// copy with SshPublicKey authentication, either PrivateKeyPath or
        /// PrivateKeyContent should be specified. SSH private key should be
        /// OpenSSH format. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.privateKeyPath")]
        public object PrivateKeyPath { get; set; }

        /// <summary>
        /// Gets or sets base64 encoded SSH private key content for
        /// SshPublicKey authentication. For on-premises copy with SshPublicKey
        /// authentication, either PrivateKeyPath or PrivateKeyContent should
        /// be specified. SSH private key should be OpenSSH format.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.privateKeyContent")]
        public SecretBase PrivateKeyContent { get; set; }

        /// <summary>
        /// Gets or sets the password to decrypt the SSH private key if the SSH
        /// private key is encrypted.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.passPhrase")]
        public SecretBase PassPhrase { get; set; }

        /// <summary>
        /// Gets or sets if true, skip the SSH host key validation. Default
        /// value is false. Type: boolean (or Expression with resultType
        /// boolean).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.skipHostKeyValidation")]
        public object SkipHostKeyValidation { get; set; }

        /// <summary>
        /// Gets or sets the host key finger-print of the SFTP server. When
        /// SkipHostKeyValidation is false, HostKeyFingerprint should be
        /// specified. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.hostKeyFingerprint")]
        public object HostKeyFingerprint { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Host == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Host");
            }
        }
    }
}
