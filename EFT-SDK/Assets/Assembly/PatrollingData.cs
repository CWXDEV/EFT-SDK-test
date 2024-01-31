using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x02000457 RID: 1111
public class PatrollingData : GClass362
{
	// Token: 0x06001AB7 RID: 6839 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static PatrolPointChooserBasic GetPointChooser(BotOwner bot, PatrolMode mode, IGetProfileData data = null)
	{
		throw null;
	}

	// Token: 0x1400002E RID: 46
	// (add) Token: 0x06001AB8 RID: 6840 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06001AB9 RID: 6841 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<PatrolPointContainer> OnPatrolPointCome
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

	// Token: 0x1400002F RID: 47
	// (add) Token: 0x06001ABA RID: 6842 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06001ABB RID: 6843 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<PatrolStatus> OnStatusChanged
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

	// Token: 0x170004CB RID: 1227
	// (get) Token: 0x06001ABC RID: 6844 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001ABD RID: 6845 RVA: 0x00002050 File Offset: 0x00000250
	public PatrolStatus Status
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x170004CC RID: 1228
	// (get) Token: 0x06001ABE RID: 6846 RVA: 0x00002050 File Offset: 0x00000250
	public float SpeedPatrol
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170004CD RID: 1229
	// (get) Token: 0x06001ABF RID: 6847 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001AC0 RID: 6848 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsActivated
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

	// Token: 0x170004CE RID: 1230
	// (get) Token: 0x06001AC1 RID: 6849 RVA: 0x00002050 File Offset: 0x00000250
	public PatrolPointContainer CurPatrolPoint
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170004CF RID: 1231
	// (get) Token: 0x06001AC2 RID: 6850 RVA: 0x00002050 File Offset: 0x00000250
	public PatrolWay Way
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170004D0 RID: 1232
	// (get) Token: 0x06001AC3 RID: 6851 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001AC4 RID: 6852 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 CurTargetPoint
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

	// Token: 0x170004D1 RID: 1233
	// (get) Token: 0x06001AC5 RID: 6853 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001AC6 RID: 6854 RVA: 0x00002050 File Offset: 0x00000250
	public PatrolPointChooserBasic PointChooser
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

	// Token: 0x170004D2 RID: 1234
	// (get) Token: 0x06001AC7 RID: 6855 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001AC8 RID: 6856 RVA: 0x00002050 File Offset: 0x00000250
	public float ComeToPointTime
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

	// Token: 0x06001AC9 RID: 6857 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x06001ACA RID: 6858 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Unpause()
	{
		throw null;
	}

	// Token: 0x06001ACB RID: 6859 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMode(PatrolMode mode, PatrolPointChooserBasic pointChooser)
	{
		throw null;
	}

	// Token: 0x06001ACC RID: 6860 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualUpdate(bool canLookAround)
	{
		throw null;
	}

	// Token: 0x06001ACD RID: 6861 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReserveGoNextPoint()
	{
		throw null;
	}

	// Token: 0x06001ACE RID: 6862 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MoveUpdate()
	{
		throw null;
	}

	// Token: 0x06001ACF RID: 6863 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopAndLookToPoint(Vector3 sPoint)
	{
		throw null;
	}

	// Token: 0x06001AD0 RID: 6864 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateObserveWay()
	{
		throw null;
	}

	// Token: 0x06001AD1 RID: 6865 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ComeToPoint()
	{
		throw null;
	}

	// Token: 0x06001AD2 RID: 6866 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GoToPoint()
	{
		throw null;
	}

	// Token: 0x06001AD3 RID: 6867 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Disable()
	{
		throw null;
	}

	// Token: 0x06001AD4 RID: 6868 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FindNextPoint(bool withSetting, bool withoutNext, GDelegate3 pointFilter = null)
	{
		throw null;
	}

	// Token: 0x06001AD5 RID: 6869 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Pause()
	{
		throw null;
	}

	// Token: 0x06001AD6 RID: 6870 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawGizomsSelectedFromBot()
	{
		throw null;
	}

	// Token: 0x06001AD7 RID: 6871 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTargetMoveSpeed()
	{
		throw null;
	}

	// Token: 0x06001AD8 RID: 6872 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RefreshStatus()
	{
		throw null;
	}

	// Token: 0x06001AD9 RID: 6873 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void PointSetted(PatrolPointContainer point, int index)
	{
		throw null;
	}

	// Token: 0x06001ADA RID: 6874 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector3 method_0()
	{
		throw null;
	}

	// Token: 0x06001ADB RID: 6875 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(bool obj)
	{
		throw null;
	}

	// Token: 0x06001ADC RID: 6876 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x06001ADD RID: 6877 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x06001ADE RID: 6878 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4()
	{
		throw null;
	}

	// Token: 0x06001ADF RID: 6879 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TryToTalk(bool bigDelay)
	{
		throw null;
	}

	// Token: 0x06001AE0 RID: 6880 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5()
	{
		throw null;
	}

	// Token: 0x06001AE1 RID: 6881 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x06001AE2 RID: 6882 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6()
	{
		throw null;
	}

	// Token: 0x06001AE3 RID: 6883 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_7()
	{
		throw null;
	}

	// Token: 0x06001AE4 RID: 6884 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_8()
	{
		throw null;
	}

	// Token: 0x040016DD RID: 5853
	public GClass426 PointControl;

	// Token: 0x040016DE RID: 5854
	public GClass431 PatrolPathControl;

	// Token: 0x040016DF RID: 5855
	public GClass437 MoveByReservWay;

	// Token: 0x040016E0 RID: 5856
	public BotOwner _lastFriend;

	// Token: 0x040016E1 RID: 5857
	private float _nextFriendSearch;

	// Token: 0x040016E2 RID: 5858
	private float _nextTalk;

	// Token: 0x040016E3 RID: 5859
	private float _nextTimeCanRecalc;

	// Token: 0x040016E4 RID: 5860
	private PatrolStatus _status;

	// Token: 0x040016E5 RID: 5861
	private PatrolStatus _prevStatus;

	// Token: 0x040016E6 RID: 5862
	private float _comeTime;

	// Token: 0x040016E7 RID: 5863
	private float _reservChoosedTime;

	// Token: 0x040016E8 RID: 5864
	private bool _needUpdateNextPoint;

	// Token: 0x040016E9 RID: 5865
	private GInterface7 PatrolMove;

	// Token: 0x040016EA RID: 5866
	private IProductionUpdate PatrolLook;

	// Token: 0x040016EB RID: 5867
	private readonly GClass424 _botObserveData;

	// Token: 0x040016EC RID: 5868
	private readonly List<GClass502> _suspetionPlaces;

	// Token: 0x040016ED RID: 5869
	private float _recheckPeriod;
}
