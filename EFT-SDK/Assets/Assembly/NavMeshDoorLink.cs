using System;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Interactive;
using UnityEngine;
using UnityEngine.AI;

// Token: 0x02000532 RID: 1330
public class NavMeshDoorLink : MonoBehaviour
{
	// Token: 0x170005DC RID: 1500
	// (get) Token: 0x06002048 RID: 8264 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002049 RID: 8265 RVA: 0x00002050 File Offset: 0x00000250
	public Door Door
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

	// Token: 0x170005DD RID: 1501
	// (get) Token: 0x0600204A RID: 8266 RVA: 0x00002050 File Offset: 0x00000250
	public GClass297 SegmentOpen
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170005DE RID: 1502
	// (get) Token: 0x0600204B RID: 8267 RVA: 0x00002050 File Offset: 0x00000250
	public GClass297 SegmentClose
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600204C RID: 8268 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x0600204D RID: 8269 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDoor(Door door, bool withSubscribe)
	{
		throw null;
	}

	// Token: 0x0600204E RID: 8270 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(BotsController bc)
	{
		throw null;
	}

	// Token: 0x0600204F RID: 8271 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualUpdate()
	{
		throw null;
	}

	// Token: 0x06002050 RID: 8272 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ShallInteract()
	{
		throw null;
	}

	// Token: 0x06002051 RID: 8273 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TryCreateCrave()
	{
		throw null;
	}

	// Token: 0x06002052 RID: 8274 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckAfterCreatedCarver()
	{
		throw null;
	}

	// Token: 0x06002053 RID: 8275 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CarveOff()
	{
		throw null;
	}

	// Token: 0x06002054 RID: 8276 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAllCarvers(bool val)
	{
		throw null;
	}

	// Token: 0x06002055 RID: 8277 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCoef()
	{
		throw null;
	}

	// Token: 0x06002056 RID: 8278 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DropCoef()
	{
		throw null;
	}

	// Token: 0x06002057 RID: 8279 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(WorldInteractiveObject obj, EDoorState prevstate, EDoorState nextstate)
	{
		throw null;
	}

	// Token: 0x06002058 RID: 8280 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x06002059 RID: 8281 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x0600205A RID: 8282 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmosSelected()
	{
		throw null;
	}

	// Token: 0x04001EEA RID: 7914
	private const float float_0 = 9999f;

	// Token: 0x04001EEB RID: 7915
	public int Id;

	// Token: 0x04001EEC RID: 7916
	public BotOwner Opening;

	// Token: 0x04001EED RID: 7917
	public Vector3 Close1;

	// Token: 0x04001EEE RID: 7918
	public Vector3 Close2_Normal;

	// Token: 0x04001EEF RID: 7919
	public Vector3 Close2_Breach;

	// Token: 0x04001EF0 RID: 7920
	public Vector3 FarestClosePoint;

	// Token: 0x04001EF1 RID: 7921
	public Vector3 Open1;

	// Token: 0x04001EF2 RID: 7922
	public Vector3 Open2;

	// Token: 0x04001EF3 RID: 7923
	public float BottomY;

	// Token: 0x04001EF4 RID: 7924
	public Vector3 MidOpen;

	// Token: 0x04001EF5 RID: 7925
	public Vector3 MidClose;

	// Token: 0x04001EF6 RID: 7926
	public NavMeshObstacle Carver_Opened;

	// Token: 0x04001EF7 RID: 7927
	public NavMeshObstacle Carver_Breached;

	// Token: 0x04001EF8 RID: 7928
	public NavMeshObstacle Carver_Closed;

	// Token: 0x04001EF9 RID: 7929
	public bool ShallTryInteract;

	// Token: 0x04001EFA RID: 7930
	public int ConnectedNavGraphPathOpenStateId;

	// Token: 0x04001EFB RID: 7931
	public int ConnectedNavGraphPathCloseStateId;

	// Token: 0x04001EFC RID: 7932
	public NavGraphEditorPath ConnectedNavGraphOpenStatePath;

	// Token: 0x04001EFD RID: 7933
	public NavGraphEditorPath ConnectedNavGraphCloseStatePath;

	// Token: 0x04001EFE RID: 7934
	private GClass297 gclass297_0;

	// Token: 0x04001EFF RID: 7935
	private GClass297 gclass297_1;

	// Token: 0x04001F00 RID: 7936
	private BotsController botsController_0;

	// Token: 0x04001F01 RID: 7937
	private bool bool_0;

	// Token: 0x04001F02 RID: 7938
	private float float_1;

	// Token: 0x04001F03 RID: 7939
	private bool bool_1;

	// Token: 0x04001F04 RID: 7940
	[CompilerGenerated]
	private Door door_0;
}
