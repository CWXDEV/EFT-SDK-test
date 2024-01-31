using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace EFT.Hideout
{
	// Token: 0x02001A7C RID: 6780
	public class InteractiveAmbianceObject<T> : AmbianceObject<T>, GInterface159
	{
		// Token: 0x170015A2 RID: 5538
		// (get) Token: 0x06008EEC RID: 36588 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008EED RID: 36589 RVA: 0x00002050 File Offset: 0x00000250
		private ELightStatus PreviousStatus
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

		// Token: 0x170015A3 RID: 5539
		// (get) Token: 0x06008EEE RID: 36590 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008EEF RID: 36591 RVA: 0x00002050 File Offset: 0x00000250
		private ELightStatus CurrentStatus
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

		// Token: 0x170015A4 RID: 5540
		// (get) Token: 0x06008EF0 RID: 36592 RVA: 0x00002050 File Offset: 0x00000250
		public ELightStatus CombinedStatus
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170015A5 RID: 5541
		// (get) Token: 0x06008EF1 RID: 36593 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008EF2 RID: 36594 RVA: 0x00002050 File Offset: 0x00000250
		public bool Enabled
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

		// Token: 0x170015A6 RID: 5542
		// (get) Token: 0x06008EF3 RID: 36595 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008EF4 RID: 36596 RVA: 0x00002050 File Offset: 0x00000250
		public bool Active
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

		// Token: 0x06008EF5 RID: 36597 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEnable(bool value)
		{
			throw null;
		}

		// Token: 0x06008EF6 RID: 36598 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnEnable()
		{
			throw null;
		}

		// Token: 0x06008EF7 RID: 36599 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnDisable()
		{
			throw null;
		}

		// Token: 0x06008EF8 RID: 36600 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void Interact()
		{
			throw null;
		}

		// Token: 0x06008EF9 RID: 36601 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Task<bool> PerformInteraction(ELightStatus status)
		{
			throw null;
		}

		// Token: 0x06008EFA RID: 36602 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[DebuggerHidden]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task<bool> method_0(ELightStatus status)
		{
			throw null;
		}

		// Token: 0x04009632 RID: 38450
		private bool bool_0;

		// Token: 0x04009633 RID: 38451
		private bool bool_1;

		// Token: 0x04009634 RID: 38452
		[CompilerGenerated]
		private ELightStatus elightStatus_0;

		// Token: 0x04009635 RID: 38453
		[CompilerGenerated]
		private ELightStatus elightStatus_1;

		// Token: 0x04009636 RID: 38454
		[CompilerGenerated]
		private bool bool_2;

		// Token: 0x04009637 RID: 38455
		[CompilerGenerated]
		private bool bool_3;
	}
}
