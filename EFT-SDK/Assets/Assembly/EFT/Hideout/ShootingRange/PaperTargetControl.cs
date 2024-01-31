using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Hideout.ShootingRange
{
	// Token: 0x02001C10 RID: 7184
	public class PaperTargetControl : InteractiveShootingRange
	{
		// Token: 0x060096BB RID: 38587 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override GClass3008 InteractionStates(HideoutPlayerOwner owner)
		{
			throw null;
		}

		// Token: 0x060096BC RID: 38588 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x060096BD RID: 38589 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x04009DBB RID: 40379
		[Space]
		[SerializeField]
		private PaperTarget[] _paperTargets;

		// Token: 0x04009DBC RID: 40380
		[Space]
		[SerializeField]
		private AudioSource _replaceTargetsAudio;

		// Token: 0x02001C11 RID: 7185
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1693
		{
			// Token: 0x060096BE RID: 38590 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(PaperTarget v)
			{
				throw null;
			}

			// Token: 0x04009DBD RID: 40381
			public static readonly PaperTargetControl.Class1693 class1693_0;

			// Token: 0x04009DBE RID: 40382
			public static Func<PaperTarget, bool> func_0;
		}
	}
}
