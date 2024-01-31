using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Audio.Data
{
	// Token: 0x02000D62 RID: 3426
	[CreateAssetMenu(menuName = "Scriptable objects/Audio/BtrDriverSoundBankContainer", fileName = "BtrDriverSoundBankContainer")]
	[Serializable]
	public class BtrDriverSoundBankContainer : SoundBankContainerBase<EBtrDriverPhraseTrigger>
	{
		// Token: 0x060048F1 RID: 18673 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool TryGetBank(EBtrDriverPhraseTrigger soundType, out SoundBankWithSettings bank)
		{
			throw null;
		}

		// Token: 0x040053B8 RID: 21432
		[SerializeField]
		private BtrDriverSoundBankContainer.BtrDriverPhrasesByTrigger _phraseData;

		// Token: 0x02000D63 RID: 3427
		[Serializable]
		public class BtrDriverPhrasesByTrigger : SerializableEnumDictionary<EBtrDriverPhraseTrigger, SoundBankWithSettings>
		{
		}
	}
}
