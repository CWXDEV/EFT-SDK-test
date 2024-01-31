using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Audio.SpatialSystem;
using UnityEngine;

// Token: 0x020008CB RID: 2251
[Serializable]
public class SpatialAudioRoom : MonoBehaviour
{
	// Token: 0x170008B0 RID: 2224
	// (get) Token: 0x0600329C RID: 12956 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600329D RID: 12957 RVA: 0x00002050 File Offset: 0x00000250
	public BoxCollider[] Colliders
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x170008B1 RID: 2225
	// (get) Token: 0x0600329E RID: 12958 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600329F RID: 12959 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsInitialized
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x170008B2 RID: 2226
	// (get) Token: 0x060032A0 RID: 12960 RVA: 0x00002050 File Offset: 0x00000250
	public int ID
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170008B3 RID: 2227
	// (get) Token: 0x060032A1 RID: 12961 RVA: 0x00002050 File Offset: 0x00000250
	public float RoomSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060032A2 RID: 12962 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Awake()
	{
		throw null;
	}

	// Token: 0x060032A3 RID: 12963 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x060032A4 RID: 12964 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize()
	{
		throw null;
	}

	// Token: 0x060032A5 RID: 12965 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x060032A6 RID: 12966 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_2()
	{
		throw null;
	}

	// Token: 0x060032A7 RID: 12967 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x060032A8 RID: 12968 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4()
	{
		throw null;
	}

	// Token: 0x060032A9 RID: 12969 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5(object sender, GEventArgs0 e)
	{
		throw null;
	}

	// Token: 0x060032AA RID: 12970 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x060032AB RID: 12971 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6()
	{
		throw null;
	}

	// Token: 0x060032AC RID: 12972 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_7()
	{
		throw null;
	}

	// Token: 0x040033BC RID: 13244
	private readonly GClass982 _logger;

	// Token: 0x040033BD RID: 13245
	[Tooltip("Optionally give the room a unique name for more informative debug messages.")]
	public string roomName;

	// Token: 0x040033BE RID: 13246
	public List<AudioTriggerArea> Areas;

	// Token: 0x040033BF RID: 13247
	public bool Outdoor;

	// Token: 0x040033C0 RID: 13248
	public bool Isolated;

	// Token: 0x040033C1 RID: 13249
	[Tooltip("experimental options to fit room in scene geometry")]
	public bool FitToGeometry;

	// Token: 0x040033C2 RID: 13250
	public List<SpatialAudioRoom.RoomConnection> roomConnections;

	// Token: 0x040033C3 RID: 13251
	[SerializeField]
	private int _iD;

	// Token: 0x040033C4 RID: 13252
	[SerializeField]
	private float _roomSize;

	// Token: 0x040033C5 RID: 13253
	private readonly Dictionary<int, uint> _playersEnteredAreasCount;

	// Token: 0x020008CC RID: 2252
	[Serializable]
	public class RoomConnection
	{
		// Token: 0x040033C8 RID: 13256
		public SpatialAudioRoom connectedRoom;

		// Token: 0x040033C9 RID: 13257
		public SpatialAudioPortal[] connectingPortals;
	}

	// Token: 0x020008CD RID: 2253
	[CompilerGenerated]
	[Serializable]
	private sealed class Class464
	{
		// Token: 0x060032AD RID: 12973 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(SpatialAudioPortal connectingPortal)
		{
			throw null;
		}

		// Token: 0x040033CA RID: 13258
		public static readonly SpatialAudioRoom.Class464 class464_0;

		// Token: 0x040033CB RID: 13259
		public static Func<SpatialAudioPortal, bool> func_0;
	}
}
