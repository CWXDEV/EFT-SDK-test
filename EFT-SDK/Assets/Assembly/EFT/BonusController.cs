using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace EFT
{
	// Token: 0x02001289 RID: 4745
	public sealed class BonusController
	{
		// Token: 0x14000114 RID: 276
		// (add) Token: 0x060062F8 RID: 25336 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060062F9 RID: 25337 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<bool, EBonusType> OnBonusChanged
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

		// Token: 0x17000FC4 RID: 4036
		// (get) Token: 0x060062FA RID: 25338 RVA: 0x00002050 File Offset: 0x00000250
		private float Single_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000FC5 RID: 4037
		// (get) Token: 0x060062FB RID: 25339 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060062FC RID: 25340 RVA: 0x00002050 File Offset: 0x00000250
		[JsonIgnore]
		public string StashTemplateId
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

		// Token: 0x17000FC6 RID: 4038
		// (get) Token: 0x060062FD RID: 25341 RVA: 0x00002050 File Offset: 0x00000250
		[JsonIgnore]
		public IEnumerable<EBonusType> ActiveBonuses
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060062FE RID: 25342 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitSkillManager(SkillManager skillManager)
		{
			throw null;
		}

		// Token: 0x060062FF RID: 25343 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(GClass1763 baseSkill)
		{
			throw null;
		}

		// Token: 0x06006300 RID: 25344 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x06006301 RID: 25345 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(GClass1404 bonus)
		{
			throw null;
		}

		// Token: 0x06006302 RID: 25346 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddBonus(GClass1404 bonus, bool silent = false)
		{
			throw null;
		}

		// Token: 0x06006303 RID: 25347 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveBonus(GClass1404 bonus, bool silent = false)
		{
			throw null;
		}

		// Token: 0x06006304 RID: 25348 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool HasBonus(EBonusType type)
		{
			throw null;
		}

		// Token: 0x06006305 RID: 25349 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public double Calculate(GClass1765 skill, double input)
		{
			throw null;
		}

		// Token: 0x06006306 RID: 25350 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public double Calculate(EBonusType type, double input)
		{
			throw null;
		}

		// Token: 0x06006307 RID: 25351 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private double method_3(Enum type, double input)
		{
			throw null;
		}

		// Token: 0x06006308 RID: 25352 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x06006309 RID: 25353 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerable<GClass1404> GetAttachedBonuses(EAreaType areaType)
		{
			throw null;
		}

		// Token: 0x04006FE3 RID: 28643
		private readonly Dictionary<Enum, BonusController.Class912> _activeBonuses;

		// Token: 0x04006FE4 RID: 28644
		private SkillManager _skillManager;

		// Token: 0x0200128A RID: 4746
		private sealed class Class912
		{
			// Token: 0x17000FC7 RID: 4039
			// (get) Token: 0x0600630A RID: 25354 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600630B RID: 25355 RVA: 0x00002050 File Offset: 0x00000250
			public GClass1404 Result
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

			// Token: 0x0600630C RID: 25356 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public double CalculateValue(double input)
			{
				throw null;
			}

			// Token: 0x0600630D RID: 25357 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Add(GClass1404 bonus)
			{
				throw null;
			}

			// Token: 0x0600630E RID: 25358 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Remove(GClass1404 bonus)
			{
				throw null;
			}

			// Token: 0x0600630F RID: 25359 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private bool method_0(MongoID id, out GClass1404 bonus)
			{
				throw null;
			}

			// Token: 0x06006310 RID: 25360 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool HasBonus()
			{
				throw null;
			}

			// Token: 0x06006311 RID: 25361 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetBoost(double boostValue)
			{
				throw null;
			}

			// Token: 0x06006312 RID: 25362 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_1()
			{
				throw null;
			}

			// Token: 0x06006313 RID: 25363 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_2()
			{
				throw null;
			}

			// Token: 0x04006FE6 RID: 28646
			private readonly List<GClass1404> list_0;

			// Token: 0x04006FE7 RID: 28647
			[CompilerGenerated]
			private GClass1404 gclass1404_0;
		}
	}
}
