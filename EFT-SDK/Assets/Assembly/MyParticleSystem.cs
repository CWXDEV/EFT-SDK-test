using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000AEC RID: 2796
[Serializable]
public class MyParticleSystem : MonoBehaviour
{
	// Token: 0x170009F9 RID: 2553
	// (get) Token: 0x06003CEA RID: 15594 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003CEB RID: 15595 RVA: 0x00002050 File Offset: 0x00000250
	public int InitialPoolSize
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

	// Token: 0x170009FA RID: 2554
	// (get) Token: 0x06003CEC RID: 15596 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003CED RID: 15597 RVA: 0x00002050 File Offset: 0x00000250
	public int MaxPoolSize
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

	// Token: 0x06003CEE RID: 15598 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Start()
	{
		throw null;
	}

	// Token: 0x06003CEF RID: 15599 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(ParticlePoolItem item)
	{
		throw null;
	}

	// Token: 0x06003CF0 RID: 15600 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Play(Vector3 pos, Vector3 rot)
	{
		throw null;
	}

	// Token: 0x040042E6 RID: 17126
	public string Name;

	// Token: 0x040042E7 RID: 17127
	public ParticleSystem System;

	// Token: 0x040042E8 RID: 17128
	private int _initialPoolSize;

	// Token: 0x040042E9 RID: 17129
	private Transform _parent;

	// Token: 0x040042EA RID: 17130
	private int _maxPoolSize;

	// Token: 0x040042EB RID: 17131
	private List<ParticlePoolItem> _usedSystems;

	// Token: 0x040042EC RID: 17132
	private Queue<ParticlePoolItem> _freeSystems;

	// Token: 0x040042ED RID: 17133
	private int _poolSize;
}
