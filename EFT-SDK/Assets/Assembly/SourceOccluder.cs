using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Audio;

// Token: 0x020008A1 RID: 2209
public class SourceOccluder : MonoBehaviour
{
	// Token: 0x060031D4 RID: 12756 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	// Token: 0x060031D5 RID: 12757 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x060031D6 RID: 12758 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(AudioSource source, Vector3 vector3)
	{
		throw null;
	}

	// Token: 0x060031D7 RID: 12759 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(AudioSource source, Vector3 vector3)
	{
		throw null;
	}

	// Token: 0x060031D8 RID: 12760 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x060031D9 RID: 12761 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		throw null;
	}

	// Token: 0x060031DA RID: 12762 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x040032F9 RID: 13049
	public AudioSource[] _sources;

	// Token: 0x040032FA RID: 13050
	private int int_0;

	// Token: 0x040032FB RID: 13051
	public int UpdateEveryFrames;

	// Token: 0x040032FC RID: 13052
	public Action<AudioSource, Vector3> OutputSwitcher;

	// Token: 0x040032FD RID: 13053
	public AudioMixerGroup CustomOutput;

	// Token: 0x040032FE RID: 13054
	public AudioMixerGroup CustomOutputOccluded;

	// Token: 0x040032FF RID: 13055
	private Action action_0;
}
