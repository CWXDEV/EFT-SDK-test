using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020008B3 RID: 2227
public class SonicBulletSoundPlayer : BulletSoundPlayer
{
	// Token: 0x0600325C RID: 12892 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x0600325D RID: 12893 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x0600325E RID: 12894 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FireBullet(SonicBulletSoundPlayer.GClass794 sonicInfo)
	{
		throw null;
	}

	// Token: 0x0600325F RID: 12895 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private SonicBulletSoundPlayer.SonicAudio method_0(SonicBulletSoundPlayer.SonicType type)
	{
		throw null;
	}

	// Token: 0x06003260 RID: 12896 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private int method_1(SonicBulletSoundPlayer.GClass794 sonicInfo, float distance)
	{
		throw null;
	}

	// Token: 0x04003355 RID: 13141
	private readonly float float_0;

	// Token: 0x04003356 RID: 13142
	[SerializeField]
	private List<SonicBulletSoundPlayer.SonicAudio> _sources;

	// Token: 0x04003357 RID: 13143
	[SerializeField]
	private AnimationCurve _soundCurve;

	// Token: 0x04003358 RID: 13144
	[SerializeField]
	private float _minDistance;

	// Token: 0x04003359 RID: 13145
	private readonly GClass831<SonicBulletSoundPlayer.Class459> gclass831_0;

	// Token: 0x020008B4 RID: 2228
	private class Class459 : GClass836.GInterface37
	{
		// Token: 0x06003261 RID: 12897 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialize(GClass831<SonicBulletSoundPlayer.Class459> pool, Vector3 start, AudioClip clip, float distance, int rollOff, float volume)
		{
			throw null;
		}

		// Token: 0x06003262 RID: 12898 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Release()
		{
			throw null;
		}

		// Token: 0x0400335A RID: 13146
		private GClass831<SonicBulletSoundPlayer.Class459> gclass831_0;

		// Token: 0x0400335B RID: 13147
		private Vector3 vector3_0;

		// Token: 0x0400335C RID: 13148
		private AudioClip audioClip_0;

		// Token: 0x0400335D RID: 13149
		private float float_0;

		// Token: 0x0400335E RID: 13150
		private int int_0;

		// Token: 0x0400335F RID: 13151
		private float float_1;
	}

	// Token: 0x020008B5 RID: 2229
	public enum SonicType
	{
		// Token: 0x04003361 RID: 13153
		Sonic9,
		// Token: 0x04003362 RID: 13154
		Sonic545,
		// Token: 0x04003363 RID: 13155
		Sonic762,
		// Token: 0x04003364 RID: 13156
		SonicShotgun
	}

	// Token: 0x020008B6 RID: 2230
	public class GClass794
	{
		// Token: 0x04003365 RID: 13157
		public BulletClass Ammo;

		// Token: 0x04003366 RID: 13158
		public Vector3 ShotPosition;

		// Token: 0x04003367 RID: 13159
		public Vector3 ShotDirection;

		// Token: 0x04003368 RID: 13160
		public Camera Camera;

		// Token: 0x04003369 RID: 13161
		public float Rolloff;

		// Token: 0x0400336A RID: 13162
		public float Delay;

		// Token: 0x0400336B RID: 13163
		public bool IsOccluded;
	}

	// Token: 0x020008B7 RID: 2231
	[Serializable]
	public class SonicAudio
	{
		// Token: 0x0400336C RID: 13164
		public SonicBulletSoundPlayer.SonicType Type;

		// Token: 0x0400336D RID: 13165
		public AudioClip Clip;
	}

	// Token: 0x020008B8 RID: 2232
	[CompilerGenerated]
	private sealed class Class460
	{
		// Token: 0x06003263 RID: 12899 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(SonicBulletSoundPlayer.SonicAudio x)
		{
			throw null;
		}

		// Token: 0x0400336E RID: 13166
		public SonicBulletSoundPlayer.SonicType type;
	}
}
