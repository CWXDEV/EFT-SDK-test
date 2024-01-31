using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using EFT.InventoryLogic;

// Token: 0x0200232D RID: 9005
public class ArmorClass : GClass2626
{
	// Token: 0x0600B676 RID: 46710 RVA: 0x00002050 File Offset: 0x00000250
	[OnDeserializing]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_11(StreamingContext context)
	{
		throw null;
	}

	// Token: 0x0400BA08 RID: 47624
	public readonly RepairableComponent Repairable;

	// Token: 0x0400BA09 RID: 47625
	public readonly ArmorComponent Armor;

	// Token: 0x0400BA0A RID: 47626
	public readonly TogglableComponent Togglable;

	// Token: 0x0400BA0B RID: 47627
	public readonly FaceShieldComponent FaceShield;

	// Token: 0x0400BA0C RID: 47628
	public BuffComponent Buff;

	// Token: 0x0200232E RID: 9006
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1998
	{
		// Token: 0x0600B677 RID: 46711 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Slot slot)
		{
			throw null;
		}

		// Token: 0x0400BA0D RID: 47629
		public static readonly ArmorClass.Class1998 class1998_0;

		// Token: 0x0400BA0E RID: 47630
		public static Func<Slot, bool> func_0;
	}
}
