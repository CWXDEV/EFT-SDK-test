using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.GlobalEvents;
using EFT.Interactive;
using UnityEngine;

namespace Audio.SpatialSystem
{
	// Token: 0x02000D47 RID: 3399
	[RequireComponent(typeof(BoxCollider))]
	[Serializable]
	public class SpatialAudioPortal : MonoBehaviour
	{
		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x0600483C RID: 18492 RVA: 0x00002050 File Offset: 0x00000250
		public int ID
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x0600483D RID: 18493 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600483E RID: 18494 RVA: 0x00002050 File Offset: 0x00000250
		public float PortalClosureLevel
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

		// Token: 0x0600483F RID: 18495 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x06004840 RID: 18496 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_0()
		{
			throw null;
		}

		// Token: 0x06004841 RID: 18497 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x06004842 RID: 18498 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(InteractiveObjectInteractionResultEvent resultEvent)
		{
			throw null;
		}

		// Token: 0x06004843 RID: 18499 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(WindowBreaker breaker, DamageInfo info, WindowBreakingConfig.Crack crack, float damage)
		{
			throw null;
		}

		// Token: 0x06004844 RID: 18500 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_4(Vector3 interactiveObjectPosition)
		{
			throw null;
		}

		// Token: 0x06004845 RID: 18501 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x06004846 RID: 18502 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x06004847 RID: 18503 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(SpatialAudioPortal.PortalState requiredState, bool allowFade)
		{
			throw null;
		}

		// Token: 0x06004848 RID: 18504 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8(bool allowFade)
		{
			throw null;
		}

		// Token: 0x06004849 RID: 18505 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9(bool allowFade)
		{
			throw null;
		}

		// Token: 0x0600484A RID: 18506 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetConnectedRoom(SpatialAudioRoom room)
		{
			throw null;
		}

		// Token: 0x0600484B RID: 18507 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<SpatialAudioRoom> GetConnectedRooms()
		{
			throw null;
		}

		// Token: 0x0600484C RID: 18508 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_10(float start, float duration)
		{
			throw null;
		}

		// Token: 0x0600484D RID: 18509 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_11(float start, float duration)
		{
			throw null;
		}

		// Token: 0x0600484E RID: 18510 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0600484F RID: 18511 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_12()
		{
			throw null;
		}

		// Token: 0x06004850 RID: 18512 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_13()
		{
			throw null;
		}

		// Token: 0x04005318 RID: 21272
		public EDisplayMode DisplayMode;

		// Token: 0x04005319 RID: 21273
		private const float MAX_ALLOWED_POSITION_OFFSET = 15f;

		// Token: 0x0400531A RID: 21274
		[Tooltip("The level of portal transmission, 1 - full transmission like open portal, 0 - min transmission, like wall")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _transmission;

		// Token: 0x0400531B RID: 21275
		[Tooltip("Optionally give the portal a unique name for more informative debug messages.")]
		public string portalName;

		// Token: 0x0400531C RID: 21276
		[Tooltip("this function is used to try to adjust the size of the portal to the surrounding geometry")]
		public bool FitToGeometry;

		// Token: 0x0400531D RID: 21277
		[Tooltip("experimental function to try to automatically set rotations for the portal")]
		public bool AutoRotate;

		// Token: 0x0400531E RID: 21278
		public SpatialAudioPortal.PortalType portalType;

		// Token: 0x0400531F RID: 21279
		public SpatialAudioPortal.PortalState state;

		// Token: 0x04005320 RID: 21280
		public BoxCollider portalCollider;

		// Token: 0x04005321 RID: 21281
		[Range(0f, 1f)]
		public float wallOcclusion;

		// Token: 0x04005322 RID: 21282
		[Range(0f, 1f)]
		public float traversalMaxCost;

		// Token: 0x04005323 RID: 21283
		public bool ToOutdoor;

		// Token: 0x04005324 RID: 21284
		public AnimationCurve openEnvelope;

		// Token: 0x04005325 RID: 21285
		public AnimationCurve closeEnvelope;

		// Token: 0x04005326 RID: 21286
		[Range(0f, 10f)]
		public float openFadeTime;

		// Token: 0x04005327 RID: 21287
		[Range(0f, 10f)]
		public float closeFadeTime;

		// Token: 0x04005328 RID: 21288
		public string DoorID;

		// Token: 0x04005329 RID: 21289
		[SerializeField]
		private int _iD;

		// Token: 0x0400532A RID: 21290
		private readonly List<SpatialAudioRoom> _connectedRooms;

		// Token: 0x0400532C RID: 21292
		private bool _inProgressOpen;

		// Token: 0x0400532D RID: 21293
		private bool _inProgressClose;

		// Token: 0x0400532E RID: 21294
		private Coroutine _interactionCoroutine;

		// Token: 0x0400532F RID: 21295
		private Action _unsubscribeOnDestroy;

		// Token: 0x02000D48 RID: 3400
		[Serializable]
		public enum PortalType
		{
			// Token: 0x04005331 RID: 21297
			Opening,
			// Token: 0x04005332 RID: 21298
			Static,
			// Token: 0x04005333 RID: 21299
			Wall,
			// Token: 0x04005334 RID: 21300
			Window
		}

		// Token: 0x02000D49 RID: 3401
		[Serializable]
		public enum PortalState
		{
			// Token: 0x04005336 RID: 21302
			Open,
			// Token: 0x04005337 RID: 21303
			Closed
		}
	}
}
