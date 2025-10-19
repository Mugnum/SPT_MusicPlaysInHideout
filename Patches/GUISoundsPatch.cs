using DG.Tweening;
using EFT.UI;
using SPT.Reflection.Patching;
using System.Reflection;
using UnityEngine;

// ReSharper disable InconsistentNaming
namespace Mugnum.TarkovMods.MusicPlaysInHideout.Patches
{
	/// <summary>
	/// Patch for <see cref="GUISounds"/> class.
	/// </summary>
	internal class GUISoundsPatch : ModulePatch
	{
		/// <summary>
		/// Returns method to override.
		/// </summary>
		/// <returns> Target method. </returns>
		protected override MethodBase GetTargetMethod()
		{
			return typeof(GUISounds).GetMethod(nameof(GUISounds.method_9));
		}

		/// <summary>
		/// Prefix patch.
		/// </summary>
		/// <param name="isActive"> Is menu music active. False indicates we're entering hideout. </param>
		/// <param name="__instance"> Context instance. </param>
		/// <param name="___audioSource_3"> "audioSource_3" private field (music category). </param>
		/// <returns> Flag indicating the need to execute original method. </returns>
		[PatchPrefix]
		private static bool PatchPrefix(bool isActive, GUISounds __instance, AudioSource ___audioSource_3)
		{
			const bool IsNeedToExecuteOriginalMethod = false;
			const float BaseVolume = 1f;
			var transitionDurationInSec = Mathf.Clamp(Plugin.TransitionTimeInSec.Value, 0f, 10f);
			var newVolume = isActive
				? BaseVolume
				: BaseVolume * Plugin.RelativeVolume.Value;

			__instance.BackgroundMusicActive = true;
			___audioSource_3.DOFade(newVolume, transitionDurationInSec);

			return IsNeedToExecuteOriginalMethod;
		}
	}
}
