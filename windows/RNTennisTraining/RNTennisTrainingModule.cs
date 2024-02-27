using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Tennis.Training.RNTennisTraining
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNTennisTrainingModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNTennisTrainingModule"/>.
        /// </summary>
        internal RNTennisTrainingModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNTennisTraining";
            }
        }
    }
}
