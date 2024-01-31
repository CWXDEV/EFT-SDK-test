using System;
using System.Runtime.CompilerServices;
using Diz.Binding;
using JetBrains.Annotations;

namespace EFT.InventoryLogic
{
	// Token: 0x0200226D RID: 8813
	public class FaceShieldComponent : GClass2750
	{
		// Token: 0x17001E4F RID: 7759
		// (get) Token: 0x0600B3B1 RID: 46001 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B3B2 RID: 46002 RVA: 0x00002050 File Offset: 0x00000250
		public byte Hits
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17001E50 RID: 7760
		// (get) Token: 0x0600B3B3 RID: 46003 RVA: 0x00002050 File Offset: 0x00000250
		public FaceShieldComponent.EMask Mask
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001E51 RID: 7761
		// (get) Token: 0x0600B3B4 RID: 46004 RVA: 0x00002050 File Offset: 0x00000250
		public float BlindnessProtection
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600B3B5 RID: 46005 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StoreValidationTimestamp()
		{
			throw null;
		}

		// Token: 0x0600B3B6 RID: 46006 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TimestampIsValid(int frameCount)
		{
			throw null;
		}

		// Token: 0x0600B3B7 RID: 46007 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_0()
		{
			throw null;
		}

		// Token: 0x0600B3B8 RID: 46008 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string method_1()
		{
			throw null;
		}

		// Token: 0x0400B7F1 RID: 47089
		[CanBeNull]
		public readonly TogglableComponent Togglable;

		// Token: 0x0400B7F2 RID: 47090
		public byte HitSeed;

		// Token: 0x0400B7F3 RID: 47091
		[NonSerialized]
		public readonly BindableEvent HitsChanged;

		// Token: 0x0400B7F4 RID: 47092
		private readonly GInterface284 _template;

		// Token: 0x0400B7F5 RID: 47093
		private byte _hits;

		// Token: 0x0200226E RID: 8814
		public enum EMask
		{
			// Token: 0x0400B7F7 RID: 47095
			NoMask,
			// Token: 0x0400B7F8 RID: 47096
			Narrow,
			// Token: 0x0400B7F9 RID: 47097
			Wide
		}

		// Token: 0x0200226F RID: 8815
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1946
		{
			// Token: 0x0600B3B9 RID: 46009 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal EItemAttributeDisplayType method_0()
			{
				throw null;
			}

			// Token: 0x0400B7FA RID: 47098
			public static readonly FaceShieldComponent.Class1946 class1946_0;

			// Token: 0x0400B7FB RID: 47099
			public static Func<EItemAttributeDisplayType> func_0;
		}
	}
}
