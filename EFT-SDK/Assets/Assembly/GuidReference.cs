using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000832 RID: 2098
[Serializable]
public class GuidReference : ISerializationCallbackReceiver
{
	// Token: 0x1700084B RID: 2123
	// (get) Token: 0x06003006 RID: 12294 RVA: 0x00002050 File Offset: 0x00000250
	public byte[] AsBytes
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700084C RID: 2124
	// (get) Token: 0x06003007 RID: 12295 RVA: 0x00002050 File Offset: 0x00000250
	public Guid ObjectGuid
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700084D RID: 2125
	// (get) Token: 0x06003008 RID: 12296 RVA: 0x00002050 File Offset: 0x00000250
	public string ObjectGuidString
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x14000096 RID: 150
	// (add) Token: 0x06003009 RID: 12297 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600300A RID: 12298 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<GameObject> OnGuidAdded
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

	// Token: 0x14000097 RID: 151
	// (add) Token: 0x0600300B RID: 12299 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600300C RID: 12300 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnGuidRemoved
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

	// Token: 0x1700084E RID: 2126
	// (get) Token: 0x0600300D RID: 12301 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600300E RID: 12302 RVA: 0x00002050 File Offset: 0x00000250
	public GameObject gameObject
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x0600300F RID: 12303 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(GameObject go)
	{
		throw null;
	}

	// Token: 0x06003010 RID: 12304 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x06003011 RID: 12305 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnBeforeSerialize()
	{
		throw null;
	}

	// Token: 0x06003012 RID: 12306 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnAfterDeserialize()
	{
		throw null;
	}

	// Token: 0x06003013 RID: 12307 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x06003014 RID: 12308 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public T GetComponent<T>()
	{
		throw null;
	}

	// Token: 0x04002F38 RID: 12088
	private GameObject cachedReference;

	// Token: 0x04002F39 RID: 12089
	private bool isCacheSet;

	// Token: 0x04002F3A RID: 12090
	[SerializeField]
	private byte[] serializedGuid;

	// Token: 0x04002F3B RID: 12091
	private Guid guid;

	// Token: 0x04002F3E RID: 12094
	private Action<GameObject> addDelegate;

	// Token: 0x04002F3F RID: 12095
	private Action removeDelegate;

	// Token: 0x02000833 RID: 2099
	[CompilerGenerated]
	[Serializable]
	private sealed class Class433
	{
		// Token: 0x06003015 RID: 12309 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(GameObject go)
		{
			throw null;
		}

		// Token: 0x06003016 RID: 12310 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1()
		{
			throw null;
		}

		// Token: 0x06003017 RID: 12311 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_2(GameObject go)
		{
			throw null;
		}

		// Token: 0x06003018 RID: 12312 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_3()
		{
			throw null;
		}

		// Token: 0x06003019 RID: 12313 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_4(GameObject go)
		{
			throw null;
		}

		// Token: 0x0600301A RID: 12314 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_5()
		{
			throw null;
		}

		// Token: 0x04002F40 RID: 12096
		public static readonly GuidReference.Class433 class433_0;

		// Token: 0x04002F41 RID: 12097
		public static Action<GameObject> action_0;

		// Token: 0x04002F42 RID: 12098
		public static Action action_1;

		// Token: 0x04002F43 RID: 12099
		public static Action<GameObject> action_2;

		// Token: 0x04002F44 RID: 12100
		public static Action action_3;

		// Token: 0x04002F45 RID: 12101
		public static Action<GameObject> action_4;

		// Token: 0x04002F46 RID: 12102
		public static Action action_5;
	}
}
