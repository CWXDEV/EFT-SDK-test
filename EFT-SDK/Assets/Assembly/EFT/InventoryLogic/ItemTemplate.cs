using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using JsonType;
using Newtonsoft.Json;

namespace EFT.InventoryLogic
{
	// Token: 0x02002382 RID: 9090
	public class ItemTemplate : IItemTemplate, IAnimationVariantsComponentTemplate, IUnlootableComponentTemplate
	{
		// Token: 0x17001F9C RID: 8092
		// (get) Token: 0x0600B6DD RID: 46813 RVA: 0x00002050 File Offset: 0x00000250
		public string ShortNameLocalizationKey
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001F9D RID: 8093
		// (get) Token: 0x0600B6DE RID: 46814 RVA: 0x00002050 File Offset: 0x00000250
		public string NameLocalizationKey
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001F9E RID: 8094
		// (get) Token: 0x0600B6DF RID: 46815 RVA: 0x00002050 File Offset: 0x00000250
		public string DescriptionLocalizationKey
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001F9F RID: 8095
		// (get) Token: 0x0600B6E0 RID: 46816 RVA: 0x00002050 File Offset: 0x00000250
		public virtual IEnumerable<ResourceKey> AllResources
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001FA0 RID: 8096
		// (get) Token: 0x0600B6E1 RID: 46817 RVA: 0x00002050 File Offset: 0x00000250
		public ExtraSize ExtraSize
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001FA1 RID: 8097
		// (get) Token: 0x0600B6E2 RID: 46818 RVA: 0x00002050 File Offset: 0x00000250
		string IUnlootableComponentTemplate.SlotName
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001FA2 RID: 8098
		// (get) Token: 0x0600B6E3 RID: 46819 RVA: 0x00002050 File Offset: 0x00000250
		EPlayerSideMask IUnlootableComponentTemplate.Side
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001FA3 RID: 8099
		// (get) Token: 0x0600B6E4 RID: 46820 RVA: 0x00002050 File Offset: 0x00000250
		int IAnimationVariantsComponentTemplate.AnimationVariantsNumber
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001FA4 RID: 8100
		// (get) Token: 0x0600B6E5 RID: 46821 RVA: 0x00002050 File Offset: 0x00000250
		[JsonIgnore]
		public ItemTemplate[] CompatibleItems
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001FA5 RID: 8101
		// (get) Token: 0x0600B6E6 RID: 46822 RVA: 0x00002050 File Offset: 0x00000250
		[JsonIgnore]
		public IReadOnlyList<ItemTemplate> Children
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001FA6 RID: 8102
		// (get) Token: 0x0600B6E7 RID: 46823 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B6E8 RID: 46824 RVA: 0x00002050 File Offset: 0x00000250
		[JsonIgnore]
		public ItemTemplate Parent
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

		// Token: 0x0600B6E9 RID: 46825 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnInit()
		{
			throw null;
		}

		// Token: 0x0600B6EA RID: 46826 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddChild(ItemTemplate template)
		{
			throw null;
		}

		// Token: 0x0600B6EB RID: 46827 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsChildOf(string parentTemplateId)
		{
			throw null;
		}

		// Token: 0x0600B6EC RID: 46828 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual List<IItemComponent> CreateReadonlyComponentsCollection()
		{
			throw null;
		}

