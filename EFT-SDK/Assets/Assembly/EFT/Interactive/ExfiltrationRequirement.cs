using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using JetBrains.Annotations;

namespace EFT.Interactive
{
	// Token: 0x02002744 RID: 10052
	[Serializable]
	public class ExfiltrationRequirement : IExfiltrationRequirement
	{
		// Token: 0x0600C922 RID: 51490 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IExfiltrationRequirement CreateRequirement(ERequirementState requirementState)
		{
			throw null;
		}

		// Token: 0x0600C923 RID: 51491 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual string GetLocalizedTip(string profileId)
		{
			throw null;
		}

		// Token: 0x0600C924 RID: 51492 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool Met(Player player, ExfiltrationPoint point)
		{
			throw null;
		}

		// Token: 0x0600C925 RID: 51493 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Enter(Player player, ExfiltrationPoint point)
		{
			throw null;
		}

		// Token: 0x0600C926 RID: 51494 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Exit(Player player, ExfiltrationPoint point)
		{
			throw null;
		}

		// Token: 0x0600C927 RID: 51495 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Start(ExfiltrationPoint point)
		{
			throw null;
		}

		// Token: 0x0600C928 RID: 51496 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0400C935 RID: 51509
		public ERequirementState Requirement;

		// Token: 0x0400C936 RID: 51510
		public string Id;

		// Token: 0x0400C937 RID: 51511
		public int Count;

		// Token: 0x0400C938 RID: 51512
		public EquipmentSlot RequiredSlot;

		// Token: 0x0400C939 RID: 51513
		public string RequirementTip;
	}
}
