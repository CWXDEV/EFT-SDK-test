using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.InputSystem;
using EFT.UI.Screens;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001BD8 RID: 7128
	[RequireComponent(typeof(QTEController))]
	public sealed class HideoutAreaQTEOverlay : UIScreen, GInterface173
	{
		// Token: 0x060095AE RID: 38318 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(HideoutPlayerOwner player, AreaData areaData, HideoutScreenRear hideoutRear)
		{
			throw null;
		}

		// Token: 0x060095AF RID: 38319 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x060095B0 RID: 38320 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task SpecialAreaActionSelected(AreaData data, bool wait)
		{
			throw null;
		}

		// Token: 0x060095B1 RID: 38321 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(AreaData area)
		{
			throw null;
		}

		// Token: 0x060095B2 RID: 38322 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override ECursorResult ShouldLockCursor()
		{
			throw null;
		}

		// Token: 0x060095B3 RID: 38323 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x04009C65 RID: 40037
		private const int int_0 = 100;

		// Token: 0x04009C66 RID: 40038
		public static QTEController QteController;

		// Token: 0x04009C67 RID: 40039
		private HideoutCameraController hideoutCameraController_0;

		// Token: 0x04009C68 RID: 40040
		private AreaData areaData_0;

		// Token: 0x04009C69 RID: 40041
		private HideoutScreenRear hideoutScreenRear_0;

		// Token: 0x04009C6A RID: 40042
		private HideoutPlayerOwner hideoutPlayerOwner_0;
	}
}
