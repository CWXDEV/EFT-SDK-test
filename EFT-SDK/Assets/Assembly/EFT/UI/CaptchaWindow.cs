using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.InventoryLogic;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x020028D1 RID: 10449
	public sealed class CaptchaWindow : HandoverSelectItemsWindow
	{
		// Token: 0x17002540 RID: 9536
		// (get) Token: 0x0600D0A5 RID: 53413 RVA: 0x00002050 File Offset: 0x00000250
		protected override int GridWidth
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002541 RID: 9537
		// (get) Token: 0x0600D0A6 RID: 53414 RVA: 0x00002050 File Offset: 0x00000250
		protected override int GridHeight
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002542 RID: 9538
		// (get) Token: 0x0600D0A7 RID: 53415 RVA: 0x00002050 File Offset: 0x00000250
		protected override bool CanStretchHorizontally
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002543 RID: 9539
		// (get) Token: 0x0600D0A8 RID: 53416 RVA: 0x00002050 File Offset: 0x00000250
		protected override bool CloseOnAccept
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600D0A9 RID: 53417 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass3087 Show(string title, string description, ICollection<Item> items, Profile profile, TraderControllerClass controller, Action<List<string>> acceptAction, Action cancelAction)
		{
			throw null;
		}

		// Token: 0x0600D0AA RID: 53418 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override bool IsSelected(Item item)
		{
			throw null;
		}

		// Token: 0x0600D0AB RID: 53419 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override bool IsActive(Item item, out string tooltip)
		{
			throw null;
		}

		// Token: 0x0600D0AC RID: 53420 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Accept()
		{
			throw null;
		}

		// Token: 0x0600D0AD RID: 53421 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InvalidAnswer()
		{
			throw null;
		}

		// Token: 0x0600D0AE RID: 53422 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task ValidAnswer()
		{
			throw null;
		}

		// Token: 0x0600D0AF RID: 53423 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void UpdateItems(IEnumerable<Item> items)
		{
			throw null;
		}

		// Token: 0x0600D0B0 RID: 53424 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void TrySelectItemToHandover(Item item)
		{
			throw null;
		}

		// Token: 0x0600D0B1 RID: 53425 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SetAcceptActive(bool value)
		{
			throw null;
		}

		// Token: 0x0600D0B2 RID: 53426 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(Item item)
		{
			throw null;
		}

		// Token: 0x0600D0B3 RID: 53427 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(Item item)
		{
			throw null;
		}

		// Token: 0x0600D0B4 RID: 53428 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void ClearSelectedList()
		{
			throw null;
		}

		// Token: 0x0600D0B5 RID: 53429 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x0600D0B6 RID: 53430 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400D180 RID: 53632
		[SerializeField]
		private GameObject _loader;

		// Token: 0x0400D181 RID: 53633
		[SerializeField]
		private ScrollRect _scroll;

		// Token: 0x0400D182 RID: 53634
		private readonly List<string> list_0;

		// Token: 0x0400D183 RID: 53635
		private Action<List<string>> action_3;
	}
}
