using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using EFT;
using Newtonsoft.Json;

// Token: 0x02001616 RID: 5654
public class InfoClass
{
	// Token: 0x17001365 RID: 4965
	// (get) Token: 0x06007B1A RID: 31514 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06007B1B RID: 31515 RVA: 0x00002050 File Offset: 0x00000250
	[JsonProperty("Experience")]
	public int Experience
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

	// Token: 0x14000169 RID: 361
	// (add) Token: 0x06007B1C RID: 31516 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06007B1D RID: 31517 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<EBanType> OnBanChanged
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x1400016A RID: 362
	// (add) Token: 0x06007B1E RID: 31518 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06007B1F RID: 31519 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<int, int> OnExperienceChanged
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x1400016B RID: 363
	// (add) Token: 0x06007B20 RID: 31520 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06007B21 RID: 31521 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<int, int> OnLevelChanged
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x17001366 RID: 4966
	// (get) Token: 0x06007B22 RID: 31522 RVA: 0x00002050 File Offset: 0x00000250
	[JsonProperty("Level")]
	public int Level
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06007B23 RID: 31523 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetLevel(int experience)
	{
		throw null;
	}

	// Token: 0x06007B24 RID: 31524 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetExperience(int level)
	{
		throw null;
	}

	// Token: 0x06007B25 RID: 31525 RVA: 0x00002050 File Offset: 0x00000250
	[OnDeserialized]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(StreamingContext context)
	{
		throw null;
	}

	// Token: 0x06007B26 RID: 31526 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass1756 GetBan(EBanType type)
	{
		throw null;
	}

	// Token: 0x06007B27 RID: 31527 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddBan(EBanType type, long dateTime)
	{
		throw null;
	}

	// Token: 0x06007B28 RID: 31528 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveBan(EBanType type)
	{
		throw null;
	}

	// Token: 0x06007B29 RID: 31529 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_1(EBanType type)
	{
		throw null;
	}

	// Token: 0x06007B2A RID: 31530 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(GClass1756 ban)
	{
		throw null;
	}

	// Token: 0x06007B2B RID: 31531 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(GClass1756 ban)
	{
		throw null;
	}

	// Token: 0x06007B2C RID: 31532 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(GClass1756 ban)
	{
		throw null;
	}

	// Token: 0x04008010 RID: 32784
	[JsonProperty("Nickname")]
	public string Nickname;

	// Token: 0x04008011 RID: 32785
	[JsonProperty("MainProfileNickname")]
	public string MainProfileNickname;

	// Token: 0x04008012 RID: 32786
	[JsonProperty("Side")]
	public EPlayerSide Side;

	// Token: 0x04008013 RID: 32787
	[JsonProperty("RegistrationDate")]
	public int RegistrationDate;

	// Token: 0x04008014 RID: 32788
	[JsonProperty("SavageLockTime")]
	public double SavageLockTime;

	// Token: 0x04008015 RID: 32789
	[JsonProperty("GroupId")]
	public string GroupId;

	// Token: 0x04008016 RID: 32790
	[JsonProperty("TeamId")]
	public string TeamId;

	// Token: 0x04008017 RID: 32791
	[JsonProperty("EntryPoint")]
	public string EntryPoint;

	// Token: 0x04008018 RID: 32792
	[JsonProperty("NicknameChangeDate")]
	public long NicknameChangeDate;

	// Token: 0x04008019 RID: 32793
	[JsonProperty("GameVersion")]
	public string GameVersion;

	// Token: 0x0400801A RID: 32794
	[JsonProperty("Voice")]
	public string Voice;

	// Token: 0x0400801B RID: 32795
	[JsonProperty("IsStreamerModeAvailable")]
	public bool IsStreamerModeAvailable;

	// Token: 0x0400801C RID: 32796
	[JsonProperty("SquadInviteRestriction")]
	public bool GroupInviteRestriction;

	// Token: 0x0400801D RID: 32797
	[JsonProperty("Bans")]
	private List<GClass1756> list_0;

	// Token: 0x0400801E RID: 32798
	public GClass1745 Settings;

	// Token: 0x0400801F RID: 32799
	[JsonProperty("MemberCategory")]
	public EMemberCategory MemberCategory;

	// Token: 0x04008020 RID: 32800
	private int int_0;

	// Token: 0x04008021 RID: 32801
	[CompilerGenerated]
	private Action<EBanType> action_0;

	// Token: 0x04008022 RID: 32802
	[CompilerGenerated]
	private Action<int, int> action_1;

	// Token: 0x04008023 RID: 32803
	[CompilerGenerated]
	private Action<int, int> action_2;

	// Token: 0x02001617 RID: 5655
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1159
	{
		// Token: 0x06007B2D RID: 31533 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass1756 x)
		{
			throw null;
		}

		// Token: 0x04008024 RID: 32804
		public static readonly InfoClass.Class1159 class1159_0;

		// Token: 0x04008025 RID: 32805
		public static Predicate<GClass1756> predicate_0;
	}

	// Token: 0x02001618 RID: 5656
	[CompilerGenerated]
	private sealed class Class1160
	{
		// Token: 0x06007B2E RID: 31534 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass1756 x)
		{
			throw null;
		}

		// Token: 0x04008026 RID: 32806
		public EBanType type;
	}

	// Token: 0x02001619 RID: 5657
	[CompilerGenerated]
	private sealed class Class1161
	{
		// Token: 0x06007B2F RID: 31535 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x04008027 RID: 32807
		public InfoClass gclass1757_0;

		// Token: 0x04008028 RID: 32808
		public GClass1756 ban;
	}
}
