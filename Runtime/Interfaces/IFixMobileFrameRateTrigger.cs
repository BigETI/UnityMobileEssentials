using UnityPatterns;

/// <summary>
/// Unity mobile essentials
/// </summary>
namespace UnityMobileEssentials
{
    /// <summary>
    /// An interface that represents a fixing mobile frame rate trigger
    /// </summary>
    public interface IFixMobileFrameRateTrigger : ITrigger
    {
        /// <summary>
        /// V-Sync count
        /// </summary>
        uint VSyncCount { get; set; }

        /// <summary>
        /// Target framerate
        /// </summary>
        uint TargetFrameRate { get; set; }
    }
}
