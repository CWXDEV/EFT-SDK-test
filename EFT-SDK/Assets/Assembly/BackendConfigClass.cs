using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x02000FFC RID: 4092
public class BackendConfigClass
{
	// Token: 0x040061CF RID: 25039
	[JsonProperty("config")]
	public BackendConfigSettingsClass Config;

	// Token: 0x040061D0 RID: 25040
	public Dictionary<string, GClass1200> ItemPresets;

	// Token: 0x040061D1 RID: 25041
	[JsonProperty("bot_presets")]
	public BotPresetClass[] BotPresets;

	// Token: 0x040061D2 RID: 25042
	[JsonProperty("BotWeaponScatterings")]
	public GClass525[] BotWeaponScatterings;
}
