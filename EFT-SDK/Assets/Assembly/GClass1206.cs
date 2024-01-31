using System;
using System.Runtime.CompilerServices;
using EFT;
using Newtonsoft.Json;

// Token: 0x02000FE2 RID: 4066
public class GClass1206 : IProfileDataContainer
{
	// Token: 0x17000D55 RID: 3413
	// (get) Token: 0x0600554B RID: 21835 RVA: 0x00002050 File Offset: 0x00000250
	string IProfileDataContainer.ProfileId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000D56 RID: 3414
	// (get) Token: 0x0600554C RID: 21836 RVA: 0x00002050 File Offset: 0x00000250
	string IProfileDataContainer.Nickname
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000D57 RID: 3415
	// (get) Token: 0x0600554D RID: 21837 RVA: 0x00002050 File Offset: 0x00000250
	EPlayerSide IProfileDataContainer.Side
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x04006102 RID: 24834
	[JsonProperty("aid")]
	public string AccountId;

	// Token: 0x04006103 RID: 24835
	[JsonProperty("_id")]
	public string Id;

	// Token: 0x04006104 RID: 24836
	[JsonProperty("lookingGroup")]
	public bool LookingForGroup;

	// Token: 0x04006105 RID: 24837
	public bool IsLeader;

	// Token: 0x04006106 RID: 24838
	public bool IsReady;

	// Token: 0x04006107 RID: 24839
	public GClass1205 Info;

	// Token: 0x04006108 RID: 24840
	public PlayerVisualRepresentation PlayerVisualRepresentation;
}
