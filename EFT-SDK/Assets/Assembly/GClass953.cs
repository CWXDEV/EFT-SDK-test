using System;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Bsg.GameSettings;
using Newtonsoft.Json;

// Token: 0x02001993 RID: 6547
public sealed class GClass953 : GClass952<GClass953>
{
	// Token: 0x17001552 RID: 5458
	// (get) Token: 0x06008C1E RID: 35870 RVA: 0x00002050 File Offset: 0x00000250
	[JsonIgnore]
	public int InterfaceVolumeValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001553 RID: 5459
	// (get) Token: 0x06008C1F RID: 35871 RVA: 0x00002050 File Offset: 0x00000250
	[JsonIgnore]
	public int MusicVolumeValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001554 RID: 5460
	// (get) Token: 0x06008C20 RID: 35872 RVA: 0x00002050 File Offset: 0x00000250
	[JsonIgnore]
	public int HideoutVolumeValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06008C21 RID: 35873 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int smethod_0(int value)
	{
		throw null;
	}

	// Token: 0x06008C22 RID: 35874 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetRealSoundValue(int index)
	{
		throw null;
	}

	// Token: 0x06008C23 RID: 35875 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string smethod_1(string device)
	{
		throw null;
	}

	// Token: 0x06008C24 RID: 35876 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ReadOnlyCollection<string> GetMicrophones()
	{
		throw null;
	}

	// Token: 0x06008C25 RID: 35877 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsValidMicrophone(string device)
	{
		throw null;
	}

	// Token: 0x17001555 RID: 5461
	// (get) Token: 0x06008C26 RID: 35878 RVA: 0x00002050 File Offset: 0x00000250
	public static string DefaultMicrophone
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06008C27 RID: 35879 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool smethod_2(bool voipEnabled)
	{
		throw null;
	}

	// Token: 0x06008C28 RID: 35880 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CheckMicrophone()
	{
		throw null;
	}

	// Token: 0x06008C29 RID: 35881 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ForceApplyVolumeSettings()
	{
		throw null;
	}

	// Token: 0x06008C2A RID: 35882 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override GClass953 Clone()
	{
		throw null;
	}

	// Token: 0x040091C0 RID: 37312
	public const string NOTHING_DEVICE = "Settings/UnavailablePressType";

	// Token: 0x040091C1 RID: 37313
	public const string DEFAULT_DEVICE = "Default";

	// Token: 0x040091C2 RID: 37314
	private static bool? nullable_0;

	// Token: 0x040091C3 RID: 37315
	public readonly GameSetting<int> OverallVolume;

	// Token: 0x040091C4 RID: 37316
	public readonly GameSetting<int> InterfaceVolume;

	// Token: 0x040091C5 RID: 37317
	public readonly GameSetting<int> ChatVolume;

	// Token: 0x040091C6 RID: 37318
	public readonly GameSetting<int> MusicVolume;

	// Token: 0x040091C7 RID: 37319
	public readonly GameSetting<int> HideoutVolume;

	// Token: 0x040091C8 RID: 37320
	public readonly GameSetting<bool> MusicOnRaidEnd;

	// Token: 0x040091C9 RID: 37321
	public readonly GameSetting<bool> BinauralSound;

	// Token: 0x040091CA RID: 37322
	public readonly GameSetting<bool> VoipEnabled;

	// Token: 0x040091CB RID: 37323
	public readonly GameSetting<string> VoipDevice;

	// Token: 0x040091CC RID: 37324
	public readonly GameSetting<int> VoipDeviceSensitivity;

	// Token: 0x040091CD RID: 37325
	private static readonly int[] int_0;

	// Token: 0x040091CE RID: 37326
	private static readonly string[] string_0;

	// Token: 0x02001994 RID: 6548
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1529
	{
		// Token: 0x06008C2B RID: 35883 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_0(int x)
		{
			throw null;
		}

		// Token: 0x040091CF RID: 37327
		public static readonly GClass953.Class1529 class1529_0;

		// Token: 0x040091D0 RID: 37328
		public static Func<int, int> func_0;
	}
}
