using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using UnityEngine;

namespace EFT
{
	// Token: 0x0200156D RID: 5485
	public class GrenadeCartridge : Throwable
	{
		// Token: 0x1400013C RID: 316
		// (add) Token: 0x060075A0 RID: 30112 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060075A1 RID: 30113 RVA: 0x00002050 File Offset: 0x00000250
		public event GrenadeCartridge.GDelegate60 BlowUpEvent
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

		// Token: 0x1700126C RID: 4716
		// (get) Token: 0x060075A2 RID: 30114 RVA: 0x00002050 File Offset: 0x00000250
		public override int Id
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700126D RID: 4717
		// (get) Token: 0x060075A3 RID: 30115 RVA: 0x00002050 File Offset: 0x00000250
		public override bool HasNetData
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060075A4 RID: 30116 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x060075A5 RID: 30117 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(Player player, BulletClass grenadeCartridgeAmmo, Item weapon)
		{
			throw null;
		}

		// Token: 0x060075A6 RID: 30118 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Launch()
		{
			throw null;
		}

		// Token: 0x060075A7 RID: 30119 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x060075A8 RID: 30120 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnCollisionEnter(Collision collision)
		{
			throw null;
		}

		// Token: 0x060075A9 RID: 30121 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x04007BB4 RID: 31668
		private Player player_0;

		// Token: 0x04007BB5 RID: 31669
		private BulletClass gclass2732_0;

		// Token: 0x04007BB6 RID: 31670
		private Item item_0;

		// Token: 0x04007BB7 RID: 31671
		[CompilerGenerated]
		private GrenadeCartridge.GDelegate60 gdelegate60_0;

		// Token: 0x04007BB8 RID: 31672
		private bool bool_2;

		// Token: 0x04007BB9 RID: 31673
		private WeaponSounds weaponSounds_0;

		// Token: 0x04007BBA RID: 31674
		private const float float_3 = 76f;

		// Token: 0x0200156E RID: 5486
		// (Invoke) Token: 0x060075AA RID: 30122
		public delegate void GDelegate60(Player player, BulletClass grenade, Item weapon, Vector3 position, GrenadeCartridge grenadeCartridge);
	}
}
