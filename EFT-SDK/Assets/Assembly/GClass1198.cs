using System;
using EFT;

// Token: 0x02000FD1 RID: 4049
public class GClass1198 : ISerializer<LootItemPositionClass>, ISerializer<GClass1197>
{
	// Token: 0x040060B8 RID: 24760
	public string Id;

	// Token: 0x040060B9 RID: 24761
	public ClassVector3 Position;

	// Token: 0x040060BA RID: 24762
	public ClassVector3 Rotation;

	// Token: 0x040060BB RID: 24763
	public GClass1186[] Items;

	// Token: 0x040060BC RID: 24764
	public string Root;

	// Token: 0x040060BD RID: 24765
	public bool IsContainer;

	// Token: 0x040060BE RID: 24766
	public string[] ValidProfiles;

	// Token: 0x040060BF RID: 24767
	public bool useGravity;

	// Token: 0x040060C0 RID: 24768
	public bool randomRotation;

	// Token: 0x040060C1 RID: 24769
	public GClass1752 Customization;

	// Token: 0x040060C2 RID: 24770
	public EPlayerSide Side;

	// Token: 0x040060C3 RID: 24771
	public ClassTransformSync[] Bones;

	// Token: 0x040060C4 RID: 24772
	public string CorpseProfileID;

	// Token: 0x040060C5 RID: 24773
	public ClassVector3 Shift;
	LootItemPositionClass ISerializer<LootItemPositionClass>.Deserialize()
	{
		throw new NotImplementedException();
	}

	public object Serialize(GClass1197 t)
	{
		throw new NotImplementedException();
	}

	public object Serialize(LootItemPositionClass t)
	{
		throw new NotImplementedException();
	}

	GClass1197 ISerializer<GClass1197>.Deserialize()
	{
		throw new NotImplementedException();
	}
}
