using System;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x02000664 RID: 1636
public class GClass606 : GInterface23
{
	// Token: 0x170006BB RID: 1723
	public Quaternion this[int index]
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

	// Token: 0x170006BC RID: 1724
	// (get) Token: 0x06002579 RID: 9593 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsAlternative
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170006BD RID: 1725
	// (get) Token: 0x0600257A RID: 9594 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsCached
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170006BE RID: 1726
	// (get) Token: 0x0600257B RID: 9595 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 Position
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170006BF RID: 1727
	// (get) Token: 0x0600257C RID: 9596 RVA: 0x00002050 File Offset: 0x00000250
	public Quaternion Rotation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x04002497 RID: 9367
	public Quaternion[][] Fingers;

	// Token: 0x04002498 RID: 9368
	private Transform transform_0;

	// Token: 0x04002499 RID: 9369
	private Transform transform_1;

	// Token: 0x0400249A RID: 9370
	private float float_0;

	// Token: 0x0400249B RID: 9371
	public Player.ValueBlender Blender;

	// Token: 0x02000665 RID: 1637
	[CompilerGenerated]
	[Serializable]
	private sealed class Class313
	{
		// Token: 0x0600257D RID: 9597 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Quaternion method_0(Transform x)
		{
			throw null;
		}

		// Token: 0x0600257E RID: 9598 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Quaternion method_1(Transform x)
		{
			throw null;
		}

		// Token: 0x0400249C RID: 9372
		public static readonly GClass606.Class313 class313_0;

		// Token: 0x0400249D RID: 9373
		public static Func<Transform, Quaternion> func_0;

		// Token: 0x0400249E RID: 9374
		public static Func<Transform, Quaternion> func_1;
	}
}
