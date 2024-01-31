using System;
using System.Runtime.CompilerServices;
using EFT.Bots;
using JsonType;
using Newtonsoft.Json;

namespace EFT
{
	// Token: 0x020012FD RID: 4861
	[Serializable]
	public sealed class RaidSettings
	{
		// Token: 0x17001042 RID: 4162
		// (get) Token: 0x060064D3 RID: 25811 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060064D4 RID: 25812 RVA: 0x00002050 File Offset: 0x00000250
		[JsonIgnore]
		public LocationSettingsClass.Location SelectedLocation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17001043 RID: 4163
		// (get) Token: 0x060064D5 RID: 25813 RVA: 0x00002050 File Offset: 0x00000250
		[JsonIgnore]
		public bool Local
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001044 RID: 4164
		// (get) Token: 0x060064D6 RID: 25814 RVA: 0x00002050 File Offset: 0x00000250
		[JsonIgnore]
		public bool IsPmc
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001045 RID: 4165
		// (get) Token: 0x060064D7 RID: 25815 RVA: 0x00002050 File Offset: 0x00000250
		[JsonIgnore]
		public bool IsScav
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060064D8 RID: 25816 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Apply(RaidSettings raidSettings)
		{
			throw null;
		}

		// Token: 0x060064D9 RID: 25817 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RaidSettings Clone()
		{
			throw null;
		}

		// Token: 0x04007132 RID: 28978
		[JsonProperty("keyId")]
		public string KeyId;

		// Token: 0x04007133 RID: 28979
		[JsonProperty("side")]
		public ESideType Side;

		// Token: 0x04007134 RID: 28980
		[JsonProperty("location")]
		public string LocationId;

		// Token: 0x04007135 RID: 28981
		[JsonProperty("timeVariant")]
		public EDateTime SelectedDateTime;

		// Token: 0x04007136 RID: 28982
		[JsonProperty("raidMode")]
		public ERaidMode RaidMode;

		// Token: 0x04007137 RID: 28983
		[JsonProperty("metabolismDisabled")]
		public bool MetabolismDisabled;

		// Token: 0x04007138 RID: 28984
		[JsonProperty("playersSpawnPlace")]
		public EPlayersSpawnPlace PlayersSpawnPlace;

		// Token: 0x04007139 RID: 28985
		[JsonProperty("timeAndWeatherSettings")]
		public TimeAndWeatherSettings TimeAndWeatherSettings;

		// Token: 0x0400713A RID: 28986
		[JsonProperty("botSettings")]
		public BotControllerSettings BotSettings;

		// Token: 0x0400713B RID: 28987
		[JsonProperty("wavesSettings")]
		public WavesSettings WavesSettings;

		// Token: 0x0400713C RID: 28988
		[JsonIgnore]
		private LocationSettingsClass.Location _selectedLocation;
	}
}
