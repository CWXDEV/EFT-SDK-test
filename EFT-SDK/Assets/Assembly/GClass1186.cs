using System;
using System.Runtime.CompilerServices;
using EFT;
using Newtonsoft.Json;

// Token: 0x02000FC3 RID: 4035
public class GClass1186
{
	// Token: 0x06005520 RID: 21792 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass1186 Clone(MongoID id, string parent, string slot)
	{
		throw null;
	}

	// Token: 0x06005521 RID: 21793 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass1186 Clone()
	{
		throw null;
	}

	// Token: 0x06005522 RID: 21794 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(GClass1078 writer)
	{
		throw null;
	}

	// Token: 0x06005523 RID: 21795 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Deserialize(GClass1073 reader)
	{
		throw null;
	}

	// Token: 0x0400607F RID: 24703
	public string _id;

	// Token: 0x04006080 RID: 24704
	public string _tpl;

	// Token: 0x04006081 RID: 24705
	[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
	public string parentId;

	// Token: 0x04006082 RID: 24706
	[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
	public string slotId;

	// Token: 0x04006083 RID: 24707
	[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
	public GClass748 location;

	// Token: 0x04006084 RID: 24708
	[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
	public GClass748 upd;
}
