using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using DG.Tweening;
using EFT.Interactive;
using EFT.Utilities;
using EFT.Visual;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001A83 RID: 6787
	public sealed class MultiObjectAmbiance : InteractiveAmbianceObject<MultiObjectAmbiance.AmbianceAffectedObjects>
	{
		// Token: 0x06008F0A RID: 36618 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Task<bool> PerformInteraction(ELightStatus status)
		{
			throw null;
		}

		// Token: 0x06008F0B RID: 36619 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x06008F0C RID: 36620 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnDisable()
		{
			throw null;
		}

		// Token: 0x06008F0D RID: 36621 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[DebuggerHidden]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task<bool> method_1(ELightStatus status)
		{
			throw null;
		}

		// Token: 0x02001A84 RID: 6788
		[Serializable]
		public sealed class AmbianceAffectedObjects
		{
			// Token: 0x06008F0E RID: 36622 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void PerformTransition()
			{
				throw null;
			}

			// Token: 0x06008F0F RID: 36623 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public float GetTime(bool update)
			{
				throw null;
			}

			// Token: 0x06008F10 RID: 36624 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Disable()
			{
				throw null;
			}

			// Token: 0x06008F11 RID: 36625 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Destroy()
			{
				throw null;
			}

			// Token: 0x0400964C RID: 38476
			public List<GClass1897> ControlledObjects;

			// Token: 0x0400964D RID: 38477
			public float TransitionTime;

			// Token: 0x0400964E RID: 38478
			public float RandomRange;

			// Token: 0x0400964F RID: 38479
			public Ease TransitionType;

			// Token: 0x04009650 RID: 38480
			private float _currentTransitionTime;
		}

		// Token: 0x02001A85 RID: 6789
		[Serializable]
		public abstract class AnimatedAmbianceAffectedObject : GClass1897
		{
			// Token: 0x170015A9 RID: 5545
			// (get) Token: 0x06008F12 RID: 36626 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06008F13 RID: 36627 RVA: 0x00002050 File Offset: 0x00000250
			protected string PropertyId
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

			// Token: 0x06008F14 RID: 36628 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected string GetObjectId(UnityEngine.Object obj, string propertyId = null)
			{
				throw null;
			}

			// Token: 0x04009651 RID: 38481
			protected string TweenId;

			// Token: 0x04009652 RID: 38482
			private string _propertyId;
		}

		// Token: 0x02001A86 RID: 6790
		[Serializable]
		public abstract class LoopedAmbianceAffectedObject<TUnityObject, TLoopedAmbiance> : MultiObjectAmbiance.AnimatedAmbianceAffectedObject where TUnityObject : UnityEngine.Object where TLoopedAmbiance : MultiObjectAmbiance.LoopedAmbianceAffectedObject<TUnityObject, TLoopedAmbiance>
		{
			// Token: 0x06008F15 RID: 36629 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void LoopTween(Tween tween, TUnityObject target, string propertyName = null, params Tween[] extraTweens)
			{
				throw null;
			}

			// Token: 0x06008F16 RID: 36630 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Disable()
			{
				throw null;
			}

			// Token: 0x06008F17 RID: 36631 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Destroy()
			{
				throw null;
			}

			// Token: 0x06008F18 RID: 36632 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void InitTween(Tween tween)
			{
				throw null;
			}

			// Token: 0x06008F19 RID: 36633 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected virtual void InitLoopEffect()
			{
				throw null;
			}

			// Token: 0x06008F1A RID: 36634 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_0()
			{
				throw null;
			}

			// Token: 0x06008F1B RID: 36635 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected bool SecondaryAction()
			{
				throw null;
			}

			// Token: 0x06008F1C RID: 36636 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_1()
			{
				throw null;
			}

			// Token: 0x04009653 RID: 38483
			public bool Loop;

			// Token: 0x04009654 RID: 38484
			public TLoopedAmbiance LoopEffect;

			// Token: 0x04009655 RID: 38485
			public TUnityObject AffectedObject;

			// Token: 0x04009656 RID: 38486
			[SerializeField]
			[HideInInspector]
			private bool _secondaryAction;
		}

		// Token: 0x02001A87 RID: 6791
		[Serializable]
		public class AffectedMultiShaders : MultiObjectAmbiance.AmbianceAffectedShader
		{
			// Token: 0x06008F1D RID: 36637 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void InitLoopEffect()
			{
				throw null;
			}

			// Token: 0x06008F1E RID: 36638 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void InitTween(Tween tween)
			{
				throw null;
			}

			// Token: 0x06008F1F RID: 36639 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Material method_3(GameObject x)
			{
				throw null;
			}

			// Token: 0x06008F20 RID: 36640 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_4()
			{
				throw null;
			}

			// Token: 0x04009657 RID: 38487
			public List<GameObject> ExtraShaders;

			// Token: 0x04009658 RID: 38488
			private IEnumerable<Material> _extraMaterials;
		}

		// Token: 0x02001A88 RID: 6792
		[Serializable]
		public class AmbianceAffectedShader : MultiObjectAmbiance.LoopedAmbianceAffectedObject<GameObject, MultiObjectAmbiance.AmbianceAffectedShader>
		{
			// Token: 0x06008F21 RID: 36641 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void PerformTransition()
			{
				throw null;
			}

			// Token: 0x06008F22 RID: 36642 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void InitLoopEffect()
			{
				throw null;
			}

			// Token: 0x06008F23 RID: 36643 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetColor()
			{
				throw null;
			}

			// Token: 0x06008F24 RID: 36644 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetFloat()
			{
				throw null;
			}

			// Token: 0x06008F25 RID: 36645 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetRandom()
			{
				throw null;
			}

			// Token: 0x06008F26 RID: 36646 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_2()
			{
				throw null;
			}

			// Token: 0x04009659 RID: 38489
			public string PropertyName;

			// Token: 0x0400965A RID: 38490
			public int MaterialNumber;

			// Token: 0x0400965B RID: 38491
			public bool Float;

			// Token: 0x0400965C RID: 38492
			public bool Color;

			// Token: 0x0400965D RID: 38493
			public bool Random;

			// Token: 0x0400965E RID: 38494
			public float PropertyValue;

			// Token: 0x0400965F RID: 38495
			public Color PropertyColor;

			// Token: 0x04009660 RID: 38496
			public RandomBetweenFloats PropertyRandom;

			// Token: 0x04009661 RID: 38497
			protected Material Material;
		}

		// Token: 0x02001A89 RID: 6793
		[Serializable]
		public sealed class AmbianceAffectedLight : MultiObjectAmbiance.LoopedAmbianceAffectedObject<Light, MultiObjectAmbiance.AmbianceAffectedLight>
		{
			// Token: 0x06008F27 RID: 36647 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void PerformTransition()
			{
				throw null;
			}

			// Token: 0x04009662 RID: 38498
			public float Intensity;

			// Token: 0x04009663 RID: 38499
			public bool ChangeColor;

			// Token: 0x04009664 RID: 38500
			public Color Color;
		}

		// Token: 0x02001A8A RID: 6794
		[Serializable]
		public sealed class AmbianceAffectedFlicker : GClass1897
		{
			// Token: 0x06008F28 RID: 36648 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void PerformTransition()
			{
				throw null;
			}

			// Token: 0x06008F29 RID: 36649 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Disable()
			{
				throw null;
			}

			// Token: 0x06008F2A RID: 36650 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Destroy()
			{
				throw null;
			}

			// Token: 0x04009665 RID: 38501
			public LightFlicker AffectedFlicker;

			// Token: 0x04009666 RID: 38502
			public bool IsActive;
		}

		// Token: 0x02001A8B RID: 6795
		[Serializable]
		public sealed class AmbianceAffectedGameObject : GClass1897
		{
			// Token: 0x06008F2B RID: 36651 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void PerformTransition()
			{
				throw null;
			}

			// Token: 0x06008F2C RID: 36652 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Disable()
			{
				throw null;
			}

			// Token: 0x06008F2D RID: 36653 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Destroy()
			{
				throw null;
			}

			// Token: 0x04009667 RID: 38503
			public GameObject AffectedObject;

			// Token: 0x04009668 RID: 38504
			public bool IsActive;
		}

		// Token: 0x02001A8C RID: 6796
		[Serializable]
		public sealed class AmbianceAffectedLamp : GClass1897
		{
			// Token: 0x06008F2E RID: 36654 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void PerformTransition()
			{
				throw null;
			}

			// Token: 0x06008F2F RID: 36655 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Disable()
			{
				throw null;
			}

			// Token: 0x06008F30 RID: 36656 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Destroy()
			{
				throw null;
			}

			// Token: 0x04009669 RID: 38505
			public LampController AffectedObject;

			// Token: 0x0400966A RID: 38506
			public bool Active;

			// Token: 0x0400966B RID: 38507
			public RandomBetweenFloats Flickering;

			// Token: 0x0400966C RID: 38508
			[Range(0f, 100f)]
			public float FlickeringChance;
		}

		// Token: 0x02001A8D RID: 6797
		[Serializable]
		public sealed class AmbianceAffectedComponent : GClass1897
		{
			// Token: 0x06008F31 RID: 36657 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void PerformTransition()
			{
				throw null;
			}

			// Token: 0x06008F32 RID: 36658 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Disable()
			{
				throw null;
			}

			// Token: 0x06008F33 RID: 36659 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Destroy()
			{
				throw null;
			}

			// Token: 0x0400966D RID: 38509
			public MonoBehaviour AffectedComponent;

			// Token: 0x0400966E RID: 38510
			public string MethodName;
		}
	}
}
