using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace EFT.Hideout
{
	// Token: 0x02001BC8 RID: 7112
	[Serializable]
	public sealed class SkillRequirement : Requirement
	{
		// Token: 0x17001708 RID: 5896
		// (get) Token: 0x06009554 RID: 38228 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009555 RID: 38229 RVA: 0x00002050 File Offset: 0x00000250
		[JsonIgnore]
		public FakeSkill FakeSkill
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

		// Token: 0x17001709 RID: 5897
		// (get) Token: 0x06009556 RID: 38230 RVA: 0x00002050 File Offset: 0x00000250
		private ESkillId ESkillId_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700170A RID: 5898
		// (get) Token: 0x06009557 RID: 38231 RVA: 0x00002050 File Offset: 0x00000250
		public override ERequirementType Type
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06009558 RID: 38232 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Test(SkillManager value)
		{
			throw null;
		}

		// Token: 0x04009C15 RID: 39957
		[JsonProperty("skillName")]
		public string SkillName;

		// Token: 0x04009C16 RID: 39958
		[JsonProperty("skillLevel")]
		public int SkillLevel;

		// Token: 0x04009C18 RID: 39960
		private SkillManager _skillManager;

		// Token: 0x04009C19 RID: 39961
		private GClass1765 _realSkill;
	}
}
