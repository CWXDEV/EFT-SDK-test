using System;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;
using UnityEngine.Audio;

// Token: 0x02000D3E RID: 3390
public static class GClass978
{
	// Token: 0x17000B73 RID: 2931
	// (get) Token: 0x06004823 RID: 18467 RVA: 0x00002050 File Offset: 0x00000250
	private static Player Player_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06004824 RID: 18468 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool OcclusionTest(Vector3 origin, Vector3 destination, float distance)
	{
		throw null;
	}

	// Token: 0x06004825 RID: 18469 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool smethod_0(Vector3 origin, Vector3 destination, float distance, int mask)
	{
		throw null;
	}

	// Token: 0x06004826 RID: 18470 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void CalculateGunshotsOcclusion(Vector3 gunPosition, out float volume, ref float lowerFrequency)
	{
		throw null;
	}

	// Token: 0x06004827 RID: 18471 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void VolumeDependentOcclusion(Vector3 soundPosition, ref float propagationEffect, ref float lowerFrequency, ref float volume, float maxDistance = 50f)
	{
		throw null;
	}

	// Token: 0x06004828 RID: 18472 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_1(GStruct386 connection, ref float lowerFrequency, ref float occlusionEffect, ref float volume, bool isSourcesInDifferentVolume, float originalDistance, float maxDistance)
	{
		throw null;
	}

	// Token: 0x06004829 RID: 18473 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_2(GStruct386 connection, ref float lowerFrequency, Vector3 listenerPosition, Vector3 soundPosition, ref float occlusionEffect, ref float volume, float distance, bool isSourcesInDifferentVolume)
	{
		throw null;
	}

	// Token: 0x0600482A RID: 18474 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static AudioMixerGroup VolumeDependentOcclusion(Vector3 soundPosition, ref float volume, float distance)
	{
		throw null;
	}

	// Token: 0x0600482B RID: 18475 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static AudioMixerGroup VolumeDependentOcclusion(Vector3 soundPosition, ref float volume, float distance, Player sourcePlayer, EnvironmentType sourceEnvironment)
	{
		throw null;
	}

	// Token: 0x0600482C RID: 18476 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static AudioMixerGroup VolumeDependentOcclusion(Vector3 soundPosition, ref float volume, float distance, IPlayer sourcePlayer, EnvironmentType sourceEnvironment, int mask)
	{
		throw null;
	}

	// Token: 0x0600482D RID: 18477 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static AudioMixerGroup GetGunshotOcclusionMixerGroup(float occlusionEffect)
	{
		throw null;
	}

	// Token: 0x0600482E RID: 18478 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static AudioMixerGroup GetGunshotsOcclusionGroup(Player player, out float volume)
	{
		throw null;
	}

	// Token: 0x040052E6 RID: 21222
	private static RaycastHit raycastHit_0;

	// Token: 0x040052E7 RID: 21223
	private static float float_0;

	// Token: 0x040052E8 RID: 21224
	private static float float_1;
}
