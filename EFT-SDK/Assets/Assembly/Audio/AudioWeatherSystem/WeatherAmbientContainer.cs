using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Audio.AudioWeatherSystem
{
	// Token: 0x02000D6E RID: 3438
	[Serializable]
	public class WeatherAmbientContainer
	{
		// Token: 0x06004912 RID: 18706 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryGetDayTimeSoundContainer(EWinterStatus status, out DayTimeAmbientSoundContainer soundContainer)
		{
			throw null;
		}

		// Token: 0x040053E9 RID: 21481
		[SerializeField]
		private WeatherAmbientContainer.SoundsByWeather _soundsByWeather;

		// Token: 0x02000D6F RID: 3439
		[Serializable]
		public class SoundsByWeather : SerializableEnumDictionary<EWinterStatus, DayTimeAmbientSoundContainer>
		{
		}
	}
}
