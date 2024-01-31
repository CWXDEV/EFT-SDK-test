using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EFT;
using EFT.BufferZone;
using UnityEngine.Networking;

// Token: 0x02002714 RID: 10004
public class BufferZoneControllerClass
{
	// Token: 0x0600C695 RID: 50837 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowAlreadyHaveCustomersNotification()
	{
		throw null;
	}

	// Token: 0x0600C696 RID: 50838 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowGateNotAvailableNotification()
	{
		throw null;
	}

	// Token: 0x0600C697 RID: 50839 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowAccessDeniedNotification()
	{
		throw null;
	}

	// Token: 0x0600C698 RID: 50840 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowUsageTimeEndedNotification()
	{
		throw null;
	}

	// Token: 0x0600C699 RID: 50841 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowTimerRemindNotification()
	{
		throw null;
	}

	// Token: 0x0600C69A RID: 50842 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowGateKickAlarmNotification()
	{
		throw null;
	}

	// Token: 0x1700238F RID: 9103
	// (get) Token: 0x0600C69B RID: 50843 RVA: 0x00002050 File Offset: 0x00000250
	public static BufferZoneControllerClass Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x140002D2 RID: 722
	// (add) Token: 0x0600C69C RID: 50844 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600C69D RID: 50845 RVA: 0x00002050 File Offset: 0x00000250
	public static event Action OnInitialized
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

	// Token: 0x17002390 RID: 9104
	// (get) Token: 0x0600C69E RID: 50846 RVA: 0x00002050 File Offset: 0x00000250
	public BackendConfigSettingsClass.GClass1371 Settings
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002391 RID: 9105
	// (get) Token: 0x0600C69F RID: 50847 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsInnerZoneAvailable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002392 RID: 9106
	// (get) Token: 0x0600C6A0 RID: 50848 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsBufferZoneExists
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600C6A1 RID: 50849 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_0(CancellationToken cancellationToken)
	{
		throw null;
	}

	// Token: 0x0600C6A2 RID: 50850 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x0600C6A3 RID: 50851 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RegisterContainer(BufferZoneContainer container)
	{
		throw null;
	}

	// Token: 0x0600C6A4 RID: 50852 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetInnerZoneAvailabilityStatus(bool isZoneAvaliable, EBufferZoneData changesDataType)
	{
		throw null;
	}

	// Token: 0x0600C6A5 RID: 50853 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPlayerAccessStatus(string profileID, bool status)
	{
		throw null;
	}

	// Token: 0x0600C6A6 RID: 50854 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPlayerInZoneStatus(string profileID, bool inZone)
	{
		throw null;
	}

	// Token: 0x0600C6A7 RID: 50855 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsPlayerCanAccessBufferZone(string profileID, out BufferAccessStatusType receivedAccessStatus)
	{
		throw null;
	}

	// Token: 0x0600C6A8 RID: 50856 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsPlayerHaveAccessToInnerZone(string profileID)
	{
		throw null;
	}

	// Token: 0x0600C6A9 RID: 50857 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetPlayerBufferZoneUsageTimeLeft(string playerProfileID)
	{
		throw null;
	}

	// Token: 0x0600C6AA RID: 50858 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HandleReconnectedPlayer(bool isInBufferZone, Player player, int bufferZoneUsageTimeLeft, Task onCurrentHandsControllerSpawned)
	{
		throw null;
	}

	// Token: 0x0600C6AB RID: 50859 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WriteStates(NetworkWriter writer)
	{
		throw null;
	}

	// Token: 0x0600C6AC RID: 50860 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReadStates(NetworkReader reader)
	{
		throw null;
	}

	// Token: 0x0600C6AD RID: 50861 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DevSetPlayerAccessLevel(Player player, int levelAccess)
	{
		throw null;
	}

	// Token: 0x0600C6AE RID: 50862 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DevResetPlayerUsageTime(Player player)
	{
		throw null;
	}

	// Token: 0x0400C85C RID: 51292
	private GClass2019 gclass2019_0;

	// Token: 0x0400C85D RID: 51293
	private GClass2020 gclass2020_0;

	// Token: 0x0400C85E RID: 51294
	private GClass2021 gclass2021_0;

	// Token: 0x0400C85F RID: 51295
	private GClass2022 gclass2022_0;

	// Token: 0x0400C860 RID: 51296
	private GClass2023 gclass2023_0;

	// Token: 0x0400C861 RID: 51297
	private GClass2024 gclass2024_0;

	// Token: 0x0400C862 RID: 51298
	[CompilerGenerated]
	private static Action action_0;

	// Token: 0x0400C863 RID: 51299
	private bool bool_0;

	// Token: 0x0400C864 RID: 51300
	private BackendConfigSettingsClass.GClass1371 gclass1371_0;

	// Token: 0x0400C865 RID: 51301
	private BufferZoneContainer bufferZoneContainer_0;

	// Token: 0x0400C866 RID: 51302
	private CancellationTokenSource cancellationTokenSource_0;
}
