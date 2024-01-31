using System;
using System.Runtime.CompilerServices;

namespace EFT
{
	// Token: 0x020015FE RID: 5630
	[Serializable]
	public sealed class DamageStats
	{
		// Token: 0x17001338 RID: 4920
		// (get) Token: 0x06007A77 RID: 31351 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007A78 RID: 31352 RVA: 0x00002050 File Offset: 0x00000250
		public EDamageType Type
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17001339 RID: 4921
		// (get) Token: 0x06007A79 RID: 31353 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007A7A RID: 31354 RVA: 0x00002050 File Offset: 0x00000250
		public string SourceId
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x1700133A RID: 4922
		// (get) Token: 0x06007A7B RID: 31355 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007A7C RID: 31356 RVA: 0x00002050 File Offset: 0x00000250
		public EBodyPart? OverDamageFrom
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x1700133B RID: 4923
		// (get) Token: 0x06007A7D RID: 31357 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007A7E RID: 31358 RVA: 0x00002050 File Offset: 0x00000250
		public bool Blunt
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x1700133C RID: 4924
		// (get) Token: 0x06007A7F RID: 31359 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007A80 RID: 31360 RVA: 0x00002050 File Offset: 0x00000250
		public float ImpactsCount
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06007A81 RID: 31361 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsEqual(DamageStats damageStats, bool compareShots = false)
		{
			throw null;
		}

		// Token: 0x06007A82 RID: 31362 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Add(DamageStats damage)
		{
			throw null;
		}

		// Token: 0x06007A83 RID: 31363 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DamageStats Clone()
		{
			throw null;
		}

		// Token: 0x06007A84 RID: 31364 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x04007F88 RID: 32648
		public float Amount;

		// Token: 0x020015FF RID: 5631
		public enum EDamageResult
		{
			// Token: 0x04007F8F RID: 32655
			None,
			// Token: 0x04007F90 RID: 32656
			Regular,
			// Token: 0x04007F91 RID: 32657
			Lethal
		}
	}
}
