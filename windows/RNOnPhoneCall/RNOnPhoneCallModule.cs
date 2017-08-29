using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Com.Reactlibrary.RNOnPhoneCall
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNOnPhoneCallModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNOnPhoneCallModule"/>.
        /// </summary>
        internal RNOnPhoneCallModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNOnPhoneCall";
            }
        }
    }
}
