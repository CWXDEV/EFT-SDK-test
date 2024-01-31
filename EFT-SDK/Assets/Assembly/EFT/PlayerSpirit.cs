using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using UnityEngine;

namespace EFT
{
	// Token: 0x020015D0 RID: 5584
	[DisallowMultipleComponent]
	public class PlayerSpirit : PlayerSpiritBase
	{
		// Token: 0x060079B2 RID: 31154 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Init(Player player, Vector3 position, bool isBodyAnimatorUpdating, CharacterControllerSpawner.Mode characterControllerMode, CharacterControllerSpawner.Mode disconnectedCharacterControllerMode)
		{
			throw null;
		}

		// Token: 0x060079B3 RID: 31155 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void PlayerSync()
		{
			throw null;
		}

		// Token: 0x060079B4 RID: 31156 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void InitDebugImage()
		{
			throw null;
		}

		// Token: 0x060079B5 RID: 31157 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ConnectToPlayerEvents()
		{
			throw null;
		}

		// Token: 0x060079B6 RID: 31158 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RecheckSwitch()
		{
			throw null;
		}

		// Token: 0x060079B7 RID: 31159 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Switch(bool toSpirit)
		{
			throw null;
		}

		// Token: 0x060079B8 RID: 31160 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void TranslateStateToPlayer()
		{
			throw null;
		}

		// Token: 0x060079B9 RID: 31161 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void TranslateStateToSpirit()
		{
			throw null;
		}

		// Token: 0x060079BA RID: 31162 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void TranslateAnimatorState(IAnimator animatorRecipient, IAnimator animatorDonor, Player.EUpdateMode updateMode)
		{
			throw null;
		}

		// Token: 0x060079BB RID: 31163 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected bool CanSwitchToSpirit()
		{
			throw null;
		}

		// Token: 0x060079BC RID: 31164 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HideUnusedPart()
		{
			throw null;
		}

		// Token: 0x060079BD RID: 31165 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HideUnusedPartOnNextFrame()
		{
			throw null;
		}

		// Token: 0x060079BE RID: 31166 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected IEnumerator HideUnusedPartOnNextFrameWorker()
		{
			throw null;
		}

		// Token: 0x060079BF RID: 31167 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected bool HasActiveLightMode()
		{
			throw null;
		}

		// Token: 0x060079C0 RID: 31168 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected bool HasActiveLightMode(Weapon weapon)
		{
			throw null;
		}

		// Token: 0x060079C1 RID: 31169 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void InventoryControllerOnAddItemEvent(GEventArgs2 addItemEventArgs)
		{
			throw null;
		}

		// Token: 0x060079C2 RID: 31170 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnRenderObject()
		{
			throw null;
		}

		// Token: 0x060079C3 RID: 31171 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_54(Slot slot)
		{
			throw null;
		}

		// Token: 0x04007E7D RID: 32381
		protected SpriteRenderer _spiritDebugImage;

		// Token: 0x04007E7E RID: 32382
		protected readonly Vector3 _unseenPlace;

		// Token: 0x04007E7F RID: 32383
		protected readonly List<string> _slotIdsWithVisibleWeapons;

		// Token: 0x04007E80 RID: 32384
		private int int_0;

		// Token: 0x04007E81 RID: 32385
		private const int int_1 = 10;

		// Token: 0x020015D2 RID: 5586
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1149
		{
			// Token: 0x060079C8 RID: 31176 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Item method_0(Slot slot)
			{
				throw null;
			}

			// Token: 0x04007E85 RID: 32389
			public static readonly PlayerSpirit.Class1149 class1149_0;

			// Token: 0x04007E86 RID: 32390
			public static Func<Slot, Item> func_0;
		}
	}
}
