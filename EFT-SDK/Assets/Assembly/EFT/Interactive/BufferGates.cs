using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Interactive
{
	// Token: 0x02002727 RID: 10023
	public class BufferGates : Switch
	{
		// Token: 0x170023A0 RID: 9120
		// (get) Token: 0x0600C8BC RID: 51388 RVA: 0x00002050 File Offset: 0x00000250
		internal bool Boolean_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600C8BD RID: 51389 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void ProcessAngleAsShift(float value)
		{
			throw null;
		}

		// Token: 0x0600C8BE RID: 51390 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void DoorStateChanged(EDoorState newState)
		{
			throw null;
		}

		// Token: 0x0600C8BF RID: 51391 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void InitializeSmoothOpenInteraction(EDoorState state, bool confirmed)
		{
			throw null;
		}

		// Token: 0x0600C8C0 RID: 51392 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override bool CanStartInteraction(EDoorState state, bool logFalse = false)
		{
			throw null;
		}

		// Token: 0x0600C8C1 RID: 51393 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600C8C2 RID: 51394 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0600C8C3 RID: 51395 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x0600C8C4 RID: 51396 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7()
		{
			throw null;
		}

		// Token: 0x0400C8D4 RID: 51412
		[SerializeField]
		private AnimationCurve _gatesMovementCurve;

		// Token: 0x0400C8D5 RID: 51413
		[SerializeField]
		private AnimationCurve _gatesCloseMovementCurve;

		// Token: 0x0400C8D6 RID: 51414
		[SerializeField]
		private GameObjectsToggleByDistance gatePartsDisabler;

		// Token: 0x0400C8D7 RID: 51415
		[SerializeField]
		private AudioClip _gatesOpenSound;

		// Token: 0x0400C8D8 RID: 51416
		[SerializeField]
		private AudioClip _gatesCloseSound;

		// Token: 0x0400C8D9 RID: 51417
		[SerializeField]
		private float _curveValueOnStartAutoClosing;

		// Token: 0x0400C8DA RID: 51418
		private float float_0;

		// Token: 0x0400C8DB RID: 51419
		private float float_1;

		// Token: 0x0400C8DC RID: 51420
		private bool bool_0;

		// Token: 0x0400C8DD RID: 51421
		private bool bool_1;
	}
}
