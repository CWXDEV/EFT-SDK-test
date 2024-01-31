using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Interactive
{
	// Token: 0x0200279C RID: 10140
	public class Switch : WorldInteractiveObject
	{
		// Token: 0x1700241F RID: 9247
		// (get) Token: 0x0600CB1C RID: 51996 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CB1D RID: 51997 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x17002420 RID: 9248
		// (get) Token: 0x0600CB1E RID: 51998 RVA: 0x00002050 File Offset: 0x00000250
		public bool HasAuthority
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002421 RID: 9249
		// (get) Token: 0x0600CB1F RID: 51999 RVA: 0x00002050 File Offset: 0x00000250
		public override string TypeKey
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002422 RID: 9250
		// (get) Token: 0x0600CB20 RID: 52000 RVA: 0x00002050 File Offset: 0x00000250
		public override AnimationCurve ProgressCurve
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002423 RID: 9251
		// (get) Token: 0x0600CB21 RID: 52001 RVA: 0x00002050 File Offset: 0x00000250
		public override float AngleSyncForSync
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002424 RID: 9252
		// (get) Token: 0x0600CB22 RID: 52002 RVA: 0x00002050 File Offset: 0x00000250
		public override float MaxAllowedAngleDesync
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600CB23 RID: 52003 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Interact(InteractionResult interactionResult)
		{
			throw null;
		}

		// Token: 0x0600CB24 RID: 52004 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override IEnumerator SmoothDoorOpenCoroutine(EDoorState state, bool isLocalInteraction, float speed = 1f)
		{
			throw null;
		}

		// Token: 0x0600CB25 RID: 52005 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override WorldInteractiveObject.GStruct385 GetInteractionParameters(Vector3 yourPosition)
		{
			throw null;
		}

		// Token: 0x0600CB26 RID: 52006 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetTip()
		{
			throw null;
		}

		// Token: 0x0600CB27 RID: 52007 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void ProcessAngleAsShift(float value)
		{
			throw null;
		}

		// Token: 0x0600CB28 RID: 52008 RVA: 0x00002050 File Offset: 0x00000250
		[DebuggerHidden]
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_3(EDoorState state, bool isLocalInteraction, float speed)
		{
			throw null;
		}

		// Token: 0x0400CB34 RID: 52020
		[Header("-------------  Switch -----------")]
		public bool DontAnimateRotation;

		// Token: 0x0400CB35 RID: 52021
		public string ContextMenuTip;

		// Token: 0x0400CB36 RID: 52022
		public float Delay;

		// Token: 0x0400CB37 RID: 52023
		[Header("Exfiltration Zone")]
		public ExfiltrationPoint ExfiltrationPoint;

		// Token: 0x0400CB38 RID: 52024
		public EExfiltrationStatus TargetStatus;

		// Token: 0x0400CB39 RID: 52025
		public EExfiltrationStatus[] ConditionStatus;

		// Token: 0x0400CB3A RID: 52026
		public string ExtractionZoneTip;

		// Token: 0x0400CB3B RID: 52027
		[Header("Other Switches")]
		public Switch.SwitchAndOperation[] NextSwitches;

		// Token: 0x0400CB3C RID: 52028
		public Switch PreviousSwitch;

		// Token: 0x0400CB3D RID: 52029
		[Header("Door")]
		public Door Door;

		// Token: 0x0400CB3E RID: 52030
		public EInteractionType Interaction;

		// Token: 0x0400CB3F RID: 52031
		[Header("Lamps")]
		public LampController[] Lamps;

		// Token: 0x0400CB40 RID: 52032
		[Header("Curve is played 1.5x faster. Consider!")]
		public AnimationCurve CustomProgressCurve;

		// Token: 0x0400CB41 RID: 52033
		public Vector3 ShutPosition;

		// Token: 0x0400CB42 RID: 52034
		public Vector3 OpenPosition;

		// Token: 0x0200279D RID: 10141
		[Serializable]
		public class SwitchAndOperation
		{
			// Token: 0x0400CB43 RID: 52035
			public Switch Switch;

			// Token: 0x0400CB44 RID: 52036
			public EInteractionType Operation;
		}
	}
}
