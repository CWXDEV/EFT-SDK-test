using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT;
using EFT.UI.Screens;
using UnityEngine;

// Token: 0x02001C96 RID: 7318
public static class GClass1953
{
	// Token: 0x17001767 RID: 5991
	// (get) Token: 0x060098E3 RID: 39139 RVA: 0x00002050 File Offset: 0x00000250
	public static Player Player
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060098E4 RID: 39140 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UnloadUnusedResources()
	{
		throw null;
	}

	// Token: 0x060098E5 RID: 39141 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DeleteAll<T>() where T : Component
	{
		throw null;
	}

	// Token: 0x060098E6 RID: 39142 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Task WaitScreenChanged(EEftScreenType eftScreenType)
	{
		throw null;
	}

	// Token: 0x060098E7 RID: 39143 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Task WaitScreenChangedToAnother(EEftScreenType eftScreenType)
	{
		throw null;
	}

	// Token: 0x060098E8 RID: 39144 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Task WaitScreenChanged(Predicate<EEftScreenType> isNeededScreenType)
	{
		throw null;
	}

	// Token: 0x060098E9 RID: 39145 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T GetUIScreen<T>(EEftScreenType eftScreenType) where T : UIScreen
	{
		throw null;
	}

	// Token: 0x060098EA RID: 39146 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Task WaitGameStarted()
	{
		throw null;
	}

	// Token: 0x02001C97 RID: 7319
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1715
	{
		// Token: 0x060098EB RID: 39147 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(AsyncOperation _)
		{
			throw null;
		}

		// Token: 0x0400A019 RID: 40985
		public static readonly GClass1953.Class1715 class1715_0;

		// Token: 0x0400A01A RID: 40986
		public static Action<AsyncOperation> action_0;
	}

	// Token: 0x02001C98 RID: 7320
	[CompilerGenerated]
	private sealed class Class1716
	{
		// Token: 0x060098EC RID: 39148 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(EEftScreenType st)
		{
			throw null;
		}

		// Token: 0x0400A01B RID: 40987
		public EEftScreenType eftScreenType;
	}

	// Token: 0x02001C99 RID: 7321
	[CompilerGenerated]
	private sealed class Class1717
	{
		// Token: 0x060098ED RID: 39149 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(EEftScreenType st)
		{
			throw null;
		}

		// Token: 0x0400A01C RID: 40988
		public EEftScreenType eftScreenType;
	}

	// Token: 0x02001C9A RID: 7322
	[CompilerGenerated]
	private sealed class Class1718
	{
		// Token: 0x060098EE RID: 39150 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(EEftScreenType currentScreen)
		{
			throw null;
		}

		// Token: 0x0400A01D RID: 40989
		public Predicate<EEftScreenType> isNeededScreenType;

		// Token: 0x0400A01E RID: 40990
		public TaskCompletionSource<bool> waiting;
	}

	// Token: 0x02001C9C RID: 7324
	[CompilerGenerated]
	private sealed class Class1719
	{
		// Token: 0x060098F1 RID: 39153 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x0400A023 RID: 40995
		public GameWorld gameWorld;

		// Token: 0x0400A024 RID: 40996
		public TaskCompletionSource<bool> waitGameStartedEvent;
	}
}
