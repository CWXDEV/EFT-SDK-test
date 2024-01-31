using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using UnityEngine;

namespace EFT.HandBook
{
	// Token: 0x02002613 RID: 9747
	[Serializable]
	public class HandbookData : BaseHandbookData
	{
		// Token: 0x17002290 RID: 8848
		// (get) Token: 0x0600C18B RID: 49547 RVA: 0x00002050 File Offset: 0x00000250
		public Color BackgroundColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600C18C RID: 49548 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HandbookData CloneAsCategory()
		{
			throw null;
		}

		// Token: 0x0600C18D RID: 49549 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HandbookData Clone()
		{
			throw null;
		}

		// Token: 0x0600C18E RID: 49550 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private HandbookData method_0(ENodeType type)
		{
			throw null;
		}

		// Token: 0x0600C18F RID: 49551 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0400C3AC RID: 50092
		public string Icon;

		// Token: 0x0400C3AD RID: 50093
		public string Color;

		// Token: 0x0400C3AE RID: 50094
		public int Order;

		// Token: 0x0400C3AF RID: 50095
		public string Name;

		// Token: 0x0400C3B0 RID: 50096
		public Item Item;

		// Token: 0x0400C3B1 RID: 50097
		public ENodeType Type;

		// Token: 0x0400C3B2 RID: 50098
		public bool FromBuild;

		// Token: 0x0400C3B3 RID: 50099
		private Color _backgroundColor;
	}
}
