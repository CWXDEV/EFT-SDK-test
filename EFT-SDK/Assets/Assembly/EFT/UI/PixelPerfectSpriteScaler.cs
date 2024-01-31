using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002C42 RID: 11330
	[DisallowMultipleComponent]
	[RequireComponent(typeof(RectTransform))]
	public sealed class PixelPerfectSpriteScaler : UIBehaviour
	{
		// Token: 0x0600DF4D RID: 57165 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		// Token: 0x0600DF4E RID: 57166 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnEnable()
		{
			throw null;
		}

		// Token: 0x0600DF4F RID: 57167 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnDisable()
		{
			throw null;
		}

		// Token: 0x0600DF50 RID: 57168 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600DF51 RID: 57169 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0400E40C RID: 58380
		[SerializeField]
		private PixelPerfectSpriteScaler.EScaleSide _sidesToScale;

		// Token: 0x0400E40D RID: 58381
		private Image image_0;

		// Token: 0x0400E40E RID: 58382
		private RectTransform rectTransform_0;

		// Token: 0x0400E40F RID: 58383
		private Vector2 vector2_0;

		// Token: 0x0400E410 RID: 58384
		private Vector2 vector2_1;

		// Token: 0x02002C43 RID: 11331
		[Flags]
		private enum EScaleSide
		{
			// Token: 0x0400E412 RID: 58386
			Top = 1,
			// Token: 0x0400E413 RID: 58387
			Left = 2,
			// Token: 0x0400E414 RID: 58388
			Bottom = 4,
			// Token: 0x0400E415 RID: 58389
			Right = 8,
			// Token: 0x0400E416 RID: 58390
			All = 15
		}
	}
}
