using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Audio.DebugTools;
using EFT;
using JetBrains.Annotations;
using UnityEngine;

namespace Audio.SpatialSystem
{
	// Token: 0x02000D50 RID: 3408
	public sealed class SpatialAudioSystem : MonoBehaviourSingleton<SpatialAudioSystem>
	{
		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x0600485D RID: 18525 RVA: 0x00002050 File Offset: 0x00000250
		private static float Single_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x0600485E RID: 18526 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x0600485F RID: 18527 RVA: 0x00002050 File Offset: 0x00000250
		public SpatialAudioRoom ListenerCurrentRoom
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x06004860 RID: 18528 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004861 RID: 18529 RVA: 0x00002050 File Offset: 0x00000250
		public SoundOcclusionDebugger DebugPanel
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

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x06004862 RID: 18530 RVA: 0x00002050 File Offset: 0x00000250
		public static LoggerClass Logger
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x06004863 RID: 18531 RVA: 0x00002050 File Offset: 0x00000250
		public float PropagationDepth
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004864 RID: 18532 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialize()
		{
			throw null;
		}

		// Token: 0x06004865 RID: 18533 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_0(bool newSystemEnabled = true)
		{
			throw null;
		}

		// Token: 0x06004866 RID: 18534 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static GInterface54 smethod_1()
		{
			throw null;
		}

		// Token: 0x06004867 RID: 18535 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ProcessSourceOcclusion([NotNull] IPlayer player, [NotNull] BetterSource source)
		{
			throw null;
		}

		// Token: 0x06004868 RID: 18536 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(IPlayer player)
		{
			throw null;
		}

		// Token: 0x06004869 RID: 18537 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ProcessSourceOcclusion([NotNull] BetterSource source, EOcclusionTest test)
		{
			throw null;
		}

		// Token: 0x0600486A RID: 18538 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1([NotNull] BetterSource source, EOcclusionTest test = EOcclusionTest.Fast)
		{
			throw null;
		}

		// Token: 0x0600486B RID: 18539 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2([NotNull] BetterSource source)
		{
			throw null;
		}

		// Token: 0x0600486C RID: 18540 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddPlayerCurrentRoom(SpatialAudioRoom room, IPlayer player)
		{
			throw null;
		}

		// Token: 0x0600486D RID: 18541 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(SpatialAudioRoom newRoom, int playerId)
		{
			throw null;
		}

		// Token: 0x0600486E RID: 18542 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemovePlayerCurrentRoom(SpatialAudioRoom room, IPlayer player)
		{
			throw null;
		}

		// Token: 0x0600486F RID: 18543 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsSourceInListenerRoom(GClass984 sourceContainer)
		{
			throw null;
		}

		// Token: 0x06004870 RID: 18544 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsSourceInListenerRoom(Vector3 sourcePosition)
		{
			throw null;
		}

		// Token: 0x06004871 RID: 18545 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsSourceAndListenerOutdoor(SpatialAudioRoom sourceRoom)
		{
			throw null;
		}

		// Token: 0x06004872 RID: 18546 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x06004873 RID: 18547 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LateUpdate()
		{
			throw null;
		}

		// Token: 0x06004874 RID: 18548 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x06004875 RID: 18549 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x06004876 RID: 18550 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x06004877 RID: 18551 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7()
		{
			throw null;
		}

		// Token: 0x06004878 RID: 18552 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x06004879 RID: 18553 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9(GClass984 sourceContainer)
		{
			throw null;
		}

		// Token: 0x0600487A RID: 18554 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10()
		{
			throw null;
		}

		// Token: 0x0600487B RID: 18555 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11(GClass984 sourceContainer)
		{
			throw null;
		}

		// Token: 0x0600487C RID: 18556 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Transform method_12()
		{
			throw null;
		}

		// Token: 0x0600487D RID: 18557 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryGetMatchingRoomPair(SpatialAudioRoom emitterRoom, out RoomPair roomPair)
		{
			throw null;
		}

		// Token: 0x0600487E RID: 18558 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryGetPortalById(int id, out SpatialAudioPortal portal)
		{
			throw null;
		}

		// Token: 0x0600487F RID: 18559 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnDestroy()
		{
			throw null;
		}

		// Token: 0x06004880 RID: 18560 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x06004881 RID: 18561 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_13()
		{
			throw null;
		}

		// Token: 0x0400534B RID: 21323
		private const float float_0 = 4f;

		// Token: 0x0400534C RID: 21324
		public bool UseNewPropagationSystem;

		// Token: 0x0400534D RID: 21325
		public bool UseWindowsBreakSystem;

		// Token: 0x0400534E RID: 21326
		[SerializeField]
		private AudioRoutesBakeData _routesBakeData;

		// Token: 0x0400534F RID: 21327
		private readonly List<GClass984> list_0;

		// Token: 0x04005350 RID: 21328
		private readonly Dictionary<int, GClass984> dictionary_0;

		// Token: 0x04005351 RID: 21329
		private readonly Dictionary<int, GClass976> dictionary_1;

		// Token: 0x04005352 RID: 21330
		private readonly List<GClass976> list_1;

		// Token: 0x04005353 RID: 21331
		private readonly GClass831<GClass984> gclass831_0;

		// Token: 0x04005354 RID: 21332
		private Transform transform_0;

		// Token: 0x04005355 RID: 21333
		private bool bool_0;

		// Token: 0x04005356 RID: 21334
		private GClass969 gclass969_0;

		// Token: 0x04005357 RID: 21335
		private GClass968 gclass968_0;

		// Token: 0x04005358 RID: 21336
		private GInterface54 ginterface54_0;

		// Token: 0x04005359 RID: 21337
		private float float_1;

		// Token: 0x0400535A RID: 21338
		[CompilerGenerated]
		private SoundOcclusionDebugger soundOcclusionDebugger_0;

		// Token: 0x0400535B RID: 21339
		[CompilerGenerated]
		private static readonly LoggerClass gclass611_0;
	}
}
