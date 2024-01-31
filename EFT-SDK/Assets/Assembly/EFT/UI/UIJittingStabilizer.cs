using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002C63 RID: 11363
	public class UIJittingStabilizer : MonoBehaviour
	{
		// Token: 0x0600E00A RID: 57354 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x0600E00B RID: 57355 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(Vector2 arg0)
		{
			throw null;
		}

		// Token: 0x0600E00C RID: 57356 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600E00D RID: 57357 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_2()
		{
			throw null;
		}

		// Token: 0x0600E00E RID: 57358 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			throw null;
		}

		// Token: 0x0600E00F RID: 57359 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		// Token: 0x0600E010 RID: 57360 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_3()
		{
			throw null;
		}

		// Token: 0x0600E011 RID: 57361 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_4()
		{
			throw null;
		}

		// Token: 0x0400E498 RID: 58520
		public static float MinDeltaDistance;

		// Token: 0x0400E499 RID: 58521
		public ScrollRect ScrollRectCached;

		// Token: 0x0400E49A RID: 58522
		public List<UIJittingStabilizer.JittedUiElement> ControlledElements;

		// Token: 0x0400E49B RID: 58523
		private ScrollRect.MovementType movementType_0;

		// Token: 0x0400E49C RID: 58524
		private bool bool_0;

		// Token: 0x0400E49D RID: 58525
		private float float_0;

		// Token: 0x02002C64 RID: 11364
		[Serializable]
		public class JittedUiElement
		{
			// Token: 0x0600E012 RID: 57362 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void UpdatePosition()
			{
				throw null;
			}

			// Token: 0x0400E49E RID: 58526
			public GameObject GameObjectCached;

			// Token: 0x0400E49F RID: 58527
			public RectTransform RectTransformCached;

			// Token: 0x0400E4A0 RID: 58528
			public Vector2 LastFramePosition;

			// Token: 0x0400E4A1 RID: 58529
			public bool Stabilize;

			// Token: 0x0400E4A2 RID: 58530
			public bool IsJitted;
		}

		// Token: 0x02002C65 RID: 11365
		[CompilerGenerated]
		private sealed class Class2704
		{
			// Token: 0x0600E013 RID: 57363 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(RectTransform t)
			{
				throw null;
			}

			// Token: 0x0400E4A3 RID: 58531
			public Transform thisTransform;

			// Token: 0x0400E4A4 RID: 58532
			public Func<RectTransform, bool> func_0;
		}

		// Token: 0x02002C66 RID: 11366
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2705
		{
			// Token: 0x0600E014 RID: 57364 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(UIJittingStabilizer.JittedUiElement uiElement)
			{
				throw null;
			}

			// Token: 0x0400E4A5 RID: 58533
			public static readonly UIJittingStabilizer.Class2705 class2705_0;

			// Token: 0x0400E4A6 RID: 58534
			public static Func<UIJittingStabilizer.JittedUiElement, bool> func_0;
		}
	}
}
