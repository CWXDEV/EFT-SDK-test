using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Comfort.Common;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT
{
	// Token: 0x02001948 RID: 6472
	internal sealed class ClientFirearmController : Player.FirearmController
	{
		// Token: 0x06008AF7 RID: 35575 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ClientFirearmController smethod_8(ClientPlayer player, Weapon weapon)
		{
			throw null;
		}

		// Token: 0x06008AF8 RID: 35576 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Task<ClientFirearmController> smethod_9(ClientPlayer player, string itemId, bool isStationaryWeapon)
		{
			throw null;
		}

		// Token: 0x06008AF9 RID: 35577 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void InitBallisticCalculator()
		{
			throw null;
		}

		// Token: 0x06008AFA RID: 35578 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void RemoveBallisticCalculator()
		{
			throw null;
		}

		// Token: 0x06008AFB RID: 35579 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ChangeFireMode(Weapon.EFireMode fireMode)
		{
			throw null;
		}

		// Token: 0x06008AFC RID: 35580 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ChangeAimingMode()
		{
			throw null;
		}

		// Token: 0x06008AFD RID: 35581 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void CompassStateHandler(bool isActive)
		{
			throw null;
		}

		// Token: 0x06008AFE RID: 35582 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetInventoryOpened(bool opened)
		{
			throw null;
		}

		// Token: 0x06008AFF RID: 35583 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetAim(bool value)
		{
			throw null;
		}

		// Token: 0x06008B00 RID: 35584 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void AimingChanged(bool newValue)
		{
			throw null;
		}

		// Token: 0x06008B01 RID: 35585 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ReloadMag(MagazineClass magazine, [CanBeNull] GClass2765 gridItemAddress, [CanBeNull] Callback callback)
		{
			throw null;
		}

		// Token: 0x06008B02 RID: 35586 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void QuickReloadMag(MagazineClass magazine, Callback callback)
		{
			throw null;
		}

		// Token: 0x06008B03 RID: 35587 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ReloadCylinderMagazine(GClass2491 ammoPack, Callback callback, bool quickReload = false)
		{
			throw null;
		}

		// Token: 0x06008B04 RID: 35588 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ReloadBarrels(GClass2491 ammoPack, GClass2765 placeToPutContainedAmmoMagazine, Callback callback)
		{
			throw null;
		}

		// Token: 0x06008B05 RID: 35589 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ReloadWithAmmo(GClass2491 ammoPack, [CanBeNull] Callback callback)
		{
			throw null;
		}

		// Token: 0x06008B06 RID: 35590 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ReloadGrenadeLauncher(GClass2491 ammoPack, [CanBeNull] Callback callback)
		{
			throw null;
		}

		// Token: 0x06008B07 RID: 35591 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ExamineWeapon()
		{
			throw null;
		}

		// Token: 0x06008B08 RID: 35592 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void RollCylinder(bool rollToZeroCamora)
		{
			throw null;
		}

		// Token: 0x06008B09 RID: 35593 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ShowGesture(EGesture gesture)
		{
			throw null;
		}

		// Token: 0x06008B0A RID: 35594 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool CheckAmmo()
		{
			throw null;
		}

		// Token: 0x06008B0B RID: 35595 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool CheckChamber()
		{
			throw null;
		}

		// Token: 0x06008B0C RID: 35596 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool CheckFireMode()
		{
			throw null;
		}

		// Token: 0x06008B0D RID: 35597 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetLightsState(GStruct162[] lightsStates, bool force = false)
		{
			throw null;
		}

		// Token: 0x06008B0E RID: 35598 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetScopeMode(GStruct163[] scopeStates)
		{
			throw null;
		}

		// Token: 0x06008B0F RID: 35599 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void UnderbarrelSightingRangeUp()
		{
			throw null;
		}

		// Token: 0x06008B10 RID: 35600 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void UnderbarrelSightingRangeDown()
		{
			throw null;
		}

		// Token: 0x06008B11 RID: 35601 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OpticCalibrationSwitchUp(GStruct163[] scopeStates)
		{
			throw null;
		}

		// Token: 0x06008B12 RID: 35602 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OpticCalibrationSwitchDown(GStruct163[] scopeStates)
		{
			throw null;
		}

		// Token: 0x06008B13 RID: 35603 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_93(GStruct163[] scopeStates)
		{
			throw null;
		}

		// Token: 0x06008B14 RID: 35604 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ToggleLauncher()
		{
			throw null;
		}

		// Token: 0x06008B15 RID: 35605 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ChangeLeftStance()
		{
			throw null;
		}

		// Token: 0x06008B16 RID: 35606 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void InitiateShot(GInterface320 weapon, BulletClass ammo, Vector3 shotPosition, Vector3 shotDirection, Vector3 fireportPosition, int chamberIndex, float overheat)
		{
			throw null;
		}

		// Token: 0x06008B17 RID: 35607 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_94(Weapon weapon)
		{
			throw null;
		}

		// Token: 0x06008B18 RID: 35608 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SendStartOneShotFire()
		{
			throw null;
		}

		// Token: 0x06008B19 RID: 35609 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void CreateFlareShot(BulletClass ammo, Vector3 shotPosition, Vector3 shotForward)
		{
			throw null;
		}

		// Token: 0x06008B1A RID: 35610 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void ShotMisfired(BulletClass ammo, Weapon.EMalfunctionState malfunctionState, float overheat)
		{
			throw null;
		}

		// Token: 0x06008B1B RID: 35611 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected internal override void DryShot(int chamberIndex = 0, bool underbarrelShot = false)
		{
			throw null;
		}

		// Token: 0x06008B1C RID: 35612 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void BallisticUpdate(float deltaTime)
		{
			throw null;
		}

		// Token: 0x06008B1D RID: 35613 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void RegisterShot(Item weapon, GClass2988 shot)
		{
			throw null;
		}

		// Token: 0x06008B1E RID: 35614 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_95()
		{
			throw null;
		}

		// Token: 0x06008B1F RID: 35615 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_96(int ammoToLoadIntoMag)
		{
			throw null;
		}

		// Token: 0x06008B20 RID: 35616 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_97(int ammoToLoadIntoMag)
		{
			throw null;
		}

		// Token: 0x06008B21 RID: 35617 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool CanStartReload()
		{
			throw null;
		}

		// Token: 0x06008B22 RID: 35618 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool CanPressTrigger()
		{
			throw null;
		}

		// Token: 0x06008B23 RID: 35619 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void LightAndSoundShot(Vector3 point, Vector3 direction, AmmoTemplate ammoTemplate)
		{
			throw null;
		}

		// Token: 0x06008B24 RID: 35620 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Player.GClass1580 method_98()
		{
			throw null;
		}

		// Token: 0x06008B25 RID: 35621 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Player.GClass1580 method_99()
		{
			throw null;
		}

		// Token: 0x06008B26 RID: 35622 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Player.GClass1580 method_100()
		{
			throw null;
		}

		// Token: 0x0400909C RID: 37020
		private const int int_2 = 12;

		// Token: 0x0400909D RID: 37021
		public GStruct186 FirearmPacket;

		// Token: 0x0400909E RID: 37022
		private readonly List<GClass2988> list_3;

		// Token: 0x0400909F RID: 37023
		private readonly List<GClass2988> list_4;

		// Token: 0x040090A0 RID: 37024
		private readonly GClass2988[] gclass2988_0;

		// Token: 0x040090A1 RID: 37025
		private byte byte_0;

		// Token: 0x040090A2 RID: 37026
		private EShotType eshotType_0;

		// Token: 0x02001949 RID: 6473
		public class Class1018 : Player.FirearmController.GClass1599
		{
			// Token: 0x06008B27 RID: 35623 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Start()
			{
				throw null;
			}

			// Token: 0x06008B28 RID: 35624 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void SetTriggerPressed(bool pressed)
			{
				throw null;
			}

			// Token: 0x06008B29 RID: 35625 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void SetInventoryOpened(bool opened)
			{
				throw null;
			}

			// Token: 0x06008B2A RID: 35626 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void ReloadMag(MagazineClass magazine, GClass2765 gridItemAddress, Callback finishCallback, Callback startCallback)
			{
				throw null;
			}

			// Token: 0x06008B2B RID: 35627 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void QuickReloadMag(MagazineClass magazine, Callback finishCallback, Callback startCallback)
			{
				throw null;
			}

			// Token: 0x06008B2C RID: 35628 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void ReloadWithAmmo(GClass2491 ammoPack, Callback finishCallback, Callback startCallback)
			{
				throw null;
			}

			// Token: 0x06008B2D RID: 35629 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_14(bool value)
			{
				throw null;
			}

			// Token: 0x06008B2E RID: 35630 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Reset()
			{
				throw null;
			}

			// Token: 0x040090A3 RID: 37027
			private readonly ClientFirearmController clientFirearmController_0;

			// Token: 0x040090A4 RID: 37028
			private bool bool_5;
		}

		// Token: 0x0200194A RID: 6474
		public class Class1015 : Player.FirearmController.GClass1586
		{
			// Token: 0x06008B2F RID: 35631 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void SetTriggerPressed(bool pressed)
			{
				throw null;
			}

			// Token: 0x06008B30 RID: 35632 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void SwitchToIdle()
			{
				throw null;
			}

			// Token: 0x040090A5 RID: 37029
			private readonly ClientFirearmController clientFirearmController_0;
		}

		// Token: 0x0200194B RID: 6475
		public class Class1016 : Player.FirearmController.GClass1587
		{
			// Token: 0x06008B31 RID: 35633 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void SetTriggerPressed(bool pressed)
			{
				throw null;
			}

			// Token: 0x06008B32 RID: 35634 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void SwitchToIdle()
			{
				throw null;
			}

			// Token: 0x040090A6 RID: 37030
			private readonly ClientFirearmController clientFirearmController_0;
		}

		// Token: 0x0200194C RID: 6476
		public class Class1017 : Player.FirearmController.GClass1588
		{
			// Token: 0x06008B33 RID: 35635 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void SetTriggerPressed(bool pressed)
			{
				throw null;
			}

			// Token: 0x06008B34 RID: 35636 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void SwitchToIdle()
			{
				throw null;
			}

			// Token: 0x040090A7 RID: 37031
			private readonly ClientFirearmController clientFirearmController_0;
		}

		// Token: 0x0200194D RID: 6477
		[CompilerGenerated]
		private sealed class Class1507
		{
			// Token: 0x06008B35 RID: 35637 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(IResult error)
			{
				throw null;
			}

			// Token: 0x040090A8 RID: 37032
			public GClass2765 gridItemAddress;

			// Token: 0x040090A9 RID: 37033
			public ClientFirearmController clientFirearmController_0;

			// Token: 0x040090AA RID: 37034
			public MagazineClass magazine;
		}

		// Token: 0x0200194E RID: 6478
		[CompilerGenerated]
		private sealed class Class1508
		{
			// Token: 0x06008B36 RID: 35638 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(IResult error)
			{
				throw null;
			}

			// Token: 0x040090AB RID: 37035
			public ClientFirearmController clientFirearmController_0;

			// Token: 0x040090AC RID: 37036
			public bool quickReload;

			// Token: 0x040090AD RID: 37037
			public string[] ammoIds;

			// Token: 0x040090AE RID: 37038
			public List<int> shellsIndexes;

			// Token: 0x040090AF RID: 37039
			public CylinderMagazineClass cylinderMagazine;
		}

		// Token: 0x0200194F RID: 6479
		[CompilerGenerated]
		private sealed class Class1509
		{
			// Token: 0x06008B37 RID: 35639 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(IResult error)
			{
				throw null;
			}

			// Token: 0x040090B0 RID: 37040
			public GClass2765 placeToPutContainedAmmoMagazine;

			// Token: 0x040090B1 RID: 37041
			public ClientFirearmController clientFirearmController_0;

			// Token: 0x040090B2 RID: 37042
			public GClass2491 ammoPack;
		}

		// Token: 0x02001950 RID: 6480
		[CompilerGenerated]
		private sealed class Class1510
		{
			// Token: 0x06008B38 RID: 35640 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(IResult error)
			{
				throw null;
			}

			// Token: 0x040090B3 RID: 37043
			public ClientFirearmController clientFirearmController_0;

			// Token: 0x040090B4 RID: 37044
			public string[] ammoIds;
		}

		// Token: 0x02001951 RID: 6481
		[CompilerGenerated]
		private sealed class Class1511
		{
			// Token: 0x06008B39 RID: 35641 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(IResult finishCallback)
			{
				throw null;
			}

			// Token: 0x040090B5 RID: 37045
			public ClientFirearmController clientFirearmController_0;

			// Token: 0x040090B6 RID: 37046
			public CylinderMagazineClass cylinderMagazine;
		}
	}
}
