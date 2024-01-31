using System;
using System.Runtime.CompilerServices;

namespace EFT.InventoryLogic
{
	// Token: 0x020022A3 RID: 8867
	public class RecodableComponent : GClass2750
	{
		// Token: 0x14000290 RID: 656
		// (add) Token: 0x0600B440 RID: 46144 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600B441 RID: 46145 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<bool> OnRecodableStateChanged
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

		// Token: 0x0600B442 RID: 46146 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void AddRecodableAttribute(Item item)
		{
			throw null;
		}

		// Token: 0x0600B443 RID: 46147 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual string GetAttributeValue()
		{
			throw null;
		}

		// Token: 0x0600B444 RID: 46148 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetEncoded(bool value)
		{
			throw null;
		}

		// Token: 0x0600B445 RID: 46149 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string method_0()
		{
			throw null;
		}

		// Token: 0x0400B85E RID: 47198
		protected const string ENCODED = "RecodableItem/AttributeValues/Encoded";

		// Token: 0x0400B85F RID: 47199
		protected const string DECODED = "RecodableItem/AttributeValues/Decoded";

		// Token: 0x0400B860 RID: 47200
		public bool IsEncoded;

		// Token: 0x0400B861 RID: 47201
		private readonly GInterface306 ginterface306_0;

		// Token: 0x0400B862 RID: 47202
		[CompilerGenerated]
		private Action<bool> action_0;

		// Token: 0x020022A4 RID: 8868
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1959
		{
			// Token: 0x0600B446 RID: 46150 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal EItemAttributeDisplayType method_0()
			{
				throw null;
			}

			// Token: 0x0400B863 RID: 47203
			public static readonly RecodableComponent.Class1959 class1959_0;

			// Token: 0x0400B864 RID: 47204
			public static Func<EItemAttributeDisplayType> func_0;
		}
	}
}
