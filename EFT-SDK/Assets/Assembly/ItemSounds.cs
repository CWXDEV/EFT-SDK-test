using System;
using System.Runtime.CompilerServices;
using EFT.UI;
using UnityEngine;

// Token: 0x020009C7 RID: 2503
public class ItemSounds : ScriptableObject
{
	// Token: 0x060037D8 RID: 14296 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public AudioClip GetClip(string partName, EInventorySoundType soundType)
	{
		throw null;
	}

	// Token: 0x0400397B RID: 14715
	public ItemSounds.ClipsByEInventorySoundType[] Clips;

	// Token: 0x0400397C RID: 14716
	public AudioClip[] LootingClips;

	// Token: 0x020009C8 RID: 2504
	[Serializable]
	public class ClipsByEInventorySoundType
	{
		// Token: 0x0400397D RID: 14717
		public AudioClip[] Clips;
	}
}
