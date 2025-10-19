using BepInEx;
using BepInEx.Configuration;
using JetBrains.Annotations;
using Mugnum.TarkovMods.MusicPlaysInHideout.Extensions;
using Mugnum.TarkovMods.MusicPlaysInHideout.Patches;

namespace Mugnum.TarkovMods.MusicPlaysInHideout
{
	/// <summary>
	/// Music plays in hideout mod.
	/// </summary>
	[BepInPlugin("com.mugnum.musicplaysinhideout", "Mugnum-MusicPlaysInHideout", "1.2.0")]
	public class Plugin : BaseUnityPlugin
	{
		/// <summary>
		/// Relative volume setting.
		/// </summary>
		internal static ConfigEntry<float> RelativeVolume;

		/// <summary>
		/// Transition time (in seconds) setting.
		/// </summary>
		internal static ConfigEntry<float> TransitionTimeInSec;

		/// <summary>
		/// Initializes mod.
		/// </summary>
		[UsedImplicitly]
		internal void Awake()
		{
			InitializeConfig();
			new GUISoundsPatch().Enable();
		}

		/// <summary>
		/// Initializes config.
		/// </summary>
		private void InitializeConfig()
		{
			const string CommonSection = "Volume";
			var percentageAttributes = new ConfigurationManagerAttributes
			{
				ShowRangeAsPercent = true
			};

			RelativeVolume = Config.Bind(CommonSection, "Relative hideout volume", 0.8f,
				new ConfigDescription("Hideout music volume, relative to main menu volume.",
					new AcceptableValueRange<float>(0f, 1f),
					percentageAttributes));

			TransitionTimeInSec = Config.Bind(CommonSection, "Transition time", 2f,
				new ConfigDescription("Music volume fade time (in seconds).",
					new AcceptableValueRange<float>(0f, 10f)));
		}
	}
}
