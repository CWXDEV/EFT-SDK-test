using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ChartAndGraph
{
	// Token: 0x02003158 RID: 12632
	public abstract class ChartItemEffect : MonoBehaviour
	{
		// Token: 0x17002AC7 RID: 10951
		// (get) Token: 0x0600F7F9 RID: 63481 RVA: 0x00002050 File Offset: 0x00000250
		protected CharItemEffectController Controller
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x140003A3 RID: 931
		// (add) Token: 0x0600F7FA RID: 63482 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600F7FB RID: 63483 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<ChartItemEffect> Deactivate
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

		// Token: 0x0600F7FC RID: 63484 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void RaiseDeactivated()
		{
			throw null;
		}

		// Token: 0x0600F7FD RID: 63485 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600F7FE RID: 63486 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600F7FF RID: 63487 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnDisable()
		{
			throw null;
		}

		// Token: 0x0600F800 RID: 63488 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnEnable()
		{
			throw null;
		}

		// Token: 0x0600F801 RID: 63489 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Start()
		{
			throw null;
		}

		// Token: 0x0600F802 RID: 63490 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Destroy()
		{
			throw null;
		}

		// Token: 0x0600F803 RID: 63491
		public abstract void TriggerIn(bool deactivateOnEnd);

		// Token: 0x0600F804 RID: 63492
		public abstract void TriggerOut(bool deactivateOnEnd);

		// Token: 0x17002AC9 RID: 10953
		// (get) Token: 0x0600F805 RID: 63493
		internal abstract Quaternion Quaternion_0 { get; }

		// Token: 0x0400FD16 RID: 64790
		internal int int_0;

		// Token: 0x0400FD17 RID: 64791
		private CharItemEffectController charItemEffectController_0;

		// Token: 0x0400FD18 RID: 64792
		[CompilerGenerated]
		private Action<ChartItemEffect> action_0;
	}
}
