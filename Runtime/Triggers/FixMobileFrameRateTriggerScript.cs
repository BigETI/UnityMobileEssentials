using UnityEngine;
using UnityPatterns.Triggers;

/// <summary>
/// Unity mobile essentials triggers
/// </summary>
namespace UnityMobileEssentials.Triggers
{
    /// <summary>
    /// A class that describes a fixing mobile frame rate trigger script
    /// </summary>
    public class FixMobileFrameRateTriggerScript : ATriggerScript, IFixMobileFrameRateTrigger
    {
        /// <summary>
        /// V-Sync count
        /// </summary>
        [SerializeField]
        [Tooltip("Sets the V-Sync count in the graphics settings")]
        private uint vSyncCount = 1U;

        /// <summary>
        /// Target frame rate
        /// </summary>
        [SerializeField]
        [Tooltip("Sets the target framerate")]
        private uint targetFrameRate = 300U;

        /// <summary>
        /// V-Sync count
        /// </summary>
        public uint VSyncCount
        {
            get => vSyncCount;
            set
            {
                vSyncCount = value;
                QualitySettings.vSyncCount = (int)vSyncCount;
            }
        }

        /// <summary>
        /// Target framerate
        /// </summary>
        public uint TargetFrameRate
        {
            get => targetFrameRate;
            set
            {
                targetFrameRate = value;
                Application.targetFrameRate = (int)targetFrameRate;
            }
        }

        /// <summary>
        /// Gets invoked when script has been started
        /// </summary>
        protected override void Start()
        {
            base.Start();
            QualitySettings.vSyncCount = (int)vSyncCount;
            Application.targetFrameRate = (int)targetFrameRate;
        }
    }
}
