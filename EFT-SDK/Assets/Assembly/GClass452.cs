using System;
using System.Runtime.CompilerServices;
using EFT;
using EFT.InventoryLogic;
using UnityEngine;

// Token: 0x020004D0 RID: 1232
public class GClass452 : GClass362, IBotAiming
{
	// Token: 0x14000046 RID: 70
	// (add) Token: 0x06001E7C RID: 7804 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06001E7D RID: 7805 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<Vector3> OnSettingsTarget
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

	// Token: 0x1700057F RID: 1407
	// (get) Token: 0x06001E7E RID: 7806 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001E7F RID: 7807 RVA: 0x00002050 File Offset: 0x00000250
	public bool HardAim
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

	// Token: 0x17000580 RID: 1408
	// (get) Token: 0x06001E80 RID: 7808 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001E81 RID: 7809 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 From
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

	// Token: 0x17000581 RID: 1409
	// (get) Token: 0x06001E82 RID: 7810 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001E83 RID: 7811 RVA: 0x00002050 File Offset: 0x00000250
	public float SinDist
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

	// Token: 0x17000582 RID: 1410
	// (get) Token: 0x06001E84 RID: 7812 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001E85 RID: 7813 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 To
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

	// Token: 0x17000583 RID: 1411
	// (get) Token: 0x06001E86 RID: 7814 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001E87 RID: 7815 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 TargetToLook
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

	// Token: 0x17000584 RID: 1412
	// (get) Token: 0x06001E88 RID: 7816 RVA: 0x00002050 File Offset: 0x00000250
	public GClass451 ScatteringData
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000585 RID: 1413
	// (get) Token: 0x06001E89 RID: 7817 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 EndTargetPoint
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000586 RID: 1414
	// (get) Token: 0x06001E8A RID: 7818 RVA: 0x00002050 File Offset: 0x00000250
	public bool AlwaysTurnOnLight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000587 RID: 1415
	// (get) Token: 0x06001E8B RID: 7819 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsReady
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000588 RID: 1416
	// (get) Token: 0x06001E8C RID: 7820 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001E8D RID: 7821 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 RealTargetPoint
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

	// Token: 0x17000589 RID: 1417
	// (get) Token: 0x06001E8E RID: 7822 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001E8F RID: 7823 RVA: 0x00002050 File Offset: 0x00000250
	public float LastDist2Target
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

	// Token: 0x06001E90 RID: 7824 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetHit(DamageInfo damageInfo)
	{
		throw null;
	}

	// Token: 0x06001E91 RID: 7825 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x06001E92 RID: 7826 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void NodeUpdate()
	{
		throw null;
	}

	// Token: 0x06001E93 RID: 7827 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoseTarget()
	{
		throw null;
	}

	// Token: 0x06001E94 RID: 7828 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTarget(Vector3 trg)
	{
		throw null;
	}

	// Token: 0x06001E95 RID: 7829 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetNextAimingDelay(float nextAimingDelay)
	{
		throw null;
	}

	// Token: 0x06001E96 RID: 7830 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TriggerPressedDone()
	{
		throw null;
	}

	// Token: 0x06001E97 RID: 7831 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShootDone(Weapon weapon)
	{
		throw null;
	}

	// Token: 0x06001E98 RID: 7832 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Panic()
	{
		throw null;
	}

	// Token: 0x06001E99 RID: 7833 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawGizmosSelected()
	{
		throw null;
	}

	// Token: 0x06001E9A RID: 7834 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PermanentUpdate()
	{
		throw null;
	}

	// Token: 0x06001E9B RID: 7835 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RotateX(float angToRotate)
	{
		throw null;
	}

	// Token: 0x06001E9C RID: 7836 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RotateY(float deltaAngle)
	{
		throw null;
	}

	// Token: 0x06001E9D RID: 7837 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetWeapon(Weapon weapon)
	{
		throw null;
	}

	// Token: 0x06001E9E RID: 7838 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTracers(bool isTracers)
	{
		throw null;
	}

	// Token: 0x06001E9F RID: 7839 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Move(float delta = 0f)
	{
		throw null;
	}

	// Token: 0x06001EA0 RID: 7840 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void NextShotMiss()
	{
		throw null;
	}

	// Token: 0x06001EA1 RID: 7841 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDrawGizmos()
	{
		throw null;
	}

	// Token: 0x06001EA2 RID: 7842 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DebugDraw()
	{
		throw null;
	}

	// Token: 0x06001EA3 RID: 7843 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06001EA4 RID: 7844 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(bool obj)
	{
		throw null;
	}

	// Token: 0x06001EA5 RID: 7845 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(float obj)
	{
		throw null;
	}

	// Token: 0x06001EA6 RID: 7846 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x06001EA7 RID: 7847 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_4(float dist)
	{
		throw null;
	}

	// Token: 0x06001EA8 RID: 7848 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_5(float cur, float min, float max, float lowVal, float hightVal)
	{
		throw null;
	}

	// Token: 0x06001EA9 RID: 7849 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6(Vector3 trg, Vector3 center)
	{
		throw null;
	}

	// Token: 0x06001EAA RID: 7850 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_7()
	{
		throw null;
	}

	// Token: 0x06001EAB RID: 7851 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_8(Vector3 dir)
	{
		throw null;
	}

	// Token: 0x06001EAC RID: 7852 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x040019A1 RID: 6561
	public bool _alwaysTurnOnLight;

	// Token: 0x040019A2 RID: 6562
	private float float_0;

	// Token: 0x040019A3 RID: 6563
	private bool bool_0;

	// Token: 0x040019A4 RID: 6564
	private bool bool_1;

	// Token: 0x040019A5 RID: 6565
	private bool bool_2;

	// Token: 0x040019A6 RID: 6566
	private Vector3 vector3_0;

	// Token: 0x040019A7 RID: 6567
	private GClass527 gclass527_0;

	// Token: 0x040019A8 RID: 6568
	private IFirearmHandsController ifirearmHandsController_0;

	// Token: 0x040019A9 RID: 6569
	private AimStatus aimStatus_0;

	// Token: 0x040019AA RID: 6570
	private float float_1;

	// Token: 0x040019AB RID: 6571
	private bool bool_3;

	// Token: 0x040019AC RID: 6572
	[CompilerGenerated]
	private Action<Vector3> action_0;

	// Token: 0x040019AD RID: 6573
	[CompilerGenerated]
	private bool bool_4;

	// Token: 0x040019AE RID: 6574
	[CompilerGenerated]
	private Vector3 vector3_1;

	// Token: 0x040019AF RID: 6575
	[CompilerGenerated]
	private float float_2;

	// Token: 0x040019B0 RID: 6576
	[CompilerGenerated]
	private Vector3 vector3_2;

	// Token: 0x040019B1 RID: 6577
	[CompilerGenerated]
	private Vector3 vector3_3;

	// Token: 0x040019B2 RID: 6578
	[CompilerGenerated]
	private readonly GClass451 gclass451_0;

	// Token: 0x040019B3 RID: 6579
	[CompilerGenerated]
	private Vector3 vector3_4;

	// Token: 0x040019B4 RID: 6580
	[CompilerGenerated]
	private float float_3;
}
