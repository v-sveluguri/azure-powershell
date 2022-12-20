﻿// -----------------------------------------------------------------------------
﻿//
﻿// Copyright Microsoft Corporation
﻿// Licensed under the Apache License, Version 2.0 (the "License");
﻿// you may not use this file except in compliance with the License.
﻿// You may obtain a copy of the License at
﻿// http://www.apache.org/licenses/LICENSE-2.0
﻿// Unless required by applicable law or agreed to in writing, software
﻿// distributed under the License is distributed on an "AS IS" BASIS,
﻿// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
﻿// See the License for the specific language governing permissions and
﻿// limitations under the License.
﻿// -----------------------------------------------------------------------------
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:5.0.17
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Batch.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Microsoft.Azure.Batch;
    
    
    public partial class PSCloudTask
    {
        
        internal Microsoft.Azure.Batch.CloudTask omObject;
        
        private PSAffinityInformation affinityInformation;
        
        private IList<PSApplicationPackageReference> applicationPackageReferences;
        
        private PSAuthenticationTokenSettings authenticationTokenSettings;
        
        private PSComputeNodeInformation computeNodeInformation;
        
        private PSTaskConstraints constraints;
        
        private PSTaskContainerSettings containerSettings;
        
        private PSTaskDependencies dependsOn;
        
        private IDictionary environmentSettings;
        
        private PSTaskExecutionInformation executionInformation;
        
        private PSExitConditions exitConditions;
        
        private PSMultiInstanceSettings multiInstanceSettings;
        
        private IList<PSOutputFile> outputFiles;
        
        private IList<PSResourceFile> resourceFiles;
        
        private PSTaskStatistics statistics;
        
        private PSUserIdentity userIdentity;
        
        public PSCloudTask(string id, string commandline)
        {
            this.omObject = new Microsoft.Azure.Batch.CloudTask(id, commandline);
        }
        
        internal PSCloudTask(Microsoft.Azure.Batch.CloudTask omObject)
        {
            if ((omObject == null))
            {
                throw new System.ArgumentNullException("omObject");
            }
            this.omObject = omObject;
        }
        
        public PSAffinityInformation AffinityInformation
        {
            get
            {
                if (((this.affinityInformation == null) 
                            && (this.omObject.AffinityInformation != null)))
                {
                    this.affinityInformation = new PSAffinityInformation(this.omObject.AffinityInformation);
                }
                return this.affinityInformation;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.AffinityInformation = null;
                }
                else
                {
                    this.omObject.AffinityInformation = value.omObject;
                }
                this.affinityInformation = value;
            }
        }
        
        public IList<PSApplicationPackageReference> ApplicationPackageReferences
        {
            get
            {
                if (((this.applicationPackageReferences == null) 
                            && (this.omObject.ApplicationPackageReferences != null)))
                {
                    List<PSApplicationPackageReference> list;
                    list = new List<PSApplicationPackageReference>();
                    IEnumerator<Microsoft.Azure.Batch.ApplicationPackageReference> enumerator;
                    enumerator = this.omObject.ApplicationPackageReferences.GetEnumerator();
                    for (
                    ; enumerator.MoveNext(); 
                    )
                    {
                        list.Add(new PSApplicationPackageReference(enumerator.Current));
                    }
                    this.applicationPackageReferences = list;
                }
                return this.applicationPackageReferences;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.ApplicationPackageReferences = null;
                }
                else
                {
                    this.omObject.ApplicationPackageReferences = new List<Microsoft.Azure.Batch.ApplicationPackageReference>();
                }
                this.applicationPackageReferences = value;
            }
        }
        
        public PSAuthenticationTokenSettings AuthenticationTokenSettings
        {
            get
            {
                if (((this.authenticationTokenSettings == null) 
                            && (this.omObject.AuthenticationTokenSettings != null)))
                {
                    this.authenticationTokenSettings = new PSAuthenticationTokenSettings(this.omObject.AuthenticationTokenSettings);
                }
                return this.authenticationTokenSettings;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.AuthenticationTokenSettings = null;
                }
                else
                {
                    this.omObject.AuthenticationTokenSettings = value.omObject;
                }
                this.authenticationTokenSettings = value;
            }
        }
        
        public string CommandLine
        {
            get
            {
                return this.omObject.CommandLine;
            }
            set
            {
                this.omObject.CommandLine = value;
            }
        }
        
        public PSComputeNodeInformation ComputeNodeInformation
        {
            get
            {
                if (((this.computeNodeInformation == null) 
                            && (this.omObject.ComputeNodeInformation != null)))
                {
                    this.computeNodeInformation = new PSComputeNodeInformation(this.omObject.ComputeNodeInformation);
                }
                return this.computeNodeInformation;
            }
        }
        
        public PSTaskConstraints Constraints
        {
            get
            {
                if (((this.constraints == null) 
                            && (this.omObject.Constraints != null)))
                {
                    this.constraints = new PSTaskConstraints(this.omObject.Constraints);
                }
                return this.constraints;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.Constraints = null;
                }
                else
                {
                    this.omObject.Constraints = value.omObject;
                }
                this.constraints = value;
            }
        }
        
        public PSTaskContainerSettings ContainerSettings
        {
            get
            {
                if (((this.containerSettings == null) 
                            && (this.omObject.ContainerSettings != null)))
                {
                    this.containerSettings = new PSTaskContainerSettings(this.omObject.ContainerSettings);
                }
                return this.containerSettings;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.ContainerSettings = null;
                }
                else
                {
                    this.omObject.ContainerSettings = value.omObject;
                }
                this.containerSettings = value;
            }
        }
        
        public System.DateTime? CreationTime
        {
            get
            {
                return this.omObject.CreationTime;
            }
        }
        
        public PSTaskDependencies DependsOn
        {
            get
            {
                if (((this.dependsOn == null) 
                            && (this.omObject.DependsOn != null)))
                {
                    this.dependsOn = new PSTaskDependencies(this.omObject.DependsOn);
                }
                return this.dependsOn;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.DependsOn = null;
                }
                else
                {
                    this.omObject.DependsOn = value.omObject;
                }
                this.dependsOn = value;
            }
        }
        
        public string DisplayName
        {
            get
            {
                return this.omObject.DisplayName;
            }
            set
            {
                this.omObject.DisplayName = value;
            }
        }
        
        public IDictionary EnvironmentSettings
        {
            get
            {
                if (((this.environmentSettings == null) 
                            && (this.omObject.EnvironmentSettings != null)))
                {
                    Dictionary<string, string> dict;
                    dict = new Dictionary<string, string>();
                    IEnumerator<Microsoft.Azure.Batch.EnvironmentSetting> enumerator;
                    enumerator = this.omObject.EnvironmentSettings.GetEnumerator();
                    for (
                    ; enumerator.MoveNext(); 
                    )
                    {
                        dict.Add(enumerator.Current.Name, enumerator.Current.Value);
                    }
                    this.environmentSettings = dict;
                }
                return this.environmentSettings;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.EnvironmentSettings = null;
                }
                else
                {
                    this.omObject.EnvironmentSettings = new List<Microsoft.Azure.Batch.EnvironmentSetting>();
                }
                this.environmentSettings = value;
            }
        }
        
        public string ETag
        {
            get
            {
                return this.omObject.ETag;
            }
        }
        
        public PSTaskExecutionInformation ExecutionInformation
        {
            get
            {
                if (((this.executionInformation == null) 
                            && (this.omObject.ExecutionInformation != null)))
                {
                    this.executionInformation = new PSTaskExecutionInformation(this.omObject.ExecutionInformation);
                }
                return this.executionInformation;
            }
        }
        
        public PSExitConditions ExitConditions
        {
            get
            {
                if (((this.exitConditions == null) 
                            && (this.omObject.ExitConditions != null)))
                {
                    this.exitConditions = new PSExitConditions(this.omObject.ExitConditions);
                }
                return this.exitConditions;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.ExitConditions = null;
                }
                else
                {
                    this.omObject.ExitConditions = value.omObject;
                }
                this.exitConditions = value;
            }
        }
        
        public string Id
        {
            get
            {
                return this.omObject.Id;
            }
            set
            {
                this.omObject.Id = value;
            }
        }
        
        public System.DateTime? LastModified
        {
            get
            {
                return this.omObject.LastModified;
            }
        }
        
        public PSMultiInstanceSettings MultiInstanceSettings
        {
            get
            {
                if (((this.multiInstanceSettings == null) 
                            && (this.omObject.MultiInstanceSettings != null)))
                {
                    this.multiInstanceSettings = new PSMultiInstanceSettings(this.omObject.MultiInstanceSettings);
                }
                return this.multiInstanceSettings;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.MultiInstanceSettings = null;
                }
                else
                {
                    this.omObject.MultiInstanceSettings = value.omObject;
                }
                this.multiInstanceSettings = value;
            }
        }
        
        public IList<PSOutputFile> OutputFiles
        {
            get
            {
                if (((this.outputFiles == null) 
                            && (this.omObject.OutputFiles != null)))
                {
                    List<PSOutputFile> list;
                    list = new List<PSOutputFile>();
                    IEnumerator<Microsoft.Azure.Batch.OutputFile> enumerator;
                    enumerator = this.omObject.OutputFiles.GetEnumerator();
                    for (
                    ; enumerator.MoveNext(); 
                    )
                    {
                        list.Add(new PSOutputFile(enumerator.Current));
                    }
                    this.outputFiles = list;
                }
                return this.outputFiles;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.OutputFiles = null;
                }
                else
                {
                    this.omObject.OutputFiles = new List<Microsoft.Azure.Batch.OutputFile>();
                }
                this.outputFiles = value;
            }
        }
        
        public Microsoft.Azure.Batch.Common.TaskState? PreviousState
        {
            get
            {
                return this.omObject.PreviousState;
            }
        }
        
        public System.DateTime? PreviousStateTransitionTime
        {
            get
            {
                return this.omObject.PreviousStateTransitionTime;
            }
        }
        
        public System.Int32? RequiredSlots
        {
            get
            {
                return this.omObject.RequiredSlots;
            }
            set
            {
                this.omObject.RequiredSlots = value;
            }
        }
        
        public IList<PSResourceFile> ResourceFiles
        {
            get
            {
                if (((this.resourceFiles == null) 
                            && (this.omObject.ResourceFiles != null)))
                {
                    List<PSResourceFile> list;
                    list = new List<PSResourceFile>();
                    IEnumerator<Microsoft.Azure.Batch.ResourceFile> enumerator;
                    enumerator = this.omObject.ResourceFiles.GetEnumerator();
                    for (
                    ; enumerator.MoveNext(); 
                    )
                    {
                        list.Add(new PSResourceFile(enumerator.Current));
                    }
                    this.resourceFiles = list;
                }
                return this.resourceFiles;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.ResourceFiles = null;
                }
                else
                {
                    this.omObject.ResourceFiles = new List<Microsoft.Azure.Batch.ResourceFile>();
                }
                this.resourceFiles = value;
            }
        }
        
        public Microsoft.Azure.Batch.Common.TaskState? State
        {
            get
            {
                return this.omObject.State;
            }
        }
        
        public System.DateTime? StateTransitionTime
        {
            get
            {
                return this.omObject.StateTransitionTime;
            }
        }
        
        public PSTaskStatistics Statistics
        {
            get
            {
                if (((this.statistics == null) 
                            && (this.omObject.Statistics != null)))
                {
                    this.statistics = new PSTaskStatistics(this.omObject.Statistics);
                }
                return this.statistics;
            }
        }
        
        public string Url
        {
            get
            {
                return this.omObject.Url;
            }
        }
        
        public PSUserIdentity UserIdentity
        {
            get
            {
                if (((this.userIdentity == null) 
                            && (this.omObject.UserIdentity != null)))
                {
                    this.userIdentity = new PSUserIdentity(this.omObject.UserIdentity);
                }
                return this.userIdentity;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.UserIdentity = null;
                }
                else
                {
                    this.omObject.UserIdentity = value.omObject;
                }
                this.userIdentity = value;
            }
        }
    }
}
