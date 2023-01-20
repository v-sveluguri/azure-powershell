
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create an in-memory object for HealthProbeParameters.
.Description
Create an in-memory object for HealthProbeParameters.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.HealthProbeParameters
.Link
https://learn.microsoft.com/powershell/module/az.Cdn/new-AzCdnHealthProbeParametersObject
#>
function New-AzCdnHealthProbeParametersObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.HealthProbeParameters')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(HelpMessage="The number of seconds between health probes.Default is 240sec.")]
        [int]
        $ProbeIntervalInSecond,
        [Parameter(HelpMessage="The path relative to the origin that is used to determine the health of the origin.")]
        [string]
        $ProbePath,
        [Parameter(HelpMessage="Protocol to use for health probe.")]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProbeProtocol])]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProbeProtocol]
        $ProbeProtocol,
        [Parameter(HelpMessage="The type of health probe request that is made.")]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.HealthProbeRequestType])]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.HealthProbeRequestType]
        $ProbeRequestType
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.HealthProbeParameters]::New()

        if ($PSBoundParameters.ContainsKey('ProbeIntervalInSecond')) {
            $Object.ProbeIntervalInSecond = $ProbeIntervalInSecond
        }
        if ($PSBoundParameters.ContainsKey('ProbePath')) {
            $Object.ProbePath = $ProbePath
        }
        if ($PSBoundParameters.ContainsKey('ProbeProtocol')) {
            $Object.ProbeProtocol = $ProbeProtocol
        }
        if ($PSBoundParameters.ContainsKey('ProbeRequestType')) {
            $Object.ProbeRequestType = $ProbeRequestType
        }
        return $Object
    }
}

