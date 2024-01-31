using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Audio.SpatialSystem;
using EFT;
using JetBrains.Annotations;
using UnityEngine;

// Token: 0x02000D29 RID: 3369
public sealed class GClass969
{
	// Token: 0x17000B62 RID: 2914
	// (get) Token: 0x060047A9 RID: 18345 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	public SpatialAudioRoom ListenerCurrentRoom
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060047AA RID: 18346 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(AudioRoutesBakeData routesBakeData)
	{
		throw null;
	}

	// Token: 0x060047AB RID: 18347 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddPlayerCurrentRoom(SpatialAudioRoom room, IPlayer player)
	{
		throw null;
	}

	// Token: 0x060047AC RID: 18348 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(SpatialAudioRoom room)
	{
		throw null;
	}

	// Token: 0x060047AD RID: 18349 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemovePlayerCurrentRoom(SpatialAudioRoom room, IPlayer player)
	{
		throw null;
	}

	// Token: 0x060047AE RID: 18350 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(SpatialAudioRoom room)
	{
		throw null;
	}

	// Token: 0x060047AF RID: 18351 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SpatialAudioRoom GetOtherPlayerCurrentRoom(int playerId)
	{
		throw null;
	}

	// Token: 0x060047B0 RID: 18352 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SpatialAudioRoom FindInitialRoom(Vector3 position)
	{
		throw null;
	}

	// Token: 0x060047B1 RID: 18353 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetMatchingRoomPair(SpatialAudioRoom emitterRoom, SpatialAudioRoom listenerRoom, out RoomPair roomPair)
	{
		throw null;
	}

	// Token: 0x060047B2 RID: 18354 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SpatialAudioRoom FindActualCurrentRoom(SpatialAudioRoom previouslyKnownRoom, Vector3 currentPosition)
	{
		throw null;
	}

	// Token: 0x060047B3 RID: 18355 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private SpatialAudioRoom method_3(IReadOnlyList<SpatialAudioRoom> proposedRooms, int roomsCount)
	{
		throw null;
	}

	// Token: 0x060047B4 RID: 18356 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private SpatialAudioRoom method_4(SpatialAudioRoom roomA, SpatialAudioRoom roomB)
	{
		throw null;
	}

	// Token: 0x060047B5 RID: 18357 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5(List<SpatialAudioRoom> audioRooms)
	{
		throw null;
	}

	// Token: 0x060047B6 RID: 18358 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6()
	{
		throw null;
	}

	// Token: 0x060047B7 RID: 18359 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static List<SpatialAudioRoom> smethod_0(SpatialAudioRoom startingRoom)
	{
		throw null;
	}

	// Token: 0x060047B8 RID: 18360 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
		throw null;
	}

	// Token: 0x04005293 RID: 21139
	private const short short_0 = 5;

	// Token: 0x04005294 RID: 21140
	private readonly List<SpatialAudioRoom> list_0;

	// Token: 0x04005295 RID: 21141
	private readonly Dictionary<SpatialAudioRoom, List<SpatialAudioRoom>> dictionary_0;

	// Token: 0x04005296 RID: 21142
	private readonly List<SpatialAudioRoom> list_1;

	// Token: 0x04005297 RID: 21143
	private readonly Dictionary<int, uint[]> dictionary_1;

	// Token: 0x04005298 RID: 21144
	private readonly Dictionary<uint, RoomPair> dictionary_2;

	// Token: 0x04005299 RID: 21145
	private readonly List<SpatialAudioRoom> list_2;

	// Token: 0x0400529A RID: 21146
	private readonly List<SpatialAudioRoom> list_3;

	// Token: 0x0400529B RID: 21147
	private readonly Dictionary<int, List<SpatialAudioRoom>> dictionary_3;

	// Token: 0x0400529C RID: 21148
	private readonly Dictionary<int, List<SpatialAudioRoom>> dictionary_4;

	// Token: 0x0400529D RID: 21149
	private readonly Dictionary<int, SpatialAudioRoom> dictionary_5;

	// Token: 0x0400529E RID: 21150
	private SpatialAudioRoom spatialAudioRoom_0;
}