		// Token: 0x0600B6ED RID: 46829 RVA: 0x00002050 File Offset: 0x00000250
		[NotNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<IItemComponent> GetReadonlyComponents()
		{
			throw null;
		}

		// Token: 0x0400BA78 RID: 47736
		public string Name;

		// Token: 0x0400BA79 RID: 47737
		public string ShortName;

		// Token: 0x0400BA7A RID: 47738
		public string Description;

		// Token: 0x0400BA7B RID: 47739
		public float Weight;

		// Token: 0x0400BA7C RID: 47740
		public bool ExaminedByDefault;

		// Token: 0x0400BA7D RID: 47741
		public float ExamineTime;

		// Token: 0x0400BA7E RID: 47742
		public bool QuestItem;

		// Token: 0x0400BA7F RID: 47743
		public TaxonomyColor BackgroundColor;

		// Token: 0x0400BA80 RID: 47744
		public int Width;

		// Token: 0x0400BA81 RID: 47745
		public int Height;

		// Token: 0x0400BA82 RID: 47746
		public int ExtraSizeLeft;

		// Token: 0x0400BA83 RID: 47747
		public int ExtraSizeRight;

		// Token: 0x0400BA84 RID: 47748
		public int ExtraSizeUp;

		// Token: 0x0400BA85 RID: 47749
		public int ExtraSizeDown;

		// Token: 0x0400BA86 RID: 47750
		public bool ExtraSizeForceAdd;

		// Token: 0x0400BA87 RID: 47751
		public int StackMaxSize;

		// Token: 0x0400BA88 RID: 47752
		public int StackObjectsCount;

		// Token: 0x0400BA89 RID: 47753
		public int CreditsPrice;

		// Token: 0x0400BA8A RID: 47754
		public string ItemSound;

		// Token: 0x0400BA8B RID: 47755
		public ResourceKey Prefab;

		// Token: 0x0400BA8C RID: 47756
		public ResourceKey UsePrefab;

		// Token: 0x0400BA8D RID: 47757
		public ELootRarity Rarity;

		// Token: 0x0400BA8E RID: 47758
		public EItemDropSoundType DropSoundType;

		// Token: 0x0400BA8F RID: 47759
		public float SpawnChance;

		// Token: 0x0400BA90 RID: 47760
		public bool NotShownInSlot;

		// Token: 0x0400BA91 RID: 47761
		public int LootExperience;

		// Token: 0x0400BA92 RID: 47762
		public bool HideEntrails;

		// Token: 0x0400BA93 RID: 47763
		public int ExamineExperience;

		// Token: 0x0400BA94 RID: 47764
		public int RepairCost;

		// Token: 0x0400BA95 RID: 47765
		public int RepairSpeed;

		// Token: 0x0400BA96 RID: 47766
		public bool MergesWithChildren;

		// Token: 0x0400BA97 RID: 47767
		public bool CanSellOnRagfair;

		// Token: 0x0400BA98 RID: 47768
		public bool CanRequireOnRagfair;

		// Token: 0x0400BA99 RID: 47769
		public string[] ConflictingItems;

		// Token: 0x0400BA9A RID: 47770
		public int AnimationVariantsNumber;

		// Token: 0x0400BA9B RID: 47771
		public float RagFairCommissionModifier;

		// Token: 0x0400BA9C RID: 47772
		public bool IsAlwaysAvailableForInsurance;

		// Token: 0x0400BA9D RID: 47773
		public bool InsuranceDisabled;

		// Token: 0x0400BA9E RID: 47774
		public int DiscardLimit;

		// Token: 0x0400BA9F RID: 47775
		public bool Unlootable;

		// Token: 0x0400BAA0 RID: 47776
		public bool IsUnremovable;

		// Token: 0x0400BAA1 RID: 47777
		public bool IsSpecialSlotOnly;

		// Token: 0x0400BAA2 RID: 47778
		public string UnlootableFromSlot;

		// Token: 0x0400BAA3 RID: 47779
		public EPlayerSideMask UnlootableFromSide;

		// Token: 0x0400BAA4 RID: 47780
		public string _id;

		// Token: 0x0400BAA5 RID: 47781
		public string _name;

		// Token: 0x0400BAA6 RID: 47782
		public string _parent;

		// Token: 0x0400BAA7 RID: 47783
		public NodeType _type;

		// Token: 0x0400BAA8 RID: 47784
		public GClass1186[] _items;

		// Token: 0x0400BAA9 RID: 47785
		protected List<IItemComponent> ReadonlyComponents;

		// Token: 0x0400BAAA RID: 47786
		private List<ItemTemplate> _children;

		// Token: 0x0400BAAB RID: 47787
		[JsonIgnore]
		private ItemTemplate[] _compatibleItems;
	}
}
