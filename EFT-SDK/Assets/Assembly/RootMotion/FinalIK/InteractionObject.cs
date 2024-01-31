using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020010D1 RID: 4305
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Object")]
	public class InteractionObject : MonoBehaviour
	{
		// Token: 0x06005AC4 RID: 23236 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x06005AC5 RID: 23237 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x06005AC6 RID: 23238 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x06005AC7 RID: 23239 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x06005AC8 RID: 23240 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("Support Group")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x06005AC9 RID: 23241 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("Asset Store Thread")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x17000E3F RID: 3647
		// (get) Token: 0x06005ACA RID: 23242 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005ACB RID: 23243 RVA: 0x00002050 File Offset: 0x00000250
		public float length
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

		// Token: 0x17000E40 RID: 3648
		// (get) Token: 0x06005ACC RID: 23244 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005ACD RID: 23245 RVA: 0x00002050 File Offset: 0x00000250
		public InteractionSystem lastUsedInteractionSystem
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

		// Token: 0x06005ACE RID: 23246 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initiate()
		{
			throw null;
		}

		// Token: 0x17000E41 RID: 3649
		// (get) Token: 0x06005ACF RID: 23247 RVA: 0x00002050 File Offset: 0x00000250
		public Transform lookAtTarget
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06005AD0 RID: 23248 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			throw null;
		}

		// Token: 0x06005AD1 RID: 23249 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CurveUsed(InteractionObject.WeightCurve.Type type)
		{
			throw null;
		}

		// Token: 0x06005AD2 RID: 23250 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public InteractionTarget[] GetTargets()
		{
			throw null;
		}

		// Token: 0x06005AD3 RID: 23251 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			throw null;
		}

		// Token: 0x06005AD4 RID: 23252 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
			throw null;
		}

		// Token: 0x06005AD5 RID: 23253 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
			throw null;
		}

		// Token: 0x06005AD6 RID: 23254 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetValue(InteractionObject.WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			throw null;
		}

		// Token: 0x17000E42 RID: 3650
		// (get) Token: 0x06005AD7 RID: 23255 RVA: 0x00002050 File Offset: 0x00000250
		public Transform targetsRoot
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06005AD8 RID: 23256 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x06005AD9 RID: 23257 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionObject.WeightCurve.Type type, float value, float weight)
		{
			throw null;
		}

		// Token: 0x06005ADA RID: 23258 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Transform method_7(FullBodyBipedEffector effectorType)
		{
			throw null;
		}

		// Token: 0x06005ADB RID: 23259 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private int method_8(InteractionObject.WeightCurve.Type weightCurveType)
		{
			throw null;
		}

		// Token: 0x06005ADC RID: 23260 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private int method_9(InteractionObject.WeightCurve.Type weightCurveType)
		{
			throw null;
		}

		// Token: 0x06005ADD RID: 23261 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("User Manual")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10()
		{
			throw null;
		}

		// Token: 0x06005ADE RID: 23262 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("Scrpt Reference")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11()
		{
			throw null;
		}

		// Token: 0x04006654 RID: 26196
		[Tooltip("If the Interaction System has a 'Look At' LookAtIK component assigned, will use it to make the character look at the specified Transform. If unassigned, will look at this GameObject.")]
		public Transform otherLookAtTarget;

		// Token: 0x04006655 RID: 26197
		[Tooltip("The root Transform of the InteractionTargets. If null, will use this GameObject. GetComponentsInChildren<InteractionTarget>() will be used at initiation to find all InteractionTargets associated with this InteractionObject.")]
		public Transform otherTargetsRoot;

		// Token: 0x04006656 RID: 26198
		[Tooltip("If assigned, all PositionOffset channels will be applied in the rotation space of this Transform. If not, they will be in the rotation space of the character.")]
		public Transform positionOffsetSpace;

		// Token: 0x04006657 RID: 26199
		public InteractionObject.WeightCurve[] weightCurves;

		// Token: 0x04006658 RID: 26200
		public InteractionObject.Multiplier[] multipliers;

		// Token: 0x04006659 RID: 26201
		public InteractionObject.InteractionEvent[] events;

		// Token: 0x0400665C RID: 26204
		private InteractionTarget[] targets;

		// Token: 0x020010D2 RID: 4306
		[Serializable]
		public class InteractionEvent
		{
			// Token: 0x06005ADF RID: 23263 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Activate(Transform t)
			{
				throw null;
			}

			// Token: 0x0400665D RID: 26205
			[Tooltip("The time of the event since interaction start.")]
			public float time;

			// Token: 0x0400665E RID: 26206
			[Tooltip("If true, the interaction will be paused on this event. The interaction can be resumed by InteractionSystem.ResumeInteraction() or InteractionSystem.ResumeAll;")]
			public bool pause;

			// Token: 0x0400665F RID: 26207
			[Tooltip("If true, the object will be parented to the effector bone on this event. Note that picking up like this can be done by only a single effector at a time. If you wish to pick up an object with both hands, see the Interaction PickUp2Handed demo scene.")]
			public bool pickUp;

			// Token: 0x04006660 RID: 26208
			[Tooltip("The animations called on this event.")]
			public InteractionObject.AnimatorEvent[] animations;

			// Token: 0x04006661 RID: 26209
			[Tooltip("The messages sent on this event using GameObject.SendMessage().")]
			public InteractionObject.Message[] messages;
		}

		// Token: 0x020010D3 RID: 4307
		[Serializable]
		public class Message
		{
			// Token: 0x06005AE0 RID: 23264 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Send(Transform t)
			{
				throw null;
			}

			// Token: 0x04006662 RID: 26210
			[Tooltip("The name of the function called.")]
			public string function;

			// Token: 0x04006663 RID: 26211
			[Tooltip("The recipient game object.")]
			public GameObject recipient;

			// Token: 0x04006664 RID: 26212
			private const string empty = "";
		}

		// Token: 0x020010D4 RID: 4308
		[Serializable]
		public class AnimatorEvent
		{
			// Token: 0x06005AE1 RID: 23265 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Activate(bool pickUp)
			{
				throw null;
			}

			// Token: 0x06005AE2 RID: 23266 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_0(Animator animator)
			{
				throw null;
			}

			// Token: 0x06005AE3 RID: 23267 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_1(Animation animation)
			{
				throw null;
			}

			// Token: 0x04006665 RID: 26213
			[Tooltip("The Animator component that will receive the AnimatorEvents.")]
			public Animator animator;

			// Token: 0x04006666 RID: 26214
			[Tooltip("The Animation component that will receive the AnimatorEvents (Legacy).")]
			public Animation animation;

			// Token: 0x04006667 RID: 26215
			[Tooltip("The name of the animation state.")]
			public string animationState;

			// Token: 0x04006668 RID: 26216
			[Tooltip("The crossfading time.")]
			public float crossfadeTime;

			// Token: 0x04006669 RID: 26217
			[Tooltip("The layer of the animation state (if using Legacy, the animation state will be forced to this layer).")]
			public int layer;

			// Token: 0x0400666A RID: 26218
			[Tooltip("Should the animation always start from 0 normalized time?")]
			public bool resetNormalizedTime;

			// Token: 0x0400666B RID: 26219
			private const string empty = "";
		}

		// Token: 0x020010D5 RID: 4309
		[Serializable]
		public class WeightCurve
		{
			// Token: 0x06005AE4 RID: 23268 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public float GetValue(float timer)
			{
				throw null;
			}

			// Token: 0x0400666C RID: 26220
			[Tooltip("The type of the curve (InteractionObject.WeightCurve.Type).")]
			public InteractionObject.WeightCurve.Type type;

			// Token: 0x0400666D RID: 26221
			[Tooltip("The weight curve.")]
			public AnimationCurve curve;

			// Token: 0x020010D6 RID: 4310
			[Serializable]
			public enum Type
			{
				// Token: 0x0400666F RID: 26223
				PositionWeight,
				// Token: 0x04006670 RID: 26224
				RotationWeight,
				// Token: 0x04006671 RID: 26225
				PositionOffsetX,
				// Token: 0x04006672 RID: 26226
				PositionOffsetY,
				// Token: 0x04006673 RID: 26227
				PositionOffsetZ,
				// Token: 0x04006674 RID: 26228
				Pull,
				// Token: 0x04006675 RID: 26229
				Reach,
				// Token: 0x04006676 RID: 26230
				RotateBoneWeight,
				// Token: 0x04006677 RID: 26231
				Push,
				// Token: 0x04006678 RID: 26232
				PushParent,
				// Token: 0x04006679 RID: 26233
				PoserWeight
			}
		}

		// Token: 0x020010D7 RID: 4311
		[Serializable]
		public class Multiplier
		{
			// Token: 0x06005AE5 RID: 23269 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public float GetValue(InteractionObject.WeightCurve weightCurve, float timer)
			{
				throw null;
			}

			// Token: 0x0400667A RID: 26234
			[Tooltip("The curve type to multiply.")]
			public InteractionObject.WeightCurve.Type curve;

			// Token: 0x0400667B RID: 26235
			[Tooltip("The multiplier of the curve's value.")]
			public float multiplier;

			// Token: 0x0400667C RID: 26236
			[Tooltip("The resulting value will be applied to this channel.")]
			public InteractionObject.WeightCurve.Type result;
		}
	}
}
