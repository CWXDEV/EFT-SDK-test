using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Sirenix.OdinInspector;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001AAE RID: 6830
	public sealed class HideoutAreaLevel : SerializedMonoBehaviour
	{
		// Token: 0x170015CF RID: 5583
		// (get) Token: 0x06008FD8 RID: 36824 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008FD9 RID: 36825 RVA: 0x00002050 File Offset: 0x00000250
		[SerializeField]
		public Dictionary<string, Transform> StashObjectsSpawnPoints
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

		// Token: 0x170015D0 RID: 5584
		// (get) Token: 0x06008FDA RID: 36826 RVA: 0x00002050 File Offset: 0x00000250
		public bool CanSetProducedItemsOnPlace
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170015D1 RID: 5585
		// (get) Token: 0x06008FDB RID: 36827 RVA: 0x00002050 File Offset: 0x00000250
		public Dictionary<ELightingLevel, LightLevel> LightingLevels
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170015D2 RID: 5586
		// (get) Token: 0x06008FDC RID: 36828 RVA: 0x00002050 File Offset: 0x00000250
		public AreaLevelAudio AudioAmbiance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170015D3 RID: 5587
		// (get) Token: 0x06008FDD RID: 36829 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008FDE RID: 36830 RVA: 0x00002050 File Offset: 0x00000250
		public Transform HighlightTransform
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170015D4 RID: 5588
		// (get) Token: 0x06008FDF RID: 36831 RVA: 0x00002050 File Offset: 0x00000250
		public RelatedSounds Sounds
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06008FE0 RID: 36832 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(Stage stage, EAreaType areaType)
		{
			throw null;
		}

		// Token: 0x06008FE1 RID: 36833 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Enable(bool immediate)
		{
			throw null;
		}

		// Token: 0x06008FE2 RID: 36834 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_0(Transform arg)
		{
			throw null;
		}

		// Token: 0x06008FE3 RID: 36835 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAvailableLightingLevels(IReadOnlyCollection<ELightingLevel> availableLevels)
		{
			throw null;
		}

		// Token: 0x06008FE4 RID: 36836 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLightLevel(ELightingLevel level)
		{
			throw null;
		}

		// Token: 0x06008FE5 RID: 36837 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetItemsOnPlace(IEnumerable<GameObject> dynamicObjects)
		{
			throw null;
		}

		// Token: 0x06008FE6 RID: 36838 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Disable()
		{
			throw null;
		}

		// Token: 0x04009713 RID: 38675
		[SerializeField]
		private Dictionary<ELightingLevel, LightLevel> _lightingLevels;

		// Token: 0x04009714 RID: 38676
		[SerializeField]
		private AreaLevelAudio _audioAmbiance;

		// Token: 0x04009715 RID: 38677
		[SerializeField]
		private ParticleSystem _constructionParticlesTemplate;

		// Token: 0x04009716 RID: 38678
		[SerializeField]
		private GameObject _immediateEnable;

		// Token: 0x04009717 RID: 38679
		[SerializeField]
		private Transform _highlightTransform;

		// Token: 0x04009718 RID: 38680
		[SerializeField]
		private Transform[] _producedObjectsSpawnPoints;

		// Token: 0x04009719 RID: 38681
		[CompilerGenerated]
		private Dictionary<string, Transform> dictionary_0;

		// Token: 0x0400971A RID: 38682
		private Stage stage_0;

		// Token: 0x0400971B RID: 38683
		private List<GameObject> list_0;

		// Token: 0x0400971C RID: 38684
		private IReadOnlyCollection<ELightingLevel> ireadOnlyCollection_0;

		// Token: 0x0400971D RID: 38685
		private EAreaType eareaType_0;
	}
}
