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

namespace Microsoft.Azure.Batch.Common
{
    using System;
    using System.Linq;
    
    /// <summary>
    /// Specifies what to do with active tasks during a disable job operation.
    /// </summary>
    public enum DisableJobOption
    {
        /// <summary>
        /// Terminate running tasks and requeue them. The tasks will run again
        /// when the job is enabled.
        /// </summary>
        Requeue,
        
        /// <summary>
        /// Terminate running tasks. The tasks will not run again.
        /// </summary>
        Terminate,
        
        /// <summary>
        /// Allow currently running tasks to complete.
        /// </summary>
        Wait,
    }
}
