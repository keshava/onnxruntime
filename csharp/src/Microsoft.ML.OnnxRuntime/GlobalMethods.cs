// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Microsoft.ML.OnnxRuntime
{
    public static class GlobalMethods
    {
        /// <summary>
        /// Enable platform telemetry (currently only certain Windows builds has telemetry collection capabilities)
        /// </summary>
        public static void EnableTelemetryEvents()
        {
            var envHandle = OnnxRuntime.Handle;
            NativeApiStatus.VerifySuccess(NativeMethods.OrtEnableTelemetryEvents(envHandle));
        }

        /// <summary>
        /// Disable platform telemetry (currently only certain Windows builds has telemetry collection capabilities)
        /// </summary>
        public static void DisableTelemetryEvents()
        {
            var envHandle = OnnxRuntime.Handle;
            NativeApiStatus.VerifySuccess(NativeMethods.OrtDisableTelemetryEvents(envHandle));
        }
    }
}
