using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.Map
{
	// Token: 0x02002F1F RID: 12063
	public sealed class PocketMap : SimplePocketMap
	{
		// Token: 0x170028D1 RID: 10449
		// (get) Token: 0x0600EE17 RID: 60951 RVA: 0x00002050 File Offset: 0x00000250
		private float MinScale
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170028D2 RID: 10450
		// (get) Token: 0x0600EE18 RID: 60952 RVA: 0x00002050 File Offset: 0x00000250
		private float MaxScale
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600EE19 RID: 60953 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		// Token: 0x0600EE1A RID: 60954 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(MapComponent map)
		{
			throw null;
		}

		// Token: 0x0600EE1B RID: 60955 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600EE1C RID: 60956 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetScale(float scale)
		{
			throw null;
		}

		// Token: 0x0600EE1D RID: 60957 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator AnimateScale(float from, float to, float time)
		{
			throw null;
		}

		// Token: 0x0600EE1E RID: 60958 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AnimateScaleStart(float from, float to, float time)
		{
			throw null;
		}

		// Token: 0x0600EE1F RID: 60959 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AnimateScaleStop()
		{
			throw null;
		}

		// Token: 0x0600EE20 RID: 60960 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateScrollbar()
		{
			throw null;
		}

		// Token: 0x0600EE21 RID: 60961 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetScaleFromBar(float value)
		{
			throw null;
		}

		// Token: 0x0600EE22 RID: 60962 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void IncreaseScale()
		{
			throw null;
		}

		// Token: 0x0600EE23 RID: 60963 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DecreaseScale()
		{
			throw null;
		}

		// Token: 0x0600EE24 RID: 60964 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<PocketMapTile> GetTiles()
		{
			throw null;
		}

		// Token: 0x0600EE25 RID: 60965 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector2 GetSize()
		{
			throw null;
		}

		// Token: 0x0400F357 RID: 62295
		[SerializeField]
		private Scrollbar _scrollbar;

		// Token: 0x0400F358 RID: 62296
		[SerializeField]
		private Button _increaseScaleButton;

		// Token: 0x0400F359 RID: 62297
		[SerializeField]
		private Button _decreaseScaleButton;

		// Token: 0x0400F35A RID: 62298
		[SerializeField]
		[Range(0f, 1f)]
		private float _scaleStep;

		// Token: 0x0400F35B RID: 62299
		[SerializeField]
		private float _inputScaleSensitivity;

		// Token: 0x0400F35C RID: 62300
		[SerializeField]
		private float _animationSpeed;

		// Token: 0x0400F35D RID: 62301
		private IEnumerator _scaleAnimation;
	}
}
