using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using EFT.BufferZone;
using UnityEngine;

namespace EFT.Interactive
{
	// Token: 0x02002725 RID: 10021
	public class BufferGateSwitcher : Switch
	{
		// Token: 0x1700239C RID: 9116
		// (get) Token: 0x0600C8AE RID: 51374 RVA: 0x00002050 File Offset: 0x00000250
		public bool Interactable
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700239D RID: 9117
		// (get) Token: 0x0600C8AF RID: 51375 RVA: 0x00002050 File Offset: 0x00000250
		public EDoorState BufferGatesState
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x140002D4 RID: 724
		// (add) Token: 0x0600C8B0 RID: 51376 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600C8B1 RID: 51377 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<EInteractionType, bool, IPlayer> OnIntercatWithSwitch
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

		// Token: 0x0600C8B2 RID: 51378 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetUpReferences(BufferZoneContainer bufferZoneContainer)
		{
			throw null;
		}

		// Token: 0x0600C8B3 RID: 51379 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetNextInteractionWithoutSound()
		{
			throw null;
		}

		// Token: 0x0600C8B4 RID: 51380 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override bool CanStartInteraction(EDoorState state, bool logFalse = false)
		{
			throw null;
		}

		// Token: 0x0600C8B5 RID: 51381 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override IEnumerator SmoothDoorOpenCoroutine(EDoorState state, bool isLocalInteraction, float speed = 1f)
		{
			throw null;
		}

		// Token: 0x0600C8B6 RID: 51382 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(bool isSuccessful)
		{
			throw null;
		}

		// Token: 0x0600C8B7 RID: 51383 RVA: 0x00002050 File Offset: 0x00000250
		[DebuggerHidden]
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_5(EDoorState state, bool isLocalInteraction, float speed)
		{
			throw null;
		}

		// Token: 0x0400C8C6 RID: 51398
		[SerializeField]
		private bool _isOpeningEntranceGates;

		// Token: 0x0400C8C7 RID: 51399
		[SerializeField]
		private AudioClip _successfulInteractionSound;

		// Token: 0x0400C8C8 RID: 51400
		[SerializeField]
		private AudioClip _rejectedInteractionSound;

		// Token: 0x0400C8C9 RID: 51401
		private BufferGates bufferGates_0;

		// Token: 0x0400C8CA RID: 51402
		private BufferInnerZone bufferInnerZone_0;

		// Token: 0x0400C8CB RID: 51403
		private IPlayer iplayer_0;

		// Token: 0x0400C8CC RID: 51404
		private bool bool_0;

		// Token: 0x0400C8CD RID: 51405
		[CompilerGenerated]
		private Action<EInteractionType, bool, IPlayer> action_0;
	}
}
