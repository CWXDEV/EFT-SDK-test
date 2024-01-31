using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x020029B7 RID: 10679
	public class CharacteristicPanel : CompactCharacteristicPanel
	{
		// Token: 0x0600D47F RID: 54399 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(Item item)
		{
			throw null;
		}

		// Token: 0x0600D480 RID: 54400 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetValues()
		{
			throw null;
		}

		// Token: 0x0600D481 RID: 54401 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0400D6C3 RID: 54979
		private const float float_1 = 0.5f;

		// Token: 0x0400D6C4 RID: 54980
		private const float float_2 = 0.2f;

		// Token: 0x0400D6C5 RID: 54981
		private const float float_3 = 0.6f;

		// Token: 0x0400D6C6 RID: 54982
		private const float float_4 = 0.40000004f;

		// Token: 0x0400D6C7 RID: 54983
		[SerializeField]
		protected Image Border;

		// Token: 0x0400D6C8 RID: 54984
		[SerializeField]
		protected Image Current;

		// Token: 0x0400D6C9 RID: 54985
		[SerializeField]
		protected Image Delta;

		// Token: 0x0400D6CA RID: 54986
		[SerializeField]
		protected Image CompareDelta;

		// Token: 0x0400D6CB RID: 54987
		[SerializeField]
		protected Color CurrentColor;

		// Token: 0x0400D6CC RID: 54988
		[SerializeField]
		protected Color LowColor;

		// Token: 0x0400D6CD RID: 54989
		[SerializeField]
		protected Color SubColor;

		// Token: 0x0400D6CE RID: 54990
		[SerializeField]
		protected Color AddColor;

		// Token: 0x0400D6CF RID: 54991
		[SerializeField]
		protected Sprite AddSprite;

		// Token: 0x0400D6D0 RID: 54992
		[SerializeField]
		protected Sprite SubSprite;

		// Token: 0x0400D6D1 RID: 54993
		private Color color_0;

		// Token: 0x0400D6D2 RID: 54994
		private float float_5;

		// Token: 0x0400D6D3 RID: 54995
		private float float_6;
	}
}
