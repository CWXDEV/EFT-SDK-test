using System;
using System.Runtime.CompilerServices;

namespace EFT.UI
{
	// Token: 0x02002AFD RID: 11005
	public abstract class BaseSortPanel<TSortProperty> : UIElement where TSortProperty : struct, Enum
	{
		// Token: 0x14000300 RID: 768
		// (add) Token: 0x0600DA74 RID: 55924 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600DA75 RID: 55925 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<TSortProperty, bool> OnSort
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x0600DA76 RID: 55926 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void Show(SerializableEnumDictionary<TSortProperty, FilterButton> buttons, TSortProperty defaultSortingType, bool defaultAscending)
		{
			throw null;
		}

		// Token: 0x0600DA77 RID: 55927 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(TSortProperty sortType, FilterButton button)
		{
			throw null;
		}

		// Token: 0x0600DA78 RID: 55928 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(TSortProperty sortType, FilterButton button)
		{
			throw null;
		}

		// Token: 0x0400DD70 RID: 56688
		private SerializableEnumDictionary<TSortProperty, FilterButton> serializableEnumDictionary_0;

		// Token: 0x0400DD71 RID: 56689
		private FilterButton filterButton_0;

		// Token: 0x0400DD72 RID: 56690
		[CompilerGenerated]
		private Action<TSortProperty, bool> action_0;

		// Token: 0x0400DD73 RID: 56691
		private bool bool_0;
	}
}
