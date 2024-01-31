using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.Hideout
{
	// Token: 0x02001C02 RID: 7170
	public class ShrinkingCircleQTE : QTEAction
	{
		// Token: 0x06009673 RID: 38515 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Task<bool> StartAction(QuickTimeEvent quickTimeEvent)
		{
			throw null;
		}

		// Token: 0x06009674 RID: 38516 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task<bool> method_0()
		{
			throw null;
		}

		// Token: 0x06009675 RID: 38517 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_1()
		{
			throw null;
		}

		// Token: 0x06009676 RID: 38518 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(bool success)
		{
			throw null;
		}

		// Token: 0x06009677 RID: 38519 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_3(bool success)
		{
			throw null;
		}

		// Token: 0x04009D4F RID: 40271
		private const float float_0 = 3f;

		// Token: 0x04009D50 RID: 40272
		[SerializeField]
		private float _speed;

		// Token: 0x04009D51 RID: 40273
		[SerializeField]
		private Vector2 _successRange;

		// Token: 0x04009D52 RID: 40274
		[SerializeField]
		private float _minScale;

		// Token: 0x04009D53 RID: 40275
		[SerializeField]
		private KeyCode _targetInput;

		// Token: 0x04009D54 RID: 40276
		[SerializeField]
		[Space(10f)]
		private Image _dynamicCircleImage;

		// Token: 0x04009D55 RID: 40277
		[SerializeField]
		private Transform _dynamicCircleInnerBorder;

		// Token: 0x04009D56 RID: 40278
		[SerializeField]
		private Transform _dynamicCircleOuterBorder;

		// Token: 0x04009D57 RID: 40279
		[Space(10f)]
		[SerializeField]
		private Image _staticCircleImage;

		// Token: 0x04009D58 RID: 40280
		[SerializeField]
		private Transform _staticCircleInnerBorder;

		// Token: 0x04009D59 RID: 40281
		[SerializeField]
		private Transform _staticCircleOuterBorder;

		// Token: 0x04009D5A RID: 40282
		[Space(10f)]
		[SerializeField]
		private Image _staticBackgroundImage;

		// Token: 0x04009D5B RID: 40283
		[SerializeField]
		private Sprite _staticBackgroundSpriteBad;

		// Token: 0x04009D5C RID: 40284
		[SerializeField]
		private Sprite _staticBackgroundSpriteGood;

		// Token: 0x04009D5D RID: 40285
		[Space(10f)]
		[SerializeField]
		private Sprite _spriteBad;

		// Token: 0x04009D5E RID: 40286
		[SerializeField]
		private Sprite _spriteGood;

		// Token: 0x04009D5F RID: 40287
		private double double_0;

		// Token: 0x04009D60 RID: 40288
		private double double_1;

		// Token: 0x04009D61 RID: 40289
		private bool bool_0;

		// Token: 0x04009D62 RID: 40290
		private int int_0;
	}
}
