using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EFT.InventoryLogic;
using UnityEngine;

namespace EFT.Ballistics
{
	// Token: 0x0200280E RID: 10254
	public class BallisticsCalculator : MonoBehaviour, GInterface355
	{
		// Token: 0x0600CD2A RID: 52522 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static BallisticsCalculator Create(GameObject gameObject, int seed, GDelegate54 shotCallback, bool showDebug = true)
		{
			throw null;
		}

		// Token: 0x1700249F RID: 9375
		// (get) Token: 0x0600CD2B RID: 52523 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CD2C RID: 52524 RVA: 0x00002050 File Offset: 0x00000250
		public GClass2979 Randoms
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

		// Token: 0x170024A0 RID: 9376
		// (get) Token: 0x0600CD2D RID: 52525 RVA: 0x00002050 File Offset: 0x00000250
		public static BallisticCollider DefaultHitBody
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600CD2E RID: 52526 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		GClass2988 GInterface355.Shoot(BulletClass ammo, Vector3 shotPosition, Vector3 shotDirection, string playerProfileID, Item item, float speedFactor, int fragmentIndex)
		{
			throw null;
		}

		// Token: 0x0600CD2F RID: 52527 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		GClass2988 GInterface355.Shoot(BulletClass ammo, Vector3 shotPosition, Vector3 shotDirection, int fireIndex, string playerProfileID, Item item, float speedFactor, int fragmentIndex)
		{
			throw null;
		}

		// Token: 0x0600CD30 RID: 52528 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface355.ShotMultiProjectileShot(BulletClass ammo, Vector3 shotPosition, Vector3 shotDirection, float speedFactor, List<GClass2988> preAllocatedShots, string playerProfileID, Item item)
		{
			throw null;
		}

		// Token: 0x170024A1 RID: 9377
		// (get) Token: 0x0600CD31 RID: 52529 RVA: 0x00002050 File Offset: 0x00000250
		int GInterface355.ActiveShotsCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600CD32 RID: 52530 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		GClass2988 GInterface355.GetActiveShot(int shotsIndex)
		{
			throw null;
		}

		// Token: 0x170024A2 RID: 9378
		// (get) Token: 0x0600CD33 RID: 52531 RVA: 0x00002050 File Offset: 0x00000250
		BallisticCollider GInterface355.DefaultHitBody
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600CD34 RID: 52532 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass2988 CreateShot(BulletClass ammo, Vector3 origin, Vector3 direction, int fireIndex, string player, Item weapon, float speedFactor = 1f, int fragmentIndex = 0)
		{
			throw null;
		}

		// Token: 0x0600CD35 RID: 52533 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CreateMultiProjectileShot(BulletClass ammo, Vector3 origin, Vector3 direction, float speedFactor, List<GClass2988> preallocatedShots, string playerProfileID, Item weapon)
		{
			throw null;
		}

		// Token: 0x0600CD36 RID: 52534 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ManualUpdate(float deltaTime)
		{
			throw null;
		}

		// Token: 0x0600CD37 RID: 52535 RVA: 0x00002050 File Offset: 0x00000250
		[Conditional("CLIENT")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600CD38 RID: 52536 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_1(GClass2988 shot)
		{
			throw null;
		}

		// Token: 0x0600CD39 RID: 52537 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(float simulationTime)
		{
			throw null;
		}

		// Token: 0x0600CD3A RID: 52538 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Shoot(GClass2988 shot)
		{
			throw null;
		}

		// Token: 0x0600CD3B RID: 52539 RVA: 0x00002050 File Offset: 0x00000250
		[Conditional("CLIENT")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(GClass2988 shot)
		{
			throw null;
		}

		// Token: 0x0600CD3C RID: 52540 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SimulateShot(GClass2988 shot, float simulationTime, float simulationStep)
		{
			throw null;
		}

		// Token: 0x0600CD3D RID: 52541 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PreWarmerSimulateShotNoPool(GClass2988 shot, float simulationTime, float simulationStep)
		{
			throw null;
		}

		// Token: 0x0600CD3E RID: 52542 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(GClass2988 shot, float simulationTime, float simulationStep)
		{
			throw null;
		}

		// Token: 0x0600CD3F RID: 52543 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static float GetAmmoPenetrationPower(BulletClass ammo, int randomInt, GInterface354 randoms)
		{
			throw null;
		}

		// Token: 0x0600CD40 RID: 52544 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearShots()
		{
			throw null;
		}

		// Token: 0x0400CD5B RID: 52571
		public const int RND_COUNT = 512;

		// Token: 0x0400CD5C RID: 52572
		private int int_0;

		// Token: 0x0400CD5D RID: 52573
		public List<GClass2988> Shots;

		// Token: 0x0400CD5E RID: 52574
		private List<GClass2988> list_0;

		// Token: 0x0400CD5F RID: 52575
		private readonly Queue<BallisticsCalculator.Struct777> queue_0;

		// Token: 0x0400CD60 RID: 52576
		private GDelegate54 gdelegate54_0;

		// Token: 0x0400CD61 RID: 52577
		private readonly List<GStruct388> list_1;

		// Token: 0x0400CD62 RID: 52578
		[CompilerGenerated]
		private GClass2979 gclass2979_0;

		// Token: 0x0400CD63 RID: 52579
		private bool bool_0;

		// Token: 0x0400CD64 RID: 52580
		private Predicate<GClass2988> predicate_0;

		// Token: 0x0400CD65 RID: 52581
		private static BallisticCollider ballisticCollider_0;

		// Token: 0x0200280F RID: 10255
		[StructLayout(LayoutKind.Auto)]
		public struct Struct777
		{
			// Token: 0x0400CD66 RID: 52582
			public readonly float SimulationTime;

			// Token: 0x0400CD67 RID: 52583
			public readonly GClass2988 Shot;
		}
	}
}
