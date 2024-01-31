using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EFT.Interactive;
using EFT.NextObservedPlayer;
using UnityEngine;

namespace EFT
{
	// Token: 0x0200185C RID: 6236
	internal abstract class ClientGameWorld : GameWorld
	{
		// Token: 0x17001497 RID: 5271
		// (get) Token: 0x060085A0 RID: 34208 RVA: 0x00002050 File Offset: 0x00000250
		internal int Int32_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001498 RID: 5272
		// (get) Token: 0x060085A1 RID: 34209 RVA: 0x00002050 File Offset: 0x00000250
		public override ulong TotalOutgoingBytes
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001499 RID: 5273
		// (get) Token: 0x060085A2 RID: 34210 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060085A3 RID: 34211 RVA: 0x00002050 File Offset: 0x00000250
		public float LastServerWorldTime
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060085A4 RID: 34212 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Task InitLevel(ItemFactory itemFactory, GClass1797 config, bool loadBundlesAndCreatePools = true, List<ResourceKey> resources = null, IProgress<GStruct117> progress = null, CancellationToken ct = default(CancellationToken))
		{
			throw null;
		}

		// Token: 0x060085A5 RID: 34213 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void vmethod_0(World world)
		{
			throw null;
		}

		// Token: 0x060085A6 RID: 34214 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_18(Vector3 pos)
		{
			throw null;
		}

		// Token: 0x060085A7 RID: 34215 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override Task PreloadAdditionalData()
		{
			throw null;
		}

		// Token: 0x060085A8 RID: 34216 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_19(int netId, Turnable.EState state)
		{
			throw null;
		}

		// Token: 0x060085A9 RID: 34217 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_20(int netId, Vector3 hitPosition)
		{
			throw null;
		}

		// Token: 0x060085AA RID: 34218 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ShotDelegate(GClass2988 shotResult)
		{
			throw null;
		}

		// Token: 0x060085AB RID: 34219 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override GClass1673 HackShot(DamageInfo damageInfo)
		{
			throw null;
		}

		// Token: 0x060085AC RID: 34220 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnDestroy()
		{
			throw null;
		}

		// Token: 0x060085AD RID: 34221 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void RegisterPlayer(IPlayer iPlayer)
		{
			throw null;
		}

		// Token: 0x060085AE RID: 34222 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void UnregisterPlayer(IPlayer player)
		{
			throw null;
		}

		// Token: 0x060085AF RID: 34223 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OtherElseWorldTick(float dt)
		{
			throw null;
		}

		// Token: 0x060085B0 RID: 34224 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LateUpdate()
		{
			throw null;
		}

		// Token: 0x060085B1 RID: 34225 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_21(ClientPlayer player, int bytes, ulong totalBytes)
		{
			throw null;
		}

		// Token: 0x060085B2 RID: 34226 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_22(ObservedPlayerView player, int bytes, ulong totalBytes)
		{
			throw null;
		}

		// Token: 0x060085B3 RID: 34227 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SpawnLootCorpse(GClass1197 lootItem)
		{
			throw null;
		}

		// Token: 0x060085B4 RID: 34228 RVA: 0x00002050 File Offset: 0x00000250
		[DebuggerHidden]
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_23(ItemFactory itemFactory, GClass1797 config, bool loadBundlesAndCreatePools, List<ResourceKey> resources, IProgress<GStruct117> progress, CancellationToken ct)
		{
			throw null;
		}

		// Token: 0x060085B5 RID: 34229 RVA: 0x00002050 File Offset: 0x00000250
		[DebuggerHidden]
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_24()
		{
			throw null;
		}

		// Token: 0x04008C8F RID: 35983
		private int int_5;

		// Token: 0x04008C90 RID: 35984
		private ulong ulong_0;

		// Token: 0x04008C91 RID: 35985
		private ulong ulong_1;

		// Token: 0x04008C92 RID: 35986
		[CompilerGenerated]
		private float float_0;

		// Token: 0x0200185E RID: 6238
		[CompilerGenerated]
		private sealed class Class1366
		{
			// Token: 0x060085B8 RID: 34232 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x060085B9 RID: 34233 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x04008C9D RID: 35997
			public ClientWorld clientWorld;

			// Token: 0x04008C9E RID: 35998
			public ClientGameWorld clientGameWorld_0;
		}
	}
}
