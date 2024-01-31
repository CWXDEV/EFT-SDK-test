using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.InventoryLogic;
using JetBrains.Annotations;

// Token: 0x0200181E RID: 6174
public sealed class GClass1838 : GInterface142
{
	// Token: 0x060084A6 RID: 33958 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Bind(Profile profile, ISession backendSession, GClass2760 inventoryController, [CanBeNull] GClass3205 questController)
	{
		throw null;
	}

	// Token: 0x060084A7 RID: 33959 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface142.UpdateProfile(ProfileChangesPocoClass changes)
	{
		throw null;
	}

	// Token: 0x060084A8 RID: 33960 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(Dictionary<string, bool> unlockedSchemes)
	{
		throw null;
	}

	// Token: 0x060084A9 RID: 33961 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(QuestDataClass[] statuses)
	{
		throw null;
	}

	// Token: 0x060084AA RID: 33962 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(Dictionary<string, TraderData> tradersData)
	{
		throw null;
	}

	// Token: 0x060084AB RID: 33963 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(SkillManager newSkills)
	{
		throw null;
	}

	// Token: 0x060084AC RID: 33964 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(int experience)
	{
		throw null;
	}

	// Token: 0x060084AD RID: 33965 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5(RawQuestClass[] quests)
	{
		throw null;
	}

	// Token: 0x060084AE RID: 33966 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6(DailyQuestClass[] questRanges)
	{
		throw null;
	}

	// Token: 0x060084AF RID: 33967 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_7(GClass1843 stashChanges)
	{
		throw null;
	}

	// Token: 0x060084B0 RID: 33968 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_8(GClass1186[] newItems)
	{
		throw null;
	}

	// Token: 0x060084B1 RID: 33969 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_9(IEnumerable<Item> items, GClass1186[] deletedItems)
	{
		throw null;
	}

	// Token: 0x060084B2 RID: 33970 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_10(IEnumerable<Item> stashItems, GClass1186[] changedItems)
	{
		throw null;
	}

	// Token: 0x04008B79 RID: 35705
	private readonly Profile profile_0;

	// Token: 0x04008B7A RID: 35706
	private readonly GClass2760 gclass2760_0;

	// Token: 0x04008B7B RID: 35707
	private readonly RagFairClass gclass3190_0;

	// Token: 0x04008B7C RID: 35708
	private readonly ItemFactory gclass1483_0;

	// Token: 0x04008B7D RID: 35709
	private readonly HideoutClass gclass1904_0;

	// Token: 0x04008B7E RID: 35710
	[CanBeNull]
	private readonly GClass3205 gclass3205_0;

	// Token: 0x0200181F RID: 6175
	[CompilerGenerated]
	private sealed class Class1334
	{
		// Token: 0x060084B3 RID: 33971 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass1920 scheme)
		{
			throw null;
		}

		// Token: 0x04008B7F RID: 35711
		public string schemeId;
	}

	// Token: 0x02001820 RID: 6176
	[CompilerGenerated]
	private sealed class Class1335
	{
		// Token: 0x060084B4 RID: 33972 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass1186 item)
		{
			throw null;
		}

		// Token: 0x04008B80 RID: 35712
		public Item topItem;
	}

	// Token: 0x02001821 RID: 6177
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1336
	{
		// Token: 0x060084B5 RID: 33973 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_0(ContainerCollection x)
		{
			throw null;
		}

		// Token: 0x060084B6 RID: 33974 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Dictionary<string, IContainer> method_1(ContainerCollection x)
		{
			throw null;
		}

		// Token: 0x060084B7 RID: 33975 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_2(IContainer container)
		{
			throw null;
		}

		// Token: 0x060084B8 RID: 33976 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IContainer method_3(IContainer container)
		{
			throw null;
		}

		// Token: 0x060084B9 RID: 33977 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_4(Item item)
		{
			throw null;
		}

		// Token: 0x060084BA RID: 33978 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_5(GClass1186 item)
		{
			throw null;
		}

		// Token: 0x04008B81 RID: 35713
		public static readonly GClass1838.Class1336 class1336_0;

		// Token: 0x04008B82 RID: 35714
		public static Func<ContainerCollection, string> func_0;

		// Token: 0x04008B83 RID: 35715
		public static Func<IContainer, string> func_1;

		// Token: 0x04008B84 RID: 35716
		public static Func<IContainer, IContainer> func_2;

		// Token: 0x04008B85 RID: 35717
		public static Func<ContainerCollection, Dictionary<string, IContainer>> func_3;

		// Token: 0x04008B86 RID: 35718
		public static Func<Item, bool> func_4;

		// Token: 0x04008B87 RID: 35719
		public static Func<GClass1186, string> func_5;
	}

	// Token: 0x02001822 RID: 6178
	[CompilerGenerated]
	private sealed class Class1337
	{
		// Token: 0x060084BB RID: 33979 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Item item)
		{
			throw null;
		}

		// Token: 0x04008B88 RID: 35720
		public IEnumerable<string> deletedIds;
	}

	// Token: 0x02001823 RID: 6179
	[CompilerGenerated]
	private sealed class Class1338
	{
		// Token: 0x060084BC RID: 33980 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ValueTuple<GClass1186, Item> method_0(GClass1186 changedItem)
		{
			throw null;
		}

		// Token: 0x04008B89 RID: 35721
		public IEnumerable<Item> stashItems;
	}

	// Token: 0x02001824 RID: 6180
	[CompilerGenerated]
	private sealed class Class1339
	{
		// Token: 0x060084BD RID: 33981 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Item stashItem)
		{
			throw null;
		}

		// Token: 0x04008B8A RID: 35722
		public GClass1186 changedItem;
	}
}
