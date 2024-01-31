using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Token: 0x02000830 RID: 2096
public class GClass773
{
	// Token: 0x06002FF8 RID: 12280 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool Add(GuidComponent guidComponent)
	{
		throw null;
	}

	// Token: 0x06002FF9 RID: 12281 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Remove(Guid guid)
	{
		throw null;
	}

	// Token: 0x06002FFA RID: 12282 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject ResolveGuid(Guid guid, Action<GameObject> onAddCallback, Action onRemoveCallback)
	{
		throw null;
	}

	// Token: 0x06002FFB RID: 12283 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject ResolveGuid(Guid guid, Action onDestroyCallback)
	{
		throw null;
	}

	// Token: 0x06002FFC RID: 12284 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject ResolveGuid(Guid guid)
	{
		throw null;
	}

	// Token: 0x06002FFD RID: 12285 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_0(GuidComponent guidComponent)
	{
		throw null;
	}

	// Token: 0x06002FFE RID: 12286 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(Guid guid)
	{
		throw null;
	}

	// Token: 0x06002FFF RID: 12287 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GameObject method_2(Guid guid, Action<GameObject> onAddCallback, Action onRemoveCallback)
	{
		throw null;
	}

	// Token: 0x04002F33 RID: 12083
	private static GClass773 gclass773_0;

	// Token: 0x04002F34 RID: 12084
	private Dictionary<Guid, GClass773.Struct73> dictionary_0;

	// Token: 0x02000831 RID: 2097
	[StructLayout(LayoutKind.Auto)]
	public struct Struct73
	{
		// Token: 0x14000094 RID: 148
		// (add) Token: 0x06003000 RID: 12288 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003001 RID: 12289 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<GameObject> OnAdd
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

		// Token: 0x14000095 RID: 149
		// (add) Token: 0x06003002 RID: 12290 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003003 RID: 12291 RVA: 0x00002050 File Offset: 0x00000250
		public event Action OnRemove
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

		// Token: 0x06003004 RID: 12292 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HandleAddCallback()
		{
			throw null;
		}

		// Token: 0x06003005 RID: 12293 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HandleRemoveCallback()
		{
			throw null;
		}

		// Token: 0x04002F35 RID: 12085
		public GameObject go;

		// Token: 0x04002F36 RID: 12086
		[CompilerGenerated]
		private Action<GameObject> action_0;

		// Token: 0x04002F37 RID: 12087
		[CompilerGenerated]
		private Action action_1;
	}
}
