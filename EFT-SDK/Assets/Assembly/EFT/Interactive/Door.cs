using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

namespace EFT.Interactive
{
	// Token: 0x02002759 RID: 10073
	public class Door : WorldInteractiveObject
	{
		// Token: 0x170023C9 RID: 9161
		// (get) Token: 0x0600C9B7 RID: 51639 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C9B8 RID: 51640 RVA: 0x00002050 File Offset: 0x00000250
		public override EDoorState DoorState
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170023CA RID: 9162
		// (get) Token: 0x0600C9B9 RID: 51641 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C9BA RID: 51642 RVA: 0x00002050 File Offset: 0x00000250
		public override float CurrentAngle
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x170023CB RID: 9163
		// (get) Token: 0x0600C9BB RID: 51643 RVA: 0x00002050 File Offset: 0x00000250
		public override string TypeKey
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600C9BC RID: 51644 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnValidate()
		{
			throw null;
		}

		// Token: 0x0600C9BD RID: 51645 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600C9BE RID: 51646 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsBreachAngle(Vector3 yourPosition)
		{
			throw null;
		}

		// Token: 0x0600C9BF RID: 51647 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool BreachSuccessRoll(Vector3 yourPosition)
		{
			throw null;
		}

		// Token: 0x0600C9C0 RID: 51648 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static GStruct415<InteractionResult> Interact(Player player, EInteractionType interactionType)
		{
			throw null;
		}

		// Token: 0x0600C9C1 RID: 51649 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Interact(InteractionResult interactionResult)
		{
			throw null;
		}

		// Token: 0x0600C9C2 RID: 51650 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override WorldInteractiveObject.GStruct385 GetInteractionParameters(Vector3 yourPosition)
		{
			throw null;
		}

		// Token: 0x0600C9C3 RID: 51651 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FailBreach(Vector3 yourPosition)
		{
			throw null;
		}

		// Token: 0x0600C9C4 RID: 51652 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_4()
		{
			throw null;
		}

		// Token: 0x0600C9C5 RID: 51653 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetInitialSyncState(WorldInteractiveObject.GStruct384 info)
		{
			throw null;
		}

		// Token: 0x0600C9C6 RID: 51654 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SyncInteractState(WorldInteractiveObject.GStruct384 info)
		{
			throw null;
		}

		// Token: 0x0600C9C7 RID: 51655 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void KickOpen(bool confirmed)
		{
			throw null;
		}

		// Token: 0x0600C9C8 RID: 51656 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void KickOpen(Vector3 yourPosition, bool confirmed = false)
		{
			throw null;
		}

		// Token: 0x0600C9C9 RID: 51657 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override float GetAngle(EDoorState state)
		{
			throw null;
		}

		// Token: 0x0600C9CA RID: 51658 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void Start()
		{
			throw null;
		}

		// Token: 0x0600C9CB RID: 51659 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool AIEditorPosibleState()
		{
			throw null;
		}

		// Token: 0x0600C9CC RID: 51660 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public WorldInteractiveObject.GStruct385 GetBreakInParameters(Vector3 yourPosition)
		{
			throw null;
		}

		// Token: 0x0600C9CD RID: 51661 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override IEnumerator SmoothDoorOpenCoroutine(EDoorState state, bool isLocalInteraction, float speed = 1f)
		{
			throw null;
		}

		// Token: 0x0600C9CE RID: 51662 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_5(Vector3 yourPosition)
		{
			throw null;
		}

		// Token: 0x0600C9CF RID: 51663 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NavMeshObstacle FindSelfObstalce()
		{
			throw null;
		}

		// Token: 0x170023CC RID: 9164
		// (get) Token: 0x0600C9D0 RID: 51664 RVA: 0x00002050 File Offset: 0x00000250
		public List<Collider> CollisionColliders
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600C9D1 RID: 51665 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override WorldInteractiveObject.GStruct384 GetStatusInfo(bool solidState = false)
		{
			throw null;
		}

		// Token: 0x0600C9D2 RID: 51666 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[DebuggerHidden]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_6(EDoorState state, bool isLocalInteraction, float speed)
		{
			throw null;
		}

		// Token: 0x0400C9BF RID: 51647
		private BrokenDoor brokenDoor_0;

		// Token: 0x0400C9C0 RID: 51648
		public bool IsBroken;

		// Token: 0x0400C9C1 RID: 51649
		public bool CanBeBreached;

		// Token: 0x0400C9C2 RID: 51650
		public bool CanInteractWithBreach;

		// Token: 0x0400C9C3 RID: 51651
		public AnimationCurve KickCurve;

		// Token: 0x0400C9C4 RID: 51652
		public ParticleSystem HitEffect;

		// Token: 0x0400C9C5 RID: 51653
		public AudioClip HitClip;

		// Token: 0x0400C9C6 RID: 51654
		public AudioClip BreachSound;

		// Token: 0x0400C9C7 RID: 51655
		[SerializeField]
		private OcclusionPortal _occlusionPortal;

		// Token: 0x0400C9C8 RID: 51656
		private List<Collider> list_0;
	}
}
