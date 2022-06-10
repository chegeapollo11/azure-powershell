//
// Copyright (c) Microsoft and contributors.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//
// See the License for the specific language governing permissions and
// limitations under the License.
//

// Warning: This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Microsoft.Azure.Commands.Compute.Automation.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Compute;
using Microsoft.Azure.Management.Compute.Models;
using Microsoft.WindowsAzure.Commands.Utilities.Common;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    [Cmdlet(VerbsCommon.Get, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "ComputeResourceSku", DefaultParameterSetName = "DefaultParameter")]
    [OutputType(typeof(List<PSResourceSku>))]
    public partial class GetAzureRmComputeResourceSku : ComputeAutomationBaseCmdlet
    {
        [Parameter(
            Mandatory = false, 
            Position = 0, 
            ValueFromPipelineByPropertyName = true)]
        [ValidateNotNullOrEmpty]
        [LocationCompleter("Microsoft.Compute/locations/publishers")]
        public string Location { get; set; }

        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();
            ExecuteClientAction(() =>
            {
                Microsoft.Rest.Azure.IPage<ResourceSku> result;
                if (this.IsParameterBound(c => c.Location))
                {
                    string filter = String.Format("location eq '{0}'", this.Location);
                    result = ResourceSkusClient.List(filter);
                }
                else
                {
                    result = ResourceSkusClient.List();
                }
                var resultList = result.ToList();
                var nextPageLink = result.NextPageLink;
                while (!string.IsNullOrEmpty(nextPageLink))
                {
                    var pageResult = ResourceSkusClient.ListNext(nextPageLink);
                    foreach (var pageItem in pageResult)
                    {
                        resultList.Add(pageItem);
                    }
                    nextPageLink = pageResult.NextPageLink;
                }
                var psObject = new List<PSResourceSku>();
                foreach (var r in resultList)
                {
                    psObject.Add(ComputeAutomationAutoMapperProfile.Mapper.Map<ResourceSku, PSResourceSku>(r));
                }
                WriteObject(psObject, true);
            });
        }
    }
}
