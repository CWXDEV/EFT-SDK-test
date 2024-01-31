using System;
using System.Runtime.CompilerServices;
using Diz.Binding;
using EFT.InventoryLogic;
using Newtonsoft.Json;

namespace EFT.Hideout
{
	// Token: 0x02001BC2 RID: 7106
	public abstract class Requirement
	{
		// Token: 0x170016F3 RID: 5875
		// (get) Token: 0x0600952B RID: 38187
		[JsonProperty("type")]
		public abstract ERequirementType Type { get; }

		// Token: 0x170016F4 RID: 5876
		// (get) Token: 0x0600952C RID: 38188 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600952D RID: 38189 RVA: 0x00002050 File Offset: 0x00000250
		[JsonIgnore]
		public EAreaType SourceAreaType
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

		// Token: 0x170016F5 RID: 5877
		// (get) Token: 0x0600952E RID: 38190 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600952F RID: 38191 RVA: 0x00002050 File Offset: 0x00000250
		[JsonIgnore]
		public int SourceAreaLevel
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

		// Token: 0x170016F6 RID: 5878
		// (get) Token: 0x06009530 RID: 38192 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009531 RID: 38193 RVA: 0x00002050 File Offset: 0x00000250
		[JsonIgnore]
		public virtual bool Fulfilled
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

		// Token: 0x170016F7 RID: 5879
		// (get) Token: 0x06009532 RID: 38194 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009533 RID: 38195 RVA: 0x00002050 File Offset: 0x00000250
		[JsonIgnore]
		public InventoryError Error
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x06009534 RID: 38196 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(EAreaType sourceAreaType, int sourceAreaLevel)
		{
			throw null;
		}

		// Token: 0x06009535 RID: 38197 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void TestRequirement(int userValue, int targetValue)
		{
			throw null;
		}

		// Token: 0x06009536 RID: 38198 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void SetFulfillment(bool value)
		{
			throw null;
		}

		// Token: 0x04009C05 RID: 39941
		public readonly BindableEvent OnFulfillmentChange;

		// Token: 0x04009C06 RID: 39942
		private int _userValue;
	}
}
