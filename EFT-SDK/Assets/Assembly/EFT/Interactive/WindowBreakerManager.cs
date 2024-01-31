using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace EFT.Interactive
{
	// Token: 0x020027F4 RID: 10228
	public sealed class WindowBreakerManager : MonoBehaviour
	{
		// Token: 0x17002494 RID: 9364
		// (get) Token: 0x0600CCC4 RID: 52420 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CCC5 RID: 52421 RVA: 0x00002050 File Offset: 0x00000250
		public static WindowBreakerManager Instance
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

		// Token: 0x0600CCC6 RID: 52422 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600CCC7 RID: 52423 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600CCC8 RID: 52424 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0600CCC9 RID: 52425 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReturnToPool(GStruct387 piece)
		{
			throw null;
		}

		// Token: 0x0600CCCA RID: 52426 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct387 GetBrokenWindowPiece()
		{
			throw null;
		}

		// Token: 0x0600CCCB RID: 52427 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_0(WindowBreaker windowBreaker, DamageInfo info, WindowBreakingConfig.Crack brokenWindowCrack, float angle)
		{
			throw null;
		}

		// Token: 0x0600CCCC RID: 52428 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600CCCD RID: 52429 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private GStruct387 method_1()
		{
			throw null;
		}

		// Token: 0x0600CCCE RID: 52430 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static GStruct387 CreateBrokenWindowPiece()
		{
			throw null;
		}

		// Token: 0x0400CD11 RID: 52497
		private const int int_0 = 5000;

		// Token: 0x0400CD12 RID: 52498
		[CompilerGenerated]
		private static WindowBreakerManager windowBreakerManager_0;

		// Token: 0x0400CD13 RID: 52499
		private static readonly Queue<WindowBreakerManager.Struct776> queue_0;

		// Token: 0x0400CD14 RID: 52500
		[SerializeField]
		private BrokenWindowPieceTemplate _stuckPiecePrefab;

		// Token: 0x0400CD15 RID: 52501
		private Queue<GStruct387> queue_1;

		// Token: 0x020027F5 RID: 10229
		public interface GInterface353
		{
			// Token: 0x0600CCCF RID: 52431
			void Break(WindowBreakingConfig.Crack crack, in Vector3 position, in Vector3 force, float angle);
		}

		// Token: 0x020027F6 RID: 10230
		[StructLayout(LayoutKind.Auto)]
		public struct Struct776
		{
			// Token: 0x0400CD16 RID: 52502
			public WindowBreakerManager.GInterface353 Breakable;

			// Token: 0x0400CD17 RID: 52503
			public WindowBreakingConfig.Crack Crack;

			// Token: 0x0400CD18 RID: 52504
			public Vector3 Position;

			// Token: 0x0400CD19 RID: 52505
			public Vector3 Force;

			// Token: 0x0400CD1A RID: 52506
			public float Angle;
		}
	}
}
