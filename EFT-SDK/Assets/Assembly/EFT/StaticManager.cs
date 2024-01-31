using System;
using System.Collections;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT
{
	// Token: 0x020016BF RID: 5823
	[ExecuteInEditMode]
	public class StaticManager : MonoBehaviour
	{
		// Token: 0x1400017A RID: 378
		// (add) Token: 0x06007DA8 RID: 32168 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06007DA9 RID: 32169 RVA: 0x00002050 File Offset: 0x00000250
		public event Action StaticUpdate
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x170013BB RID: 5051
		// (get) Token: 0x06007DAA RID: 32170 RVA: 0x00002050 File Offset: 0x00000250
		public static StaticManager Instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06007DAB RID: 32171 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x06007DAC RID: 32172 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Coroutine BeginCoroutine(IEnumerator routine)
		{
			throw null;
		}

		// Token: 0x06007DAD RID: 32173 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void KillCoroutine([CanBeNull] Coroutine routine)
		{
			throw null;
		}

		// Token: 0x06007DAE RID: 32174 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void KillCoroutine([CanBeNull] ref Coroutine routine)
		{
			throw null;
		}

		// Token: 0x06007DAF RID: 32175 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x06007DB0 RID: 32176 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x04008493 RID: 33939
		[CompilerGenerated]
		private Action action_0;

		// Token: 0x04008494 RID: 33940
		public GClass551 TimerManager;

		// Token: 0x04008495 RID: 33941
		private static StaticManager staticManager_0;

		// Token: 0x04008496 RID: 33942
		private static bool bool_0;
	}
}
