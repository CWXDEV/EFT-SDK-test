using System;
using UnityEngine;

namespace Audio.Vehicles.BTR
{
	// Token: 0x02000D23 RID: 3363
	[CreateAssetMenu(menuName = "Scriptable objects/Audio/VehicleMovementSoundContainer", fileName = "VehicleMovementSoundContainer")]
	[Serializable]
	public class VehicleMovementSoundContainer : ScriptableObject
	{
		// Token: 0x04005270 RID: 21104
		public AudioClip EngineStartClip;

		// Token: 0x04005271 RID: 21105
		public AudioClip EngineIdleAccelClip;

		// Token: 0x04005272 RID: 21106
		public AudioClip EngineLowAccelClip;

		// Token: 0x04005273 RID: 21107
		public AudioClip EngineHighAccelClip;

		// Token: 0x04005274 RID: 21108
		public AudioClip LowRpmLoopClip;

		// Token: 0x04005275 RID: 21109
		public AudioClip HighRpmLoopClip;

		// Token: 0x04005276 RID: 21110
		public AudioClip LowSpeedMovementLoopClip;

		// Token: 0x04005277 RID: 21111
		public AudioClip HighSpeedMovementLoopClip;

		// Token: 0x04005278 RID: 21112
		public AudioClip MovementStopBreakClip;

		// Token: 0x04005279 RID: 21113
		public AudioClip[] SkidClips;

		// Token: 0x0400527A RID: 21114
		public AudioClip[] SuspensionImpactClips;
	}
}
