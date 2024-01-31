using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000B57 RID: 2903
public class ShardPool : MonoBehaviour
{
	// Token: 0x17000A21 RID: 2593
	// (get) Token: 0x06003ED1 RID: 16081 RVA: 0x00002050 File Offset: 0x00000250
	public static int ShardsUsed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000A22 RID: 2594
	// (get) Token: 0x06003ED2 RID: 16082 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsPopulated
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000A23 RID: 2595
	// (get) Token: 0x06003ED3 RID: 16083 RVA: 0x00002050 File Offset: 0x00000250
	public static Shard NextShard
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000A24 RID: 2596
	// (get) Token: 0x06003ED4 RID: 16084 RVA: 0x00002050 File Offset: 0x00000250
	private static bool Boolean_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06003ED5 RID: 16085 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06003ED6 RID: 16086 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void CheckPool()
	{
		throw null;
	}

	// Token: 0x06003ED7 RID: 16087 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_0()
	{
		throw null;
	}

	// Token: 0x06003ED8 RID: 16088 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PopulatePool()
	{
		throw null;
	}

	// Token: 0x04004650 RID: 18000
	private static ShardPool shardPool_0;

	// Token: 0x04004651 RID: 18001
	[HideInInspector]
	[SerializeField]
	private Shard[] shards;

	// Token: 0x04004652 RID: 18002
	[SerializeField]
	private int maxPoolSize;

	// Token: 0x04004653 RID: 18003
	private int int_0;
}
