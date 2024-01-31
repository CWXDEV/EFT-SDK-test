using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x02000538 RID: 1336
[Serializable]
public class PatrolWay : MonoBehaviour
{
	// Token: 0x06002084 RID: 8324 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitPoints()
	{
		throw null;
	}

	// Token: 0x06002085 RID: 8325 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EditorInitPoints()
	{
		throw null;
	}

	// Token: 0x06002086 RID: 8326 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveMe(BotOwner owner)
	{
		throw null;
	}

	// Token: 0x06002087 RID: 8327 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddUser(BotOwner owner)
	{
		throw null;
	}

	// Token: 0x06002088 RID: 8328 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HaveFreeSpace()
	{
		throw null;
	}

	// Token: 0x06002089 RID: 8329 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HaveFreeSpace(BotOwner exeptBot)
	{
		throw null;
	}

	// Token: 0x0600208A RID: 8330 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int UsersCount()
	{
		throw null;
	}

	// Token: 0x0600208B RID: 8331 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string AllUsersDebugIdInfo()
	{
		throw null;
	}

	// Token: 0x0600208C RID: 8332 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string AllUsersDebugIdInfoRole()
	{
		throw null;
	}

	// Token: 0x0600208D RID: 8333 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsCloseToSelect(BotOwner owner, float closeToSelectReservWay)
	{
		throw null;
	}

	// Token: 0x0600208E RID: 8334 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string SuitableData()
	{
		throw null;
	}

	// Token: 0x0600208F RID: 8335 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool Suitable(BotOwner bot, IGetProfileData data)
	{
		throw null;
	}

	// Token: 0x06002090 RID: 8336 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanBeUsedByRole(WildSpawnType settingsRole)
	{
		throw null;
	}

	// Token: 0x04001F1B RID: 7963
	public PatrolType PatrolType;

	// Token: 0x04001F1C RID: 7964
	public List<PatrolPoint> Points;

	// Token: 0x04001F1D RID: 7965
	public int MaxPersons;

	// Token: 0x04001F1E RID: 7966
	private HashSet<BotOwner> _users;

	// Token: 0x04001F1F RID: 7967
	public float CoefSubPoints;
}
