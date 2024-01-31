using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using UnityEngine;

namespace EFT.Interactive
{
	// Token: 0x02002768 RID: 10088
	public class KeycardDoor : Door
	{
		// Token: 0x0600CA03 RID: 51715 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Interact(InteractionResult interactionResult)
		{
			throw null;
		}

		// Token: 0x0600CA04 RID: 51716 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_7()
		{
			throw null;
		}

		// Token: 0x0600CA05 RID: 51717 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override IEnumerator SmoothDoorOpenCoroutine(EDoorState state, bool isLocalInteraction, float speed = 1f)
		{
			throw null;
		}

		// Token: 0x0600CA06 RID: 51718 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override IEnumerator UnlockCoroutine()
		{
			throw null;
		}

		// Token: 0x0600CA07 RID: 51719 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_8(bool success)
		{
			throw null;
		}

		// Token: 0x0600CA08 RID: 51720 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnEnable()
		{
			throw null;
		}

		// Token: 0x0600CA09 RID: 51721 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DoorHandle GetHandle()
		{
			throw null;
		}

		// Token: 0x0600CA0A RID: 51722 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override WorldInteractiveObject.GStruct385 GetInteractionParameters(Vector3 yourPosition)
		{
			throw null;
		}

		// Token: 0x0600CA0B RID: 51723 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override GStruct415<GClass2964> UnlockOperation(KeyComponent key, Player player)
		{
			throw null;
		}

		// Token: 0x0600CA0C RID: 51724 RVA: 0x00002050 File Offset: 0x00000250
		[DebuggerHidden]
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_9(EDoorState state, bool isLocalInteraction, float speed)
		{
			throw null;
		}

		// Token: 0x0600CA0D RID: 51725 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_10(InteractiveProxy x)
		{
			throw null;
		}

		// Token: 0x0600CA0E RID: 51726 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_11(InteractiveProxy p)
		{
			throw null;
		}

		// Token: 0x0400C9ED RID: 51693
		[SerializeField]
		private string[] _additionalKeys;

		// Token: 0x0400C9EE RID: 51694
		[SerializeField]
		private bool _openOnUnlock;

		// Token: 0x0400C9EF RID: 51695
		[SerializeField]
		private bool _lockOnShut;

		// Token: 0x0400C9F0 RID: 51696
		public AudioClip DeniedBeep;

		// Token: 0x0400C9F1 RID: 51697
		public AudioClip GrantedBeep;

		// Token: 0x0400C9F2 RID: 51698
		public AudioClip UnlockSound;

		// Token: 0x0400C9F3 RID: 51699
		private GripPose gripPose_0;

		// Token: 0x0400C9F4 RID: 51700
		public InteractiveProxy[] Proxies;
	}
}
