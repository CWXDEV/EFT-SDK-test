using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.GlobalEvents;

// Token: 0x02002621 RID: 9761
public class GClass2911
{
	// Token: 0x1700229C RID: 8860
	// (get) Token: 0x0600C1E5 RID: 49637 RVA: 0x00002050 File Offset: 0x00000250
	public static GClass2911 Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x140002C0 RID: 704
	// (add) Token: 0x0600C1E6 RID: 49638 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600C1E7 RID: 49639 RVA: 0x00002050 File Offset: 0x00000250
	public static event Action<GClass2885> OnEventInvoked
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

	// Token: 0x0600C1E8 RID: 49640 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize()
	{
		throw null;
	}

	// Token: 0x0600C1E9 RID: 49641 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(Type eventType, GClass2885 invokedEvent)
	{
		throw null;
	}

	// Token: 0x0600C1EA RID: 49642 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public T CreateCommonEvent<T>() where T : GClass2885
	{
		throw null;
	}

	// Token: 0x0600C1EB RID: 49643 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T CreateEvent<T>() where T : GClass2885
	{
		throw null;
	}

	// Token: 0x0600C1EC RID: 49644 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool TryGetEvents<T>(out List<T> eventList) where T : GClass2885
	{
		throw null;
	}

	// Token: 0x0600C1ED RID: 49645 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool TryGetEvents(string eventName, out List<GInterface341> eventList)
	{
		throw null;
	}

	// Token: 0x0600C1EE RID: 49646 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public G CreateEvent<T, G>() where T : CommonEventData where G : GClass2885
	{
		throw null;
	}

	// Token: 0x0600C1EF RID: 49647 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Action SubscribeOnEvent<T>(Action<T> callback) where T : GClass2885
	{
		throw null;
	}

	// Token: 0x0600C1F0 RID: 49648 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyEvents()
	{
		throw null;
	}

	// Token: 0x0600C1F1 RID: 49649 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearEvents()
	{
		throw null;
	}

	// Token: 0x0400C3DD RID: 50141
	private static GClass2911 gclass2911_0;

	// Token: 0x0400C3DE RID: 50142
	[CompilerGenerated]
	private static Action<GClass2885> action_0;

	// Token: 0x0400C3DF RID: 50143
	private bool bool_0;

	// Token: 0x0400C3E0 RID: 50144
	private Dictionary<Type, List<Action<GClass2885>>> dictionary_0;

	// Token: 0x02002622 RID: 9762
	[CompilerGenerated]
	private sealed class Class2197<T> where T : GClass2885
	{
		// Token: 0x0600C1F2 RID: 49650 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(GClass2885 e)
		{
			throw null;
		}

		// Token: 0x0600C1F3 RID: 49651 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1()
		{
			throw null;
		}

		// Token: 0x0400C3E1 RID: 50145
		public Action<T> callback;

		// Token: 0x0400C3E2 RID: 50146
		public GClass2911 gclass2911_0;

		// Token: 0x0400C3E3 RID: 50147
		public Type type;

		// Token: 0x0400C3E4 RID: 50148
		public Action<GClass2885> callbackAction;
	}
}
