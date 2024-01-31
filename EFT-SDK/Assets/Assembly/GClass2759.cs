using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Comfort.Common;
using EFT;
using EFT.InventoryLogic;
using Newtonsoft.Json;

// Token: 0x02002551 RID: 9553
public class GClass2759 : InventoryControllerClass
{
	// Token: 0x17002218 RID: 8728
	// (get) Token: 0x0600BF41 RID: 48961 RVA: 0x00002050 File Offset: 0x00000250
	public new Profile Profile
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002219 RID: 8729
	// (get) Token: 0x0600BF42 RID: 48962 RVA: 0x00002050 File Offset: 0x00000250
	public override bool CanSearch
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700221A RID: 8730
	// (get) Token: 0x0600BF43 RID: 48963 RVA: 0x00002050 File Offset: 0x00000250
	protected override MongoID NextId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600BF44 RID: 48964 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void RollBack()
	{
		throw null;
	}

	// Token: 0x0600BF45 RID: 48965 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Heal(Item item, EBodyPart bodyPart, int count)
	{
		throw null;
	}

	// Token: 0x0600BF46 RID: 48966 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Eat(Item item, int count)
	{
		throw null;
	}

	// Token: 0x0600BF47 RID: 48967 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override void Execute(GClass2833 operation, Callback networkCallback)
	{
		throw null;
	}

	// Token: 0x0600BF48 RID: 48968 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsLimitedAtAddress(string templateId, ItemAddress address, out int limit)
	{
		throw null;
	}

	// Token: 0x0600BF49 RID: 48969 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsAllowedToSort(LootItemClass item)
	{
		throw null;
	}

	// Token: 0x0600BF4A RID: 48970 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override GClass2765 FindQuestGridToPickUp(Item item)
	{
		throw null;
	}

	// Token: 0x0600BF4B RID: 48971 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_31(string item)
	{
		throw null;
	}

	// Token: 0x0600BF4C RID: 48972 RVA: 0x00002050 File Offset: 0x00000250
	[DebuggerHidden]
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_32(GClass2833 operation, Callback callback)
	{
		throw null;
	}

	// Token: 0x0400C123 RID: 49443
	private Profile profile_0;

	// Token: 0x0400C124 RID: 49444
	private readonly ISession ginterface145_0;

	// Token: 0x0400C125 RID: 49445
	private GClass2832 gclass2832_0;

	// Token: 0x0400C126 RID: 49446
	private readonly Dictionary<string, int> dictionary_1;

	// Token: 0x0400C127 RID: 49447
	private readonly BackendIdGenerator backendIdGenerator_0;

	// Token: 0x02002552 RID: 9554
	public sealed class GClass2808
	{
		// Token: 0x0400C128 RID: 49448
		public string parentItem;

		// Token: 0x0400C129 RID: 49449
		public string container;

		// Token: 0x0400C12A RID: 49450
		public LocationInGrid location;
	}

	// Token: 0x02002553 RID: 9555
	[Serializable]
	public sealed class FullItemLocationSerializer : ISerializer<GClass2759.GClass2808>
	{
		// Token: 0x0600BF4D RID: 48973 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass2759.GClass2808 Deserialize()
		{
			throw null;
		}

		// Token: 0x0600BF4E RID: 48974 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public object Serialize(GClass2759.GClass2808 t)
		{
			throw null;
		}

		// Token: 0x0400C12B RID: 49451
		[JsonProperty("id")]
		public string Id;

		// Token: 0x0400C12C RID: 49452
		[JsonProperty("container")]
		public string Container;

		// Token: 0x0400C12D RID: 49453
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public LocationInGrid location;
	}

	// Token: 0x02002554 RID: 9556
	[CompilerGenerated]
	[Serializable]
	private sealed class Class2132
	{
		// Token: 0x0600BF4F RID: 48975 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_0(BackendConfigSettingsClass.GClass1366 restriction)
		{
			throw null;
		}

		// Token: 0x0600BF50 RID: 48976 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_1(BackendConfigSettingsClass.GClass1366 restriction)
		{
			throw null;
		}

		// Token: 0x0600BF51 RID: 48977 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_2(IResult error)
		{
			throw null;
		}

		// Token: 0x0600BF52 RID: 48978 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_3(IResult error)
		{
			throw null;
		}

		// Token: 0x0400C12E RID: 49454
		public static readonly GClass2759.Class2132 class2132_0;

		// Token: 0x0400C12F RID: 49455
		public static Func<BackendConfigSettingsClass.GClass1366, string> func_0;

		// Token: 0x0400C130 RID: 49456
		public static Func<BackendConfigSettingsClass.GClass1366, int> func_1;

		// Token: 0x0400C131 RID: 49457
		public static Callback callback_0;

		// Token: 0x0400C132 RID: 49458
		public static Callback callback_1;
	}

	// Token: 0x02002555 RID: 9557
	[CompilerGenerated]
	private sealed class Class2133
	{
		// Token: 0x0600BF53 RID: 48979 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult result)
		{
			throw null;
		}

		// Token: 0x0600BF54 RID: 48980 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(Callback localCallback)
		{
			throw null;
		}

		// Token: 0x0400C133 RID: 49459
		public GClass2759 gclass2759_0;

		// Token: 0x0400C134 RID: 49460
		public GClass2833 operation;

		// Token: 0x0400C135 RID: 49461
		public Callback networkCallback;
	}
}
