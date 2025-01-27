// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>
    /// Edgenode is a global Point of Presence (POP) location used to deliver CDN content to end users.
    /// </summary>
    public partial class EdgeNode :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEdgeNode,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEdgeNodeInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.Resource();

        /// <summary>List of ip address groups.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IIPAddressGroup[] IPAddressGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEdgeNodePropertiesInternal)Property).IPAddressGroup; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEdgeNodePropertiesInternal)Property).IPAddressGroup = value ?? null /* arrayOf */; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.FormatTable(Index = 0)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).Id; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEdgeNodeProperties Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEdgeNodeInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.EdgeNodeProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ISystemData Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).Type = value; }

        /// <summary>Resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.DoNotFormat]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEdgeNodeProperties _property;

        /// <summary>The JSON object that contains the properties required to create an edgenode.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEdgeNodeProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.EdgeNodeProperties()); set => this._property = value; }

        /// <summary>Read only system data</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).SystemData; }

        /// <summary>The timestamp of resource creation (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.DoNotFormat]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>An identifier for the identity that created the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.DoNotFormat]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.IdentityType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).SystemDataCreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.IdentityType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.DoNotFormat]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>An identifier for the identity that last modified the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.DoNotFormat]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.IdentityType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).SystemDataLastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.IdentityType)""); }

        /// <summary>Resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.DoNotFormat]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="EdgeNode" /> instance.</summary>
        public EdgeNode()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Edgenode is a global Point of Presence (POP) location used to deliver CDN content to end users.
    public partial interface IEdgeNode :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResource
    {
        /// <summary>List of ip address groups.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of ip address groups.",
        SerializedName = @"ipAddressGroups",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IIPAddressGroup) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IIPAddressGroup[] IPAddressGroup { get; set; }

    }
    /// Edgenode is a global Point of Presence (POP) location used to deliver CDN content to end users.
    internal partial interface IEdgeNodeInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceInternal
    {
        /// <summary>List of ip address groups.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IIPAddressGroup[] IPAddressGroup { get; set; }
        /// <summary>The JSON object that contains the properties required to create an edgenode.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEdgeNodeProperties Property { get; set; }

    }
}