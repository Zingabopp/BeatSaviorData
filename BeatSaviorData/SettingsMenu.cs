﻿using BeatSaberMarkupLanguage.Attributes;
using BS_Utils.Utilities;

namespace BeatSaviorData
{
	class SettingsMenu : PersistentSingleton<SettingsMenu>
	{
		private static readonly Config config = new Config("BeatSaviorData");

		[UIValue("DisablePass")]
		public bool DisablePass
		{
			get => config.GetBool("BeatSaviorData", "DisablePass", false, true);
			set => config.SetBool("BeatSaviorData", "DisablePass", value);
		}

		[UIValue("DisableFail")]
		public bool DisableFails
		{
			get => config.GetBool("BeatSaviorData", "DisableFails", false, true);
			set => config.SetBool("BeatSaviorData", "DisableFails", value);
		}

		[UIValue("EnableUI")]
		public bool EnableUI
		{
			get => config.GetBool("BeatSaviorData", "EnableUI", true, true);
			set => config.SetBool("BeatSaviorData", "EnableUI", value);
		}

		[UIValue("DisableGraphPanel")]
		public bool DisableGraphPanel
		{
			get => config.GetBool("BeatSaviorData", "DisableGraphPanel", false, true);
			set => config.SetBool("BeatSaviorData", "DisableGraphPanel", value);
		}

		[UIValue("DisableBeatSaviorUpload")]
		public bool DisableBeatSaviorUpload
		{
			get => config.GetBool("BeatSaviorData", "DisableBeatSaviorUpload", false, true);
			set => config.SetBool("BeatSaviorData", "DisableBeatSaviorUpload", value);
		}
	}
}
