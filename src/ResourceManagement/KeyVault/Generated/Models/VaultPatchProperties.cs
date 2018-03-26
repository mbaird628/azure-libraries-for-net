// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.KeyVault.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Properties of the vault
    /// </summary>
    public partial class VaultPatchProperties
    {
        /// <summary>
        /// Initializes a new instance of the VaultPatchProperties class.
        /// </summary>
        public VaultPatchProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VaultPatchProperties class.
        /// </summary>
        /// <param name="tenantId">The Azure Active Directory tenant ID that
        /// should be used for authenticating requests to the key
        /// vault.</param>
        /// <param name="sku">SKU details</param>
        /// <param name="accessPolicies">An array of 0 to 16 identities that
        /// have access to the key vault. All identities in the array must use
        /// the same tenant ID as the key vault's tenant ID.</param>
        /// <param name="enabledForDeployment">Property to specify whether
        /// Azure Virtual Machines are permitted to retrieve certificates
        /// stored as secrets from the key vault.</param>
        /// <param name="enabledForDiskEncryption">Property to specify whether
        /// Azure Disk Encryption is permitted to retrieve secrets from the
        /// vault and unwrap keys.</param>
        /// <param name="enabledForTemplateDeployment">Property to specify
        /// whether Azure Resource Manager is permitted to retrieve secrets
        /// from the key vault.</param>
        /// <param name="enableSoftDelete">Property specifying whether
        /// recoverable deletion ('soft' delete) is enabled for this key vault.
        /// The property may not be set to false.</param>
        /// <param name="createMode">The vault's create mode to indicate
        /// whether the vault need to be recovered or not. Possible values
        /// include: 'recover', 'default'</param>
        /// <param name="enablePurgeProtection">Property specifying whether
        /// protection against purge is enabled for this vault; it is only
        /// effective if soft delete is also enabled. Once activated, the
        /// property may no longer be reset to false.</param>
        public VaultPatchProperties(System.Guid? tenantId = default(System.Guid?), Sku sku = default(Sku), IList<AccessPolicyEntry> accessPolicies = default(IList<AccessPolicyEntry>), bool? enabledForDeployment = default(bool?), bool? enabledForDiskEncryption = default(bool?), bool? enabledForTemplateDeployment = default(bool?), bool? enableSoftDelete = default(bool?), CreateMode? createMode = default(CreateMode?), bool? enablePurgeProtection = default(bool?))
        {
            TenantId = tenantId;
            Sku = sku;
            AccessPolicies = accessPolicies;
            EnabledForDeployment = enabledForDeployment;
            EnabledForDiskEncryption = enabledForDiskEncryption;
            EnabledForTemplateDeployment = enabledForTemplateDeployment;
            EnableSoftDelete = enableSoftDelete;
            CreateMode = createMode;
            EnablePurgeProtection = enablePurgeProtection;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Azure Active Directory tenant ID that should be
        /// used for authenticating requests to the key vault.
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public System.Guid? TenantId { get; set; }

        /// <summary>
        /// Gets or sets SKU details
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets an array of 0 to 16 identities that have access to the
        /// key vault. All identities in the array must use the same tenant ID
        /// as the key vault's tenant ID.
        /// </summary>
        [JsonProperty(PropertyName = "accessPolicies")]
        public IList<AccessPolicyEntry> AccessPolicies { get; set; }

        /// <summary>
        /// Gets or sets property to specify whether Azure Virtual Machines are
        /// permitted to retrieve certificates stored as secrets from the key
        /// vault.
        /// </summary>
        [JsonProperty(PropertyName = "enabledForDeployment")]
        public bool? EnabledForDeployment { get; set; }

        /// <summary>
        /// Gets or sets property to specify whether Azure Disk Encryption is
        /// permitted to retrieve secrets from the vault and unwrap keys.
        /// </summary>
        [JsonProperty(PropertyName = "enabledForDiskEncryption")]
        public bool? EnabledForDiskEncryption { get; set; }

        /// <summary>
        /// Gets or sets property to specify whether Azure Resource Manager is
        /// permitted to retrieve secrets from the key vault.
        /// </summary>
        [JsonProperty(PropertyName = "enabledForTemplateDeployment")]
        public bool? EnabledForTemplateDeployment { get; set; }

        /// <summary>
        /// Gets or sets property specifying whether recoverable deletion
        /// ('soft' delete) is enabled for this key vault. The property may not
        /// be set to false.
        /// </summary>
        [JsonProperty(PropertyName = "enableSoftDelete")]
        public bool? EnableSoftDelete { get; set; }

        /// <summary>
        /// Gets or sets the vault's create mode to indicate whether the vault
        /// need to be recovered or not. Possible values include: 'recover',
        /// 'default'
        /// </summary>
        [JsonProperty(PropertyName = "createMode")]
        public CreateMode? CreateMode { get; set; }

        /// <summary>
        /// Gets or sets property specifying whether protection against purge
        /// is enabled for this vault; it is only effective if soft delete is
        /// also enabled. Once activated, the property may no longer be reset
        /// to false.
        /// </summary>
        [JsonProperty(PropertyName = "enablePurgeProtection")]
        public bool? EnablePurgeProtection { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Sku != null)
            {
                Sku.Validate();
            }
            if (AccessPolicies != null)
            {
                foreach (var element in AccessPolicies)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
