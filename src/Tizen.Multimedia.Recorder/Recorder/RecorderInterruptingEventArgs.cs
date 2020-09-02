/*
 * Copyright (c) 2016 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;

namespace Tizen.Multimedia
{
    /// <summary>
    /// Provides data for the <see cref="Recorder.Interrupting"/> event.
    /// </summary>
    /// <since_tizen> 4 </since_tizen>
    public class RecorderInterruptingEventArgs : EventArgs
    {
        internal RecorderInterruptingEventArgs(RecorderPolicy policy, RecorderState state)
        {
            Reason = policy;
            State = state;
        }

        /// <summary>
        /// Gets the reason of the interrupt.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public RecorderPolicy Reason { get; }

        /// <summary>
        /// Gets the previous state of the recorder.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public RecorderState State { get; }
    }
}