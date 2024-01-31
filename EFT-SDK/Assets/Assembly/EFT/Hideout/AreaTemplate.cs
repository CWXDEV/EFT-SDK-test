using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Sirenix.OdinInspector;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001B68 RID: 7016
	public sealed class AreaTemplate : SerializedScriptableObject
	{
		// Token: 0x170016AC RID: 5804
		// (get) Token: 0x060093D2 RID: 37842 RVA: 0x00002050 File Offset: 0x00000250
		public int MaxLevel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170016AD RID: 5805
		// (get) Token: 0x060093D3 RID: 37843 RVA: 0x00002050 File Offset: 0x00000250
		public string Name
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060093D4 RID: 37844 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init()
		{
			throw null;
		}

		// Token: 0x060093D5 RID: 37845 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateData(AreaTemplate template)
		{
			throw null;
		}

		// Token: 0x04009A70 RID: 39536
		public string Id;

		// Token: 0x04009A71 RID: 39537
		public bool Enabled;

		// Token: 0x04009A72 RID: 39538
		public bool NeedsFuel;

		// Token: 0x04009A73 RID: 39539
		public bool CraftGivesExp;

		// Token: 0x04009A74 RID: 39540
		public bool TakeFromSlotLocked;

		// Token: 0x04009A75 RID: 39541
		public EAreaType Type;

		// Token: 0x04009A76 RID: 39542
		public bool DisplayLevel;

		// Token: 0x04009A77 RID: 39543
		public string ParentAreaId;

		// Token: 0x04009A78 RID: 39544
		public float stashGridStep;

		// Token: 0x04009A79 RID: 39545
		[JsonIgnore]
		public GClass1924 AreaBehaviour;

		// Token: 0x04009A7A RID: 39546
		[JsonIgnore]
		public Sprite AreaIcon;

		// Token: 0x04009A7B RID: 39547
		[JsonIgnore]
		public int CameraTimePosition;

		// Token: 0x04009A7C RID: 39548
		[JsonIgnore]
		public bool IsElite;

		// Token: 0x04009A7D RID: 39549
		[JsonIgnore]
		public readonly Dictionary<ELightStatus, float> PowerDelays;

		// Token: 0x04009A7E RID: 39550
		[JsonIgnore]
		public Dictionary<EAreaActivityType, AudioClip> DefaultSounds;

		// Token: 0x04009A7F RID: 39551
		[HideInInspector]
		public RelatedRequirements Requirements;

		// Token: 0x04009A80 RID: 39552
		public Dictionary<int, Stage> Stages;
	}
}
