using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x020028E1 RID: 10465
	[RequireComponent(typeof(BattleUIComponentAnimation))]
	public sealed class AmmoCountPanel : UIElement
	{
		// Token: 0x0600D0F3 RID: 53491 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowFireMode(Weapon.EFireMode fireMode)
		{
			throw null;
		}

		// Token: 0x0600D0F4 RID: 53492 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(string message, string details = null)
		{
			throw null;
		}

		// Token: 0x0600D0F5 RID: 53493 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetAmmoCountByLevel(int ammoCount, int maxAmmoCount, int level)
		{
			throw null;
		}

		// Token: 0x0600D0F6 RID: 53494 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetAmmoCountByLevelForFoldingMechanismWeapon(int ammoCount, int maxAmmoCount)
		{
			throw null;
		}

		// Token: 0x0600D0F7 RID: 53495 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Hide()
		{
			throw null;
		}

		// Token: 0x0600D0F8 RID: 53496 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400D1DB RID: 53723
		[SerializeField]
		private CustomTextMeshProUGUI _ammoCount;

		// Token: 0x0400D1DC RID: 53724
		[SerializeField]
		private CustomTextMeshProUGUI _ammoDetails;

		// Token: 0x0400D1DD RID: 53725
		private BattleUIComponentAnimation battleUIComponentAnimation_0;

		// Token: 0x0400D1DE RID: 53726
		private static readonly string[] string_0;
	}
}
